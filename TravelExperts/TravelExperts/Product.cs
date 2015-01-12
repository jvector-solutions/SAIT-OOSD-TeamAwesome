/*
 * Class for Products
 * Created By: John Nguyen
 * December 9, 2004
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    // Author: John Nguyen
    // Date Created: December 9, 2014
    // Purpose: This class is used to determine the name of the product by entering the product ID

    public class Product
    {
        public Product() { }
        [DisplayName("Product ID")]
        public int prodID { get; set; }
        [DisplayName ("Product Name")]
        public string prodName { get; set; }

        public override string ToString()
        {
            return prodName;
        }
    }
}
