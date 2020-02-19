namespace WindowsFormsApplication1
{
    partial class frmEditRoute
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoadPreviousChanges = new System.Windows.Forms.Button();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblEditRoute = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainBody.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainBody
            // 
            this.pnlMainBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMainBody.Controls.Add(this.btnCancel);
            this.pnlMainBody.Controls.Add(this.btnLoadPreviousChanges);
            this.pnlMainBody.Controls.Add(this.btnConfirmChanges);
            this.pnlMainBody.Controls.Add(this.lblPrice);
            this.pnlMainBody.Controls.Add(this.txtPrice);
            this.pnlMainBody.Controls.Add(this.lblRouteName);
            this.pnlMainBody.Controls.Add(this.txtRouteName);
            this.pnlMainBody.Controls.Add(this.label2);
            this.pnlMainBody.Controls.Add(this.btnSubmit);
            this.pnlMainBody.Controls.Add(this.txtRouteID);
            this.pnlMainBody.Controls.Add(this.lblRouteID);
            this.pnlMainBody.Controls.Add(this.lblEditRoute);
            this.pnlMainBody.Controls.Add(this.btnBack);
            this.pnlMainBody.Controls.Add(this.btnViewProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 102);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1006, 596);
            this.pnlMainBody.TabIndex = 5;
            this.pnlMainBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainBody_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(369, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoadPreviousChanges
            // 
            this.btnLoadPreviousChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadPreviousChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPreviousChanges.Location = new System.Drawing.Point(193, 289);
            this.btnLoadPreviousChanges.Name = "btnLoadPreviousChanges";
            this.btnLoadPreviousChanges.Size = new System.Drawing.Size(157, 23);
            this.btnLoadPreviousChanges.TabIndex = 31;
            this.btnLoadPreviousChanges.Text = "Load Previous Changes";
            this.btnLoadPreviousChanges.UseVisualStyleBackColor = true;
            this.btnLoadPreviousChanges.Click += new System.EventHandler(this.btnLoadPreviousChanges_Click);
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChanges.Location = new System.Drawing.Point(54, 289);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(114, 23);
            this.btnConfirmChanges.TabIndex = 30;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(54, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 20);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(214, 232);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 20);
            this.txtPrice.TabIndex = 28;
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteName.Location = new System.Drawing.Point(54, 206);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(114, 20);
            this.lblRouteName.TabIndex = 27;
            this.lblRouteName.Text = "Route Name:";
            // 
            // txtRouteName
            // 
            this.txtRouteName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRouteName.Location = new System.Drawing.Point(214, 206);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(136, 20);
            this.txtRouteName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please enter your route information to edit it";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(261, 158);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRouteID
            // 
            this.txtRouteID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRouteID.Location = new System.Drawing.Point(214, 110);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(136, 20);
            this.txtRouteID.TabIndex = 6;
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(62, 106);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(87, 20);
            this.lblRouteID.TabIndex = 4;
            this.lblRouteID.Text = "Route ID:";
            // 
            // lblEditRoute
            // 
            this.lblEditRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditRoute.AutoSize = true;
            this.lblEditRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRoute.Location = new System.Drawing.Point(466, 20);
            this.lblEditRoute.Name = "lblEditRoute";
            this.lblEditRoute.Size = new System.Drawing.Size(151, 31);
            this.lblEditRoute.TabIndex = 3;
            this.lblEditRoute.Text = "Edit Route";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(867, 30);
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
            this.btnViewProfile.Location = new System.Drawing.Point(780, 30);
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
            this.btnLogout.Location = new System.Drawing.Point(927, 30);
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
            this.pnlHeader.Location = new System.Drawing.Point(4, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1003, 104);
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
            this.lblTitle.Location = new System.Drawing.Point(204, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management System";
            // 
            // frmEditRoute
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
            this.Name = "frmEditRoute";
            this.Text = "Edit Route";
            this.Load += new System.EventHandler(this.frmEditRoute_Load);
            this.pnlMainBody.ResumeLayout(false);
            this.pnlMainBody.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblEditRoute;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadPreviousChanges;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Button btnCancel;
    }
}