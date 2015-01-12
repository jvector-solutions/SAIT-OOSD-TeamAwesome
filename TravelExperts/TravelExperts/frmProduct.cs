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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open the modify product tab in a new form from the menu bar
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyProductSupplier modifyPSForm = new frmModifyProductSupplier();
            DialogResult result = modifyPSForm.ShowDialog();
            if (result == DialogResult.OK)
                this.frmProduct_Load(this, null);
            }

        // Open the modify supplier tab in a new form from the menu bar
        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyProductSupplier modifyPSForm = new frmModifyProductSupplier();
            DialogResult result = modifyPSForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.frmProduct_Load(this, null);
                modifyPSForm.productTab = false;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // Fills the dataviewgrid with table data pulled from the database
            dgvProducts.DataSource = ProductSupplierDB.GetProducts();

            dgvProducts.Columns[0].Width = 42;
            dgvProducts.Columns[1].Width = 145;
            dgvProducts.Columns[2].Width = 316;

            // Data binding for the Products & Suppliers drop-down lists
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            
            // Load the suppliers combo box
            this.LoadSupplierComboBox();
        }

        private void txtProductSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            string searchBoxText = txtProductSupplierSearch.Text;
            dgvProducts.DataSource = ProductSupplierDB.SearchProductSupplier(searchBoxText);
        }

        // Creates an ordered list of the Suppliers
        private void LoadSupplierComboBox()
        {
            List<Supplier> supList = new List<Supplier>();
            try
            {
                supList = SupplierDB.GetSupplier();
                cboSupplierList.DataSource = supList;
                cboSupplierList.DisplayMember = "SupName";
                cboSupplierList.ValueMember = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Add a new product + supplier combination
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string selProd = cboProductList.Text;
            string selSup = cboSupplierList.Text;
            if (ProductSupplierDB.CheckProductSupplierExists(selProd,selSup)) // Combination exists in the database, warn the user
            {
                MessageBox.Show("Warning: Item already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else   // Combination is not in database, add product
            {
                ProductSupplierDB.AddProduct(selProd, selSup);
                dgvProducts.DataSource = ProductSupplierDB.GetProducts();

                var MaxID = dgvProducts.Rows.Cast<DataGridViewRow>()
                        .Max(r => Convert.ToInt32(r.Cells["ID"].Value));
                int rowIndex = 0;

                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["ID"].Value.ToString() != MaxID.ToString())
                        rowIndex++;
                    else
                    {
                        dgvProducts.Rows[rowIndex].Selected = true;
                        dgvProducts.FirstDisplayedScrollingRowIndex = rowIndex;
                        break;
                    }
                }
            }
        }

        private void btnModifyProductSupplier_Click(object sender, EventArgs e)
        {
            frmModifyProductSupplier modifyPSForm = new frmModifyProductSupplier();
            DialogResult result = modifyPSForm.ShowDialog();
            if (result == DialogResult.OK)
                this.frmProduct_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string prodValue = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();   // Gets the product of the selected row
            string supValue = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();   // Gets the supplier of the selected row
            DialogResult result = 
                MessageBox.Show("Delete this item (" + prodValue + " - " + supValue + ")?"
                ,"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow item in dgvProducts.SelectedRows)
                    {
                        dgvProducts.Rows.RemoveAt(item.Index);
                        ProductSupplierDB.DeleteProductSupplier(prodValue, supValue);
                        this.frmProduct_Load(this, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
