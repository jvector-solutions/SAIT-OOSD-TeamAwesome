using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    // Author: Garina Yadav & John Nguyen
    // Date Created: January 5, 2015
    // Purpose: This console was written to test the "Supplier" class for Workshop 1

    public class Supplier
    {
        public Supplier() { }
        public int SupplierId { get; set; }
        public string SupName { get; set; }
        /*
        // Set public properties. They are both read-only
        public int ProductID
        {
            get
            {
                return SupplierId;
            }
        }
        public string ProdName
        {
            get
            {
                return SupName;
            }
        }

        // Constructor
        public Supplier(int i = 0)
        {
            SupplierId = i;
            getSupplierName(SupplierId);
        }
        
        // Function to match a product name to each product ID
        public void getSupplierName(int i)
        {
            int selector = i;
            switch (selector)
            {
                case 69:
                    SupName = "NEW CONCEPTS - CANADA";
                    break;
                case 80:
                    SupName = "CHAT / TRAVELINE";
                    break;
                case 100:
                    SupName = "AVILA TOURS INC.";
                    break;
                case 317:
                    SupName = "BLYTH & COMPANY TRAVEL";
                    break;
                case 323:
                    SupName = "COMPAGNIA ITALIANA TURISM";
                    break;
                case 796:
                    SupName = "CYPRUS AIRWAYS LTD";
                    break;
                case 828:
                    SupName = "DER TRAVEL SERVICE LTD";
                    break;
                case 845:
                    SupName = "DISCOVER THE WORLD MARKET";
                    break;
                case 908:
                    SupName = "ELITE ORIENT TOURS INC.";
                    break;
                case 1005:
                    SupName = "ENCORE CRUISES";
                    break;
                case 1028:
                    SupName = "EUROP-AUTO-VACANCES/HOLIDAYS";
                    break;
                case 1040:
                    SupName = "EXECUTIVE SUITES";
                    break;
                case 1205:
                    SupName = "GOLDMAN MARKETING";
                    break;
                case 1406:
                    SupName = "EUROCRUISES INC.";
                    break;
                case 1416:
                    SupName = "THE HOLIDAY NETWORK";
                    break;
                case 1425:
                    SupName = "HOLLAND AMERICA LINE WEST";
                    break;
                case 1542:
                    SupName = "INSIGHT VACATIONS CANADA";
                    break;
                case 1620:
                    SupName = "INTAIR VACATIONS";
                    break;
                case 1634:
                    SupName = "ISLANDS IN THE SUN CRUISE";
                    break;
                case 1685:
                    SupName = "GOWAY TRAVEL LTD.";
                    break;
                case 1713:
                    SupName = "JETPACIFIC HOLIDAYS INC";
                    break;
                case 1766:
                    SupName = "KLM ROYAL DUTCH AIRLINES";
                    break;
                case 1859:
                    SupName = "LOTUS HOLIDAYS";
                    break;
                case 1918:
                    SupName = "MARKET SQUARE TOURS";
                    break;
                case 2140:
                    SupName = "NAGEL TOURS LTD";
                    break;
                default:
                    SupName = "invalid. Please enter a valid supplier ID.";
                    break;
            }
        }
        */
        // Used for testing, this overwrites the string to print the product name after
        // the user has entered a product ID
        public override string ToString()
        {
            return SupName;
        }
    }
}
