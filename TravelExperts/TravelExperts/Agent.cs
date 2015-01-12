using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public class Agent
    {
        //Constructor --------------------------------
        public Agent() { }

        //Properties --------------------------------
        public int AgentId { get; set; }

        public string AgtFirstName { get; set; }

        public string AgtMiddleInitial { get; set; }

        public string AgtLastName { get; set; }

        public string AgtBusPhone { get; set; }

        public string AgtEmail { get; set; }

        public string AgtPosition { get; set; }

        public int AgencyId { get; set; }

        public string AgtPassword { get; set; }

    }
}
