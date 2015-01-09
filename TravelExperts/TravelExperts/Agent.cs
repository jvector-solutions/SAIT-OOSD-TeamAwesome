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
        private int agentId;
        private string agtFirstName;
        private string agtMiddleInitial;
        private string agtLastName;
        private string agtBusPhone;
        private string agtEmail;
        private string agtPosition;
        private string agencyId;
        private string agtPassword;

        //Constructor with parameters and default values
        public Agent(int i=0, string fN="", string mI="", string lN="", 
            string bP="", string e="", string p="", string aI="", string pass="")
        {
            agentId = i;
            agtFirstName = fN;
            agtMiddleInitial = mI;
            agtLastName = lN;
            agtBusPhone = bP;
            agtEmail = e;
            agtPosition = p;
            agencyId = aI;
            agtPassword = pass;
        }
  
        //Setters and getters
        public int AgentId
        {
            get { return agentId; }
            set { agentId = value;}
        }
        public string AgtFirstName
        {
            get { return agtFirstName; }
            set { agtFirstName = value;}
        } 
        public string AgtMiddleInitial
        {
            get { return agtMiddleInitial; }
            set { agtMiddleInitial = value;}
        } 
        public string AgtLastName
        {
            get { return agtLastName; }
            set { agtLastName = value;}
        }
        public string AgtBusPhone
        {
            get { return agtBusPhone; }
            set { agtBusPhone = value;}
        }
        public string AgtEmail
        {
            get { return agtEmail; }
            set { agtEmail = value;}
        }
        public string AgtPosition
        {
            get { return agtPosition; }
            set { agtPosition = value;}
        }
        public string AgencyId
        {
            get { return agencyId; }
            set { agencyId = value;}
        }
        public string AgtPassword
        {
            get { return agtPassword; }
            set { agtPassword = value;}
        }

        //methods
        //returns string with object's data values
        public override string ToString() //override the parent method 
        {
            return agentId + " " + agtFirstName + " " + agtMiddleInitial + " " + agtLastName + "\n" + agtBusPhone + "\n" +agtEmail + "\n" + agtPosition + "\n" + agencyId;
        }
    }
}
