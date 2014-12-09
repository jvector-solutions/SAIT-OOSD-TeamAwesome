/*
 * Console for Testing Package Class
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
    class Program
    {
        static void Main(string[] args)
        {
            //create list for packages
            List<Package> packages = new List<Package>();

            //create Packages
            Package pkg1 = new Package();
            Package pkg2 = new Package(10);
            Package pkg3 = new Package(20,"Carribean");
            Package pkg4 = new Package(30,"SAIT");
            Package pkg5 = new Package(40,"BubbleMania","","","Unlimited drinks",0m,100m);
            Package pkg6 = new Package(50,"Earl's","","","",100m);

            //add pkgX to List
            packages.Add(pkg1);
            packages.Add(pkg2);
            packages.Add(pkg3);
            packages.Add(pkg4);
            packages.Add(pkg5);
            packages.Add(pkg6);

            //display packages
            foreach (Package pkg in packages)
            {
                Console.WriteLine(pkg);
            }

            //delay
            Console.ReadKey();
        }
    }
}
