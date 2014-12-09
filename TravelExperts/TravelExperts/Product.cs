/*
 * Class for Products
 * Created By: John Nguyen
 * December 9, 2004
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class Product
    {
        private int prodID;
        private string prodName;

        // Public Properties
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

        public Product(int i = 0)
        {
            prodID = i;
            getProductName(prodID);
        }

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

        public override string ToString()
        {
            return "The package name is " + prodName;
        }
    }
}
