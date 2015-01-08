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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbAgents = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductSupplier = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.dgvMainPage = new System.Windows.Forms.DataGridView();
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
            this.rdbPackage.Click += new System.EventHandler(this.rdbPackage_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(19, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(429, 22);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
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
            this.rdbProduct.Click += new System.EventHandler(this.rdbProduct_Click);
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
            this.rdbSupplier.Click += new System.EventHandler(this.rdbSupplier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 139);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
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
            this.rdbAgents.Click += new System.EventHandler(this.rdbAgents_Click);
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
            // btnProductSupplier
            // 
            this.btnProductSupplier.Location = new System.Drawing.Point(452, 551);
            this.btnProductSupplier.Name = "btnProductSupplier";
            this.btnProductSupplier.Size = new System.Drawing.Size(139, 38);
            this.btnProductSupplier.TabIndex = 46;
            this.btnProductSupplier.Text = "&Product / &Supplier";
            this.btnProductSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(597, 551);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(139, 38);
            this.btnAgent.TabIndex = 47;
            this.btnAgent.Text = "&Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(887, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 38);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(307, 551);
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
            this.dgvMainPage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMainPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainPage.Location = new System.Drawing.Point(27, 252);
            this.dgvMainPage.Name = "dgvMainPage";
            this.dgvMainPage.ReadOnly = true;
            this.dgvMainPage.RowTemplate.Height = 24;
            this.dgvMainPage.Size = new System.Drawing.Size(999, 271);
            this.dgvMainPage.TabIndex = 51;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1052, 601);
            this.Controls.Add(this.dgvMainPage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.btnProductSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnProductSupplier;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.DataGridView dgvMainPage;
        private System.Windows.Forms.RadioButton rdbAgents;
    }
}

