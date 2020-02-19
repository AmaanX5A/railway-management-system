namespace WindowsFormsApplication1
{
    partial class frmMainPanel
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
            this.ol_btn = new System.Windows.Forms.Button();
            this.gml_btn = new System.Windows.Forms.Button();
            this.al_btn = new System.Windows.Forms.Button();
            this.title_request = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.statusStripMainPanel = new System.Windows.Forms.StatusStrip();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ol_btn
            // 
            this.ol_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ol_btn.Location = new System.Drawing.Point(52, 286);
            this.ol_btn.Name = "ol_btn";
            this.ol_btn.Size = new System.Drawing.Size(288, 74);
            this.ol_btn.TabIndex = 6;
            this.ol_btn.Text = "Operator Login";
            this.ol_btn.UseVisualStyleBackColor = true;
            this.ol_btn.Click += new System.EventHandler(this.ol_btn_Click);
            // 
            // gml_btn
            // 
            this.gml_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gml_btn.Location = new System.Drawing.Point(52, 89);
            this.gml_btn.Name = "gml_btn";
            this.gml_btn.Size = new System.Drawing.Size(288, 74);
            this.gml_btn.TabIndex = 5;
            this.gml_btn.Text = "General Manager Login";
            this.gml_btn.UseVisualStyleBackColor = true;
            this.gml_btn.Click += new System.EventHandler(this.gml_btn_Click);
            // 
            // al_btn
            // 
            this.al_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.al_btn.Location = new System.Drawing.Point(52, 186);
            this.al_btn.Name = "al_btn";
            this.al_btn.Size = new System.Drawing.Size(288, 74);
            this.al_btn.TabIndex = 4;
            this.al_btn.Text = "Admin Login";
            this.al_btn.UseVisualStyleBackColor = true;
            this.al_btn.Click += new System.EventHandler(this.al_btn_Click);
            // 
            // title_request
            // 
            this.title_request.AutoSize = true;
            this.title_request.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_request.Location = new System.Drawing.Point(20, 26);
            this.title_request.Name = "title_request";
            this.title_request.Size = new System.Drawing.Size(342, 32);
            this.title_request.TabIndex = 8;
            this.title_request.Text = "Please Select Your Designation";
            this.title_request.Click += new System.EventHandler(this.title_gml_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(52, 387);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(285, 74);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up!";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // statusStripMainPanel
            // 
            this.statusStripMainPanel.Location = new System.Drawing.Point(0, 675);
            this.statusStripMainPanel.Name = "statusStripMainPanel";
            this.statusStripMainPanel.Size = new System.Drawing.Size(1008, 22);
            this.statusStripMainPanel.TabIndex = 21;
            this.statusStripMainPanel.Text = "Status Strip Main Panel";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(0, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 114);
            this.pnlHeader.TabIndex = 22;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(166, 26);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.btnSignUp);
            this.pnlMain.Controls.Add(this.title_request);
            this.pnlMain.Controls.Add(this.ol_btn);
            this.pnlMain.Controls.Add(this.gml_btn);
            this.pnlMain.Controls.Add(this.al_btn);
            this.pnlMain.Location = new System.Drawing.Point(308, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(394, 480);
            this.pnlMain.TabIndex = 23;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.Controls.Add(this.pnlMain);
            this.pnlBody.Location = new System.Drawing.Point(0, 121);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1008, 551);
            this.pnlBody.TabIndex = 24;
            // 
            // frmMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStripMainPanel);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmMainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "titlepage";
            this.Load += new System.EventHandler(this.titlepage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ol_btn;
        private System.Windows.Forms.Button gml_btn;
        private System.Windows.Forms.Button al_btn;
        private System.Windows.Forms.Label title_request;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.StatusStrip statusStripMainPanel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBody;
    }
}