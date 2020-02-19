namespace WindowsFormsApplication1
{
    partial class frmEditTrain
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
            this.pnlMainBody = new System.Windows.Forms.Panel();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.btnSearchTrain = new System.Windows.Forms.Button();
            this.txtRegistrationNo = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblEditTrain = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.startingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.pnlEditPanel = new System.Windows.Forms.Panel();
            this.btnEditCoaches = new System.Windows.Forms.Button();
            this.pnlMainBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainBody
            // 
            this.pnlMainBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainBody.Controls.Add(this.btnEditCoaches);
            this.pnlMainBody.Controls.Add(this.pnlEditPanel);
            this.pnlMainBody.Controls.Add(this.btnCancelChanges);
            this.pnlMainBody.Controls.Add(this.btnSubmitChanges);
            this.pnlMainBody.Controls.Add(this.btnSearchTrain);
            this.pnlMainBody.Controls.Add(this.txtRegistrationNo);
            this.pnlMainBody.Controls.Add(this.lblRegNo);
            this.pnlMainBody.Controls.Add(this.lblEditTrain);
            this.pnlMainBody.Controls.Add(this.btnBack);
            this.pnlMainBody.Controls.Add(this.btnViewProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Location = new System.Drawing.Point(5, 107);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(998, 584);
            this.pnlMainBody.TabIndex = 5;
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitChanges.Location = new System.Drawing.Point(210, 106);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(144, 23);
            this.btnSubmitChanges.TabIndex = 10;
            this.btnSubmitChanges.Text = "Submit Changes";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrain.Location = new System.Drawing.Point(91, 106);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(100, 23);
            this.btnSearchTrain.TabIndex = 8;
            this.btnSearchTrain.Text = "Search Train";
            this.btnSearchTrain.UseVisualStyleBackColor = true;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegistrationNo.Location = new System.Drawing.Point(162, 65);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Size = new System.Drawing.Size(192, 20);
            this.txtRegistrationNo.TabIndex = 6;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.Location = new System.Drawing.Point(29, 65);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(127, 20);
            this.lblRegNo.TabIndex = 4;
            this.lblRegNo.Text = "Registration #:";
            // 
            // lblEditTrain
            // 
            this.lblEditTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditTrain.AutoSize = true;
            this.lblEditTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTrain.Location = new System.Drawing.Point(360, 15);
            this.lblEditTrain.Name = "lblEditTrain";
            this.lblEditTrain.Size = new System.Drawing.Size(140, 31);
            this.lblEditTrain.TabIndex = 3;
            this.lblEditTrain.Text = "Edit Train";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(779, 23);
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
            this.btnViewProfile.Location = new System.Drawing.Point(827, 23);
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
            this.btnLogout.Location = new System.Drawing.Point(905, 23);
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
            this.pnlHeader.Location = new System.Drawing.Point(5, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(998, 97);
            this.pnlHeader.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 538);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(191, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management System";
            // 
            // startingDate
            // 
            this.startingDate.CustomFormat = "yyyy-MM-dd";
            this.startingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startingDate.Location = new System.Drawing.Point(255, 51);
            this.startingDate.Name = "startingDate";
            this.startingDate.Size = new System.Drawing.Size(210, 20);
            this.startingDate.TabIndex = 19;
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingDate.Location = new System.Drawing.Point(49, 51);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(122, 20);
            this.lblStartingDate.TabIndex = 18;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(255, 95);
            this.txtType.MaxLength = 10;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(210, 20);
            this.txtType.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(49, 89);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 20);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(255, 174);
            this.txtModelNo.MaxLength = 20;
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(210, 20);
            this.txtModelNo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Model #:";
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(255, 133);
            this.txtEngineNumber.MaxLength = 10;
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(210, 20);
            this.txtEngineNumber.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Engine Number:";
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChanges.Location = new System.Drawing.Point(379, 106);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(121, 23);
            this.btnCancelChanges.TabIndex = 24;
            this.btnCancelChanges.Text = "Cancel Changes";
            this.btnCancelChanges.UseVisualStyleBackColor = true;
            this.btnCancelChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlEditPanel
            // 
            this.pnlEditPanel.Controls.Add(this.startingDate);
            this.pnlEditPanel.Controls.Add(this.lblType);
            this.pnlEditPanel.Controls.Add(this.txtModelNo);
            this.pnlEditPanel.Controls.Add(this.txtType);
            this.pnlEditPanel.Controls.Add(this.label4);
            this.pnlEditPanel.Controls.Add(this.lblStartingDate);
            this.pnlEditPanel.Controls.Add(this.txtEngineNumber);
            this.pnlEditPanel.Controls.Add(this.label2);
            this.pnlEditPanel.Location = new System.Drawing.Point(91, 165);
            this.pnlEditPanel.Name = "pnlEditPanel";
            this.pnlEditPanel.Size = new System.Drawing.Size(505, 223);
            this.pnlEditPanel.TabIndex = 25;
            this.pnlEditPanel.Visible = false;
            // 
            // btnEditCoaches
            // 
            this.btnEditCoaches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCoaches.Location = new System.Drawing.Point(529, 106);
            this.btnEditCoaches.Name = "btnEditCoaches";
            this.btnEditCoaches.Size = new System.Drawing.Size(121, 23);
            this.btnEditCoaches.TabIndex = 26;
            this.btnEditCoaches.Text = "Edit Coaches";
            this.btnEditCoaches.UseVisualStyleBackColor = true;
            this.btnEditCoaches.Click += new System.EventHandler(this.btnEditCoaches_Click);
            // 
            // frmEditTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlMainBody);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmEditTrain";
            this.Text = "frmEditTrain";
            this.Load += new System.EventHandler(this.frmEditTrain_Load);
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlEditPanel.ResumeLayout(false);
            this.pnlEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.Button btnSubmitChanges;
        private System.Windows.Forms.Button btnSearchTrain;
        private System.Windows.Forms.TextBox txtRegistrationNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblEditTrain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker startingDate;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.Panel pnlEditPanel;
        private System.Windows.Forms.Button btnEditCoaches;
    }
}