namespace WindowsFormsApplication1
{
    partial class frmAddStation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.pnlTitle = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExplantion = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblAddStation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.pnlMainBody = new System.Windows.Forms.Panel();
            this.btnAddNewStation = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSize = true;
            this.pnlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitle.Location = new System.Drawing.Point(175, 34);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(536, 42);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Text = "Railway Management System";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLongitude.Location = new System.Drawing.Point(343, 215);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(138, 20);
            this.txtLongitude.TabIndex = 14;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(210, 213);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(94, 20);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = "Longitude:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(343, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(210, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblExplantion
            // 
            this.lblExplantion.AutoSize = true;
            this.lblExplantion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplantion.Location = new System.Drawing.Point(14, 68);
            this.lblExplantion.Name = "lblExplantion";
            this.lblExplantion.Size = new System.Drawing.Size(384, 20);
            this.lblExplantion.TabIndex = 10;
            this.lblExplantion.Text = "Please Enter your Station Information to Add it";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(312, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.pnlTitle);
            this.pnlHeader.Location = new System.Drawing.Point(-5, -2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1010, 98);
            this.pnlHeader.TabIndex = 6;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLatitude.Location = new System.Drawing.Point(343, 170);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(138, 20);
            this.txtLatitude.TabIndex = 6;
            // 
            // lblAddStation
            // 
            this.lblAddStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddStation.AutoSize = true;
            this.lblAddStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStation.Location = new System.Drawing.Point(411, 10);
            this.lblAddStation.Name = "lblAddStation";
            this.lblAddStation.Size = new System.Drawing.Size(165, 31);
            this.lblAddStation.TabIndex = 3;
            this.lblAddStation.Text = "Add Station";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(872, 10);
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
            this.btnViewProfile.Location = new System.Drawing.Point(785, 10);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(72, 23);
            this.btnViewProfile.TabIndex = 1;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Location = new System.Drawing.Point(932, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(210, 170);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(80, 20);
            this.lblLatitude.TabIndex = 4;
            this.lblLatitude.Text = "Latitude:";
            // 
            // pnlMainBody
            // 
            this.pnlMainBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainBody.Controls.Add(this.btnAddNewStation);
            this.pnlMainBody.Controls.Add(this.txtLongitude);
            this.pnlMainBody.Controls.Add(this.lblLongitude);
            this.pnlMainBody.Controls.Add(this.txtName);
            this.pnlMainBody.Controls.Add(this.lblName);
            this.pnlMainBody.Controls.Add(this.lblExplantion);
            this.pnlMainBody.Controls.Add(this.btnSubmit);
            this.pnlMainBody.Controls.Add(this.txtLatitude);
            this.pnlMainBody.Controls.Add(this.lblLatitude);
            this.pnlMainBody.Controls.Add(this.lblAddStation);
            this.pnlMainBody.Controls.Add(this.btnBack);
            this.pnlMainBody.Controls.Add(this.btnViewProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Location = new System.Drawing.Point(-2, 100);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 596);
            this.pnlMainBody.TabIndex = 7;
            // 
            // btnAddNewStation
            // 
            this.btnAddNewStation.Location = new System.Drawing.Point(669, 10);
            this.btnAddNewStation.Name = "btnAddNewStation";
            this.btnAddNewStation.Size = new System.Drawing.Size(110, 23);
            this.btnAddNewStation.TabIndex = 15;
            this.btnAddNewStation.Text = "Add New Station";
            this.btnAddNewStation.UseVisualStyleBackColor = true;
            this.btnAddNewStation.Click += new System.EventHandler(this.btnAddNewStation_Click);
            // 
            // frmAddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMainBody);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmAddStation";
            this.Text = "Add Stations";
            this.Load += new System.EventHandler(this.frmAddStation_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pnlTitle;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExplantion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblAddStation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.Button btnAddNewStation;
    }
}