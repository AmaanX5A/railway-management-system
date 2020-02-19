namespace WindowsFormsApplication1
{
    partial class frmGMLogin
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
            this.lblTitleGMLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.statusStripGMLoginPanel = new System.Windows.Forms.StatusStrip();
            this.pnlMainPanel.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleGMLogin
            // 
            this.lblTitleGMLogin.AutoSize = true;
            this.lblTitleGMLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGMLogin.Location = new System.Drawing.Point(157, 15);
            this.lblTitleGMLogin.Name = "lblTitleGMLogin";
            this.lblTitleGMLogin.Size = new System.Drawing.Size(265, 32);
            this.lblTitleGMLogin.TabIndex = 5;
            this.lblTitleGMLogin.Text = "General Manager Login";
            this.lblTitleGMLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(84, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 32);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(84, 184);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 32);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(227, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 33);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPassword.Location = new System.Drawing.Point(227, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(272, 33);
            this.txtPassword.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnLogin.Location = new System.Drawing.Point(184, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 47);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainPanel.Controls.Add(this.lblTitleGMLogin);
            this.pnlMainPanel.Controls.Add(this.lblPassword);
            this.pnlMainPanel.Controls.Add(this.txtEmail);
            this.pnlMainPanel.Controls.Add(this.txtPassword);
            this.pnlMainPanel.Controls.Add(this.btnLogin);
            this.pnlMainPanel.Controls.Add(this.lblEmail);
            this.pnlMainPanel.Location = new System.Drawing.Point(192, 132);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(576, 412);
            this.pnlMainPanel.TabIndex = 10;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(3, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1005, 125);
            this.pnlHeader.TabIndex = 11;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(209, 46);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // statusStripGMLoginPanel
            // 
            this.statusStripGMLoginPanel.Location = new System.Drawing.Point(0, 675);
            this.statusStripGMLoginPanel.Name = "statusStripGMLoginPanel";
            this.statusStripGMLoginPanel.Size = new System.Drawing.Size(1008, 22);
            this.statusStripGMLoginPanel.TabIndex = 12;
            this.statusStripGMLoginPanel.Text = "status Strip GM Login Panel";
            // 
            // frmGMLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlMainPanel);
            this.Controls.Add(this.statusStripGMLoginPanel);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmGMLogin";
            this.Text = "gmloginpage";
            this.Load += new System.EventHandler(this.gmloginpage_Load);
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlMainPanel.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleGMLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.StatusStrip statusStripGMLoginPanel;
        private System.Windows.Forms.Panel pnlMainPanel;

    }
}