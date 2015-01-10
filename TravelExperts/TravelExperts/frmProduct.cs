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

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyProductSupplier modifyPSForm = new frmModifyProductSupplier();
            DialogResult result = modifyPSForm.ShowDialog();
            if (result == DialogResult.OK)
                this.frmProduct_Load(this, null);
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // Fills the dataviewgrid with table data pulled from the database
            dgvProducts.DataSource = ProductDB.ListProducts();

            dgvProducts.Columns[0].Width = 42;
            dgvProducts.Columns[1].Width = 145;
            dgvProducts.Columns[2].Width = 316;

            // Data binding for the Products & Suppliers drop-down lists
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string selProd = cboProductList.Text;
            string selSupp = cboSupplierList.Text;
            ProductDB.AddProduct(selProd,selSupp);
            dgvProducts.DataSource = ProductDB.ListProducts();
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
            string suppValue = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();   // Gets the supplier of the selected row
            DialogResult result = 
                MessageBox.Show("Delete this item (" + prodValue + " - " + suppValue + ")?"
                ,"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow item in dgvProducts.SelectedRows)
                    {
                        dgvProducts.Rows.RemoveAt(item.Index);
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
