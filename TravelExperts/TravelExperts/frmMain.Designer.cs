﻿namespace TravelExperts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpListOf = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPage)).BeginInit();
            this.grpListOf.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "To display information for logged agent after\r\nhe or she logged into the system. " +
    "\r\n(To be implemented)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
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
            this.groupBox2.Location = new System.Drawing.Point(540, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 165);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agent";
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(466, 623);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(139, 38);
            this.btnAgent.TabIndex = 47;
            this.btnAgent.Text = "&Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnProductSuppliers
            // 
            this.btnProductSuppliers.Location = new System.Drawing.Point(611, 623);
            this.btnProductSuppliers.Name = "btnProductSuppliers";
            this.btnProductSuppliers.Size = new System.Drawing.Size(250, 38);
            this.btnProductSuppliers.TabIndex = 48;
            this.btnProductSuppliers.Text = "Product and &Suppliers";
            this.btnProductSuppliers.UseVisualStyleBackColor = true;
            this.btnProductSuppliers.Click += new System.EventHandler(this.btnProductSuppliers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(867, 623);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 38);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(316, 623);
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
            this.dgvMainPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMainPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMainPage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMainPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainPage.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMainPage.Location = new System.Drawing.Point(21, 35);
            this.dgvMainPage.Name = "dgvMainPage";
            this.dgvMainPage.ReadOnly = true;
            this.dgvMainPage.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainPage.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMainPage.RowTemplate.Height = 24;
            this.dgvMainPage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainPage.Size = new System.Drawing.Size(932, 255);
            this.dgvMainPage.TabIndex = 51;
            this.dgvMainPage.Click += new System.EventHandler(this.dgvMainPage_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(905, 554);
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
            this.btnEdit.Location = new System.Drawing.Point(796, 554);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 30);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpListOf
            // 
            this.grpListOf.Controls.Add(this.dgvMainPage);
            this.grpListOf.Location = new System.Drawing.Point(31, 222);
            this.grpListOf.Name = "grpListOf";
            this.grpListOf.Size = new System.Drawing.Size(975, 310);
            this.grpListOf.TabIndex = 54;
            this.grpListOf.TabStop = false;
            this.grpListOf.Text = "List Of Packages";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1039, 692);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductSuppliers);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpListOf);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
           // this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPage)).EndInit();
            this.grpListOf.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpListOf;
    }
}

