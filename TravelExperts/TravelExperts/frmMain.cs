using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SearchFor() {
            //search for Packages
            if (rdbPackage.Checked)
            {
                string searchMe = txtSearch.Text;
                //dgvMainPage.DataSource = Package.GetPackages(searchMe);
            }
            //search for Products
            //search for Suppliers
            //search for Agents
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgents addAgentForm = new frmAgents();
            //addAgentForm.addAgent = true;
            DialogResult result = addAgentForm.ShowDialog();
            /*if (result == DialogResult.OK)
            {
                //product = addAgentForm.product;
                //txtProductCode.Text = product.ProductCode.ToString();
                //this.DisplayProduct();
            }*/
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
