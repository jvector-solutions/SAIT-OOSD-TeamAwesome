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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // Connect to database and populate the Data Grid
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "Select ProductSupplierId AS ID,ProdName AS Product,SupName AS Supplier " +
                "FROM Products p,Suppliers s,Products_Suppliers ps " +
                "WHERE p.ProductId = ps.ProductId AND s.SupplierId = ps.SupplierId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            var adapter = new SqlDataAdapter(selectCommand);

            try
            {
                connection.Open();
                var itemTable = new DataTable();
                adapter.Fill(itemTable);
                dgvProducts.DataSource = itemTable;
                dgvProducts.Columns[0].Width = 53;
                dgvProducts.Columns[1].Width = 140;
                dgvProducts.Columns[2].Width = 310;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            // Data binding for the Supplier drop-down list
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);

            // Data binding for the Product drop-down list
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyProductSupplier_Click(object sender, EventArgs e)
        {
            frmModifyProductSupplier modifyPSForm = new frmModifyProductSupplier();
            DialogResult result = modifyPSForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete ?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
