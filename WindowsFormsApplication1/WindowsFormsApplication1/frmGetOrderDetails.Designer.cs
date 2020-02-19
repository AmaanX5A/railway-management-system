namespace WindowsFormsApplication1
{
    partial class frmGetOrderDetails
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
            this.pnlMainBody = new System.Windows.Forms.Panel();
            this.lblByCompanyAndDate = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnByOrderID = new System.Windows.Forms.Button();
            this.btnByCompanyID = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.btnByDate = new System.Windows.Forms.Button();
            this.btnByCompanyName = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMainBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(1, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1007, 111);
            this.pnlHeader.TabIndex = 9;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(237, 34);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // pnlMainBody
            // 
            this.pnlMainBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainBody.Controls.Add(this.lblByCompanyAndDate);
            this.pnlMainBody.Controls.Add(this.dateTo);
            this.pnlMainBody.Controls.Add(this.dateFrom);
            this.pnlMainBody.Controls.Add(this.button1);
            this.pnlMainBody.Controls.Add(this.lblTo);
            this.pnlMainBody.Controls.Add(this.lblFrom);
            this.pnlMainBody.Controls.Add(this.dataGridView1);
            this.pnlMainBody.Controls.Add(this.btnByOrderID);
            this.pnlMainBody.Controls.Add(this.btnByCompanyID);
            this.pnlMainBody.Controls.Add(this.txtCompanyName);
            this.pnlMainBody.Controls.Add(this.lblCompanyName);
            this.pnlMainBody.Controls.Add(this.txtCompanyID);
            this.pnlMainBody.Controls.Add(this.lblCompanyID);
            this.pnlMainBody.Controls.Add(this.txtOrderID);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblOrderDetails);
            this.pnlMainBody.Controls.Add(this.btnByDate);
            this.pnlMainBody.Controls.Add(this.btnByCompanyName);
            this.pnlMainBody.Controls.Add(this.lblOrderID);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 123);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 10;
            // 
            // lblByCompanyAndDate
            // 
            this.lblByCompanyAndDate.Location = new System.Drawing.Point(692, 156);
            this.lblByCompanyAndDate.Name = "lblByCompanyAndDate";
            this.lblByCompanyAndDate.Size = new System.Drawing.Size(129, 23);
            this.lblByCompanyAndDate.TabIndex = 27;
            this.lblByCompanyAndDate.Text = "By Company And Date";
            this.lblByCompanyAndDate.UseVisualStyleBackColor = true;
            this.lblByCompanyAndDate.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(759, 122);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(106, 20);
            this.dateTo.TabIndex = 26;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(492, 122);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(120, 20);
            this.dateFrom.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generate Report!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(704, 122);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 20);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(431, 123);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 20);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "From:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1007, 341);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnByOrderID
            // 
            this.btnByOrderID.Location = new System.Drawing.Point(69, 156);
            this.btnByOrderID.Name = "btnByOrderID";
            this.btnByOrderID.Size = new System.Drawing.Size(136, 23);
            this.btnByOrderID.TabIndex = 20;
            this.btnByOrderID.Text = "By Order ID";
            this.btnByOrderID.UseVisualStyleBackColor = true;
            this.btnByOrderID.Click += new System.EventHandler(this.btnByOrderID_Click);
            // 
            // btnByCompanyID
            // 
            this.btnByCompanyID.Location = new System.Drawing.Point(397, 156);
            this.btnByCompanyID.Name = "btnByCompanyID";
            this.btnByCompanyID.Size = new System.Drawing.Size(136, 23);
            this.btnByCompanyID.TabIndex = 19;
            this.btnByCompanyID.Text = "By Company ID";
            this.btnByCompanyID.UseVisualStyleBackColor = true;
            this.btnByCompanyID.Click += new System.EventHandler(this.btnByCompanyID_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(845, 70);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(151, 20);
            this.txtCompanyName.TabIndex = 18;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(663, 70);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(139, 20);
            this.lblCompanyName.TabIndex = 17;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(492, 70);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(151, 20);
            this.txtCompanyID.TabIndex = 16;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(310, 70);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(112, 20);
            this.lblCompanyID.TabIndex = 15;
            this.lblCompanyID.Text = "Company ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(140, 70);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(151, 20);
            this.txtOrderID.TabIndex = 14;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBack.Location = new System.Drawing.Point(759, 10);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.Location = new System.Drawing.Point(840, 10);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(921, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out!";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(464, 10);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(132, 24);
            this.lblOrderDetails.TabIndex = 10;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // btnByDate
            // 
            this.btnByDate.Location = new System.Drawing.Point(554, 156);
            this.btnByDate.Name = "btnByDate";
            this.btnByDate.Size = new System.Drawing.Size(104, 23);
            this.btnByDate.TabIndex = 9;
            this.btnByDate.Text = "By Date";
            this.btnByDate.UseVisualStyleBackColor = true;
            this.btnByDate.Click += new System.EventHandler(this.btnByDate_Click);
            // 
            // btnByCompanyName
            // 
            this.btnByCompanyName.Location = new System.Drawing.Point(229, 156);
            this.btnByCompanyName.Name = "btnByCompanyName";
            this.btnByCompanyName.Size = new System.Drawing.Size(136, 23);
            this.btnByCompanyName.TabIndex = 8;
            this.btnByCompanyName.Text = "By Company Name";
            this.btnByCompanyName.UseVisualStyleBackColor = true;
            this.btnByCompanyName.Click += new System.EventHandler(this.btnByCompanyName_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(33, 70);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(83, 20);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // frmGetOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMainBody);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmGetOrderDetails";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.frmGetOrderDetails_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnByOrderID;
        private System.Windows.Forms.Button btnByCompanyID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnByDate;
        private System.Windows.Forms.Button btnByCompanyName;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button lblByCompanyAndDate;
    }
}