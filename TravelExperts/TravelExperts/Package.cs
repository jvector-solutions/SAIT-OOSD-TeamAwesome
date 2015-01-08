/*
 * Class for Packages
 * Created By: MB Jae Camacho
 * December 9, 2004
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Package
    {
        //private properties
        public int PackageId { get; set; } //11
        public string PkgName { get; set; } //max of 50 char
        public DateTime PkgStartDate { get; set; }
        public DateTime PkgEndDate { get; set; }
        public string PkgDesc { get; set; }//max of 50 char
        public decimal PkgBasePrice { get; set; } //19.4
        public decimal PkgAgencyCommission { get; set; } //19.4

        //constructors
        public Package(int i=0, string n="default", string sD="default", string eD="default", string d="default",decimal bP=0m,decimal aC=0m) {
            PackageId = i;
            PkgName = n;
            PkgStartDate = sD;
            PkgEndDate = eD;
            PkgDesc = d;
            PkgBasePrice = bP;
            PkgAgencyCommission = aC;
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
            return "\nID: " + PackageId +
                "\nName: " + PkgName +
                "\nStart Date: " + PkgStartDate +
                "\nEnd Date: " + PkgEndDate +
                "\nDescritpion: " + PkgDesc +
                "\nBase Price: " + PkgBasePrice.ToString("c") +
                "\nAgency Commission: " + PkgAgencyCommission.ToString("c");
        }
    }
}