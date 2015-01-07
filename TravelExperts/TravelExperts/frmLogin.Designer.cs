namespace TravelExperts
{
    partial class frmLogin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btbLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.txtAgencyID = new System.Windows.Forms.TextBox();
            this.txtAgtPassword = new System.Windows.Forms.TextBox();
            this.btnForgotPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 374);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 48);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btbLogin
            // 
            this.btbLogin.Location = new System.Drawing.Point(206, 264);
            this.btbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbLogin.Name = "btbLogin";
            this.btbLogin.Size = new System.Drawing.Size(156, 48);
            this.btbLogin.TabIndex = 35;
            this.btbLogin.Text = "Login";
            this.btbLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Agency ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password";
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(220, 76);
            this.txtAgentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(219, 27);
            this.txtAgentID.TabIndex = 40;
            // 
            // txtAgencyID
            // 
            this.txtAgencyID.Location = new System.Drawing.Point(220, 132);
            this.txtAgencyID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgencyID.Name = "txtAgencyID";
            this.txtAgencyID.Size = new System.Drawing.Size(124, 27);
            this.txtAgencyID.TabIndex = 41;
            // 
            // txtAgtPassword
            // 
            this.txtAgtPassword.Location = new System.Drawing.Point(220, 186);
            this.txtAgtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgtPassword.Name = "txtAgtPassword";
            this.txtAgtPassword.Size = new System.Drawing.Size(219, 27);
            this.txtAgtPassword.TabIndex = 42;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.Location = new System.Drawing.Point(206, 319);
            this.btnForgotPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(156, 48);
            this.btnForgotPass.TabIndex = 43;
            this.btnForgotPass.Text = "Forgot Password";
            this.btnForgotPass.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 471);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.txtAgtPassword);
            this.Controls.Add(this.txtAgencyID);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btbLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.TextBox txtAgencyID;
        private System.Windows.Forms.TextBox txtAgtPassword;
        private System.Windows.Forms.Button btnForgotPass;

    }
}