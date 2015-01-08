/*
 * Created By: Leisy
 * Edited By: MB
 * January 8, 2015
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExperts
{
    public static class PackageDB
    {
        //find packages that has the findMe string
        public static List<Package> GetPackages(string findMe) {

            List<Package> listOfPackages = new List<Package>();

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //create sql command
            string selectStatement = "SELECT * FROM Packages "+
                "WHERE PackageId like '%" + findMe + "%' OR "+
                "PkgName like '%" + findMe + "%' OR "+
                "PkgDesc like '%" + findMe + "%' OR ";
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

            //create reader
            try
            {
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    //create a package
                    Package newPackage = new Package();
                    //add package details
                    newPackage.Id = myReader["ProductCode"].ToString();
                    
                    //add book to list
                    books.Add(newBook);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Execute Reader Error: " + ex.Message);
            }
        }
    }
}
