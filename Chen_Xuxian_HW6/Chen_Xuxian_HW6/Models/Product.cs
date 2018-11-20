using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chen_Xuxian_HW6.Models
{
    public class Product
    {
        [Display(Name = "Product ID ")]
        public Int32 ProductID { get; set; }

        [Required(ErrorMessage = "SKU is required.")]
        [Display(Name = "SKU")]
        public Int32 SKU { get; set; } = 5001;

        [Required(ErrorMessage = "Product Name is required.")]
        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        [Display(Name = "Product Description")]
        public String ProductDescription { get; set; }

        //NP.
        public List<OrderDetail> OrderDetails { get; set; }
        public List<SupplyOrder> SupplyOrders { get; set; }

        public Product()
        {
            if (SupplyOrders == null)
            {
                SupplyOrders = new List<SupplyOrder>();
            }

            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }
    }
}
