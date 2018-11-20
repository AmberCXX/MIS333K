using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chen_Xuxian_HW6.Models
{
    public class SupplyOrder
    {
        [Display(Name = "Supplies Order ID ")]
        public Int32 SupplyOrderID { get; set; }

        //Navigation Property.
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
