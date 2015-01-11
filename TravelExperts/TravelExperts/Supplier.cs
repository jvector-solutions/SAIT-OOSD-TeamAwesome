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

        public override string ToString()
        {
            return SupName;
        }
    }
}
