using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class SupplierDB
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

        // Alter supplier value in the database
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


        /////Performs search on main page////
        public static List<Supplier> SearchSuppliers(string charactersToSearch)
        {

            List<Supplier> supplierList = new List<Supplier>();

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //create sql command
            string selectStatement = "SELECT * FROM Suppliers " +
                "WHERE SupplierId like '%" + charactersToSearch.Trim() + "%' OR " +
                "SupName like '%" + charactersToSearch.Trim() + "%'";

            //search for something
            if (charactersToSearch.Trim().Length != 0)
            {
                string msg = "";
                if (Validator.inputIsInteger(charactersToSearch, out msg))
                {
                    selectStatement += " OR SupplierId ='" + charactersToSearch + "'";
                }
            }

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            //open connection
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Supplier newSupplier = new Supplier();//create a Supplier
                    newSupplier.SupplierId = Convert.ToInt32(reader["SupplierId"]);//add Supplier details
                    var supRead = reader["SupName"].ToString();
                    newSupplier.SupName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(supRead.ToLower());

                    supplierList.Add(newSupplier);//add Supplier to list
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
