using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace TravelExperts
{
    [DataObject(true)]
    public static class CustomerDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT CustomerID, Name, Address, City, State, ZipCode " +
                "FROM Customers order by Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader();
                while (custReader.Read())
                {
                    Customer cust = new Customer();
                    cust.CustomerID = (int)custReader["CustomerID"];
                    cust.Name = custReader["Name"].ToString();
                    cust.Address = custReader["Address"].ToString();
                    cust.City = custReader["City"].ToString();
                    cust.State = custReader["State"].ToString();
                    cust.ZipCode = custReader["ZipCode"].ToString();
                    customers.Add(cust);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer GetCustomer(int customerID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT CustomerID, Name, Address, City, State, ZipCode "
                + "FROM Customers "
                + "WHERE CustomerID = @CustomerID";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerID);
            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.Name = custReader["Name"].ToString();
                    customer.Address = custReader["Address"].ToString();
                    customer.City = custReader["City"].ToString();
                    customer.State = custReader["State"].ToString();
                    customer.ZipCode = custReader["ZipCode"].ToString();
                    return customer;
                }
                else
                {
                    return null;
                }
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

        [DataObjectMethod(DataObjectMethodType.Update)]
        public static bool UpdateCustomer(Customer original_customer, Customer customer)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Customers SET " +
                "Name = @NewName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
                "WHERE Name = @OldName " +
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewName", customer.Name);
            updateCommand.Parameters.AddWithValue("@NewAddress", customer.Address);
            updateCommand.Parameters.AddWithValue("@NewCity", customer.City);
            updateCommand.Parameters.AddWithValue("@NewState", customer.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", customer.ZipCode);
            updateCommand.Parameters.AddWithValue("@OldName", original_customer.Name);
            updateCommand.Parameters.AddWithValue("@OldAddress", original_customer.Address);
            updateCommand.Parameters.AddWithValue("@OldCity", original_customer.City);
            updateCommand.Parameters.AddWithValue("@OldState", original_customer.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", original_customer.ZipCode);
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
    }
}