using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmPackage : Form
    {
        Package package;
        public frmPackage(Package newPackage)
        {
            package = newPackage;
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            if(package != null){

            }
            FillProductComboBox();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FillProductComboBox()
        {
            List<Product> products;
            products = PackageDB.GetProducts("");

            //foreach (Product p in products)
            //{
            //    cbxProductList.Items.Add(p);
            //}
            cbxProductList.DataSource = products;
            //cbxProductList.ValueMember = "prodID";
            //cbxProductList.DisplayMember = "prodName";
        }
        private void FillSupplierCombobox()
        {
            List<Supplier> suppliers;
            int productID = ((Product)cbxProductList.SelectedItem).prodID;
            suppliers = PackageDB.GetSuppliers(productID.ToString());

            cbxSuppliers.DataSource = suppliers;
            //cbxSuppliers.ValueMember = "SupplierId";
            //cbxSuppliers.DisplayMember = "SupName";
        }
        //add product and supplier to package
        private void btnAddToPackage_Click(object sender, EventArgs e)
        {
            int prodID = ((Product)cbxProductList.SelectedItem).prodID;
            string prodName = ((Product)cbxProductList.SelectedItem).prodName;
            int supID = ((Supplier)cbxSuppliers.SelectedItem).SupplierId;
            string supName = ((Supplier)cbxSuppliers.SelectedItem).SupName;
            int ID = PackageDB.GetProductSupplierID(prodID, supID);

            //add row to datagridview
            dgvProductSuppliers.Rows.Add(ID.ToString(),prodName,supName);
        }
        
        private void cbxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSupplierCombobox();
        }
    }
}
