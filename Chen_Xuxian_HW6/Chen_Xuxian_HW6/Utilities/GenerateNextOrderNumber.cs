using Chen_Xuxian_HW6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chen_Xuxian_HW6.Utilities
{
    public class GenerateNextOrderNumber
    {
        public static Int32 GetNextON(AppDbContext db)
        {
            Int32 intMaxON; //the current maximum course number
            Int32 intNextON; //the course number for the next class

            if (db.Orders.Count() == 0)
            {
                intMaxON = 10000;
            }
            else
            {
                intMaxON = db.Orders.Max(c => c.OrderNumber);
            }

            //add one to the current max to find the next one
            intNextON = intMaxON + 1;

            //return the value
            return intNextON;
        }
    }
}
