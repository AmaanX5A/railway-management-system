namespace WindowsFormsApplication1
{
    partial class frmAddStationsToRoute
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnGetRoute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSequenceNo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemovStation = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.departureTime = new System.Windows.Forms.DateTimePicker();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.btnAddToTable = new System.Windows.Forms.Button();
            this.cmboStations = new System.Windows.Forms.ComboBox();
            this.lblStations = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.dataForm = new System.Windows.Forms.DataGridView();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblSartingTime = new System.Windows.Forms.Label();
            this.lblAddStationsToRoute = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.ForeColor = System.Drawing.Color.Black;
            this.pnlHeader.Location = new System.Drawing.Point(-4, 7);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1017, 96);
            this.pnlHeader.TabIndex = 10;
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
            this.lblTitle.Location = new System.Drawing.Point(217, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Railway Management System";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBody.Controls.Add(this.btnGetRoute);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.txtSequenceNo);
            this.pnlBody.Controls.Add(this.btnUpdate);
            this.pnlBody.Controls.Add(this.btnRemovStation);
            this.pnlBody.Controls.Add(this.startTime);
            this.pnlBody.Controls.Add(this.departureTime);
            this.pnlBody.Controls.Add(this.lblRouteID);
            this.pnlBody.Controls.Add(this.txtRouteID);
            this.pnlBody.Controls.Add(this.btnAddToTable);
            this.pnlBody.Controls.Add(this.cmboStations);
            this.pnlBody.Controls.Add(this.lblStations);
            this.pnlBody.Controls.Add(this.lblDepartureTime);
            this.pnlBody.Controls.Add(this.lblExplanation);
            this.pnlBody.Controls.Add(this.dataForm);
            this.pnlBody.Controls.Add(this.btnFinish);
            this.pnlBody.Controls.Add(this.lblSartingTime);
            this.pnlBody.Controls.Add(this.lblAddStationsToRoute);
            this.pnlBody.Controls.Add(this.btnBack);
            this.pnlBody.Controls.Add(this.btnViewProfile);
            this.pnlBody.Controls.Add(this.btnLogout);
            this.pnlBody.ForeColor = System.Drawing.Color.Black;
            this.pnlBody.Location = new System.Drawing.Point(10, 112);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1003, 577);
            this.pnlBody.TabIndex = 11;
            // 
            // btnGetRoute
            // 
            this.btnGetRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetRoute.AutoSize = true;
            this.btnGetRoute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetRoute.Location = new System.Drawing.Point(723, 14);
            this.btnGetRoute.Name = "btnGetRoute";
            this.btnGetRoute.Size = new System.Drawing.Size(66, 23);
            this.btnGetRoute.TabIndex = 26;
            this.btnGetRoute.Text = "Get Route";
            this.btnGetRoute.UseVisualStyleBackColor = true;
            this.btnGetRoute.Click += new System.EventHandler(this.btnGetRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sequence #:";
            // 
            // txtSequenceNo
            // 
            this.txtSequenceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSequenceNo.Location = new System.Drawing.Point(210, 225);
            this.txtSequenceNo.Name = "txtSequenceNo";
            this.txtSequenceNo.Size = new System.Drawing.Size(200, 20);
            this.txtSequenceNo.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(425, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemovStation
            // 
            this.btnRemovStation.Location = new System.Drawing.Point(237, 301);
            this.btnRemovStation.Name = "btnRemovStation";
            this.btnRemovStation.Size = new System.Drawing.Size(173, 23);
            this.btnRemovStation.TabIndex = 22;
            this.btnRemovStation.Text = "Remove Station From Route";
            this.btnRemovStation.UseVisualStyleBackColor = true;
            this.btnRemovStation.Click += new System.EventHandler(this.btnRemovStation_Click);
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(210, 168);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 21;
            // 
            // departureTime
            // 
            this.departureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTime.Location = new System.Drawing.Point(210, 141);
            this.departureTime.Name = "departureTime";
            this.departureTime.Size = new System.Drawing.Size(200, 20);
            this.departureTime.TabIndex = 20;
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteID.Location = new System.Drawing.Point(50, 115);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(82, 20);
            this.lblRouteID.TabIndex = 17;
            this.lblRouteID.Text = "RouteID:";
            // 
            // txtRouteID
            // 
            this.txtRouteID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRouteID.Location = new System.Drawing.Point(210, 115);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(200, 20);
            this.txtRouteID.TabIndex = 16;
            // 
            // btnAddToTable
            // 
            this.btnAddToTable.Location = new System.Drawing.Point(36, 301);
            this.btnAddToTable.Name = "btnAddToTable";
            this.btnAddToTable.Size = new System.Drawing.Size(173, 23);
            this.btnAddToTable.TabIndex = 15;
            this.btnAddToTable.Text = "Add Station To Route";
            this.btnAddToTable.UseVisualStyleBackColor = true;
            this.btnAddToTable.Click += new System.EventHandler(this.btnAddToTable_Click);
            // 
            // cmboStations
            // 
            this.cmboStations.FormattingEnabled = true;
            this.cmboStations.Location = new System.Drawing.Point(210, 197);
            this.cmboStations.Name = "cmboStations";
            this.cmboStations.Size = new System.Drawing.Size(200, 21);
            this.cmboStations.TabIndex = 14;
            // 
            // lblStations
            // 
            this.lblStations.AutoSize = true;
            this.lblStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStations.Location = new System.Drawing.Point(50, 195);
            this.lblStations.Name = "lblStations";
            this.lblStations.Size = new System.Drawing.Size(81, 20);
            this.lblStations.TabIndex = 13;
            this.lblStations.Text = "Stations:";
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(50, 141);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(138, 20);
            this.lblDepartureTime.TabIndex = 11;
            this.lblDepartureTime.Text = "Departure Time:";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(32, 64);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(373, 20);
            this.lblExplanation.TabIndex = 10;
            this.lblExplanation.Text = "Please Enter your route Information to Add it.";
            // 
            // dataForm
            // 
            this.dataForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataForm.Location = new System.Drawing.Point(3, 353);
            this.dataForm.Name = "dataForm";
            this.dataForm.Size = new System.Drawing.Size(997, 221);
            this.dataForm.TabIndex = 9;
            this.dataForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataForm_CellContentClick);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(615, 301);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(164, 23);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblSartingTime
            // 
            this.lblSartingTime.AutoSize = true;
            this.lblSartingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSartingTime.Location = new System.Drawing.Point(50, 171);
            this.lblSartingTime.Name = "lblSartingTime";
            this.lblSartingTime.Size = new System.Drawing.Size(116, 20);
            this.lblSartingTime.TabIndex = 4;
            this.lblSartingTime.Text = "StartingTime:";
            // 
            // lblAddStationsToRoute
            // 
            this.lblAddStationsToRoute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddStationsToRoute.AutoSize = true;
            this.lblAddStationsToRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStationsToRoute.Location = new System.Drawing.Point(322, 14);
            this.lblAddStationsToRoute.Name = "lblAddStationsToRoute";
            this.lblAddStationsToRoute.Size = new System.Drawing.Size(308, 31);
            this.lblAddStationsToRoute.TabIndex = 3;
            this.lblAddStationsToRoute.Text = "Add Stations To Route";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(797, 14);
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
            this.btnViewProfile.Location = new System.Drawing.Point(901, 14);
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
            this.btnLogout.Location = new System.Drawing.Point(845, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmAddStationsToRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmAddStationsToRoute";
            this.Text = "Sequence #:";
            this.Load += new System.EventHandler(this.frmAddStationsToRoute_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker departureTime;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Button btnAddToTable;
        private System.Windows.Forms.ComboBox cmboStations;
        private System.Windows.Forms.Label lblStations;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.DataGridView dataForm;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblSartingTime;
        private System.Windows.Forms.Label lblAddStationsToRoute;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemovStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSequenceNo;
        private System.Windows.Forms.Button btnGetRoute;
    }
}