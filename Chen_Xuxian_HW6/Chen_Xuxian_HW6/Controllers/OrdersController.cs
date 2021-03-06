﻿using System;
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
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.Include(o => o.OrderDetails).ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.Include(r => r.OrderDetails).ThenInclude(r => r.Product)
                .FirstOrDefaultAsync(m => m.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,Notes")] Order order)
        {
            order.OrderNumber = GenerateNextOrderNumber.GetNextON(_context);
            order.OrderDate = System.DateTime.Today;

            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                //It is like for some reason, the new ID is not working.
                return RedirectToAction("AddToOrder", new { id = order.OrderID });
            }
            return View(order);
        }

        //GET: Order/AddToOrder
        public IActionResult AddToOrder(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You must specify an order to add!" });
            }

            Order ord = _context.Orders.Find(id);

            if (ord == null)
            {
                return View("Error", new string[] { "Order not found!" });
            }

            OrderDetail od = new OrderDetail() { Order = ord};

            ViewBag.AllProducts = GetAllProducts();
            return View("AddToOrder", od);
        }

        //POST: Order/AddToOrder
        [HttpPost]
        public IActionResult AddToOrder(OrderDetail od, int SelectedProducts)
        {
            //find the product associated with the selected product id
            Product product = _context.Products.Find(SelectedProducts);

            //set the order detail's course equal to the product we just found
            od.Product = product;

            //find the order based on the id
            Order ord = _context.Orders.Find(od.Order.OrderID);

            //set the order detail's order equal to the order we just found
            od.Order = ord;

            //set the Product Price for this detail equal to the current Product Price
            od.ProductPrice = od.Product.Price;

            //add total fees
            od.ExtendedPrice = od.Quantity * od.ProductPrice;

            if (ModelState.IsValid)
            {
                _context.OrderDetails.Add(od);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = od.Order.OrderID });
            }
            return View(od);
        }

        public IActionResult RemoveFromOrder(int? id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "You need to specify an order id" });
            }

            Order ord = _context.Orders.Include(r => r.OrderDetails).ThenInclude(r => r.Product).FirstOrDefault(r => r.OrderID == id);

            if (ord == null || ord.OrderDetails.Count == 0)//Order is not found
            {
                return RedirectToAction("Details", new { id = id });
            }

            //pass the list of order details to the view
            return View(ord.OrderDetails);
        }

        // GET: Orders/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Orders.Include(r => r.OrderDetails)
                                        .ThenInclude(r => r.Product)
                                        .FirstOrDefault(r => r.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Order order)
        {
            //Find the related order in the database
            Order DbOrd = _context.Orders.Find(order.OrderID);

            //Update the notes
            DbOrd.Notes = order.Notes;

            //Update the database
            _context.Orders.Update(DbOrd);

            //Save changes
            _context.SaveChanges();

            //Go back to index
            return RedirectToAction(nameof(Index));
        }
    
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }

        private SelectList GetAllProducts()
        {
            List<Product> Products = _context.Products.ToList();
            SelectList allProducts = new SelectList(Products, "ProductID", "ProductName");
            return allProducts;
        }
    }
}
