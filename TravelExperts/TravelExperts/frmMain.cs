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

        //To be used when calling the Agent form
        private Agent agent;

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

        //Display the Agent form
        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgentModify callAgentForm = new frmAgentModify();
            //callAgentForm.addAgent = true;
            DialogResult result = callAgentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                agent = callAgentForm.agent;
                //txtProductCode.Text = product.ProductCode.ToString();
                //this.DisplayProduct();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmPackage newForm = new frmPackage(null);
            DialogResult result = newForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }
    }
}
