namespace WindowsFormsApplication1
{
    partial class frmOperatorPanel
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
            this.lblOperatorPanel = new System.Windows.Forms.Label();
            this.btnGetTrainDetails = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.btnAddPassengerDetails = new System.Windows.Forms.Button();
            this.btnGetTicketDetails = new System.Windows.Forms.Button();
            this.btnEditPassengerDetails = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnViewPassengerDetails = new System.Windows.Forms.Button();
            this.btnGetCoachDetails = new System.Windows.Forms.Button();
            this.btnRemoveTicket = new System.Windows.Forms.Button();
            this.btnGetOrderDetails = new System.Windows.Forms.Button();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnGenerateTicket = new System.Windows.Forms.Button();
            this.btnCompanyDetails = new System.Windows.Forms.Button();
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.statusStripOperatorPanel = new System.Windows.Forms.StatusStrip();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOperatorPanel
            // 
            this.lblOperatorPanel.AutoSize = true;
            this.lblOperatorPanel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblOperatorPanel.Location = new System.Drawing.Point(471, 17);
            this.lblOperatorPanel.Name = "lblOperatorPanel";
            this.lblOperatorPanel.Size = new System.Drawing.Size(195, 37);
            this.lblOperatorPanel.TabIndex = 6;
            this.lblOperatorPanel.Text = "Operator Panel";
            this.lblOperatorPanel.Click += new System.EventHandler(this.operator_title_Click);
            // 
            // btnGetTrainDetails
            // 
            this.btnGetTrainDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGetTrainDetails.Location = new System.Drawing.Point(411, 77);
            this.btnGetTrainDetails.Name = "btnGetTrainDetails";
            this.btnGetTrainDetails.Size = new System.Drawing.Size(255, 47);
            this.btnGetTrainDetails.TabIndex = 11;
            this.btnGetTrainDetails.Text = "Get Train Details";
            this.btnGetTrainDetails.UseVisualStyleBackColor = true;
            this.btnGetTrainDetails.Click += new System.EventHandler(this.btnGetTrainDetails_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnCancelOrder.Location = new System.Drawing.Point(127, 226);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(255, 47);
            this.btnCancelOrder.TabIndex = 12;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGetOrder.Location = new System.Drawing.Point(127, 150);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(255, 47);
            this.btnGetOrder.TabIndex = 13;
            this.btnGetOrder.Text = "Add Order";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // btnAddPassengerDetails
            // 
            this.btnAddPassengerDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddPassengerDetails.Location = new System.Drawing.Point(127, 296);
            this.btnAddPassengerDetails.Name = "btnAddPassengerDetails";
            this.btnAddPassengerDetails.Size = new System.Drawing.Size(255, 78);
            this.btnAddPassengerDetails.TabIndex = 14;
            this.btnAddPassengerDetails.Text = "Add Passenger Details";
            this.btnAddPassengerDetails.UseVisualStyleBackColor = true;
            this.btnAddPassengerDetails.Click += new System.EventHandler(this.btnAddPassengerDetails_Click);
            // 
            // btnGetTicketDetails
            // 
            this.btnGetTicketDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGetTicketDetails.Location = new System.Drawing.Point(411, 150);
            this.btnGetTicketDetails.Name = "btnGetTicketDetails";
            this.btnGetTicketDetails.Size = new System.Drawing.Size(255, 47);
            this.btnGetTicketDetails.TabIndex = 15;
            this.btnGetTicketDetails.Text = "Get Ticket Details";
            this.btnGetTicketDetails.UseVisualStyleBackColor = true;
            this.btnGetTicketDetails.Click += new System.EventHandler(this.btnGetTicketDetails_Click);
            // 
            // btnEditPassengerDetails
            // 
            this.btnEditPassengerDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnEditPassengerDetails.Location = new System.Drawing.Point(411, 296);
            this.btnEditPassengerDetails.Name = "btnEditPassengerDetails";
            this.btnEditPassengerDetails.Size = new System.Drawing.Size(255, 78);
            this.btnEditPassengerDetails.TabIndex = 16;
            this.btnEditPassengerDetails.Text = "Edit Passenger Details";
            this.btnEditPassengerDetails.UseVisualStyleBackColor = true;
            this.btnEditPassengerDetails.Click += new System.EventHandler(this.btnEditPassengerDetails_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddTicket.Location = new System.Drawing.Point(411, 226);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(255, 47);
            this.btnAddTicket.TabIndex = 17;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // btnViewPassengerDetails
            // 
            this.btnViewPassengerDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnViewPassengerDetails.Location = new System.Drawing.Point(697, 296);
            this.btnViewPassengerDetails.Name = "btnViewPassengerDetails";
            this.btnViewPassengerDetails.Size = new System.Drawing.Size(255, 78);
            this.btnViewPassengerDetails.TabIndex = 18;
            this.btnViewPassengerDetails.Text = "View Passenger Details";
            this.btnViewPassengerDetails.UseVisualStyleBackColor = true;
            this.btnViewPassengerDetails.Click += new System.EventHandler(this.btnViewPassengerDetails_Click);
            // 
            // btnGetCoachDetails
            // 
            this.btnGetCoachDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGetCoachDetails.Location = new System.Drawing.Point(127, 394);
            this.btnGetCoachDetails.Name = "btnGetCoachDetails";
            this.btnGetCoachDetails.Size = new System.Drawing.Size(255, 47);
            this.btnGetCoachDetails.TabIndex = 19;
            this.btnGetCoachDetails.Text = "Get Coach Details";
            this.btnGetCoachDetails.UseVisualStyleBackColor = true;
            this.btnGetCoachDetails.Click += new System.EventHandler(this.btnGetCoachDetails_Click);
            // 
            // btnRemoveTicket
            // 
            this.btnRemoveTicket.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRemoveTicket.Location = new System.Drawing.Point(411, 394);
            this.btnRemoveTicket.Name = "btnRemoveTicket";
            this.btnRemoveTicket.Size = new System.Drawing.Size(255, 47);
            this.btnRemoveTicket.TabIndex = 20;
            this.btnRemoveTicket.Text = "Remove Ticket";
            this.btnRemoveTicket.UseVisualStyleBackColor = true;
            this.btnRemoveTicket.Click += new System.EventHandler(this.btnRemoveTicket_Click);
            // 
            // btnGetOrderDetails
            // 
            this.btnGetOrderDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGetOrderDetails.Location = new System.Drawing.Point(697, 226);
            this.btnGetOrderDetails.Name = "btnGetOrderDetails";
            this.btnGetOrderDetails.Size = new System.Drawing.Size(255, 47);
            this.btnGetOrderDetails.TabIndex = 22;
            this.btnGetOrderDetails.Text = "Get Order Details";
            this.btnGetOrderDetails.UseVisualStyleBackColor = true;
            this.btnGetOrderDetails.Click += new System.EventHandler(this.btnGetOrderDetails_Click);
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnViewSchedule.Location = new System.Drawing.Point(697, 150);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(255, 47);
            this.btnViewSchedule.TabIndex = 23;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.btnGenerateTicket);
            this.pnlMain.Controls.Add(this.btnCompanyDetails);
            this.pnlMain.Controls.Add(this.btnRemoveCompany);
            this.pnlMain.Controls.Add(this.btnAddCompany);
            this.pnlMain.Controls.Add(this.btnViewSchedule);
            this.pnlMain.Controls.Add(this.btnGetOrderDetails);
            this.pnlMain.Controls.Add(this.btnRemoveTicket);
            this.pnlMain.Controls.Add(this.btnGetCoachDetails);
            this.pnlMain.Controls.Add(this.btnViewPassengerDetails);
            this.pnlMain.Controls.Add(this.btnAddTicket);
            this.pnlMain.Controls.Add(this.btnEditPassengerDetails);
            this.pnlMain.Controls.Add(this.btnGetTicketDetails);
            this.pnlMain.Controls.Add(this.btnAddPassengerDetails);
            this.pnlMain.Controls.Add(this.btnGetOrder);
            this.pnlMain.Controls.Add(this.btnCancelOrder);
            this.pnlMain.Controls.Add(this.btnGetTrainDetails);
            this.pnlMain.Controls.Add(this.lblOperatorPanel);
            this.pnlMain.Location = new System.Drawing.Point(0, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1043, 527);
            this.pnlMain.TabIndex = 24;
            // 
            // btnGenerateTicket
            // 
            this.btnGenerateTicket.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnGenerateTicket.Location = new System.Drawing.Point(127, 77);
            this.btnGenerateTicket.Name = "btnGenerateTicket";
            this.btnGenerateTicket.Size = new System.Drawing.Size(255, 47);
            this.btnGenerateTicket.TabIndex = 27;
            this.btnGenerateTicket.Text = "generate Ticket";
            this.btnGenerateTicket.UseVisualStyleBackColor = true;
            this.btnGenerateTicket.Click += new System.EventHandler(this.btnGenerateTicket_Click);
            // 
            // btnCompanyDetails
            // 
            this.btnCompanyDetails.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnCompanyDetails.Location = new System.Drawing.Point(411, 447);
            this.btnCompanyDetails.Name = "btnCompanyDetails";
            this.btnCompanyDetails.Size = new System.Drawing.Size(255, 47);
            this.btnCompanyDetails.TabIndex = 26;
            this.btnCompanyDetails.Text = "Company Details";
            this.btnCompanyDetails.UseVisualStyleBackColor = true;
            this.btnCompanyDetails.Click += new System.EventHandler(this.btnCompanyDetails_Click);
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRemoveCompany.Location = new System.Drawing.Point(697, 394);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(255, 47);
            this.btnRemoveCompany.TabIndex = 25;
            this.btnRemoveCompany.Text = "Remove Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddCompany.Location = new System.Drawing.Point(697, 77);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(255, 47);
            this.btnAddCompany.TabIndex = 24;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(0, -5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1043, 115);
            this.pnlHeader.TabIndex = 25;
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(260, 36);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(536, 42);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // statusStripOperatorPanel
            // 
            this.statusStripOperatorPanel.Location = new System.Drawing.Point(0, 675);
            this.statusStripOperatorPanel.Name = "statusStripOperatorPanel";
            this.statusStripOperatorPanel.Size = new System.Drawing.Size(1046, 22);
            this.statusStripOperatorPanel.TabIndex = 26;
            this.statusStripOperatorPanel.Text = "Status Strip Operator Panel";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.Controls.Add(this.btnViewProfile);
            this.pnlBody.Controls.Add(this.btnLogOut);
            this.pnlBody.Controls.Add(this.pnlMain);
            this.pnlBody.Location = new System.Drawing.Point(0, 116);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1046, 556);
            this.pnlBody.TabIndex = 27;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(959, 13);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(75, 23);
            this.btnViewProfile.TabIndex = 26;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(877, 13);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Text = "Log Out!";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmOperatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1046, 697);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.statusStripOperatorPanel);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmOperatorPanel";
            this.Text = "Operator Panel";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperatorPanel;
        private System.Windows.Forms.Button btnGetTrainDetails;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Button btnAddPassengerDetails;
        private System.Windows.Forms.Button btnGetTicketDetails;
        private System.Windows.Forms.Button btnEditPassengerDetails;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnViewPassengerDetails;
        private System.Windows.Forms.Button btnGetCoachDetails;
        private System.Windows.Forms.Button btnRemoveTicket;
        private System.Windows.Forms.Button btnGetOrderDetails;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.StatusStrip statusStripOperatorPanel;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnCompanyDetails;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnGenerateTicket;
    }
}