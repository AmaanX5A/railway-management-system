namespace WindowsFormsApplication1
{
    partial class frmCoachDetails
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCoachType = new System.Windows.Forms.Label();
            this.btnByType = new System.Windows.Forms.Button();
            this.btnViewAllCoaches = new System.Windows.Forms.Button();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.lblCoachID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.lblViewCoachDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblCoachType);
            this.panel3.Controls.Add(this.btnByType);
            this.panel3.Controls.Add(this.btnViewAllCoaches);
            this.panel3.Controls.Add(this.txtCoachID);
            this.panel3.Controls.Add(this.lblCoachID);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btnSearchByID);
            this.panel3.Controls.Add(this.lblViewCoachDetails);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnViewProfile);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Location = new System.Drawing.Point(6, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 592);
            this.panel3.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(626, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 18;
            // 
            // lblCoachType
            // 
            this.lblCoachType.AutoSize = true;
            this.lblCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachType.Location = new System.Drawing.Point(507, 100);
            this.lblCoachType.Name = "lblCoachType";
            this.lblCoachType.Size = new System.Drawing.Size(52, 20);
            this.lblCoachType.TabIndex = 17;
            this.lblCoachType.Text = "Type:";
            // 
            // btnByType
            // 
            this.btnByType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnByType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByType.Location = new System.Drawing.Point(568, 151);
            this.btnByType.Name = "btnByType";
            this.btnByType.Size = new System.Drawing.Size(127, 23);
            this.btnByType.TabIndex = 16;
            this.btnByType.Text = "By Type";
            this.btnByType.UseVisualStyleBackColor = true;
            // 
            // btnViewAllCoaches
            // 
            this.btnViewAllCoaches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewAllCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllCoaches.Location = new System.Drawing.Point(396, 151);
            this.btnViewAllCoaches.Name = "btnViewAllCoaches";
            this.btnViewAllCoaches.Size = new System.Drawing.Size(143, 23);
            this.btnViewAllCoaches.TabIndex = 15;
            this.btnViewAllCoaches.Text = "All Coaches";
            this.btnViewAllCoaches.UseVisualStyleBackColor = true;
            // 
            // txtCoachID
            // 
            this.txtCoachID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCoachID.Location = new System.Drawing.Point(189, 102);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(152, 20);
            this.txtCoachID.TabIndex = 14;
            // 
            // lblCoachID
            // 
            this.lblCoachID.AutoSize = true;
            this.lblCoachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachID.Location = new System.Drawing.Point(70, 100);
            this.lblCoachID.Name = "lblCoachID";
            this.lblCoachID.Size = new System.Drawing.Size(89, 20);
            this.lblCoachID.TabIndex = 13;
            this.lblCoachID.Text = "Coach ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 397);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(242, 151);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(127, 23);
            this.btnSearchByID.TabIndex = 8;
            this.btnSearchByID.Text = "Search By ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            // 
            // lblViewCoachDetails
            // 
            this.lblViewCoachDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblViewCoachDetails.AutoSize = true;
            this.lblViewCoachDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCoachDetails.Location = new System.Drawing.Point(390, 11);
            this.lblViewCoachDetails.Name = "lblViewCoachDetails";
            this.lblViewCoachDetails.Size = new System.Drawing.Size(268, 31);
            this.lblViewCoachDetails.TabIndex = 3;
            this.lblViewCoachDetails.Text = "View Coach Details";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(869, 21);
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
            this.btnViewProfile.Location = new System.Drawing.Point(782, 21);
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
            this.btnLogout.Location = new System.Drawing.Point(929, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlHead
            // 
            this.pnlHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHead.BackColor = System.Drawing.Color.Aqua;
            this.pnlHead.Controls.Add(this.panel2);
            this.pnlHead.Controls.Add(this.lblTitle);
            this.pnlHead.Location = new System.Drawing.Point(3, 1);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1003, 100);
            this.pnlHead.TabIndex = 14;
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
            this.lblTitle.Location = new System.Drawing.Point(226, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management System";
            // 
            // frmCoachDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlHead);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmCoachDetails";
            this.Text = "Coach Details";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnByType;
        private System.Windows.Forms.Button btnViewAllCoaches;
        private System.Windows.Forms.TextBox txtCoachID;
        private System.Windows.Forms.Label lblCoachID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Label lblViewCoachDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCoachType;
    }
}