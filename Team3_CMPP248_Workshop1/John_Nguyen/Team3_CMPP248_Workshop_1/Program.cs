using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3_CMPP248_Workshop_1
{
    // Author: John Nguyen
    // Date Created: December 9, 2014
    // Purpose: This console was written to test the "Product" class for Workshop 1
    
    class Program
    {
        static void Main(string[] args)
        {
            int sel; // Initialize selection variable
            Console.WriteLine("Welcome. Enter a number for the product (1-10).");
            sel = Convert.ToInt32(Console.ReadLine());

            Product selProd = new Product();
            selProd.getProductName(sel);

            Console.WriteLine(selProd);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
