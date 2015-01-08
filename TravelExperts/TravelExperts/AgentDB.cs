using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    class AgentDB
    {
        

        public static Product GetAgent(string productCode)
        {
            //Build select statement 
            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode";

            SqlCommand selectCommand = TravelExpertsDB.GetAndDefineConnection(selectStatement);
    
            //Patch previous statement
            selectCommand.Parameters.AddWithValue("@ProductCode", productCode);

            //Exception handling
            try
            {
                //executes if product exists
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Product product = new Product();
                    //Fill with data from reader
                    product.ProductCode = custReader["ProductCode"].ToString();
                    product.Description = custReader["Description"].ToString();
                    product.UnitPrice = custReader["UnitPrice"].ToString();
                    product.OnHandQuantity = custReader["OnHandQuantity"].ToString();

                    //Returns product
                    return product;
                }
                else //product does not exist
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                //hand over to the presentation layer
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice, OnHandQuantity) " +
                "VALUES (@ProductCode, @Description, @UnitPrice, @OnHandQuantity)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            insertCommand.Parameters.AddWithValue("@Description", product.Description);
            insertCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            insertCommand.Parameters.AddWithValue("@OnHandQuantity", product.OnHandQuantity);

            //Exception handling
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Products') FROM Products";

                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                string productName = Convert.ToString(selectCommand.ExecuteScalar());
                return productName;
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

        //Method for updating product if new informarion
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "ProductCode = @NewProductCode, " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewUnitPrice, " +
                "OnHandQuantity = @NewOnHandQuantity " +
                "WHERE ProductCode = @OldProductCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldUnitPrice " +
                "AND OnHandQuantity = @OldOnHandQuantity";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewProductCode", newProduct.ProductCode);
            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewUnitPrice", newProduct.UnitPrice);
            updateCommand.Parameters.AddWithValue("@NewOnHandQuantity", newProduct.OnHandQuantity);

            updateCommand.Parameters.AddWithValue("@OldProductCode", oldProduct.ProductCode);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue("@OldUnitPrice", oldProduct.UnitPrice);
            updateCommand.Parameters.AddWithValue("@OldOnHandQuantity", oldProduct.OnHandQuantity);

            //Exception handling
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @ProductCode " +
                "AND Description = @Description " +
                "AND UnitPrice = @UnitPrice " +
                "AND OnHandQuantity = @OnHandQuantity ";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            deleteCommand.Parameters.AddWithValue("@Description", product.Description);
            deleteCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            deleteCommand.Parameters.AddWithValue("@OnHandQuantity", product.OnHandQuantity);

            //Exception handling
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
