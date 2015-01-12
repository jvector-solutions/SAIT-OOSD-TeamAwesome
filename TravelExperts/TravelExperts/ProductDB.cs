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
        // Get Product_SupplierID, Product Name, and Supplier Name table information from the database
        public static DataTable GetProducts()
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT ProductSupplierId AS ID,ProdName AS Product,SupName AS Supplier " +
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

        // Find ProductSupplierIds, Product Names, or Supplier Names that contain the search string
        public static DataTable SearchProductSupplier(string searchString)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "Select ProductSupplierId AS ID,ProdName AS Product,SupName AS Supplier " +
                "FROM Products p,Suppliers s,Products_Suppliers ps " +
                "WHERE (p.ProductId = ps.ProductId AND s.SupplierId = ps.SupplierId) AND " +
	            "(ProdName LIKE '" + searchString.Trim() + "%' " + 
                "OR SupName LIKE '" + searchString.Trim() + "%'" +
                "OR ProductSupplierId LIKE '" + searchString.Trim() + "%')";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
            DataTable searchTable = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(searchTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchTable;
        }

        // Method to check if the submitted product + supplier combination already exists in the database
        public static bool CheckProductExists(string prodName,string supName)
        {
            bool doesExist;
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "SELECT @prodName,@supName " +
                "FROM Products_Suppliers ps " +
                "INNER JOIN Products p ON p.ProductId = ps.ProductId AND p.ProdName = @prodName " +
                "INNER JOIN Suppliers s ON s.SupplierId = ps.SupplierId AND s.SupName = @supName";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@prodName", prodName);
            insertCommand.Parameters.AddWithValue("@supName", supName);
            try
            {
                connection.Open();
                object checkExist = insertCommand.ExecuteScalar();
                if (checkExist == null)
                {
                    doesExist = false;
                }
                else
                {
                    doesExist = true;
                }
                return doesExist;
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

        // Add a new product + supplier combination information to the database
        public static void AddProduct(string prodName,string supName)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "INSERT INTO Products_Suppliers (ProductId, SupplierId) " +
                "SELECT ProductId, SupplierId " +
                "FROM Products, Suppliers " +
                "WHERE ProdName = @prodName AND SupName = @supName";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@prodName", prodName);
            insertCommand.Parameters.AddWithValue("@supName", supName);
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

        // Delete a ProductSupplierId and Product + Supplier combination from the database
        public static void DeleteProductSupplier(string selProd,string selSup)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products_Suppliers " +
                "WHERE ProductSupplierId IN " +
                "(SELECT ProductSupplierId FROM Products_Suppliers ps " +
                "INNER JOIN Products p ON ps.ProductId = p.ProductId AND p.ProdName = @selProd " +
                "INNER JOIN Suppliers s ON ps.SupplierId = s.SupplierId AND s.SupName = @selSup)";
            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);
            insertCommand.Parameters.AddWithValue("@selProd", selProd);
            insertCommand.Parameters.AddWithValue("@selSup", selSup);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
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

        // Change the name of a single product in the database
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
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        // Add a new single product to the database
        public static void AddProductName(string newProd)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) VALUES(@newProd)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@newProd", newProd);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
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

        // Get a list of suppliers to be deleted along with the selected product
        public static List<string> GetDeleteList(string delProduct)
        {
            // Create a list of the items being deleted and display in a message box
            List<string> delList = new List<string>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT DISTINCT SupName " +
                "FROM Products p,Suppliers s,Products_Suppliers ps " +
                "WHERE p.ProductId = ps.ProductId AND s.SupplierId = ps.SupplierId " +
                "AND ProdName = @ProdName " +
                "ORDER BY SupName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProdName", delProduct);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    delList.Add(reader["SupName"].ToString());
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return delList;
        }

        // Delete a ProductSupplierId, and a ProductId from the database after confirmation
        public static void DeleteProductName(string delProduct)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products_Suppliers " +
                "WHERE ProductId IN " +
                "(SELECT ProductId FROM Products WHERE ProdName = @delProd); " +
                "DELETE FROM Products " +
                "WHERE ProdName = @delProd";
            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);
            insertCommand.Parameters.AddWithValue("@delProd", delProduct);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
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

        /////Performs search on main page////
        public static List<Product> SearchProducts(string charactersToSearch)
        {

            List<Product> productList = new List<Product>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT * FROM Products " +
                "WHERE ProductId like '%" + charactersToSearch.Trim() + "%' OR " +
                "ProdName like '%" + charactersToSearch.Trim() + "%'";
            if (charactersToSearch.Trim().Length != 0)
            {
                string msg = "";
                if (Validator.inputIsInteger(charactersToSearch, out msg))
                {
                    selectStatement += " OR ProductId ='" + charactersToSearch + "'";
                }
            }
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product newProduct = new Product(); //create a Product object
                    newProduct.prodID = Convert.ToInt32(reader["ProductId"]); //add package details
                    newProduct.prodName = reader["ProdName"].ToString();
                    productList.Add(newProduct); //add Product to list
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productList;
        }
    }
}
