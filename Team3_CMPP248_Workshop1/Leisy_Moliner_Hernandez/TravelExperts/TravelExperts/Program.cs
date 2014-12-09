//Team3_CMPP248_Workshop1
//December 9, 2014
//Leisy Moliner Hernandez
//Purpose: Main program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent newAgent = new Agent(10, "Scruffy","S","Scruffington","403-234-8989", "scruffy@te.com", "janitor","2","89889");
            string line = newAgent.ToString();
            Console.WriteLine(line);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
