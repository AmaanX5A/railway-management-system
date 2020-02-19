namespace WindowsFormsApplication1
{
    partial class frmRemoveCompany
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainBody = new System.Windows.Forms.Panel();
            this.lblCompanyDetails = new System.Windows.Forms.Label();
            this.btnConfirmDeletion = new System.Windows.Forms.Button();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.lblRemoveCompany = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMainBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management System";
            // 
            // pnlMainBody
            // 
            this.pnlMainBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainBody.Controls.Add(this.lblCompanyDetails);
            this.pnlMainBody.Controls.Add(this.btnConfirmDeletion);
            this.pnlMainBody.Controls.Add(this.lblExplanation);
            this.pnlMainBody.Controls.Add(this.dataGrid);
            this.pnlMainBody.Controls.Add(this.btnSearchSchedule);
            this.pnlMainBody.Controls.Add(this.txtCompanyID);
            this.pnlMainBody.Controls.Add(this.lblCompanyID);
            this.pnlMainBody.Controls.Add(this.lblRemoveCompany);
            this.pnlMainBody.Controls.Add(this.btnBack);
            this.pnlMainBody.Controls.Add(this.btnViewProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Location = new System.Drawing.Point(2, 106);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1005, 589);
            this.pnlMainBody.TabIndex = 11;
            // 
            // lblCompanyDetails
            // 
            this.lblCompanyDetails.AutoSize = true;
            this.lblCompanyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyDetails.Location = new System.Drawing.Point(443, 271);
            this.lblCompanyDetails.Name = "lblCompanyDetails";
            this.lblCompanyDetails.Size = new System.Drawing.Size(175, 25);
            this.lblCompanyDetails.TabIndex = 12;
            this.lblCompanyDetails.Text = "Company Details";
            // 
            // btnConfirmDeletion
            // 
            this.btnConfirmDeletion.Location = new System.Drawing.Point(291, 148);
            this.btnConfirmDeletion.Name = "btnConfirmDeletion";
            this.btnConfirmDeletion.Size = new System.Drawing.Size(136, 23);
            this.btnConfirmDeletion.TabIndex = 11;
            this.btnConfirmDeletion.Text = "Confirm Deletion";
            this.btnConfirmDeletion.UseVisualStyleBackColor = true;
            this.btnConfirmDeletion.Click += new System.EventHandler(this.btnConfirmDeletion_Click);
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(41, 52);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(312, 20);
            this.lblExplanation.TabIndex = 10;
            this.lblExplanation.Text = "Please enter Company ID to remove it";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 313);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1002, 273);
            this.dataGrid.TabIndex = 9;
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSchedule.Location = new System.Drawing.Point(118, 148);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(135, 23);
            this.btnSearchSchedule.TabIndex = 8;
            this.btnSearchSchedule.Text = "Search Company";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCompanyID.Location = new System.Drawing.Point(225, 101);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(135, 20);
            this.txtCompanyID.TabIndex = 6;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(99, 101);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(112, 20);
            this.lblCompanyID.TabIndex = 4;
            this.lblCompanyID.Text = "Company ID:";
            // 
            // lblRemoveCompany
            // 
            this.lblRemoveCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemoveCompany.AutoSize = true;
            this.lblRemoveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveCompany.Location = new System.Drawing.Point(401, 13);
            this.lblRemoveCompany.Name = "lblRemoveCompany";
            this.lblRemoveCompany.Size = new System.Drawing.Size(252, 31);
            this.lblRemoveCompany.TabIndex = 3;
            this.lblRemoveCompany.Text = "Remove Company";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(817, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewProfile.AutoSize = true;
            this.btnViewProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewProfile.Location = new System.Drawing.Point(730, 23);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(72, 23);
            this.btnViewProfile.TabIndex = 1;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Location = new System.Drawing.Point(877, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(2, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1005, 103);
            this.pnlHeader.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 538);
            this.panel2.TabIndex = 1;
            // 
            // frmRemoveCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlMainBody);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmRemoveCompany";
            this.Text = "Remove Company";
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.Label lblCompanyDetails;
        private System.Windows.Forms.Button btnConfirmDeletion;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnSearchSchedule;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.Label lblRemoveCompany;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
    }
}