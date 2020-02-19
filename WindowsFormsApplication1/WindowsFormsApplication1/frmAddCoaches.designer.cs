namespace WindowsFormsApplication1
{
    partial class frmAddCoach
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNoOfSeats = new System.Windows.Forms.TextBox();
            this.txtCoachType = new System.Windows.Forms.TextBox();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNoOfSeats = new System.Windows.Forms.Label();
            this.lblCoachType = new System.Windows.Forms.Label();
            this.lblCoachID = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAddSchedule = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.pnlMainBody.Controls.Add(this.txtPrice);
            this.pnlMainBody.Controls.Add(this.txtNoOfSeats);
            this.pnlMainBody.Controls.Add(this.txtCoachType);
            this.pnlMainBody.Controls.Add(this.txtCoachID);
            this.pnlMainBody.Controls.Add(this.lblPrice);
            this.pnlMainBody.Controls.Add(this.lblNoOfSeats);
            this.pnlMainBody.Controls.Add(this.lblCoachType);
            this.pnlMainBody.Controls.Add(this.lblCoachID);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblAddSchedule);
            this.pnlMainBody.Controls.Add(this.btnCancel);
            this.pnlMainBody.Controls.Add(this.btnSubmit);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 123);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(255, 178);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(234, 20);
            this.txtPrice.TabIndex = 21;
            // 
            // txtNoOfSeats
            // 
            this.txtNoOfSeats.Location = new System.Drawing.Point(255, 143);
            this.txtNoOfSeats.Name = "txtNoOfSeats";
            this.txtNoOfSeats.Size = new System.Drawing.Size(234, 20);
            this.txtNoOfSeats.TabIndex = 20;
            // 
            // txtCoachType
            // 
            this.txtCoachType.Location = new System.Drawing.Point(255, 105);
            this.txtCoachType.Name = "txtCoachType";
            this.txtCoachType.Size = new System.Drawing.Size(234, 20);
            this.txtCoachType.TabIndex = 19;
            // 
            // txtCoachID
            // 
            this.txtCoachID.Location = new System.Drawing.Point(255, 72);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(234, 20);
            this.txtCoachID.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(136, 178);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 16);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price:";
            // 
            // lblNoOfSeats
            // 
            this.lblNoOfSeats.AutoSize = true;
            this.lblNoOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfSeats.Location = new System.Drawing.Point(136, 147);
            this.lblNoOfSeats.Name = "lblNoOfSeats";
            this.lblNoOfSeats.Size = new System.Drawing.Size(86, 16);
            this.lblNoOfSeats.TabIndex = 16;
            this.lblNoOfSeats.Text = "No. Of Seats:";
            // 
            // lblCoachType
            // 
            this.lblCoachType.AutoSize = true;
            this.lblCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachType.Location = new System.Drawing.Point(136, 109);
            this.lblCoachType.Name = "lblCoachType";
            this.lblCoachType.Size = new System.Drawing.Size(85, 16);
            this.lblCoachType.TabIndex = 15;
            this.lblCoachType.Text = "Coach Type:";
            // 
            // lblCoachID
            // 
            this.lblCoachID.AutoSize = true;
            this.lblCoachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachID.Location = new System.Drawing.Point(136, 72);
            this.lblCoachID.Name = "lblCoachID";
            this.lblCoachID.Size = new System.Drawing.Size(66, 16);
            this.lblCoachID.TabIndex = 14;
            this.lblCoachID.Text = "Coach ID:";
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
            // lblAddSchedule
            // 
            this.lblAddSchedule.AutoSize = true;
            this.lblAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSchedule.Location = new System.Drawing.Point(464, 10);
            this.lblAddSchedule.Name = "lblAddSchedule";
            this.lblAddSchedule.Size = new System.Drawing.Size(114, 24);
            this.lblAddSchedule.TabIndex = 10;
            this.lblAddSchedule.Text = "Add Coach";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmAddCoach
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
            this.Name = "frmAddCoach";
            this.Text = "Add Coach";
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
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAddSchedule;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblNoOfSeats;
        private System.Windows.Forms.Label lblCoachType;
        private System.Windows.Forms.Label lblCoachID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNoOfSeats;
        private System.Windows.Forms.TextBox txtCoachType;
        private System.Windows.Forms.TextBox txtCoachID;

    }
}