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
    public class SupplierDB
    {
        // Get all supplier values in the database, sorted, and only first-letter capitalized
        public static List<Supplier> GetSupplier()
        {
            List<Supplier> supList = new List<Supplier>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT SupName,SupplierId " +
                "FROM Suppliers " +
                "ORDER BY SupName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Supplier s = new Supplier();
                    var supRead = reader["SupName"].ToString();
                    s.SupName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(supRead.ToLower());
                    s.SupplierId = (int)reader["SupplierId"];
                    supList.Add(s);
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
            return supList;
        }

        // Change the name of the supplier in the database
        public static void UpdateSupplier(string oldSup, string newSup)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string modifyStatement =
                "UPDATE Suppliers SET " +
                "SupName = @NewSupplierName " +
                "WHERE SupName = @OldSupplierName";
            SqlCommand modifyCommand = new SqlCommand(modifyStatement, connection);
            modifyCommand.Parameters.AddWithValue("@NewSupplierName", newSup);
            modifyCommand.Parameters.AddWithValue("@OldSupplierName", oldSup);

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

        // Add a new single supplier to the database
        public static void AddSupplierName(string newSup)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = 
                "INSERT INTO Suppliers VALUES(@randID,@newSup)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            // This line generates a random number between 14000 and 99999 for the Supplier ID
            // because the ProductID in the Suppliers table was created without the auto increment property
            Random randInt = new Random();
            insertCommand.Parameters.AddWithValue("@randID", randInt.Next(14000,99999).ToString());
            insertCommand.Parameters.AddWithValue("@newSup", newSup);
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

        // Get a list of products to be deleted for a selected supplier
        public static List<string> GetDeleteList(string delSup)
        {
            // Create a list of the items being deleted and display in a message box
            List<string> delList = new List<string>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT DISTINCT ProdName " +
                "FROM Products p,Suppliers s,Products_Suppliers ps " +
                "WHERE p.ProductId = ps.ProductId AND s.SupplierId = ps.SupplierId " +
                "AND s.SupName = @delSup " +
                "ORDER BY ProdName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@delSup", delSup);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    delList.Add(reader["ProdName"].ToString());
                }
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
            return delList;
        }

        // Delete a ProductSupplierId, and a SupplierId from the database after confirmation
        public static void DeleteSupplierName(string delSupplier)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Products_Suppliers " +
                "WHERE SupplierId IN " +
                "(SELECT SupplierId FROM Suppliers WHERE SupName = @delSup); " +
                "DELETE FROM Suppliers " +
                "WHERE SupName = @delSup";
            SqlCommand insertCommand = new SqlCommand(deleteStatement, connection);
            insertCommand.Parameters.AddWithValue("@delSup", delSupplier);
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

        // Performs search on main page
        public static List<Supplier> SearchSuppliers(string charactersToSearch)
        {

            List<Supplier> supplierList = new List<Supplier>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT * FROM Suppliers " +
                "WHERE SupplierId like '%" + charactersToSearch.Trim() + "%' OR " +
                "SupName like '%" + charactersToSearch.Trim() + "%'";
            if (charactersToSearch.Trim().Length != 0)
            {
                string msg = "";
                if (Validator.inputIsInteger(charactersToSearch, out msg))
                {
                    selectStatement += " OR SupplierId ='" + charactersToSearch + "'";
                }
            }
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Supplier newSupplier = new Supplier(); //create a Supplier object
                    newSupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]); //add Supplier details
                    var supRead = reader["SupName"].ToString();
                    newSupplier.SupName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(supRead.ToLower());
                    supplierList.Add(newSupplier); //add Supplier to list
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
            return supplierList;
        }
    }
}
