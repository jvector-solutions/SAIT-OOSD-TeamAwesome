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
            // Connect to database and populate the list
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
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dgvProducts.DataSource = myTable;
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
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
