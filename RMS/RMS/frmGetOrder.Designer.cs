namespace WindowsFormsApplication1
{
    partial class frmGetOrder
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
            this.lblCalculateBill = new System.Windows.Forms.Button();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDop = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAddOrder = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.cmboDestinationStation = new System.Windows.Forms.ComboBox();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.cmboSourceStation = new System.Windows.Forms.ComboBox();
            this.lblSourceStation = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMainBody.SuspendLayout();
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
            this.pnlHeader.TabIndex = 5;
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
            this.pnlMainBody.Controls.Add(this.lblCalculateBill);
            this.pnlMainBody.Controls.Add(this.txtAmountToPay);
            this.pnlMainBody.Controls.Add(this.lblAmountToPay);
            this.pnlMainBody.Controls.Add(this.txtCategory);
            this.pnlMainBody.Controls.Add(this.lblCategory);
            this.pnlMainBody.Controls.Add(this.lblDop);
            this.pnlMainBody.Controls.Add(this.dateTimePicker);
            this.pnlMainBody.Controls.Add(this.txtOrderID);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblAddOrder);
            this.pnlMainBody.Controls.Add(this.btnCancel);
            this.pnlMainBody.Controls.Add(this.btnSubmit);
            this.pnlMainBody.Controls.Add(this.lblOrderID);
            this.pnlMainBody.Controls.Add(this.cmboDestinationStation);
            this.pnlMainBody.Controls.Add(this.lblDestinationStation);
            this.pnlMainBody.Controls.Add(this.cmboSourceStation);
            this.pnlMainBody.Controls.Add(this.lblSourceStation);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 123);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 6;
            this.pnlMainBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainBody_Paint);
            // 
            // lblCalculateBill
            // 
            this.lblCalculateBill.Location = new System.Drawing.Point(302, 239);
            this.lblCalculateBill.Name = "lblCalculateBill";
            this.lblCalculateBill.Size = new System.Drawing.Size(104, 23);
            this.lblCalculateBill.TabIndex = 23;
            this.lblCalculateBill.Text = "Calculate Bill";
            this.lblCalculateBill.UseVisualStyleBackColor = true;
            this.lblCalculateBill.Click += new System.EventHandler(this.lblCalculateBill_Click);
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(721, 140);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.ReadOnly = true;
            this.txtAmountToPay.Size = new System.Drawing.Size(175, 20);
            this.txtAmountToPay.TabIndex = 20;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.Location = new System.Drawing.Point(514, 138);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(135, 20);
            this.lblAmountToPay.TabIndex = 19;
            this.lblAmountToPay.Text = "Amount To Pay:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(200, 140);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(175, 20);
            this.txtCategory.TabIndex = 18;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(33, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 20);
            this.lblCategory.TabIndex = 17;
            this.lblCategory.Text = "Category:";
            // 
            // lblDop
            // 
            this.lblDop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDop.AutoSize = true;
            this.lblDop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDop.Location = new System.Drawing.Point(514, 63);
            this.lblDop.Name = "lblDop";
            this.lblDop.Size = new System.Drawing.Size(166, 20);
            this.lblDop.TabIndex = 16;
            this.lblDop.Text = "Date Of Placement:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(721, 59);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker.TabIndex = 15;
            this.dateTimePicker.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(200, 63);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(175, 20);
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
            // lblAddOrder
            // 
            this.lblAddOrder.AutoSize = true;
            this.lblAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrder.Location = new System.Drawing.Point(464, 10);
            this.lblAddOrder.Name = "lblAddOrder";
            this.lblAddOrder.Size = new System.Drawing.Size(108, 24);
            this.lblAddOrder.TabIndex = 10;
            this.lblAddOrder.Text = "Add Order";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(439, 239);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(33, 59);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(83, 20);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "Order ID:";
            // 
            // cmboDestinationStation
            // 
            this.cmboDestinationStation.FormattingEnabled = true;
            this.cmboDestinationStation.Location = new System.Drawing.Point(721, 101);
            this.cmboDestinationStation.Name = "cmboDestinationStation";
            this.cmboDestinationStation.Size = new System.Drawing.Size(175, 21);
            this.cmboDestinationStation.TabIndex = 3;
            // 
            // lblDestinationStation
            // 
            this.lblDestinationStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinationStation.AutoSize = true;
            this.lblDestinationStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationStation.Location = new System.Drawing.Point(514, 102);
            this.lblDestinationStation.Name = "lblDestinationStation";
            this.lblDestinationStation.Size = new System.Drawing.Size(169, 20);
            this.lblDestinationStation.TabIndex = 2;
            this.lblDestinationStation.Text = "Destination Station:";
            // 
            // cmboSourceStation
            // 
            this.cmboSourceStation.FormattingEnabled = true;
            this.cmboSourceStation.Location = new System.Drawing.Point(200, 98);
            this.cmboSourceStation.Name = "cmboSourceStation";
            this.cmboSourceStation.Size = new System.Drawing.Size(175, 21);
            this.cmboSourceStation.TabIndex = 1;
            // 
            // lblSourceStation
            // 
            this.lblSourceStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSourceStation.AutoSize = true;
            this.lblSourceStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceStation.Location = new System.Drawing.Point(33, 96);
            this.lblSourceStation.Name = "lblSourceStation";
            this.lblSourceStation.Size = new System.Drawing.Size(134, 20);
            this.lblSourceStation.TabIndex = 0;
            this.lblSourceStation.Text = "Source Station:";
            // 
            // frmGetOrder
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
            this.Name = "frmGetOrder";
            this.Text = "Add Order";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAddOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.ComboBox cmboDestinationStation;
        private System.Windows.Forms.Label lblDestinationStation;
        private System.Windows.Forms.ComboBox cmboSourceStation;
        private System.Windows.Forms.Label lblSourceStation;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button lblCalculateBill;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDop;
    }
}