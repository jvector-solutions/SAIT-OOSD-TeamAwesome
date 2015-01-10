/*
 * Created By: Leisy
 * Edited By: MB
 * January 8, 2015
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public static class PackageDB
    {
        //find packages that has the findMe string
        public static List<Package> GetPackages(string findMe, bool showAll) {

            List<Package> listOfPackages = new List<Package>();

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //create sql command
            string selectStatement = "SELECT * FROM Packages "+
                "WHERE PkgName like '%" + findMe.Trim() + "%' OR " +
                "PkgDesc like '%" + findMe.Trim() + "%'";
               
            //search for something
            if (findMe.Trim().Length != 0)
            {
                string msg = "";
                if (Validator.inputIsInteger(findMe, out msg))
                {
                    selectStatement += " OR PackageId ='" + findMe + "'";
                }
            }
            if (!showAll)
            {
                selectStatement = "SELECT * FROM ("+selectStatement+")as x "+
                    "WHERE PkgEndDate > GETDATE()";
            }
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
                    newPackage.ID = (int)reader["PackageId"];
                    newPackage.Name = reader["PkgName"].ToString();
                    newPackage.Start_Date = Convert.ToDateTime(reader["PkgStartDate"]);
                    newPackage.End_Date = Convert.ToDateTime(reader["PkgEndDate"]);
                    newPackage.Description = reader["PkgDesc"].ToString();
                    newPackage.Base_Price = (decimal)reader["PkgBasePrice"];
                    newPackage.Agency_Commission = (decimal)reader["PkgAgencyCommission"];
                    
                    //add book to list
                    listOfPackages.Add(newPackage);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //close connection
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listOfPackages;
        }
        //get products
        public static List<Product> GetProducts(string findMe)
        {

            List<Product> listOfProducts = new List<Product>();

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //create sql command
            string selectStatement = "SELECT * FROM Products " +
                "WHERE ProdName like '%" + findMe.Trim() + "%'";

            //search for something
            if (findMe.Trim().Length != 0)
            {
                selectStatement += " OR ProductID='"+findMe+"'";

            }
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
                    //create a product
                    Product newProduct = new Product();
                    //add product details
                    newProduct.prodID = (int)reader["ProductID"];
                    newProduct.prodName = reader["ProdName"].ToString();
                    

                    //add product to list
                    listOfProducts.Add(newProduct);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //close connection
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listOfProducts;
        }
        //get suppliers of a product
        public static List<Supplier> GetSuppliers(string findMe)
        {

            List<Supplier> listOfSuppliers = new List<Supplier>();

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //search for something
            string selectStatement;
            if (findMe.Trim().Length != 0)
            {
                selectStatement = "SELECT * FROM Suppliers " +
                    "WHERE SupplierId in " +
                        "(SELECT SupplierId FROM Products_Suppliers "+
                        "WHERE ProductId=" + findMe + ")";
            }
            else
            {
                return null;
            }
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
                    //create a supplier
                    Supplier newSupplier = new Supplier();
                    //add supplier details
                    newSupplier.SupplierId = (int)reader["SupplierId"];
                    newSupplier.SupName = reader["SupName"].ToString();


                    //add supplier to list
                    listOfSuppliers.Add(newSupplier);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //close connection
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listOfSuppliers;
        }
        public static int GetProductSupplierID(int prodID, int supID)
        {
            int ID=0;

            //create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            //search for something
            string selectStatement = "SELECT * FROM Products_Suppliers "+
                "WHERE ProductId="+prodID.ToString()+" AND "+
                    "SupplierId="+supID.ToString();
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
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    //getID
                    ID =(int) reader["ProductSupplierId"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //close connection
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ID;
        }
    }
}
