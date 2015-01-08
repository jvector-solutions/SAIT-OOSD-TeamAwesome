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
        public static Agent GetAgent(string agentId)
        {

            //Define conection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //Build select statement 
            string selectStatement
                = "SELECT AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition, AgencyId, AgtPassword "
                + "FROM Agents "
                + "WHERE AgentId = @AgentId";

            //Build SQL command
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //Patch previous statement
            selectCommand.Parameters.AddWithValue("@AgentId", agentId);

            //Exception handling
            try
            {
                //executes if product exists
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Agent agent = new Agent();
                    //Fill with data from reader
                    agent.AgentId = Convert.ToInt32(custReader["agentId"]);
                    agent.AgtMiddleInitial = custReader["MiddleInitial"].ToString();
                    agent.AgtLastName = custReader["LastName"].ToString();
                    agent.AgtBusPhone = custReader["BusPhone"].ToString();
                    agent.AgtEmail = custReader["Email"].ToString();
                    agent.AgtPosition = custReader["Position"].ToString();
                    agent.AgtPassword = custReader["Password"].ToString();

                    //Returns agent
                    return agent;
                }
                else //agent does not exist
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

        public static string AddProduct(Agent agent)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "INSERT Agents " +
                "(AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition, AgencyId, AgtPassword) " +
                "VALUES (@AgentId, @AgtFirstName, @AgtMiddleInitial, @AgtLastName, @AgtBusPhone, @AgtEmail, @AgtPosition, @AgencyId, @AgtPassword)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@AgentId", agent.AgentId);
            insertCommand.Parameters.AddWithValue("@AgtFirstName", agent.AgtFirstName);
            insertCommand.Parameters.AddWithValue("@AgtMiddleInitial", agent.AgtMiddleInitial);
            insertCommand.Parameters.AddWithValue("@AgtLastName", agent.AgtLastName);
            insertCommand.Parameters.AddWithValue("@AgtBusPhone", agent.AgtBusPhone);
            insertCommand.Parameters.AddWithValue("@AgtEmail", agent.AgtEmail);
            insertCommand.Parameters.AddWithValue("@AgtPosition", agent.AgtPosition);
            insertCommand.Parameters.AddWithValue("@AgtEmail", agent.AgencyId);
            insertCommand.Parameters.AddWithValue("@AgtPosition", agent.AgtPassword);

            //Exception handling
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Agents') FROM Agents";

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

        //Method for updating product if new info
        public static bool UpdateProduct(Agent oldAgent, Agent newAgent)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "AgentId = @NewAgentId, " +
                "AgtFirstName = @NewAgtFirstName, " +
                "AgtMiddleInitial = @NewAgtMiddleInitial, " +
                "AgtLastName = @NewAgtLastName " +
                "AgtBusPhone = @NewAgtBusPhone, " +
                "AgtEmail = @NewAgtEmail, " +
                "AgtPosition = @NewAgtPosition, " +
                "AgencyId = @NewAgencyId " +
                "AgtPassword = @NewAgtPassword " +

                "WHERE @AgentId = @OldAgentId, " +
                "AND AgtFirstName = @OldAgtFirstName, " +
                "AND AgtMiddleInitial = @OldAgtMiddleInitial, " +
                "AND AgtLastName = @OldAgtLastName " +
                "AND AgtBusPhone = @OldAgtBusPhone, " +
                "AND AgtEmail = @OldAgtEmail, " +
                "AND AgtPosition = @OldAgtPosition, " +
                "AND AgencyId = @OldAgencyId " +
                "AND AgtPassword = @OldAgtPassword";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewAgentId", newAgent.AgentId);
            updateCommand.Parameters.AddWithValue("@NewAgtFirstName", newAgent.AgtFirstName);
            updateCommand.Parameters.AddWithValue("@NewAgtMiddleInitial", newAgent.AgtMiddleInitial);
            updateCommand.Parameters.AddWithValue("@NewAgtLastName", newAgent.AgtLastName);
            updateCommand.Parameters.AddWithValue("@NewAgtBusPhone", newAgent.AgtBusPhone);
            updateCommand.Parameters.AddWithValue("@NewAgtEmail", newAgent.AgtEmail);
            updateCommand.Parameters.AddWithValue("@NewAgtPosition", newAgent.AgtPosition);
            updateCommand.Parameters.AddWithValue("@NewAgencyId", newAgent.AgencyId);
            updateCommand.Parameters.AddWithValue("@NewAgtPassword", newAgent.AgtPassword);

            updateCommand.Parameters.AddWithValue("@OldAgentId", oldAgent.AgentId);
            updateCommand.Parameters.AddWithValue("@OldAgtFirstName", oldAgent.AgtFirstName);
            updateCommand.Parameters.AddWithValue("@OldAgtMiddleInitial", oldAgent.AgtMiddleInitial);
            updateCommand.Parameters.AddWithValue("@OldAgtLastName", oldAgent.AgtLastName);
            updateCommand.Parameters.AddWithValue("@OldAgtBusPhone", oldAgent.AgtBusPhone);
            updateCommand.Parameters.AddWithValue("@OldAgtEmail", oldAgent.AgtEmail);
            updateCommand.Parameters.AddWithValue("@OldAgtPosition", oldAgent.AgtPosition);
            updateCommand.Parameters.AddWithValue("@OldAgencyId", oldAgent.AgencyId);
            updateCommand.Parameters.AddWithValue("@OldAgtPassword", oldAgent.AgtPassword);

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

        public static bool DeleteProduct(Agent agent)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Agents " +
                "WHERE AgentId = @AgentId, " +
                "AND AgtFirstName = @AgtFirstName, " +
                "AND AgtMiddleInitial = @AgtMiddleInitial, " +
                "AND AgtLastName = @AgtLastName " +
                "AND AgtBusPhone = @AgtBusPhone, " +
                "AND AgtEmail = @AgtEmail, " +
                "AND AgtPosition = @AgtPosition, " +
                "AND AgencyId = @AgencyId " +
                "AND AgtPassword = @AgtPassword";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@AgentId", agent.AgentId);
            deleteCommand.Parameters.AddWithValue("@AgtFirstName", agent.AgtFirstName);
            deleteCommand.Parameters.AddWithValue("@AgtMiddleInitial", agent.AgtMiddleInitial);
            deleteCommand.Parameters.AddWithValue("@AgtLastName", agent.AgtLastName);
            deleteCommand.Parameters.AddWithValue("@AgtBusPhone", agent.AgtBusPhone);
            deleteCommand.Parameters.AddWithValue("@AgtEmail", agent.AgtEmail);
            deleteCommand.Parameters.AddWithValue("@AgtPosition", agent.AgtPosition);
            deleteCommand.Parameters.AddWithValue("@AgtEmail", agent.AgencyId);
            deleteCommand.Parameters.AddWithValue("@AgtPosition", agent.AgtPassword);

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
