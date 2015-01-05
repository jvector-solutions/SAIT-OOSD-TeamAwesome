using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sql name space
using System.Data.SqlClient;
using System.Data;

namespace sql_server_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>connection start");
            SqlConnection myConnection = new SqlConnection("server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=TravelExperts; " +
                                       "connection timeout=1");

            Console.WriteLine(">>>>>>open connection");
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("error detected");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(">>>>>>query start");
            SqlCommand myCommand = new SqlCommand("select * from agents;", myConnection);

            //myCommand.ExecuteNonQuery();

            Console.WriteLine(">>>>>>reader start");
            try
            {
                SqlDataReader myReader = myCommand.ExecuteReader();
                //DataTable schemaTable = myReader.GetSchemaTable();
                //foreach (DataRow row in schemaTable.Rows)
                //{
                //    foreach (DataColumn column in schemaTable.Columns)
                //    {
                //        //display
                //    }
                //}

                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column2"].ToString());
                    Console.WriteLine(myReader[1].ToString() + " ");
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(">>>>>>close connection");
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            //delay
            Console.WriteLine(">>>>>>END");
            Console.ReadKey();
        }
    }
}
