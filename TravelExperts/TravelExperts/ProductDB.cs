using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    class ProductDB
    {
        // Pull table information from the database
        public static DataTable ListProducts()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "Select ProductSupplierId AS ID,ProdName AS Product,SupName AS Supplier " +
                "FROM Products p,Suppliers s,Products_Suppliers ps " +
                "WHERE p.ProductId = ps.ProductId AND s.SupplierId = ps.SupplierId " +
                "ORDER BY Product,Supplier";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable itemTable = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(itemTable);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return itemTable;

        }

        // Add table information to the database
        public static void AddProduct(string prodName,string suppName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "INSERT INTO Products_Suppliers (ProductId, SupplierId) " +
                "SELECT ProductId, SupplierId " +
                "FROM Products, Suppliers " +
                "WHERE ProdName = @productName AND SupName = @supplierName";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@productName", prodName);
            insertCommand.Parameters.AddWithValue("@supplierName", suppName);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": "
                    + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        // Alter product value in the database
        public static void UpdateProduct(string oldProd, string newProd)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string modifyStatement =
                "UPDATE Products SET " +
                "ProdName = @NewProductName " +
                "WHERE ProdName = @OldProductName";
            SqlCommand modifyCommand = new SqlCommand(modifyStatement, connection);
            modifyCommand.Parameters.AddWithValue("@NewProductName", newProd);
            modifyCommand.Parameters.AddWithValue("@OldProductName", oldProd);
            try
            {
                connection.Open();
                modifyCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + ": "
                    + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
