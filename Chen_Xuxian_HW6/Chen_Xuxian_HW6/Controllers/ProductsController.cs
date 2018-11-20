using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chen_Xuxian_HW6.DAL;
using Chen_Xuxian_HW6.Models;
using Chen_Xuxian_HW6.Utilities;

namespace Chen_Xuxian_HW6.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(r => r.SupplyOrders).ThenInclude(r => r.Supplier)
                .FirstOrDefaultAsync(m => m.ProductID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewBag.AllSuppliers = GetAllSuppliers();
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int[] SelectedSuppliers, [Bind("ProductID,SKU,ProductName,Price,ProductDescription")] Product product)
        {
            if (ModelState.IsValid)
            {
                //Generate next SKU
                product.SKU = GenerateSKU.GetNextSKU(_context);

                _context.Add(product);
                await _context.SaveChangesAsync();
                //add connections to suppliers
                //first, find the course you just added
                Product dbProduct = _context.Products.FirstOrDefault(c => c.SKU == product.SKU);

                //loop through selected Supplier and add them
                foreach (int i in SelectedSuppliers)
                {
                    Supplier dbSupp = _context.Suppliers.Find(i);
                    SupplyOrder so = new SupplyOrder
                    {
                        Product = dbProduct,
                        Supplier = dbSupp
                    };
                    _context.SupplyOrders.Add(so);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            //re-populate the viewbag
            ViewBag.AllSuppliers = GetAllSuppliers();
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(r => r.SupplyOrders).ThenInclude(r => r.Supplier)
                .FirstOrDefaultAsync(m => m.ProductID == id);
                
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.AllSuppliers = GetAllSuppliers(product);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product, int[] SelectedSuppliers)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Product dbProduct = _context.Products
                        .Include(c => c.SupplyOrders)
                            .ThenInclude(c => c.Supplier)
                        .FirstOrDefault(c => c.ProductID == product.ProductID);

                    dbProduct.ProductID = product.ProductID;
                    dbProduct.SKU = product.SKU;
                    dbProduct.ProductName = product.ProductName;
                    dbProduct.Price = product.Price;
                    dbProduct.ProductDescription = product.ProductDescription;

                    _context.Update(dbProduct);
                    _context.SaveChanges();

                    List<SupplyOrder> SupplierOrderToRemove = new List<SupplyOrder>();
                    foreach (SupplyOrder so in dbProduct.SupplyOrders)
                    {
                        if (SelectedSuppliers.Contains(so.Supplier.SupplierID) == false)
                        //list of selected depts does not include this departments id
                        {
                            SupplierOrderToRemove.Add(so);
                        }
                    }
                    //remove SupplyOrder you found in list above - this has to be 2 separate steps because you can't 
                    //iterate over a list that you are removing items from
                    foreach (SupplyOrder so in SupplierOrderToRemove)
                    {
                        _context.SupplyOrders.Remove(so);
                        _context.SaveChanges();
                    }

                    //now add the supplier that are new
                    foreach (int i in SelectedSuppliers)
                    {
                        if (dbProduct.SupplyOrders.Any(c => c.Supplier.SupplierID == i) == false)
                        //this supplier has not yet been added
                        {
                            //create a new SupplyOrder
                            SupplyOrder so = new SupplyOrder
                            {
                                //connect the new supplyorder to the supplier and product
                                Supplier = _context.Suppliers.Find(i),
                                Product = dbProduct
                            };

                            //update the database
                            _context.SupplyOrders.Add(so);
                            _context.SaveChanges();
                        }
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.AllDepartments = GetAllSuppliers(product);
            return View(product);
        }

        private MultiSelectList GetAllSuppliers()
        {
            List<Supplier> allSupps = _context.Suppliers.ToList();
            MultiSelectList suppList = new MultiSelectList(allSupps, "SupplierID", "Name");
            return suppList;
        }

        //overload for editing supplier
        private MultiSelectList GetAllSuppliers(Product product)
        {
            //create a list of all the suppliers
            List<Supplier> allSupps = _context.Suppliers.ToList();
            
            //create a list for the supplier ids that this course already belongs to
            List<int> currentSupp = new List<int>();

            //loop through all the details to find the list of current supplier
            foreach (SupplyOrder so in product.SupplyOrders)
            {
                currentSupp.Add(so.Supplier.SupplierID);
            }

            MultiSelectList suppList = new MultiSelectList(allSupps, "SupplierID", "Name", currentSupp);
            return suppList;
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
