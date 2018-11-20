//Author: Xuxian Chen
//Date: September 17,2018
//Assignment: Fall 2018 MIS333K HW1 
//Description: Food Truck Sale Check Out 

using System;
using System.Text.RegularExpressions;

namespace Chen_Xuxian_HW1
{
    class FoodTruckProgram
    {
        //Set up some constants for future calculation.
        private const Decimal decTaxRate = 0.0825M;
        private const Decimal decTacoPrice = 2M;
        private const Decimal decSWsPrice = 7M;

        //Main Method.
        static void Main(string[] args)
        {
            String strCustomerCode;
            Boolean bolCodeLetter;
            Boolean bolCodeValid;

            String strTacoCount;
            String strSWsCount;
            int intTacoCount;
            int intSWsCount;

            int intTotalCount;
            String strTacoSubT;
            String strSWsSubT;
            String strTax;
            String strTotal;


            do //Prompt for customer code.
            {
                do
                {
                    Console.WriteLine("Please enter the Customer Code:");
                    strCustomerCode = Console.ReadLine();
                    
                    //Validate using IsCorrectString Method.
                    bolCodeLetter = IsCorrectString(strCustomerCode);
                    
                    //Prompt Error Message. Ask for all letter input.
                    if (bolCodeLetter == false)
                    {
                        Console.WriteLine("The customer code is Letter only. Please try again.");
                    }

                } while (bolCodeLetter == false); //Loop till the customer code is all letter.
                
                //Validation using CheckCode Method.
                bolCodeValid = CheckCode(strCustomerCode);
                
                //Prompt Error Message. ASk for 4 to 6 letter input.
                if (bolCodeValid == false)
                {
                    Console.WriteLine("Invalid customer code. Please try again.");
                }
                else
                {
                    strCustomerCode = strCustomerCode.ToUpper();//Change the Code to all uppercases.
                }

            } while (bolCodeValid == false);//Loop till the entry is valid 4-6 letters.

            do //Prompt for number of items wanted.
            {
                do //Prompt for number of Tacos wanted.
                {
                    Console.WriteLine("Please enter the number of Taco you would like to order:");
                    strTacoCount = Console.ReadLine();
                    
                    //Validate using CheckCount Method.
                    intTacoCount = CheckCount(strTacoCount);
                    
                    //Prompt Error Message.
                    if (intTacoCount < 0)
                    {
                        Console.WriteLine("Incorrect number of Tacos. You must select a positive interger or zero.");
                    }
      
                } while (intTacoCount < 0);

                do //Prompt for number of Sandwiches wanted.
                {
                    Console.WriteLine("Please enter the number of Sandwiches you would like to order:");
                    strSWsCount = Console.ReadLine();

                    //Validate using CheckCount Method.
                    intSWsCount = CheckCount(strSWsCount);

                    //Prompt Error Message.
                    if (intSWsCount < 0)
                    {
                        Console.WriteLine("Incorrect number of Sandwiches. You must select a positive interger or zero.");
                    }

                } while (intSWsCount < 0);

                intTotalCount = intTacoCount + intSWsCount;
                if (intTotalCount == 0)
                {
                    Console.WriteLine("The total number of item wanted must be larger than zero. Please try again.");
                }
            } while (intTotalCount == 0);

            //Calculate Taco Subtotal.
            Decimal decTacoSubT = decTacoPrice * intTacoCount;
            //Calculate Sandwiches Subtotal.
            Decimal decSWsSubT = decSWsPrice * intSWsCount;
            //Calculate Items Subtotal.
            Decimal decOrderSubT = decTacoSubT + decSWsSubT;
            //Calculate tax.
            Decimal decTax = decTaxRate * decOrderSubT;
            Decimal decTotal = decOrderSubT + decTax;

            strTacoSubT = decTacoSubT.ToString("C");
            strSWsSubT = decSWsSubT.ToString("C");
            strTax = decTax.ToString("C");
            strTotal = decTotal.ToString("C");

            Console.WriteLine("Customer Code:" + strCustomerCode);
            Console.WriteLine("Total Items:" + intTotalCount);
            Console.WriteLine("Taco Subtotal:" + strTacoSubT);
            Console.WriteLine("Sanwiches Subtotal:" + strSWsSubT);
            Console.WriteLine("Sale Tax:" + strTax);
            Console.WriteLine("Grand Total:" + strTotal);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
        
        //This method checks to see if the Customer Code is letter only.
        public static Boolean IsCorrectString(String strInput)
        {
            return Regex.IsMatch(strInput, @"^[A-Za-z\s]*$");
        }

        //This method checks if the customer code is within 4 to 6 letters.
        public static Boolean CheckCode(String strInput)
        {
            if (strInput.Length < 4 || strInput.Length > 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int CheckCount(String strInput)
        {
            int intCount;

            try
            {
                //Check if entry is interger.
                intCount = Convert.ToInt32(strInput);
                // Check if entry is positive.
                if (intCount < 0)
                {
                    return -1; //Assign flag value.
                }
                return intCount;
            }
            catch
            {
                return -2;//Assign flag value
            }

        }
    }
}