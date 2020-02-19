namespace WindowsFormsApplication1
{
    partial class frmEditEmployee
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtAllowedSignin = new System.Windows.Forms.TextBox();
            this.lblAllowedSignin = new System.Windows.Forms.Label();
            this.dateTimePickerDoh = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lablRank = new System.Windows.Forms.Label();
            this.lblDoH = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPhoneNo3 = new System.Windows.Forms.TextBox();
            this.lblPhoneNo3 = new System.Windows.Forms.Label();
            this.txtPhoneNo2 = new System.Windows.Forms.TextBox();
            this.lblPhoneNo2 = new System.Windows.Forms.Label();
            this.txtPhoneNo1 = new System.Windows.Forms.TextBox();
            this.lblPhoneNo1 = new System.Windows.Forms.Label();
            this.lblCellNo3 = new System.Windows.Forms.Label();
            this.lblCellNo2 = new System.Windows.Forms.Label();
            this.txtCellNo3 = new System.Windows.Forms.TextBox();
            this.txtCellNo2 = new System.Windows.Forms.TextBox();
            this.txtCellNo1 = new System.Windows.Forms.TextBox();
            this.lblCellNo1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchEmployeeID = new System.Windows.Forms.TextBox();
            this.txtSearchEmployeeCNIC = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlGender.SuspendLayout();
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
            this.pnlHeader.TabIndex = 7;
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
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnGoBack);
            this.pnlBody.Controls.Add(this.btnProfile);
            this.pnlBody.Controls.Add(this.btnLogout);
            this.pnlBody.Controls.Add(this.pnlMain);
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.lblExplanation);
            this.pnlBody.Controls.Add(this.btnSearch);
            this.pnlBody.Controls.Add(this.txtSearchEmployeeID);
            this.pnlBody.Controls.Add(this.txtSearchEmployeeCNIC);
            this.pnlBody.Controls.Add(this.btnCancel);
            this.pnlBody.Controls.Add(this.btnSubmit);
            this.pnlBody.Controls.Add(this.lblEmployeeID);
            this.pnlBody.Controls.Add(this.lblCNIC);
            this.pnlBody.Location = new System.Drawing.Point(1, 123);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1007, 567);
            this.pnlBody.TabIndex = 8;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBack.Location = new System.Drawing.Point(747, 13);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.Location = new System.Drawing.Point(828, 13);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(909, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Log Out!";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMain.Controls.Add(this.txtAllowedSignin);
            this.pnlMain.Controls.Add(this.lblAllowedSignin);
            this.pnlMain.Controls.Add(this.dateTimePickerDoh);
            this.pnlMain.Controls.Add(this.dateTimePickerDob);
            this.pnlMain.Controls.Add(this.pnlGender);
            this.pnlMain.Controls.Add(this.txtZipCode);
            this.pnlMain.Controls.Add(this.lblZipCode);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.txtStreet);
            this.pnlMain.Controls.Add(this.lblStreet);
            this.pnlMain.Controls.Add(this.txtHouseNo);
            this.pnlMain.Controls.Add(this.lblHouseNo);
            this.pnlMain.Controls.Add(this.txtProvince);
            this.pnlMain.Controls.Add(this.lblProvince);
            this.pnlMain.Controls.Add(this.txtCity);
            this.pnlMain.Controls.Add(this.lblCity);
            this.pnlMain.Controls.Add(this.txtCountry);
            this.pnlMain.Controls.Add(this.lblCountry);
            this.pnlMain.Controls.Add(this.txtSalary);
            this.pnlMain.Controls.Add(this.lblSalary);
            this.pnlMain.Controls.Add(this.txtDesignation);
            this.pnlMain.Controls.Add(this.lblDesignation);
            this.pnlMain.Controls.Add(this.txtRank);
            this.pnlMain.Controls.Add(this.lablRank);
            this.pnlMain.Controls.Add(this.lblDoH);
            this.pnlMain.Controls.Add(this.lblDoB);
            this.pnlMain.Controls.Add(this.txtQualification);
            this.pnlMain.Controls.Add(this.lblQualification);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtPhoneNo3);
            this.pnlMain.Controls.Add(this.lblPhoneNo3);
            this.pnlMain.Controls.Add(this.txtPhoneNo2);
            this.pnlMain.Controls.Add(this.lblPhoneNo2);
            this.pnlMain.Controls.Add(this.txtPhoneNo1);
            this.pnlMain.Controls.Add(this.lblPhoneNo1);
            this.pnlMain.Controls.Add(this.lblCellNo3);
            this.pnlMain.Controls.Add(this.lblCellNo2);
            this.pnlMain.Controls.Add(this.txtCellNo3);
            this.pnlMain.Controls.Add(this.txtCellNo2);
            this.pnlMain.Controls.Add(this.txtCellNo1);
            this.pnlMain.Controls.Add(this.lblCellNo1);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtCNIC);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtLastName);
            this.pnlMain.Controls.Add(this.lblLastName);
            this.pnlMain.Controls.Add(this.txtMiddleName);
            this.pnlMain.Controls.Add(this.lblMiddleName);
            this.pnlMain.Controls.Add(this.txtFirstName);
            this.pnlMain.Controls.Add(this.lblFirstName);
            this.pnlMain.Location = new System.Drawing.Point(1, 160);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1005, 407);
            this.pnlMain.TabIndex = 17;
            // 
            // txtAllowedSignin
            // 
            this.txtAllowedSignin.Location = new System.Drawing.Point(774, 212);
            this.txtAllowedSignin.MaxLength = 1;
            this.txtAllowedSignin.Name = "txtAllowedSignin";
            this.txtAllowedSignin.Size = new System.Drawing.Size(150, 20);
            this.txtAllowedSignin.TabIndex = 64;
            // 
            // lblAllowedSignin
            // 
            this.lblAllowedSignin.AutoSize = true;
            this.lblAllowedSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowedSignin.Location = new System.Drawing.Point(638, 210);
            this.lblAllowedSignin.Name = "lblAllowedSignin";
            this.lblAllowedSignin.Size = new System.Drawing.Size(131, 20);
            this.lblAllowedSignin.TabIndex = 63;
            this.lblAllowedSignin.Text = "Allowed Signin:";
            // 
            // dateTimePickerDoh
            // 
            this.dateTimePickerDoh.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDoh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoh.Location = new System.Drawing.Point(774, 242);
            this.dateTimePickerDoh.Name = "dateTimePickerDoh";
            this.dateTimePickerDoh.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDoh.TabIndex = 62;
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDob.Location = new System.Drawing.Point(160, 241);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDob.TabIndex = 60;
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdoMale);
            this.pnlGender.Controls.Add(this.rdoFemale);
            this.pnlGender.Location = new System.Drawing.Point(160, 209);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(150, 26);
            this.pnlGender.TabIndex = 61;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(24, 3);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 17);
            this.rdoMale.TabIndex = 54;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(92, 3);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(56, 17);
            this.rdoFemale.TabIndex = 55;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(466, 213);
            this.txtZipCode.MaxLength = 9;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(150, 20);
            this.txtZipCode.TabIndex = 51;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(330, 213);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(102, 24);
            this.lblZipCode.TabIndex = 50;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(3, 208);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(86, 24);
            this.lblGender.TabIndex = 48;
            this.lblGender.Text = "Gender:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(774, 182);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(150, 20);
            this.txtStreet.TabIndex = 47;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(639, 182);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(64, 24);
            this.lblStreet.TabIndex = 46;
            this.lblStreet.Text = "Street";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(466, 187);
            this.txtHouseNo.MaxLength = 10;
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(150, 20);
            this.txtHouseNo.TabIndex = 45;
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(330, 183);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(94, 24);
            this.lblHouseNo.TabIndex = 44;
            this.lblHouseNo.Text = "House #:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(160, 183);
            this.txtProvince.MaxLength = 50;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(150, 20);
            this.txtProvince.TabIndex = 43;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(4, 182);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(98, 24);
            this.lblProvince.TabIndex = 42;
            this.lblProvince.Text = "Province:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(774, 153);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 41;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(639, 153);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 24);
            this.lblCity.TabIndex = 40;
            this.lblCity.Text = "City:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(466, 158);
            this.txtCountry.MaxLength = 50;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(150, 20);
            this.txtCountry.TabIndex = 39;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(329, 158);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 24);
            this.lblCountry.TabIndex = 38;
            this.lblCountry.Text = "Country:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(774, 75);
            this.txtSalary.MaxLength = 9;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 20);
            this.txtSalary.TabIndex = 35;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(639, 72);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(73, 24);
            this.lblSalary.TabIndex = 34;
            this.lblSalary.Text = "Salary:";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(466, 72);
            this.txtDesignation.MaxLength = 30;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(150, 20);
            this.txtDesignation.TabIndex = 33;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(329, 72);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(126, 24);
            this.lblDesignation.TabIndex = 32;
            this.lblDesignation.Text = "Designation:";
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(774, 45);
            this.txtRank.MaxLength = 30;
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(150, 20);
            this.txtRank.TabIndex = 31;
            // 
            // lablRank
            // 
            this.lablRank.AutoSize = true;
            this.lablRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablRank.Location = new System.Drawing.Point(639, 45);
            this.lablRank.Name = "lablRank";
            this.lablRank.Size = new System.Drawing.Size(63, 24);
            this.lablRank.TabIndex = 30;
            this.lablRank.Text = "Rank:";
            // 
            // lblDoH
            // 
            this.lblDoH.AutoSize = true;
            this.lblDoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoH.Location = new System.Drawing.Point(638, 236);
            this.lblDoH.Name = "lblDoH";
            this.lblDoH.Size = new System.Drawing.Size(130, 24);
            this.lblDoH.TabIndex = 28;
            this.lblDoH.Text = "Date Of Hire:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(4, 236);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(133, 24);
            this.lblDoB.TabIndex = 27;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(466, 45);
            this.txtQualification.MaxLength = 30;
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(150, 20);
            this.txtQualification.TabIndex = 25;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualification.Location = new System.Drawing.Point(329, 45);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(131, 24);
            this.lblQualification.TabIndex = 24;
            this.lblQualification.Text = "Qualification:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(160, 157);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 23;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 24);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password:";
            // 
            // txtPhoneNo3
            // 
            this.txtPhoneNo3.Location = new System.Drawing.Point(774, 127);
            this.txtPhoneNo3.MaxLength = 12;
            this.txtPhoneNo3.Name = "txtPhoneNo3";
            this.txtPhoneNo3.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNo3.TabIndex = 21;
            // 
            // lblPhoneNo3
            // 
            this.lblPhoneNo3.AutoSize = true;
            this.lblPhoneNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo3.Location = new System.Drawing.Point(639, 127);
            this.lblPhoneNo3.Name = "lblPhoneNo3";
            this.lblPhoneNo3.Size = new System.Drawing.Size(94, 24);
            this.lblPhoneNo3.TabIndex = 20;
            this.lblPhoneNo3.Text = "Phone #:";
            // 
            // txtPhoneNo2
            // 
            this.txtPhoneNo2.Location = new System.Drawing.Point(466, 132);
            this.txtPhoneNo2.MaxLength = 12;
            this.txtPhoneNo2.Name = "txtPhoneNo2";
            this.txtPhoneNo2.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNo2.TabIndex = 19;
            // 
            // lblPhoneNo2
            // 
            this.lblPhoneNo2.AutoSize = true;
            this.lblPhoneNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo2.Location = new System.Drawing.Point(329, 128);
            this.lblPhoneNo2.Name = "lblPhoneNo2";
            this.lblPhoneNo2.Size = new System.Drawing.Size(94, 24);
            this.lblPhoneNo2.TabIndex = 18;
            this.lblPhoneNo2.Text = "Phone #:";
            // 
            // txtPhoneNo1
            // 
            this.txtPhoneNo1.Location = new System.Drawing.Point(160, 127);
            this.txtPhoneNo1.MaxLength = 12;
            this.txtPhoneNo1.Name = "txtPhoneNo1";
            this.txtPhoneNo1.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNo1.TabIndex = 17;
            // 
            // lblPhoneNo1
            // 
            this.lblPhoneNo1.AutoSize = true;
            this.lblPhoneNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo1.Location = new System.Drawing.Point(3, 127);
            this.lblPhoneNo1.Name = "lblPhoneNo1";
            this.lblPhoneNo1.Size = new System.Drawing.Size(94, 24);
            this.lblPhoneNo1.TabIndex = 16;
            this.lblPhoneNo1.Text = "Phone #:";
            // 
            // lblCellNo3
            // 
            this.lblCellNo3.AutoSize = true;
            this.lblCellNo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo3.Location = new System.Drawing.Point(639, 104);
            this.lblCellNo3.Name = "lblCellNo3";
            this.lblCellNo3.Size = new System.Drawing.Size(69, 24);
            this.lblCellNo3.TabIndex = 15;
            this.lblCellNo3.Text = "Cell #:";
            // 
            // lblCellNo2
            // 
            this.lblCellNo2.AutoSize = true;
            this.lblCellNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo2.Location = new System.Drawing.Point(330, 104);
            this.lblCellNo2.Name = "lblCellNo2";
            this.lblCellNo2.Size = new System.Drawing.Size(69, 24);
            this.lblCellNo2.TabIndex = 14;
            this.lblCellNo2.Text = "Cell #:";
            // 
            // txtCellNo3
            // 
            this.txtCellNo3.Location = new System.Drawing.Point(774, 101);
            this.txtCellNo3.MaxLength = 12;
            this.txtCellNo3.Name = "txtCellNo3";
            this.txtCellNo3.Size = new System.Drawing.Size(150, 20);
            this.txtCellNo3.TabIndex = 13;
            // 
            // txtCellNo2
            // 
            this.txtCellNo2.Location = new System.Drawing.Point(466, 103);
            this.txtCellNo2.MaxLength = 12;
            this.txtCellNo2.Name = "txtCellNo2";
            this.txtCellNo2.Size = new System.Drawing.Size(150, 20);
            this.txtCellNo2.TabIndex = 12;
            // 
            // txtCellNo1
            // 
            this.txtCellNo1.Location = new System.Drawing.Point(160, 98);
            this.txtCellNo1.MaxLength = 12;
            this.txtCellNo1.Name = "txtCellNo1";
            this.txtCellNo1.Size = new System.Drawing.Size(150, 20);
            this.txtCellNo1.TabIndex = 11;
            // 
            // lblCellNo1
            // 
            this.lblCellNo1.AutoSize = true;
            this.lblCellNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNo1.Location = new System.Drawing.Point(3, 103);
            this.lblCellNo1.Name = "lblCellNo1";
            this.lblCellNo1.Size = new System.Drawing.Size(69, 24);
            this.lblCellNo1.TabIndex = 10;
            this.lblCellNo1.Text = "Cell #:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(151, 24);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 72);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(160, 46);
            this.txtCNIC.MaxLength = 15;
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.ReadOnly = true;
            this.txtCNIC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCNIC.Size = new System.Drawing.Size(150, 20);
            this.txtCNIC.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CINC #:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(774, 17);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(639, 15);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(114, 24);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(466, 15);
            this.txtMiddleName.MaxLength = 30;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(150, 20);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(329, 20);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(117, 20);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 20);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(4, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(117, 24);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(431, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 24);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Edit Employee";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(34, 48);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(229, 13);
            this.lblExplanation.TabIndex = 15;
            this.lblExplanation.Text = "Enter CNIC/Name or ID of employee to Update";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(333, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEmployeeID
            // 
            this.txtSearchEmployeeID.Location = new System.Drawing.Point(202, 78);
            this.txtSearchEmployeeID.Name = "txtSearchEmployeeID";
            this.txtSearchEmployeeID.Size = new System.Drawing.Size(231, 20);
            this.txtSearchEmployeeID.TabIndex = 12;
            // 
            // txtSearchEmployeeCNIC
            // 
            this.txtSearchEmployeeCNIC.Location = new System.Drawing.Point(597, 75);
            this.txtSearchEmployeeCNIC.Name = "txtSearchEmployeeCNIC";
            this.txtSearchEmployeeCNIC.Size = new System.Drawing.Size(283, 20);
            this.txtSearchEmployeeCNIC.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(566, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(435, 131);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Confirm Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(36, 78);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(116, 20);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblCNIC
            // 
            this.lblCNIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNIC.Location = new System.Drawing.Point(514, 76);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(56, 20);
            this.lblCNIC.TabIndex = 2;
            this.lblCNIC.Text = "CNIC:";
            // 
            // frmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmEditEmployee";
            this.Text = "frmEditEmployee";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderRMS;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEmployeeID;
        private System.Windows.Forms.TextBox txtSearchEmployeeCNIC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label lablRank;
        private System.Windows.Forms.Label lblDoH;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPhoneNo3;
        private System.Windows.Forms.Label lblPhoneNo3;
        private System.Windows.Forms.TextBox txtPhoneNo2;
        private System.Windows.Forms.Label lblPhoneNo2;
        private System.Windows.Forms.TextBox txtPhoneNo1;
        private System.Windows.Forms.Label lblPhoneNo1;
        private System.Windows.Forms.Label lblCellNo3;
        private System.Windows.Forms.Label lblCellNo2;
        private System.Windows.Forms.TextBox txtCellNo3;
        private System.Windows.Forms.TextBox txtCellNo2;
        private System.Windows.Forms.TextBox txtCellNo1;
        private System.Windows.Forms.Label lblCellNo1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtAllowedSignin;
        private System.Windows.Forms.Label lblAllowedSignin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoh;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
    }
}