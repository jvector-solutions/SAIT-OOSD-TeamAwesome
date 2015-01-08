using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmPackage : Form
    {
        Package package;
        public frmPackage(Package newPackage)
        {
            package = newPackage;
            InitializeComponent();
        }
    }
}
