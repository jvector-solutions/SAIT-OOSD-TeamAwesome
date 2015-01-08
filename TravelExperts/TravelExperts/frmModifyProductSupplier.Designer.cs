namespace TravelExperts
{
    partial class frmModifyProductSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tabModifyProductSupplier = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.tabModifyProductSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 38);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 38);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 54;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(374, 191);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 38);
            this.btnDone.TabIndex = 55;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // tabModifyProductSupplier
            // 
            this.tabModifyProductSupplier.Controls.Add(this.tabProduct);
            this.tabModifyProductSupplier.Controls.Add(this.tabSupplier);
            this.tabModifyProductSupplier.Location = new System.Drawing.Point(12, 13);
            this.tabModifyProductSupplier.Name = "tabModifyProductSupplier";
            this.tabModifyProductSupplier.SelectedIndex = 0;
            this.tabModifyProductSupplier.Size = new System.Drawing.Size(451, 172);
            this.tabModifyProductSupplier.TabIndex = 56;
            // 
            // tabProduct
            // 
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(443, 143);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // tabSupplier
            // 
            this.tabSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplier.Size = new System.Drawing.Size(443, 143);
            this.tabSupplier.TabIndex = 1;
            this.tabSupplier.Text = "Supplier";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // frmModifyProductSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 241);
            this.Controls.Add(this.tabModifyProductSupplier);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmModifyProductSupplier";
            this.tabModifyProductSupplier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TabControl tabModifyProductSupplier;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabSupplier;
    }
}