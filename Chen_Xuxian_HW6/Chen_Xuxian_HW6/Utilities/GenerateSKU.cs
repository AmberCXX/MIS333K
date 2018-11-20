using Chen_Xuxian_HW6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chen_Xuxian_HW6.Utilities
{
    public class GenerateSKU
    {
        public static Int32 GetNextSKU(AppDbContext db)
        {
            Int32 intMaxSKU; //the current maximum course number
            Int32 intNextSKU; //the course number for the next class

            if (db.Products.Count() == 0)
            {
                intMaxSKU = 5000; 
            }
            else
            {
                intMaxSKU = db.Products.Max(c => c.SKU); 
            }

            //add one to the current max to find the next one
            intNextSKU = intMaxSKU + 1;

            //return the value
            return intNextSKU;
        }
    }
}
