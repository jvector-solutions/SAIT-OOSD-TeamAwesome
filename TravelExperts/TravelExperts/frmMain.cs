using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection start
            SqlConnection myConnection = new SqlConnection("server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=TravelExperts; " +
                                       "connection timeout=1");

            //open connection
            try
            {
                myConnection.Open();
            }
            catch (Exception eror)
            {
                Console.WriteLine("error detected");
                Console.WriteLine(eror.ToString());
            }

            //query
            SqlCommand myCommand = new SqlCommand("select * from packages;", myConnection);

            //reader start
            try
            {
                SqlDataReader myReader = myCommand.ExecuteReader();
                string pkgName="";
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column2"].ToString());
                    pkgName += myReader[1].ToString()+"\n";

                }
                //display
                MessageBox.Show(pkgName, "Name of Packages");
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }

            //close connection
            try
            {
                myConnection.Close();
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            //connection start
            SqlConnection myConnection = new SqlConnection("server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=TravelExperts; " +
                                       "connection timeout=1");

            //open connection
            try
            {
                myConnection.Open();
            }
            catch (Exception eror)
            {
                Console.WriteLine("error detected");
                Console.WriteLine(eror.ToString());
            }

            //query
            SqlCommand myCommand = new SqlCommand("select * from agents;", myConnection);

            //reader start
            try
            {
                SqlDataReader myReader = myCommand.ExecuteReader();
                string pkgName="";
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column2"].ToString());
                    pkgName += myReader[1].ToString()+"\n";

                }
                //display
                MessageBox.Show(pkgName, "Name of Agents");
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }

            //close connection
            try
            {
                myConnection.Close();
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //connection start
            SqlConnection myConnection = new SqlConnection("server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=TravelExperts; " +
                                       "connection timeout=1");

            //open connection
            try
            {
                myConnection.Open();
            }
            catch (Exception eror)
            {
                Console.WriteLine("error detected");
                Console.WriteLine(eror.ToString());
            }

            //query
            SqlCommand myCommand = new SqlCommand("select * from products;", myConnection);

            //reader start
            try
            {
                SqlDataReader myReader = myCommand.ExecuteReader();
                string pkgName="";
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column2"].ToString());
                    pkgName += myReader[1].ToString()+"\n";

                }
                //display
                MessageBox.Show(pkgName, "Name of Products");
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }

            //close connection
            try
            {
                myConnection.Close();
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            //connection start
            SqlConnection myConnection = new SqlConnection("server=.\\sqlexpress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=TravelExperts; " +
                                       "connection timeout=1");

            //open connection
            try
            {
                myConnection.Open();
            }
            catch (Exception eror)
            {
                Console.WriteLine("error detected");
                Console.WriteLine(eror.ToString());
            }

            //query
            SqlCommand myCommand = new SqlCommand("select * from suppliers;", myConnection);

            //reader start
            try
            {
                SqlDataReader myReader = myCommand.ExecuteReader();
                string pkgName="";
                while (myReader.Read())
                {
                    //Console.WriteLine(myReader["Column2"].ToString());
                    pkgName += myReader[1].ToString()+"\n";

                }
                //display
                MessageBox.Show(pkgName, "Name of Suppliers");
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }

            //close connection
            try
            {
                myConnection.Close();
            }
            catch (Exception eror)
            {
                Console.WriteLine(eror.ToString());
            }
        }
    }
}
