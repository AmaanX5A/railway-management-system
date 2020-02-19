namespace WindowsFormsApplication1
{
    partial class frmGetPayment
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGetPayment = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pnlSubPanel = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtAmountPayed = new System.Windows.Forms.TextBox();
            this.lblPayedAmount = new System.Windows.Forms.Label();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.lblDueAmount = new System.Windows.Forms.Label();
            this.txtAddAmount = new System.Windows.Forms.TextBox();
            this.lblAddAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtOrderID1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMainBody.SuspendLayout();
            this.pnlSubPanel.SuspendLayout();
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
            this.pnlMainBody.Controls.Add(this.btnSearchOrder);
            this.pnlMainBody.Controls.Add(this.pnlSubPanel);
            this.pnlMainBody.Controls.Add(this.txtOrderID);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblGetPayment);
            this.pnlMainBody.Controls.Add(this.lblOrderID);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 123);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 10;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(201, 70);
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
            // 
            // lblGetPayment
            // 
            this.lblGetPayment.AutoSize = true;
            this.lblGetPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetPayment.Location = new System.Drawing.Point(464, 10);
            this.lblGetPayment.Name = "lblGetPayment";
            this.lblGetPayment.Size = new System.Drawing.Size(128, 24);
            this.lblGetPayment.TabIndex = 10;
            this.lblGetPayment.Text = "Get Payment";
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
            // pnlSubPanel
            // 
            this.pnlSubPanel.Controls.Add(this.txtOrderID1);
            this.pnlSubPanel.Controls.Add(this.btnCancel);
            this.pnlSubPanel.Controls.Add(this.label1);
            this.pnlSubPanel.Controls.Add(this.txtAddAmount);
            this.pnlSubPanel.Controls.Add(this.btnSubmit);
            this.pnlSubPanel.Controls.Add(this.txtDueAmount);
            this.pnlSubPanel.Controls.Add(this.lblAddAmount);
            this.pnlSubPanel.Controls.Add(this.lblDueAmount);
            this.pnlSubPanel.Controls.Add(this.txtAmountPayed);
            this.pnlSubPanel.Controls.Add(this.lblPayedAmount);
            this.pnlSubPanel.Controls.Add(this.txtTotalAmount);
            this.pnlSubPanel.Controls.Add(this.lblTotalAmount);
            this.pnlSubPanel.Location = new System.Drawing.Point(15, 191);
            this.pnlSubPanel.Name = "pnlSubPanel";
            this.pnlSubPanel.Size = new System.Drawing.Size(980, 375);
            this.pnlSubPanel.TabIndex = 15;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(448, 30);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(151, 20);
            this.txtTotalAmount.TabIndex = 19;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(310, 30);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(121, 20);
            this.lblTotalAmount.TabIndex = 18;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtAmountPayed
            // 
            this.txtAmountPayed.Location = new System.Drawing.Point(755, 30);
            this.txtAmountPayed.Name = "txtAmountPayed";
            this.txtAmountPayed.ReadOnly = true;
            this.txtAmountPayed.Size = new System.Drawing.Size(151, 20);
            this.txtAmountPayed.TabIndex = 21;
            // 
            // lblPayedAmount
            // 
            this.lblPayedAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayedAmount.AutoSize = true;
            this.lblPayedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayedAmount.Location = new System.Drawing.Point(612, 30);
            this.lblPayedAmount.Name = "lblPayedAmount";
            this.lblPayedAmount.Size = new System.Drawing.Size(130, 20);
            this.lblPayedAmount.TabIndex = 20;
            this.lblPayedAmount.Text = "Payed Amount:";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(153, 67);
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.ReadOnly = true;
            this.txtDueAmount.Size = new System.Drawing.Size(151, 20);
            this.txtDueAmount.TabIndex = 23;
            // 
            // lblDueAmount
            // 
            this.lblDueAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDueAmount.AutoSize = true;
            this.lblDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueAmount.Location = new System.Drawing.Point(7, 65);
            this.lblDueAmount.Name = "lblDueAmount";
            this.lblDueAmount.Size = new System.Drawing.Size(114, 20);
            this.lblDueAmount.TabIndex = 22;
            this.lblDueAmount.Text = "Due Amount:";
            // 
            // txtAddAmount
            // 
            this.txtAddAmount.Location = new System.Drawing.Point(448, 65);
            this.txtAddAmount.Name = "txtAddAmount";
            this.txtAddAmount.Size = new System.Drawing.Size(151, 20);
            this.txtAddAmount.TabIndex = 17;
            // 
            // lblAddAmount
            // 
            this.lblAddAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddAmount.AutoSize = true;
            this.lblAddAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAmount.Location = new System.Drawing.Point(310, 65);
            this.lblAddAmount.Name = "lblAddAmount";
            this.lblAddAmount.Size = new System.Drawing.Size(113, 20);
            this.lblAddAmount.TabIndex = 16;
            this.lblAddAmount.Text = "Add Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(304, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtOrderID1
            // 
            this.txtOrderID1.Location = new System.Drawing.Point(153, 30);
            this.txtOrderID1.Name = "txtOrderID1";
            this.txtOrderID1.ReadOnly = true;
            this.txtOrderID1.Size = new System.Drawing.Size(151, 20);
            this.txtOrderID1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order ID:";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(405, 132);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(104, 23);
            this.btnSearchOrder.TabIndex = 17;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            // 
            // frmGetPayment
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
            this.Name = "frmGetPayment";
            this.Text = "frmGetPayment";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            this.pnlSubPanel.ResumeLayout(false);
            this.pnlSubPanel.PerformLayout();
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
        private System.Windows.Forms.Label lblGetPayment;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Panel pnlSubPanel;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label lblDueAmount;
        private System.Windows.Forms.TextBox txtAmountPayed;
        private System.Windows.Forms.Label lblPayedAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtAddAmount;
        private System.Windows.Forms.Label lblAddAmount;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtOrderID1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
    }
}