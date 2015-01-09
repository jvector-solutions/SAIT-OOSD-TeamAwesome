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

        private void frmPackage_Load(object sender, EventArgs e)
        {
            //load info if modify is clicked
            if(package != null){

            }
            FillProductComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FillProductComboBox()
        {
            List<Product> products;
            products = PackageDB.GetProducts("");

            foreach (Product p in products)
            {
                //ComboBoxItem item = new ComboBoxItem();
                //item.Text = "Item text1";
                //item.Value = 12;
                cbxProductList.Items.Add(p);
            }
        }
    }
}
