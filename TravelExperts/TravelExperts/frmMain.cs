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
        private Package package;

        private void SearchFor() {
            //search for Packages
            if (rdbPackage.Checked)
            {
                string searchMe = txtSearch.Text;
                dgvMainPage.DataSource = PackageDB.GetPackages(searchMe, chbIncludeExpiredPackages.Checked);
            }
            //search for Products
            if (rdbProduct.Checked)
            {
                string searchMe = txtSearch.Text;
                dgvMainPage.DataSource = PackageDB.GetProducts(searchMe, false);
            }
            //search for Suppliers
            if (rdbSupplier.Checked)
            {

            }
            //search for Agents
            if (rdbAgents.Checked)
            {

            }
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

        //Display the Agent form
        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgents callAgentForm = new frmAgents();
            //callAgentForm.addAgent = true;
            DialogResult result = callAgentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //agent = callAgentForm.agent;
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
            package = null;
            frmPackage newForm = new frmPackage(package);
            DialogResult result = newForm.ShowDialog();
            SearchFor();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }

        private void chbIncludeExpiredPackages_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            frmProduct newForm = new frmProduct();
            DialogResult result = newForm.ShowDialog();
        }
        private bool OneRowIsSelected()
        {
            int count = 0;
            foreach (DataGridViewRow item in this.dgvMainPage.SelectedRows)
            {
                count++;
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }

        private void dgvMainPage_Click(object sender, EventArgs e)
        {
            if (OneRowIsSelected() && rdbPackage.Checked)
            {
                if (rdbPackage.Checked)//package
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }//multiple items are selected
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rdbPackage.Checked)//delete the package
            {
                int row = this.dgvMainPage.CurrentCell.RowIndex;
                int col = 0;
                int pkgid = (int)dgvMainPage.Rows[row].Cells[col].Value;
                if (PackageDB.DeletePackage(pkgid))
                {
                    MessageBox.Show("Package was deleted");
                    SearchFor();
                }
                else
                {
                    MessageBox.Show("Failed deleting Package");
                }
            }
        }
        //edit package
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //get selected package
            int row = this.dgvMainPage.CurrentCell.RowIndex;
            int col = 0;
            int pkgid = (int)dgvMainPage.Rows[row].Cells[col].Value;
            package = PackageDB.GetPackage(pkgid);

            //open modify form and pass selected package
            frmPackage newForm = new frmPackage(package);
            DialogResult result = newForm.ShowDialog();
            SearchFor();
        }
    }
}
