using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());         // Runs the main program

            // Application.Run(new frmProducts());      // Runs the Product form
            // Application.Run(new frmSupplier());     // Runs the Supplier form
        }
    }
}
