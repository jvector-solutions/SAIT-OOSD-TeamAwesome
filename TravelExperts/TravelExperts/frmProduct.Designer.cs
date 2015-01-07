namespace TravelExperts
{
    partial class frmProduct
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btbSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "Air",
            "Attractions",
            "Car Rental",
            "Cruise",
            "Hotel",
            "Motor Coach",
            "Railroad",
            "Tours",
            "Travel Insurance",
            "Yatch/Boat Charters"});
            this.cmbSupplier.Location = new System.Drawing.Point(329, 294);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 24);
            this.cmbSupplier.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "supplier";
            // 
            // lblSupplier
            // 
            this.lblSupplier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSupplier.Location = new System.Drawing.Point(169, 294);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(79, 22);
            this.lblSupplier.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(135, 294);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Supplier Information";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Air",
            "Attractions",
            "Car Rental",
            "Cruise",
            "Hotel",
            "Motor Coach",
            "Railroad",
            "Tours",
            "Travel Insurance",
            "Yatch/Boat Charters"});
            this.cmbProduct.Location = new System.Drawing.Point(326, 228);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(264, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "product";
            // 
            // lblProductId
            // 
            this.lblProductId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductId.Location = new System.Drawing.Point(166, 228);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(79, 22);
            this.lblProductId.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Product Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(298, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 38);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btbSubmit
            // 
            this.btbSubmit.Location = new System.Drawing.Point(151, 402);
            this.btbSubmit.Name = "btbSubmit";
            this.btbSubmit.Size = new System.Drawing.Size(139, 38);
            this.btbSubmit.TabIndex = 44;
            this.btbSubmit.Text = "Submit";
            this.btbSubmit.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btbSubmit);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btbSubmit;
    }
}