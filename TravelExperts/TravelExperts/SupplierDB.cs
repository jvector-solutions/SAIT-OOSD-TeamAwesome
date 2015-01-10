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
                    s.SupName = reader["SupName"].ToString();
                    s.SupplierId = (int) reader["SupplierId"];
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
    }
}
