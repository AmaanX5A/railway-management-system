namespace WindowsFormsApplication1
{
    partial class frmAdminPanel
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
            this.statusStripAdminPanel = new System.Windows.Forms.StatusStrip();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderRMS = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.BtnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout1 = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSetCoachesToTrain = new System.Windows.Forms.Button();
            this.btnTrainDetails = new System.Windows.Forms.Button();
            this.btnRemoveStation = new System.Windows.Forms.Button();
            this.btnSearchStation = new System.Windows.Forms.Button();
            this.btnAddCoaches = new System.Windows.Forms.Button();
            this.btnRemoveRoute = new System.Windows.Forms.Button();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnSearchRoute = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.btnSearchSchedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.btnSearchPassenger = new System.Windows.Forms.Button();
            this.btnRemovePassenger = new System.Windows.Forms.Button();
            this.btnSearchTrain = new System.Windows.Forms.Button();
            this.btnEditTrain = new System.Windows.Forms.Button();
            this.btnRemoveTrain = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnStationDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripAdminPanel
            // 
            this.statusStripAdminPanel.Location = new System.Drawing.Point(0, 675);
            this.statusStripAdminPanel.Name = "statusStripAdminPanel";
            this.statusStripAdminPanel.Size = new System.Drawing.Size(1008, 22);
            this.statusStripAdminPanel.TabIndex = 0;
            this.statusStripAdminPanel.Text = "status Strip Admin Panel";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.Aqua;
            this.pnlHeader.Controls.Add(this.lblHeaderRMS);
            this.pnlHeader.Location = new System.Drawing.Point(0, -21);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 112);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblHeaderRMS
            // 
            this.lblHeaderRMS.AutoSize = true;
            this.lblHeaderRMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRMS.Location = new System.Drawing.Point(115, 31);
            this.lblHeaderRMS.Name = "lblHeaderRMS";
            this.lblHeaderRMS.Size = new System.Drawing.Size(685, 55);
            this.lblHeaderRMS.TabIndex = 2;
            this.lblHeaderRMS.Text = "Railway Management System";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBody.Controls.Add(this.BtnViewProfile);
            this.pnlBody.Controls.Add(this.btnLogout1);
            this.pnlBody.Controls.Add(this.pnlMain);
            this.pnlBody.Location = new System.Drawing.Point(0, 97);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1008, 575);
            this.pnlBody.TabIndex = 2;
            // 
            // BtnViewProfile
            // 
            this.BtnViewProfile.Location = new System.Drawing.Point(890, 9);
            this.BtnViewProfile.Name = "BtnViewProfile";
            this.BtnViewProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnViewProfile.TabIndex = 4;
            this.BtnViewProfile.Text = "View Profile";
            this.BtnViewProfile.UseVisualStyleBackColor = true;
            this.BtnViewProfile.Click += new System.EventHandler(this.BtnViewProfile_Click);
            // 
            // btnLogout1
            // 
            this.btnLogout1.Location = new System.Drawing.Point(799, 9);
            this.btnLogout1.Name = "btnLogout1";
            this.btnLogout1.Size = new System.Drawing.Size(75, 23);
            this.btnLogout1.TabIndex = 3;
            this.btnLogout1.Text = "Log Out";
            this.btnLogout1.UseVisualStyleBackColor = true;
            this.btnLogout1.Click += new System.EventHandler(this.btnLogout1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.btnSetCoachesToTrain);
            this.pnlMain.Controls.Add(this.btnTrainDetails);
            this.pnlMain.Controls.Add(this.btnRemoveStation);
            this.pnlMain.Controls.Add(this.btnSearchStation);
            this.pnlMain.Controls.Add(this.btnAddCoaches);
            this.pnlMain.Controls.Add(this.btnRemoveRoute);
            this.pnlMain.Controls.Add(this.btnEditRoute);
            this.pnlMain.Controls.Add(this.btnSearchRoute);
            this.pnlMain.Controls.Add(this.btnAddRoute);
            this.pnlMain.Controls.Add(this.btnAddStation);
            this.pnlMain.Controls.Add(this.btnEmployeeDetails);
            this.pnlMain.Controls.Add(this.btnSearchSchedule);
            this.pnlMain.Controls.Add(this.btnRemoveSchedule);
            this.pnlMain.Controls.Add(this.btnSearchPassenger);
            this.pnlMain.Controls.Add(this.btnRemovePassenger);
            this.pnlMain.Controls.Add(this.btnSearchTrain);
            this.pnlMain.Controls.Add(this.btnEditTrain);
            this.pnlMain.Controls.Add(this.btnRemoveTrain);
            this.pnlMain.Controls.Add(this.btnAddTrain);
            this.pnlMain.Controls.Add(this.btnSearchEmployee);
            this.pnlMain.Controls.Add(this.btnEditEmployee);
            this.pnlMain.Controls.Add(this.btnRemoveEmployee);
            this.pnlMain.Controls.Add(this.btnAddEmployee);
            this.pnlMain.Controls.Add(this.btnAddSchedule);
            this.pnlMain.Controls.Add(this.btnStationDetails);
            this.pnlMain.Font = new System.Drawing.Font("Hobo Std", 8.25F);
            this.pnlMain.Location = new System.Drawing.Point(12, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 537);
            this.pnlMain.TabIndex = 2;
            // 
            // btnSetCoachesToTrain
            // 
            this.btnSetCoachesToTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCoachesToTrain.Location = new System.Drawing.Point(390, 419);
            this.btnSetCoachesToTrain.Name = "btnSetCoachesToTrain";
            this.btnSetCoachesToTrain.Size = new System.Drawing.Size(190, 34);
            this.btnSetCoachesToTrain.TabIndex = 26;
            this.btnSetCoachesToTrain.Text = "Set Coaches to Train";
            this.btnSetCoachesToTrain.UseVisualStyleBackColor = true;
            this.btnSetCoachesToTrain.Click += new System.EventHandler(this.btnSetCoachesToTrain_Click);
            // 
            // btnTrainDetails
            // 
            this.btnTrainDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainDetails.Location = new System.Drawing.Point(27, 419);
            this.btnTrainDetails.Name = "btnTrainDetails";
            this.btnTrainDetails.Size = new System.Drawing.Size(155, 35);
            this.btnTrainDetails.TabIndex = 25;
            this.btnTrainDetails.Text = "Train Details";
            this.btnTrainDetails.UseVisualStyleBackColor = true;
            this.btnTrainDetails.Click += new System.EventHandler(this.btnTrainDetails_Click);
            // 
            // btnRemoveStation
            // 
            this.btnRemoveStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStation.Location = new System.Drawing.Point(390, 343);
            this.btnRemoveStation.Name = "btnRemoveStation";
            this.btnRemoveStation.Size = new System.Drawing.Size(190, 31);
            this.btnRemoveStation.TabIndex = 24;
            this.btnRemoveStation.Text = "Remove Station";
            this.btnRemoveStation.UseVisualStyleBackColor = true;
            this.btnRemoveStation.Click += new System.EventHandler(this.btnRemoveStation_Click);
            // 
            // btnSearchStation
            // 
            this.btnSearchStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStation.Location = new System.Drawing.Point(27, 460);
            this.btnSearchStation.Name = "btnSearchStation";
            this.btnSearchStation.Size = new System.Drawing.Size(155, 33);
            this.btnSearchStation.TabIndex = 23;
            this.btnSearchStation.Text = "Search Station";
            this.btnSearchStation.UseVisualStyleBackColor = true;
            this.btnSearchStation.Click += new System.EventHandler(this.btnSearchStation_Click);
            // 
            // btnAddCoaches
            // 
            this.btnAddCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoaches.Location = new System.Drawing.Point(27, 380);
            this.btnAddCoaches.Name = "btnAddCoaches";
            this.btnAddCoaches.Size = new System.Drawing.Size(155, 33);
            this.btnAddCoaches.TabIndex = 22;
            this.btnAddCoaches.Text = "Add Coaches";
            this.btnAddCoaches.UseVisualStyleBackColor = true;
            this.btnAddCoaches.Click += new System.EventHandler(this.btnSetCoaches_Click);
            // 
            // btnRemoveRoute
            // 
            this.btnRemoveRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRoute.Location = new System.Drawing.Point(390, 309);
            this.btnRemoveRoute.Name = "btnRemoveRoute";
            this.btnRemoveRoute.Size = new System.Drawing.Size(190, 28);
            this.btnRemoveRoute.TabIndex = 21;
            this.btnRemoveRoute.Text = "Remove Route";
            this.btnRemoveRoute.UseVisualStyleBackColor = true;
            this.btnRemoveRoute.Click += new System.EventHandler(this.btnRemoveRoute_Click);
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoute.Location = new System.Drawing.Point(390, 276);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(190, 27);
            this.btnEditRoute.TabIndex = 20;
            this.btnEditRoute.Text = "Edit Route";
            this.btnEditRoute.UseVisualStyleBackColor = true;
            this.btnEditRoute.Click += new System.EventHandler(this.btnEditRoute_Click);
            // 
            // btnSearchRoute
            // 
            this.btnSearchRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoute.Location = new System.Drawing.Point(390, 237);
            this.btnSearchRoute.Name = "btnSearchRoute";
            this.btnSearchRoute.Size = new System.Drawing.Size(190, 33);
            this.btnSearchRoute.TabIndex = 19;
            this.btnSearchRoute.Text = "Search Route";
            this.btnSearchRoute.UseVisualStyleBackColor = true;
            this.btnSearchRoute.Click += new System.EventHandler(this.btnSearchRoute_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoute.Location = new System.Drawing.Point(390, 202);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(190, 29);
            this.btnAddRoute.TabIndex = 18;
            this.btnAddRoute.Text = "Add Route";
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStation.Location = new System.Drawing.Point(390, 162);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(190, 30);
            this.btnAddStation.TabIndex = 17;
            this.btnAddStation.Text = "Add Station";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDetails.Location = new System.Drawing.Point(390, 124);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(190, 32);
            this.btnEmployeeDetails.TabIndex = 16;
            this.btnEmployeeDetails.Text = "Employee Details";
            this.btnEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            // 
            // btnSearchSchedule
            // 
            this.btnSearchSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSchedule.Location = new System.Drawing.Point(390, 90);
            this.btnSearchSchedule.Name = "btnSearchSchedule";
            this.btnSearchSchedule.Size = new System.Drawing.Size(190, 28);
            this.btnSearchSchedule.TabIndex = 15;
            this.btnSearchSchedule.Text = "Search Schedule";
            this.btnSearchSchedule.UseVisualStyleBackColor = true;
            this.btnSearchSchedule.Click += new System.EventHandler(this.btnSearchSchedule_Click);
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSchedule.Location = new System.Drawing.Point(390, 49);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(190, 31);
            this.btnRemoveSchedule.TabIndex = 14;
            this.btnRemoveSchedule.Text = "Remove Schedule";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
            // 
            // btnSearchPassenger
            // 
            this.btnSearchPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPassenger.Location = new System.Drawing.Point(390, 13);
            this.btnSearchPassenger.Name = "btnSearchPassenger";
            this.btnSearchPassenger.Size = new System.Drawing.Size(190, 30);
            this.btnSearchPassenger.TabIndex = 13;
            this.btnSearchPassenger.Text = "Search Passenger";
            this.btnSearchPassenger.UseVisualStyleBackColor = true;
            this.btnSearchPassenger.Click += new System.EventHandler(this.btnSearchPassenger_Click);
            // 
            // btnRemovePassenger
            // 
            this.btnRemovePassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePassenger.Location = new System.Drawing.Point(390, 380);
            this.btnRemovePassenger.Name = "btnRemovePassenger";
            this.btnRemovePassenger.Size = new System.Drawing.Size(190, 34);
            this.btnRemovePassenger.TabIndex = 12;
            this.btnRemovePassenger.Text = "Remove Passenger";
            this.btnRemovePassenger.UseVisualStyleBackColor = true;
            this.btnRemovePassenger.Click += new System.EventHandler(this.btnRemovePassenger_Click);
            // 
            // btnSearchTrain
            // 
            this.btnSearchTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTrain.Location = new System.Drawing.Point(27, 343);
            this.btnSearchTrain.Name = "btnSearchTrain";
            this.btnSearchTrain.Size = new System.Drawing.Size(155, 31);
            this.btnSearchTrain.TabIndex = 10;
            this.btnSearchTrain.Text = "Search Train";
            this.btnSearchTrain.UseVisualStyleBackColor = true;
            this.btnSearchTrain.Click += new System.EventHandler(this.btnSearchTrain_Click);
            // 
            // btnEditTrain
            // 
            this.btnEditTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTrain.Location = new System.Drawing.Point(27, 309);
            this.btnEditTrain.Name = "btnEditTrain";
            this.btnEditTrain.Size = new System.Drawing.Size(155, 28);
            this.btnEditTrain.TabIndex = 9;
            this.btnEditTrain.Text = "Edit Train";
            this.btnEditTrain.UseVisualStyleBackColor = true;
            this.btnEditTrain.Click += new System.EventHandler(this.btnEditTrain_Click);
            // 
            // btnRemoveTrain
            // 
            this.btnRemoveTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTrain.Location = new System.Drawing.Point(27, 271);
            this.btnRemoveTrain.Name = "btnRemoveTrain";
            this.btnRemoveTrain.Size = new System.Drawing.Size(155, 32);
            this.btnRemoveTrain.TabIndex = 8;
            this.btnRemoveTrain.Text = "Remove Train";
            this.btnRemoveTrain.UseVisualStyleBackColor = true;
            this.btnRemoveTrain.Click += new System.EventHandler(this.btnRemoveTrain_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrain.Location = new System.Drawing.Point(27, 237);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(155, 28);
            this.btnAddTrain.TabIndex = 7;
            this.btnAddTrain.Text = "Add Train";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(27, 202);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(155, 29);
            this.btnSearchEmployee.TabIndex = 6;
            this.btnSearchEmployee.Text = "Search Employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(27, 162);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(155, 30);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(27, 124);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(155, 32);
            this.btnRemoveEmployee.TabIndex = 4;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(27, 86);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(155, 32);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Location = new System.Drawing.Point(27, 49);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(155, 31);
            this.btnAddSchedule.TabIndex = 2;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnStationDetails
            // 
            this.btnStationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStationDetails.Location = new System.Drawing.Point(27, 13);
            this.btnStationDetails.Name = "btnStationDetails";
            this.btnStationDetails.Size = new System.Drawing.Size(155, 30);
            this.btnStationDetails.TabIndex = 0;
            this.btnStationDetails.Text = "Station Details";
            this.btnStationDetails.UseVisualStyleBackColor = true;
            this.btnStationDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Stations To Route";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStripAdminPanel);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.adminrolepage_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripAdminPanel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnStationDetails;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnRemovePassenger;
        private System.Windows.Forms.Button btnSearchTrain;
        private System.Windows.Forms.Button btnEditTrain;
        private System.Windows.Forms.Button btnRemoveTrain;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Button btnSearchPassenger;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.Button btnEmployeeDetails;
        private System.Windows.Forms.Button btnSearchSchedule;
        private System.Windows.Forms.Button btnSearchRoute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnRemoveRoute;
        private System.Windows.Forms.Button btnAddCoaches;
        private System.Windows.Forms.Button btnRemoveStation;
        private System.Windows.Forms.Button btnSearchStation;
        private System.Windows.Forms.Button btnTrainDetails;
        private System.Windows.Forms.Button BtnViewProfile;
        private System.Windows.Forms.Button btnLogout1;
        private System.Windows.Forms.Button btnSetCoachesToTrain;
        private System.Windows.Forms.Button button1;
    }
}