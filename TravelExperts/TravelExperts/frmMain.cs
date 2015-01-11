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
        //--------->>>>>>> Feel free to break it por favor :)
        //--------->>>>>>> Let me know if i got to fix something. There are details here and there but i did not 
        //--------->>>>>>> find anything that make the thing explode :)

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
        }        //edit package from main form
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

        }//delete package from main form

        //Main form controls --------------------------------
         private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DataGridView Controls  --------------------------------
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
            //--------->>>>>>> MB I disabled this checkbox unless "produt" radio button is active. Also we need to 
            //--------->>>>>>> fix the 'edit' and 'delete' buttons because they dont become enabled until the user
            //--------->>>>>>> selects the second row on the dgvMainPage. Maybe placing the enable property were 
            //--------->>>>>>> it will load sooner? or maybe loading the dataTable w/o an initial selected row by
            //--------->>>>>>> default? :) not a big thing but i noticed... 

            bool isIncludeExpiredPackagesEnabled = false;

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
        }
        private void FocusSelectAllSearchBox()
        {
            txtSearch.Focus();
            txtSearch.SelectAll();
        }

        //--------->>>>>>> MB i changed the method below from 'Selected' to 'CheckedChanged' so the loading 
        //--------->>>>>>> of the tables is done as soon as the user changes the option on the radio button 
        //--------->>>>>>> but if you have a better idea goooooooooooo ahead :) so far i think this one works 
        //--------->>>>>>> pretty well, before the tables would not update until data was entered on the search box

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
    }
}
