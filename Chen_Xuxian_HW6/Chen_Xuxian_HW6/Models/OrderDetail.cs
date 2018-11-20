using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chen_Xuxian_HW6.Models
{
    public class OrderDetail
    {
        [Display(Name = "Order Detail ID ")]
        public Int32 OrderDetailID { get; set; }

        [Required(ErrorMessage = "You must specify a number to purchase")]
        [Display(Name = "Quantity")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Must be Positive number")]
        public Int32 Quantity { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ProductPrice { get; set; }

        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }

        //NP.
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
