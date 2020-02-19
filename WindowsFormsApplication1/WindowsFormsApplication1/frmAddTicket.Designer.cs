namespace WindowsFormsApplication1
{
    partial class frmAddTicket
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
            this.txtPassengerID = new System.Windows.Forms.TextBox();
            this.lblPassengerID = new System.Windows.Forms.Label();
            this.lblSeatNo = new System.Windows.Forms.Label();
            this.txtSeatNo = new System.Windows.Forms.TextBox();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmboDestinationStation = new System.Windows.Forms.ComboBox();
            this.lblDestinationStation = new System.Windows.Forms.Label();
            this.cmboSourceStation = new System.Windows.Forms.ComboBox();
            this.lblSourceStation = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAddTicket = new System.Windows.Forms.Label();
            this.btnsubmitTicket = new System.Windows.Forms.Button();
            this.btnSearchAvailablility = new System.Windows.Forms.Button();
            this.lblScheduleID = new System.Windows.Forms.Label();
            this.cmboScheduleID = new System.Windows.Forms.ComboBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblSeatsBooked = new System.Windows.Forms.Label();
            this.txtSeatsBooked = new System.Windows.Forms.TextBox();
            this.txtTrain = new System.Windows.Forms.TextBox();
            this.lblSelectCoachType = new System.Windows.Forms.Label();
            this.cmboCoachType = new System.Windows.Forms.ComboBox();
            this.lblFare = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.btnCalculateFare = new System.Windows.Forms.Button();
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
            this.pnlMainBody.Controls.Add(this.btnCalculateFare);
            this.pnlMainBody.Controls.Add(this.lblFare);
            this.pnlMainBody.Controls.Add(this.txtFare);
            this.pnlMainBody.Controls.Add(this.lblSelectCoachType);
            this.pnlMainBody.Controls.Add(this.cmboCoachType);
            this.pnlMainBody.Controls.Add(this.txtTrain);
            this.pnlMainBody.Controls.Add(this.lblSeatsBooked);
            this.pnlMainBody.Controls.Add(this.txtSeatsBooked);
            this.pnlMainBody.Controls.Add(this.lblSerialNo);
            this.pnlMainBody.Controls.Add(this.txtSerialNo);
            this.pnlMainBody.Controls.Add(this.cmboScheduleID);
            this.pnlMainBody.Controls.Add(this.lblScheduleID);
            this.pnlMainBody.Controls.Add(this.txtPassengerID);
            this.pnlMainBody.Controls.Add(this.lblPassengerID);
            this.pnlMainBody.Controls.Add(this.lblSeatNo);
            this.pnlMainBody.Controls.Add(this.txtSeatNo);
            this.pnlMainBody.Controls.Add(this.lblTrain);
            this.pnlMainBody.Controls.Add(this.lblDate);
            this.pnlMainBody.Controls.Add(this.date);
            this.pnlMainBody.Controls.Add(this.cmboDestinationStation);
            this.pnlMainBody.Controls.Add(this.lblDestinationStation);
            this.pnlMainBody.Controls.Add(this.cmboSourceStation);
            this.pnlMainBody.Controls.Add(this.lblSourceStation);
            this.pnlMainBody.Controls.Add(this.btnGoBack);
            this.pnlMainBody.Controls.Add(this.btnProfile);
            this.pnlMainBody.Controls.Add(this.btnLogout);
            this.pnlMainBody.Controls.Add(this.lblAddTicket);
            this.pnlMainBody.Controls.Add(this.btnsubmitTicket);
            this.pnlMainBody.Controls.Add(this.btnSearchAvailablility);
            this.pnlMainBody.Location = new System.Drawing.Point(1, 123);
            this.pnlMainBody.Name = "pnlMainBody";
            this.pnlMainBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlMainBody.TabIndex = 10;
            // 
            // txtPassengerID
            // 
            this.txtPassengerID.Location = new System.Drawing.Point(740, 234);
            this.txtPassengerID.Name = "txtPassengerID";
            this.txtPassengerID.Size = new System.Drawing.Size(119, 20);
            this.txtPassengerID.TabIndex = 30;
            // 
            // lblPassengerID
            // 
            this.lblPassengerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassengerID.AutoSize = true;
            this.lblPassengerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerID.Location = new System.Drawing.Point(533, 232);
            this.lblPassengerID.Name = "lblPassengerID";
            this.lblPassengerID.Size = new System.Drawing.Size(123, 20);
            this.lblPassengerID.TabIndex = 29;
            this.lblPassengerID.Text = "Passenger ID:";
            // 
            // lblSeatNo
            // 
            this.lblSeatNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeatNo.AutoSize = true;
            this.lblSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatNo.Location = new System.Drawing.Point(48, 207);
            this.lblSeatNo.Name = "lblSeatNo";
            this.lblSeatNo.Size = new System.Drawing.Size(74, 20);
            this.lblSeatNo.TabIndex = 28;
            this.lblSeatNo.Text = "SeatNo:";
            // 
            // txtSeatNo
            // 
            this.txtSeatNo.Location = new System.Drawing.Point(215, 207);
            this.txtSeatNo.MaxLength = 10;
            this.txtSeatNo.Name = "txtSeatNo";
            this.txtSeatNo.Size = new System.Drawing.Size(137, 20);
            this.txtSeatNo.TabIndex = 27;
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrain.AutoSize = true;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(533, 194);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(54, 20);
            this.lblTrain.TabIndex = 25;
            this.lblTrain.Text = "Train:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(47, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 20);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date:";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(155, 46);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(104, 20);
            this.date.TabIndex = 19;
            // 
            // cmboDestinationStation
            // 
            this.cmboDestinationStation.FormattingEnabled = true;
            this.cmboDestinationStation.Location = new System.Drawing.Point(740, 163);
            this.cmboDestinationStation.Name = "cmboDestinationStation";
            this.cmboDestinationStation.Size = new System.Drawing.Size(119, 21);
            this.cmboDestinationStation.TabIndex = 18;
            // 
            // lblDestinationStation
            // 
            this.lblDestinationStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinationStation.AutoSize = true;
            this.lblDestinationStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationStation.Location = new System.Drawing.Point(533, 164);
            this.lblDestinationStation.Name = "lblDestinationStation";
            this.lblDestinationStation.Size = new System.Drawing.Size(169, 20);
            this.lblDestinationStation.TabIndex = 17;
            this.lblDestinationStation.Text = "Destination Station:";
            // 
            // cmboSourceStation
            // 
            this.cmboSourceStation.FormattingEnabled = true;
            this.cmboSourceStation.Location = new System.Drawing.Point(215, 160);
            this.cmboSourceStation.Name = "cmboSourceStation";
            this.cmboSourceStation.Size = new System.Drawing.Size(137, 21);
            this.cmboSourceStation.TabIndex = 16;
            // 
            // lblSourceStation
            // 
            this.lblSourceStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSourceStation.AutoSize = true;
            this.lblSourceStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceStation.Location = new System.Drawing.Point(48, 160);
            this.lblSourceStation.Name = "lblSourceStation";
            this.lblSourceStation.Size = new System.Drawing.Size(134, 20);
            this.lblSourceStation.TabIndex = 15;
            this.lblSourceStation.Text = "Source Station:";
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
            // lblAddTicket
            // 
            this.lblAddTicket.AutoSize = true;
            this.lblAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTicket.Location = new System.Drawing.Point(464, 10);
            this.lblAddTicket.Name = "lblAddTicket";
            this.lblAddTicket.Size = new System.Drawing.Size(110, 24);
            this.lblAddTicket.TabIndex = 10;
            this.lblAddTicket.Text = "Add Ticket";
            // 
            // btnsubmitTicket
            // 
            this.btnsubmitTicket.Location = new System.Drawing.Point(260, 304);
            this.btnsubmitTicket.Name = "btnsubmitTicket";
            this.btnsubmitTicket.Size = new System.Drawing.Size(104, 23);
            this.btnsubmitTicket.TabIndex = 9;
            this.btnsubmitTicket.Text = "Submit Ticket";
            this.btnsubmitTicket.UseVisualStyleBackColor = true;
            this.btnsubmitTicket.Click += new System.EventHandler(this.btnsubmitTicket_Click);
            // 
            // btnSearchAvailablility
            // 
            this.btnSearchAvailablility.Location = new System.Drawing.Point(436, 85);
            this.btnSearchAvailablility.Name = "btnSearchAvailablility";
            this.btnSearchAvailablility.Size = new System.Drawing.Size(104, 23);
            this.btnSearchAvailablility.TabIndex = 8;
            this.btnSearchAvailablility.Text = "Search Availablility";
            this.btnSearchAvailablility.UseVisualStyleBackColor = true;
            this.btnSearchAvailablility.Click += new System.EventHandler(this.btnSearchAvailablility_Click);
            // 
            // lblScheduleID
            // 
            this.lblScheduleID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScheduleID.AutoSize = true;
            this.lblScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleID.Location = new System.Drawing.Point(315, 46);
            this.lblScheduleID.Name = "lblScheduleID";
            this.lblScheduleID.Size = new System.Drawing.Size(113, 20);
            this.lblScheduleID.TabIndex = 31;
            this.lblScheduleID.Text = "Schedule ID:";
            // 
            // cmboScheduleID
            // 
            this.cmboScheduleID.FormattingEnabled = true;
            this.cmboScheduleID.Location = new System.Drawing.Point(436, 45);
            this.cmboScheduleID.Name = "cmboScheduleID";
            this.cmboScheduleID.Size = new System.Drawing.Size(138, 21);
            this.cmboScheduleID.TabIndex = 32;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.Location = new System.Drawing.Point(533, 130);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(87, 20);
            this.lblSerialNo.TabIndex = 34;
            this.lblSerialNo.Text = "Serial No:";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(740, 130);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.ReadOnly = true;
            this.txtSerialNo.Size = new System.Drawing.Size(119, 20);
            this.txtSerialNo.TabIndex = 33;
            // 
            // lblSeatsBooked
            // 
            this.lblSeatsBooked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeatsBooked.AutoSize = true;
            this.lblSeatsBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatsBooked.Location = new System.Drawing.Point(48, 128);
            this.lblSeatsBooked.Name = "lblSeatsBooked";
            this.lblSeatsBooked.Size = new System.Drawing.Size(127, 20);
            this.lblSeatsBooked.TabIndex = 36;
            this.lblSeatsBooked.Text = "Seats Booked:";
            // 
            // txtSeatsBooked
            // 
            this.txtSeatsBooked.Location = new System.Drawing.Point(215, 130);
            this.txtSeatsBooked.Name = "txtSeatsBooked";
            this.txtSeatsBooked.ReadOnly = true;
            this.txtSeatsBooked.Size = new System.Drawing.Size(137, 20);
            this.txtSeatsBooked.TabIndex = 35;
            // 
            // txtTrain
            // 
            this.txtTrain.Location = new System.Drawing.Point(740, 196);
            this.txtTrain.Name = "txtTrain";
            this.txtTrain.ReadOnly = true;
            this.txtTrain.Size = new System.Drawing.Size(119, 20);
            this.txtTrain.TabIndex = 37;
            // 
            // lblSelectCoachType
            // 
            this.lblSelectCoachType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectCoachType.AutoSize = true;
            this.lblSelectCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCoachType.Location = new System.Drawing.Point(48, 242);
            this.lblSelectCoachType.Name = "lblSelectCoachType";
            this.lblSelectCoachType.Size = new System.Drawing.Size(89, 20);
            this.lblSelectCoachType.TabIndex = 39;
            this.lblSelectCoachType.Text = "Coach ID:";
            // 
            // cmboCoachType
            // 
            this.cmboCoachType.FormattingEnabled = true;
            this.cmboCoachType.Location = new System.Drawing.Point(214, 244);
            this.cmboCoachType.Name = "cmboCoachType";
            this.cmboCoachType.Size = new System.Drawing.Size(137, 21);
            this.cmboCoachType.TabIndex = 38;
            // 
            // lblFare
            // 
            this.lblFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.Location = new System.Drawing.Point(533, 264);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(51, 20);
            this.lblFare.TabIndex = 41;
            this.lblFare.Text = "Fare:";
            // 
            // txtFare
            // 
            this.txtFare.Location = new System.Drawing.Point(740, 264);
            this.txtFare.Name = "txtFare";
            this.txtFare.ReadOnly = true;
            this.txtFare.Size = new System.Drawing.Size(119, 20);
            this.txtFare.TabIndex = 40;
            // 
            // btnCalculateFare
            // 
            this.btnCalculateFare.Location = new System.Drawing.Point(456, 304);
            this.btnCalculateFare.Name = "btnCalculateFare";
            this.btnCalculateFare.Size = new System.Drawing.Size(104, 23);
            this.btnCalculateFare.TabIndex = 42;
            this.btnCalculateFare.Text = "Calculate Fare";
            this.btnCalculateFare.UseVisualStyleBackColor = true;
            this.btnCalculateFare.Click += new System.EventHandler(this.btnCalculateFare_Click);
            // 
            // frmAddTicket
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
            this.Name = "frmAddTicket";
            this.Text = "frmAddTicket";
            this.Load += new System.EventHandler(this.frmAddTicket_Load);
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
        private System.Windows.Forms.Label lblAddTicket;
        private System.Windows.Forms.Button btnsubmitTicket;
        private System.Windows.Forms.Button btnSearchAvailablility;
        private System.Windows.Forms.ComboBox cmboDestinationStation;
        private System.Windows.Forms.Label lblDestinationStation;
        private System.Windows.Forms.ComboBox cmboSourceStation;
        private System.Windows.Forms.Label lblSourceStation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblSeatNo;
        private System.Windows.Forms.TextBox txtSeatNo;
        private System.Windows.Forms.TextBox txtPassengerID;
        private System.Windows.Forms.Label lblPassengerID;
        private System.Windows.Forms.ComboBox cmboScheduleID;
        private System.Windows.Forms.Label lblScheduleID;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label lblSeatsBooked;
        private System.Windows.Forms.TextBox txtSeatsBooked;
        private System.Windows.Forms.TextBox txtTrain;
        private System.Windows.Forms.Label lblSelectCoachType;
        private System.Windows.Forms.ComboBox cmboCoachType;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Button btnCalculateFare;
    }
}