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
                "SELECT * " +
                "FROM Customers ORDER BY CustFirstName, CustLastName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader();
                while (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                    customer.AgentID = (int)custReader["AgentID"];

                    customers.Add(customer);
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
            Customer customer = null;

            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement
                = "SELECT * "
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
                    customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                    customer.AgentID = (int)custReader["AgentID"];
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
            updateCommand.Parameters.AddWithValue("@NewName", customer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@NewAddress", customer.CustAddress);
            updateCommand.Parameters.AddWithValue("@NewCity", customer.CustCity);
            updateCommand.Parameters.AddWithValue("@NewState", customer.CustProv);
            updateCommand.Parameters.AddWithValue("@NewZipCode", customer.CustPostal);
            updateCommand.Parameters.AddWithValue("@OldName", original_customer.CustFirstName);
            updateCommand.Parameters.AddWithValue("@OldAddress", original_customer.CustAddress);
            updateCommand.Parameters.AddWithValue("@OldCity", original_customer.CustCity);
            updateCommand.Parameters.AddWithValue("@OldState", original_customer.CustProv);
            updateCommand.Parameters.AddWithValue("@OldZipCode", original_customer.CustPostal);
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