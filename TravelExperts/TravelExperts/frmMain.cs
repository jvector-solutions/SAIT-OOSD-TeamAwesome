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
                dgvMainPage.DataSource = PackageDB.GetPackages(searchMe);
            }
            //search for Products
            //search for Suppliers
            //search for Agents
        }
        private void FocusSelectAllSearchBox()
        {
            txtSearch.Focus();
            txtSearch.SelectAll();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchFor();
        }
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            SearchFor();
        }
        private void rdbPackage_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }
        private void rdbProduct_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }
        private void rdbSupplier_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }
        private void rdbAgents_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
