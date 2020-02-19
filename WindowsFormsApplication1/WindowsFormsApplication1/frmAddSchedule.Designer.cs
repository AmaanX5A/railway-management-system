namespace WindowsFormsApplication1
{
    partial class frmAddSchedule
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
            this.txtScheduleID = new System.Windows.Forms.TextBox();
            this.lblScheduleID = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAddSchedule = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmboTrain = new System.Windows.Forms.ComboBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.cmboRouteName = new System.Windows.Forms.ComboBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1007, 111);
            this.pnlHeader.TabIndex = 2;
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
            this.pnlMainBody.Controls.Add(this.txtScheduleID);
            this.pnlMainBody.Controls.Add(this.lblScheduleID);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblAddSchedule);
            this.pnlMainBody.Controls.Add(this.btnCancel);
            this.pnlMainBody.Controls.Add(this.btnSubmit);
            this.pnlMainBody.Controls.Add(this.cmboTrain);
            this.pnlMainBody.Controls.Add(this.lblTrain);
            this.pnlMainBody.Controls.Add(this.cmboRouteName);
            this.pnlMainBody.Controls.Add(this.lblRouteName);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 118);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 4;
            // 
            // txtScheduleID
            // 
            this.txtScheduleID.Location = new System.Drawing.Point(586, 70);
            this.txtScheduleID.Name = "txtScheduleID";
            this.txtScheduleID.ReadOnly = true;
            this.txtScheduleID.Size = new System.Drawing.Size(150, 20);
            this.txtScheduleID.TabIndex = 15;
            // 
            // lblScheduleID
            // 
            this.lblScheduleID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScheduleID.AutoSize = true;
            this.lblScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleID.Location = new System.Drawing.Point(441, 70);
            this.lblScheduleID.Name = "lblScheduleID";
            this.lblScheduleID.Size = new System.Drawing.Size(113, 20);
            this.lblScheduleID.TabIndex = 14;
            this.lblScheduleID.Text = "Schedule ID:";
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
            this.lblAddSchedule.Size = new System.Drawing.Size(143, 24);
            this.lblAddSchedule.TabIndex = 10;
            this.lblAddSchedule.Text = "Add Schedule";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(344, 230);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmboTrain
            // 
            this.cmboTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboTrain.FormattingEnabled = true;
            this.cmboTrain.Location = new System.Drawing.Point(200, 119);
            this.cmboTrain.Name = "cmboTrain";
            this.cmboTrain.Size = new System.Drawing.Size(175, 21);
            this.cmboTrain.TabIndex = 5;
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(33, 117);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(110, 20);
            this.lblTrain.TabIndex = 4;
            this.lblTrain.Text = "Select Train:";
            // 
            // cmboRouteName
            // 
            this.cmboRouteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboRouteName.FormattingEnabled = true;
            this.cmboRouteName.Location = new System.Drawing.Point(200, 72);
            this.cmboRouteName.Name = "cmboRouteName";
            this.cmboRouteName.Size = new System.Drawing.Size(175, 21);
            this.cmboRouteName.TabIndex = 1;
            // 
            // lblRouteName
            // 
            this.lblRouteName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteName.Location = new System.Drawing.Point(33, 70);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(114, 20);
            this.lblRouteName.TabIndex = 0;
            this.lblRouteName.Text = "Route Name:";
            this.lblRouteName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmAddSchedule
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
            this.Name = "frmAddSchedule";
            this.Text = "Add Schedule";
            this.Load += new System.EventHandler(this.frmAddSchedule_Load);
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
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.ComboBox cmboRouteName;
        private System.Windows.Forms.ComboBox cmboTrain;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAddSchedule;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtScheduleID;
        private System.Windows.Forms.Label lblScheduleID;
    }
}