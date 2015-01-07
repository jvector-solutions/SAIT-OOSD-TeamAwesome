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
            this.btbSubmit = new System.Windows.Forms.Button();
            this.lblAgentInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbPackage = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbSubmit
            // 
            this.btbSubmit.Location = new System.Drawing.Point(512, 458);
            this.btbSubmit.Name = "btbSubmit";
            this.btbSubmit.Size = new System.Drawing.Size(139, 38);
            this.btbSubmit.TabIndex = 0;
            this.btbSubmit.Text = "Submit";
            this.btbSubmit.UseVisualStyleBackColor = true;
            // 
            // lblAgentInfo
            // 
            this.lblAgentInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAgentInfo.Location = new System.Drawing.Point(753, 43);
            this.lblAgentInfo.Name = "lblAgentInfo";
            this.lblAgentInfo.Size = new System.Drawing.Size(287, 75);
            this.lblAgentInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agent";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(659, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 38);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // rdbPackage
            // 
            this.rdbPackage.AutoSize = true;
            this.rdbPackage.Location = new System.Drawing.Point(69, 108);
            this.rdbPackage.Name = "rdbPackage";
            this.rdbPackage.Size = new System.Drawing.Size(84, 21);
            this.rdbPackage.TabIndex = 41;
            this.rdbPackage.TabStop = true;
            this.rdbPackage.Text = "Package";
            this.rdbPackage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 562);
            this.Controls.Add(this.rdbPackage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgentInfo);
            this.Controls.Add(this.btbSubmit);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbSubmit;
        private System.Windows.Forms.Label lblAgentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbPackage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}

