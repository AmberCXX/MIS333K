using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Chen_Xuxian_HW6.Models
{
    public class Supplier
    {
        [Display(Name = "Supplier ID ")]
        public Int32 SupplierID { get; set; }

        [Required (ErrorMessage = "Supplier name is required.")]
        [Display(Name = "Supplier Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        [DisplayFormat(DataFormatString = "{0:###-###-###}", ApplyFormatInEditMode = true)]
        public String PhoneNum { get; set; }

        [Required(ErrorMessage = "Established date is required.")]
        [Display(Name = "Established Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EstDate { get; set; }
       
        [Display(Name = "Preferred Supplier")]
        public Boolean Preferred { get; set; }

        [Display(Name = "Notes")]
        public String Notes { get; set; }

        //Navigation Property
        public List<SupplyOrder> SupplyOrders { get; set; }

        public Supplier()
        {
            if (SupplyOrders == null)
            {
                SupplyOrders = new List<SupplyOrder>();
            }
        }
    }
}
