namespace TravelExperts
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPackage = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.rdbSupplier = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbIncludeExpiredPackages = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbAgents = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnProductSuppliers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.dgvMainPage = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agent Info Goes here. Thanks Leisy";
            // 
            // rdbPackage
            // 
            this.rdbPackage.AutoSize = true;
            this.rdbPackage.Checked = true;
            this.rdbPackage.Location = new System.Drawing.Point(12, 11);
            this.rdbPackage.Name = "rdbPackage";
            this.rdbPackage.Size = new System.Drawing.Size(84, 21);
            this.rdbPackage.TabIndex = 41;
            this.rdbPackage.TabStop = true;
            this.rdbPackage.Text = "Package";
            this.rdbPackage.UseVisualStyleBackColor = true;
            this.rdbPackage.CheckedChanged += new System.EventHandler(this.rdbPackage_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(429, 22);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(123, 11);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(78, 21);
            this.rdbProduct.TabIndex = 42;
            this.rdbProduct.Text = "Product";
            this.rdbProduct.UseVisualStyleBackColor = true;
            this.rdbProduct.CheckedChanged += new System.EventHandler(this.rdbProduct_CheckedChanged);
            // 
            // rdbSupplier
            // 
            this.rdbSupplier.AutoSize = true;
            this.rdbSupplier.Location = new System.Drawing.Point(231, 11);
            this.rdbSupplier.Name = "rdbSupplier";
            this.rdbSupplier.Size = new System.Drawing.Size(81, 21);
            this.rdbSupplier.TabIndex = 43;
            this.rdbSupplier.Text = "Supplier";
            this.rdbSupplier.UseVisualStyleBackColor = true;
            this.rdbSupplier.CheckedChanged += new System.EventHandler(this.rdbSupplier_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbIncludeExpiredPackages);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 165);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chbIncludeExpiredPackages
            // 
            this.chbIncludeExpiredPackages.AutoSize = true;
            this.chbIncludeExpiredPackages.Location = new System.Drawing.Point(19, 129);
            this.chbIncludeExpiredPackages.Name = "chbIncludeExpiredPackages";
            this.chbIncludeExpiredPackages.Size = new System.Drawing.Size(192, 21);
            this.chbIncludeExpiredPackages.TabIndex = 45;
            this.chbIncludeExpiredPackages.Text = "Include Expired Packages";
            this.chbIncludeExpiredPackages.UseVisualStyleBackColor = true;
            this.chbIncludeExpiredPackages.CheckedChanged += new System.EventHandler(this.chbIncludeExpiredPackages_CheckedChanged);
            this.chbIncludeExpiredPackages.Click += new System.EventHandler(this.chbIncludeExpiredPackages_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbAgents);
            this.panel1.Controls.Add(this.rdbSupplier);
            this.panel1.Controls.Add(this.rdbPackage);
            this.panel1.Controls.Add(this.rdbProduct);
            this.panel1.Location = new System.Drawing.Point(19, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 45);
            this.panel1.TabIndex = 44;
            // 
            // rdbAgents
            // 
            this.rdbAgents.AutoSize = true;
            this.rdbAgents.Location = new System.Drawing.Point(332, 11);
            this.rdbAgents.Name = "rdbAgents";
            this.rdbAgents.Size = new System.Drawing.Size(73, 21);
            this.rdbAgents.TabIndex = 44;
            this.rdbAgents.Text = "Agents";
            this.rdbAgents.UseVisualStyleBackColor = true;
            this.rdbAgents.CheckedChanged += new System.EventHandler(this.rdbAgents_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(536, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 189);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agent";
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(486, 676);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(139, 38);
            this.btnAgent.TabIndex = 47;
            this.btnAgent.Text = "&Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Location = new System.Drawing.Point(631, 676);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(250, 38);
            this.btnProductSuppliers.TabIndex = 48;
            this.btnProductSuppliers.Text = "Product and &Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(887, 676);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 38);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(336, 676);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(139, 38);
            this.btnAddPackage.TabIndex = 50;
            this.btnAddPackage.Text = "A&dd Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // dgvMainPage
            // 
            this.dgvMainPage.AllowUserToAddRows = false;
            this.dgvMainPage.AllowUserToDeleteRows = false;
            this.dgvMainPage.AllowUserToResizeColumns = false;
            this.dgvMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainPage.Location = new System.Drawing.Point(27, 252);
            this.dgvMainPage.Name = "dgvMainPage";
            this.dgvMainPage.ReadOnly = true;
            this.dgvMainPage.RowHeadersVisible = false;
            this.dgvMainPage.RowTemplate.Height = 24;
            this.dgvMainPage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainPage.Size = new System.Drawing.Size(999, 271);
            this.dgvMainPage.TabIndex = 51;
            this.dgvMainPage.Click += new System.EventHandler(this.dgvMainPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(923, 529);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 30);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(814, 529);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 30);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1052, 726);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMainPage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbPackage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbProduct;
        private System.Windows.Forms.RadioButton rdbSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnProductSuppliers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.DataGridView dgvMainPage;
        private System.Windows.Forms.RadioButton rdbAgents;
        private System.Windows.Forms.CheckBox chbIncludeExpiredPackages;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}

