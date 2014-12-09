using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class Agent
    {
        //private properties
        private int id;
        private string firstName;
        private string middleInitial;
        private string lastName;
        private string busPhone;
        private string email;
        private string position;
        private string agencyId;
        private string password;

        //Constructor with parameters and default values
        public Agent(int i=0, string fN="", string mI="", string lN="", 
            string bP="", string e="", string p="", string aI="", string pass="")
        {
            id = i;
            firstName = fN;
            middleInitial = mI;
            lastName = lN;
            busPhone = bP;
            email = e;
            position = p;
            agencyId = aI;
            password = pass;
        }
  
        //Setters and getters
        public int Id 
        {
            get { return id; }
            set { id = value;}
        } 
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;}
        } 
        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value;}
        } 
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;}
        }
        public string BusPhone
        {
            get { return busPhone; }
            set { busPhone = value;}
        }
        public string Email
        {
            get { return email; }
            set { email = value;}
        }
        public string Position
        {
            get { return position; }
            set { position = value;}
        }
        public string AgencyId
        {
            get { return agencyId; }
            set { agencyId = value;}
        }
        public string Password
        {
            get { return password; }
            set { password = value;}
        }

        //methods
        //returns string with object's data values
        public override string ToString() //override the parent method 
        {
            return id + " " + firstName + " " + middleInitial + " " + lastName + "\n" + busPhone + "\n" +email + "\n" + position + "\n" + agencyId;
        }
    }
}
