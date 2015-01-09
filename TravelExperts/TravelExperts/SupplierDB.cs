using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class SupplierDB
    {
        // Alter product value in the database
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
