using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team3_CMPP248_Workshop_1
{
    // Author: John Nguyen
    // Date Created: December 9, 2014
    // Purpose: This class is used to determine the name of the product by entering the product ID

    class Product
    {
        private int prodID;
        private string prodName;

        // Set public properties. They are both read-only
        public int ProductID
        {
            get
            {
                return prodID;
            }
        }
        public string ProdName
        {
            get
            {
                return prodName;
            }
        }

        // Constructor
        public Product(int i = 0)
        {
            prodID = i;
            getProductName(prodID);
        }

        // Function to match a product name to each product ID
        public void getProductName(int i)
        {
            int selector = i;
            switch (selector)
            {
                case 1:
                    prodName = "Air";
                    break;
                case 2:
                    prodName = "Attractions";
                    break;
                case 3:
                    prodName = "Car rental";
                    break;
                case 4:
                    prodName = "Cruise";
                    break;
                case 5:
                    prodName = "Hotel";
                    break;
                case 6:
                    prodName = "Hotel";
                    break;
                case 7:
                    prodName = "Railroad";
                    break;
                case 8:
                    prodName = "Tours";
                    break;
                case 9:
                    prodName = "Travel Insurance";
                    break;
                case 10:
                    prodName = "Yacht/Boat Charter";
                    break;
                default:
                    prodName = "Please enter a valid product ID";
                    break;
            }
        }

        // Used for testing, this overwrites the string to print the product name after
        // the user has entered a product ID
        public override string ToString()
        {
            return "The package name is " + prodName;
        }
    }
}
