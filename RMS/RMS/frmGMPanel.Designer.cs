namespace WindowsFormsApplication1
{
    partial class frmGMPanel
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnEmployeeLogs = new System.Windows.Forms.Button();
            this.btnPassnegerLogs = new System.Windows.Forms.Button();
            this.btnTicketLogs = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusStripGMPanel = new System.Windows.Forms.StatusStrip();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 96);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(216, 26);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.pnlCenter);
            this.pnlBody.Controls.Add(this.btnProfile);
            this.pnlBody.Controls.Add(this.btnLogout);
            this.pnlBody.Location = new System.Drawing.Point(0, 104);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1008, 568);
            this.pnlBody.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(362, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "General Manager Panel";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.Controls.Add(this.btnOrderDetails);
            this.pnlCenter.Controls.Add(this.btnEmployeeLogs);
            this.pnlCenter.Controls.Add(this.btnPassnegerLogs);
            this.pnlCenter.Controls.Add(this.btnTicketLogs);
            this.pnlCenter.Location = new System.Drawing.Point(12, 43);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(984, 510);
            this.pnlCenter.TabIndex = 2;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.Location = new System.Drawing.Point(74, 22);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(190, 45);
            this.btnOrderDetails.TabIndex = 31;
            this.btnOrderDetails.Text = "Orders Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnEmployeeLogs
            // 
            this.btnEmployeeLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLogs.Location = new System.Drawing.Point(541, 22);
            this.btnEmployeeLogs.Name = "btnEmployeeLogs";
            this.btnEmployeeLogs.Size = new System.Drawing.Size(190, 45);
            this.btnEmployeeLogs.TabIndex = 29;
            this.btnEmployeeLogs.Text = "Employee Logs";
            this.btnEmployeeLogs.UseVisualStyleBackColor = true;
            this.btnEmployeeLogs.Click += new System.EventHandler(this.btnEmployeeLogs_Click);
            // 
            // btnPassnegerLogs
            // 
            this.btnPassnegerLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassnegerLogs.Location = new System.Drawing.Point(541, 105);
            this.btnPassnegerLogs.Name = "btnPassnegerLogs";
            this.btnPassnegerLogs.Size = new System.Drawing.Size(190, 45);
            this.btnPassnegerLogs.TabIndex = 28;
            this.btnPassnegerLogs.Text = "Passenger Logs";
            this.btnPassnegerLogs.UseVisualStyleBackColor = true;
            this.btnPassnegerLogs.Click += new System.EventHandler(this.btnPassnegerLogs_Click);
            // 
            // btnTicketLogs
            // 
            this.btnTicketLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketLogs.Location = new System.Drawing.Point(74, 105);
            this.btnTicketLogs.Name = "btnTicketLogs";
            this.btnTicketLogs.Size = new System.Drawing.Size(190, 45);
            this.btnTicketLogs.TabIndex = 27;
            this.btnTicketLogs.Text = "Ticket Logs";
            this.btnTicketLogs.UseVisualStyleBackColor = true;
            this.btnTicketLogs.Click += new System.EventHandler(this.btnTicketLogs_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.Location = new System.Drawing.Point(824, 14);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(905, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out!";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // statusStripGMPanel
            // 
            this.statusStripGMPanel.Location = new System.Drawing.Point(0, 675);
            this.statusStripGMPanel.Name = "statusStripGMPanel";
            this.statusStripGMPanel.Size = new System.Drawing.Size(1008, 22);
            this.statusStripGMPanel.TabIndex = 4;
            this.statusStripGMPanel.Text = "Status Strip GM Panel";
            // 
            // frmGMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.statusStripGMPanel);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmGMPanel";
            this.Text = "GM Panel";
            this.Load += new System.EventHandler(this.frmGMPanel_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.StatusStrip statusStripGMPanel;
        private System.Windows.Forms.Button btnEmployeeLogs;
        private System.Windows.Forms.Button btnPassnegerLogs;
        private System.Windows.Forms.Button btnTicketLogs;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Label lblTitle;
    }
}