﻿namespace WindowsFormsApplication1
{
    partial class frmEmployeeLogs
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.byEmployeeID = new System.Windows.Forms.Button();
            this.byCompanyName = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnByDate = new System.Windows.Forms.Button();
            this.btnAllEmployeeDetails = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.Controls.Add(this.byEmployeeID);
            this.pnlBody.Controls.Add(this.byCompanyName);
            this.pnlBody.Controls.Add(this.crystalReportViewer1);
            this.pnlBody.Controls.Add(this.btnRange);
            this.pnlBody.Controls.Add(this.btnByDate);
            this.pnlBody.Controls.Add(this.btnAllEmployeeDetails);
            this.pnlBody.Controls.Add(this.btnGoBack);
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.btnProfile);
            this.pnlBody.Controls.Add(this.btnLogout);
            this.pnlBody.Location = new System.Drawing.Point(0, 109);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1008, 580);
            this.pnlBody.TabIndex = 7;
            // 
            // byEmployeeID
            // 
            this.byEmployeeID.Location = new System.Drawing.Point(566, 66);
            this.byEmployeeID.Name = "byEmployeeID";
            this.byEmployeeID.Size = new System.Drawing.Size(114, 23);
            this.byEmployeeID.TabIndex = 11;
            this.byEmployeeID.Text = "By Employee ID";
            this.byEmployeeID.UseVisualStyleBackColor = true;
            this.byEmployeeID.Click += new System.EventHandler(this.byEmployeeID_Click);
            // 
            // byCompanyName
            // 
            this.byCompanyName.Location = new System.Drawing.Point(438, 66);
            this.byCompanyName.Name = "byCompanyName";
            this.byCompanyName.Size = new System.Drawing.Size(111, 23);
            this.byCompanyName.TabIndex = 10;
            this.byCompanyName.Text = "by Designation";
            this.byCompanyName.UseVisualStyleBackColor = true;
            this.byCompanyName.Click += new System.EventHandler(this.byCompanyName_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 115);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1001, 462);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(297, 66);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(114, 23);
            this.btnRange.TabIndex = 7;
            this.btnRange.Text = "By Salary";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnByDate
            // 
            this.btnByDate.Location = new System.Drawing.Point(179, 66);
            this.btnByDate.Name = "btnByDate";
            this.btnByDate.Size = new System.Drawing.Size(88, 23);
            this.btnByDate.TabIndex = 6;
            this.btnByDate.Text = "By Hire Date";
            this.btnByDate.UseVisualStyleBackColor = true;
            this.btnByDate.Click += new System.EventHandler(this.btnByDate_Click);
            // 
            // btnAllEmployeeDetails
            // 
            this.btnAllEmployeeDetails.Location = new System.Drawing.Point(58, 66);
            this.btnAllEmployeeDetails.Name = "btnAllEmployeeDetails";
            this.btnAllEmployeeDetails.Size = new System.Drawing.Size(89, 23);
            this.btnAllEmployeeDetails.TabIndex = 5;
            this.btnAllEmployeeDetails.Text = "All Employees";
            this.btnAllEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnAllEmployeeDetails.Click += new System.EventHandler(this.btnAllEmployeeDetails_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(743, 20);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(362, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Employee Logs";
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.Location = new System.Drawing.Point(824, 20);
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
            this.btnLogout.Location = new System.Drawing.Point(905, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out!";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(0, 7);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 96);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(213, 33);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // frmEmployeeLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmEmployeeLogs";
            this.Text = "frmEmployeeLogs";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button byCompanyName;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnByDate;
        private System.Windows.Forms.Button btnAllEmployeeDetails;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Button byEmployeeID;
    }
}