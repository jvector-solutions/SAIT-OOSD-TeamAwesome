/* CMPP248 Part 2 Workshop 2
 * Class for Packages
 * Created by: MB, Leisy, and John
 * January 12, 2015
 */
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
        private Package package;


        //Display individual forms according to button pressed --------------------------------
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            package = null;
            frmPackage newForm = new frmPackage(package);
            DialogResult result = newForm.ShowDialog();
            SearchFor();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgents callAgentForm = new frmAgents();
            callAgentForm.ShowDialog();
        }

        private void btnProductSuppliers_Click(object sender, EventArgs e)
        {
            frmProduct newForm = new frmProduct();
            DialogResult result = newForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the package
            if (rdbPackage.Checked)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edit package from main form
            if (rdbPackage.Checked)
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


        //Main form controls --------------------------------
         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //DataGridView Controls  --------------------------------
        private void dgvMainPage_Click(object sender, EventArgs e)
        {
            EnableDisableEditButton();
        }

        private void EnableDisableEditButton()
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

        private bool OneRowIsSelected()
        {
            int count = 0;
            foreach (DataGridViewRow item in dgvMainPage.SelectedRows)
            {
                count++;
            }
            if (count == 1)
            {
                return true;
            }
            return false;
        }

        private void chbIncludeExpiredPackages_Click(object sender, EventArgs e)
        {
            SearchFor();
            FocusSelectAllSearchBox();
        }


        //Methods/Actions for interaction with radio buttons and search --------------------------------
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            SearchFor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchFor();
        }

        private void SearchFor()
        {
            bool isIncludeExpiredPackagesEnabled = false;
            dgvMainPage.DataSource = null;
            
            //search for Packages
            if (rdbPackage.Checked)
            {
                isIncludeExpiredPackagesEnabled = true;
                dgvMainPage.DataSource = PackageDB.GetPackages(txtSearch.Text, chbIncludeExpiredPackages.Checked);
            }
            //search for Products
            if (rdbProduct.Checked)
            {
                dgvMainPage.DataSource = ProductDB.SearchProducts(txtSearch.Text);
            }
            //search for Suppliers
            if (rdbSupplier.Checked)
            {
                dgvMainPage.DataSource = SupplierDB.SearchSuppliers(txtSearch.Text);
            }
            //search for Agents
            if (rdbAgents.Checked)
            {
                dgvMainPage.DataSource = AgentDB.SearchAgents(txtSearch.Text);
            }

            chbIncludeExpiredPackages.Enabled = isIncludeExpiredPackagesEnabled;//enable 'IncludeExpiredPackages' box or not
            this.Refresh();
            EnableDisableEditButton();
        }

        private void FocusSelectAllSearchBox()
        {
            txtSearch.Focus();
            txtSearch.SelectAll();
        }

        private void rdbPackage_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";//empty text field if user changes search parameters
            SearchFor();
            FocusSelectAllSearchBox();
        }

        private void rdbProduct_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";//empty text field if user changes search parameters
            SearchFor();
        }

        private void rdbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";//empty text field if user changes search parameters
            SearchFor();
        }

        private void rdbAgents_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";//empty text field if user changes search parameters
            SearchFor();
        }

        private void chbIncludeExpiredPackages_CheckedChanged(object sender, EventArgs e)
        {
            SearchFor();
        }
    }
}
