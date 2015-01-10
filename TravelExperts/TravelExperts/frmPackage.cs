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

            //add to datagridview if no duplicate
            if(ProductSupplierIsNotIncluded(prodName,supName)){
                string[] record = PackageDB.GetProductSupplier(prodID, supID);
            
                //add row to datagridview
                dgvProductSuppliers.Rows.Add(record[0],record[1],record[2]);
            }
        }
        private void cbxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSupplierCombobox();
        }
        private bool ProductSupplierIsNotIncluded(string pName,string sName)
        {
            foreach (DataGridViewRow row in dgvProductSuppliers.Rows)
            {
                if ((row.Cells[1].Value.ToString().Equals(pName)) &&
                    (row.Cells[2].Value.ToString().Equals(sName)))
                {
                    return false;
                }
            }
            return true;
        }
        //remove product&supplier on datagridview
        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvProductSuppliers.SelectedRows)
            {
                dgvProductSuppliers.Rows.RemoveAt(item.Index);
            }
            dgvProductSuppliers.ClearSelection();
        }
        private void btbSubmit_Click(object sender, EventArgs e)
        {
            //create package
            if (package == null)
            {
                string msg="";
                //validate data
                if(Validator.notEmpty(txtName.Text, out msg) &&
                    Validator.notEmpty(txtDescription.Text, out msg) &&
                    (DateTime.Compare(dtpEnd.Value, DateTime.Now) < 0) &&
                    Validator.InputIsDecimal(txtPrice.Text, out msg) &&
                    Validator.inputIsPositive(txtPrice.Text, out msg) &&
                    Validator.InputIsDecimal(txtCommission.Text, out msg) &&
                    Validator.inputRangeIsValid
                        (Convert.ToDecimal(txtCommission.Text), 0, Convert.ToDecimal(txtPrice.Text),out msg))
                {
                    //create package object
                    Package p = new Package();
                    p.Name = txtName.Text;
                    p.Description = txtDescription.Text;
                    p.Start_Date = dtpStart.Value;
                    p.End_Date = dtpEnd.Value;
                    p.Base_Price = Convert.ToDecimal(txtPrice.Text);
                    p.Agency_Commission = Convert.ToDecimal(txtCommission.Text);

                    //insert package to DB
                    if (PackageDB.AddPackage(p)) //package was created
                    {
                        //get list of added products and suppliers
                        List<int> list = new List<int>();
                        foreach (DataGridViewRow item in dgvProductSuppliers.SelectedRows)
                        {
                            int id = Convert.ToInt32(item.Cells[0].Value);
                            list.Add(id);
                        }
                        //insert products suppliers
                        foreach(int l in list){
                            PackageDB.AddPackageProductSupplier(l);
                        }
                        MessageBox.Show("The Package was Added.",
                            "Package was Added");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured. Try Again",
                            "Package was NOT Added");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input "+msg+"this");
                }

            }
            //update package
            else
            {

            }
        }
    }
}
