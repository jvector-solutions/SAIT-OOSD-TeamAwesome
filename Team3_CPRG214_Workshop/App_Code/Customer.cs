﻿/* CPRG214 ASP Workshop 2
 * Created By: John, and MB
 * January 22, 2015
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExperts
{
    public class Customer
    {
        //constructor
        public Customer() { }

        //public properties
        public int CustomerID { get; set; }

        public string CustFirstName { get; set; }

        public string CustLastName { get; set; }

        public string CustAddress { get; set; }

        public string CustCity { get; set; }

        public string CustProv { get; set; }

        public string CustPostal { get; set; }

        public string CustCountry { get; set; }

        public string CustHomePhone { get; set; }

        public string CustBusPhone { get; set; }

        public string CustEmail { get; set; }

        public int AgentID { get; set; }
    }
}