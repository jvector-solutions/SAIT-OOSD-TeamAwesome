/*
 * Class for Packages
 * Created By: MB Jae Camacho
 * December 9, 2014
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Package
    {
        // properties
        public int ID { get; set; } //11
        public string Name { get; set; } //max of 50 char
        [DisplayName("Start Date")]
        public DateTime Start_Date { get; set; }
        [DisplayName("End Date")]
        public DateTime End_Date { get; set; }
        public string Description { get; set; }//max of 50 char
        public decimal Base_Price { get; set; } //19.4
        public decimal Agency_Commission { get; set; } //19.4
        public string Products { get; set; }


        private string price;
        public string Price
        {
            get
            {
                price = Base_Price.ToString("c");
                return price;
            }
        }

        private string commission;
        public string Commission
        {
            get
            {
                commission = Agency_Commission.ToString("c");
                return commission;
            }
        }

        //constructors
        public Package()
        {
        }

        /*
        //public properties
        public int Id
        {
            get { return id; }
        }
        public string Name {
            get { return name; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    name = "default";
                }
                else
                {
                    name = value; 
                }
            }
        }
        public string StartDate
        {
            get { return startDate; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    startDate = "default";
                }
                else
                {
                    startDate = value;
                }
            }
        }
        public string EndDate
        {
            get { return endDate; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    endDate = "default";
                }
                else
                {
                    endDate = value;
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    description = "default";
                }
                else
                {
                    description = value;
                }
            }
        }
        public decimal BasePrice
        {
            get { return basePrice; }
            set
            {
                if (value < 0m)
                { //negative base price gets 0
                    basePrice = 0m;
                }
                else
                { //valid baseprice
                    basePrice = value;
                }
            }
        }
        public decimal AgencyCommission
        {
            get { return agencyCommission; }
            set
            {
                if (value < 0m)
                { //negative commision gets 0
                    agencyCommission = 0m;
                }
                else if (value > basePrice)
                { //if commission is greater than base price,
                  //commission gets baseprice
                    agencyCommission = basePrice;
                }
                else
                { //valid commission
                    agencyCommission = value;
                }
            }
        }
        */

        //methods
        public override string ToString()
        {
            return "\nID: " + ID +
                "\nName: " + Name +
                "\nStart Date: " + Start_Date +
                "\nEnd Date: " + End_Date +
                "\nDescritpion: " + Description +
                "\nBase Price: " + Base_Price.ToString("c") +
                "\nAgency Commission: " + Agency_Commission.ToString("c");
        }
    }
}