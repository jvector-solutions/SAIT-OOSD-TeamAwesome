using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExperts
{
    [DataObject(true)]
    public static class ProductSupplierDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<ProductSupplier> GetProductSupplierByPackageID(int id)
        {
            List<ProductSupplier> productsSuppliers = new List<ProductSupplier>();

            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "select Products_Suppliers.ProductSupplierId, Products.ProdName, Suppliers.SupName " +
                "from Packages, Packages_Products_Suppliers, Products_Suppliers, " +
                "Products, Suppliers " +
                "where Packages.PackageId='" + id + "' and Packages.PackageId=Packages_Products_Suppliers.PackageId and " +
                "Packages_Products_Suppliers.ProductSupplierId=Products_Suppliers.ProductSupplierId and " +
                "Products_Suppliers.ProductId=Products.ProductId and " +
                "Products_Suppliers.SupplierId=Suppliers.SupplierId";

            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while(reader.Read())
                {
                    ProductSupplier productSupplier = new ProductSupplier();

                    productSupplier.ProductSupplierId = (int)reader["ProductSupplierId"];
                    productSupplier.ProdName = (string)reader["ProdName"];
                    productSupplier.SupName = (string)reader["SupName"];

                    productsSuppliers.Add(productSupplier);
                    
                }
                return productsSuppliers;
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
