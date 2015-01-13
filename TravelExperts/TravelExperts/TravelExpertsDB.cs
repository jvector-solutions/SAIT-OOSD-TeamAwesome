/*
 * Travel Experts Project #2 - C#, ASP.NET, SQL Server
 * Class to connect to the TravelExperts Database
 * Created By: John, Leisy, MB (Team 3)
 * Created On: December 9, 2004
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            // Connect to the database using a sql server (connected model)
            string connectionString =
                "Data Source=localhost\\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
