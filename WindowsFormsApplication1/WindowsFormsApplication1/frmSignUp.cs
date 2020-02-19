using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void hireClendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String gender = null;
            if (rdoMale.Checked && !rdoFemale.Checked)
            {
                gender = "male";
            }
            else if (!rdoMale.Checked && rdoFemale.Checked)
            {
                gender = "female";
            }
            else if (rdoMale.Checked && rdoFemale.Checked)
            {
                MessageBox.Show("Error Invalid Selection: Select only one gender!");
                return;
            }
            else
            {
                MessageBox.Show("Please Select a gender!");
                return;
            }

            Person person = new Person();
            EmployeeAddress address = new EmployeeAddress();
            person.setFirstName(txtFirstName.Text);
            person.setMiddleName(txtMiddleName.Text);
            person.setLastName(txtLastName.Text);
            String[] phoneNo = { txtPhoneNo1.Text, txtPhoneNo2.Text, txtPhoneNo3.Text};
            String[] cellNo = {txtCellNo1.Text, txtCellNo2.Text, txtCellNo3.Text};
            person.setPhoneNo(phoneNo);
            person.setCellNo(cellNo);
            person.setCNIC(txtCNIC.Text);
            person.setGender(gender);
            person.setEmail(txtEmail.Text);
            person.setDateOfBirth(dateTimePickerDob.Value);
            address.setCity(txtCity.Text);
            address.setCountry(txtCountry.Text);
            address.setHouseNo(txtHouseNo.Text);
            address.setStreet(txtStreet.Text);
            address.setZipCode(int.Parse(txtZipCode.Text));
            address.setProvince(txtProvince.Text);
            Employee emp = new Employee();
            emp.setPersonalInformation(person);
            emp.setAddress(address);
            emp.setDesignation(txtDesignation.Text);
            emp.setRank(txtRank.Text);
            emp.setQualification(txtQualification.Text);
            emp.setPassword(txtPassword.Text);
            emp.setSalary(int.Parse(txtSalary.Text));
            emp.setDateOfHire(dateTimePickerDoh.Value);
            Database db = new Database();
            if (db.insertEmployee(emp))
            {
                MessageBox.Show("Employee Successfully Registered! Wait for approval");
                this.Hide();
                frmMainPanel mainPanel = new frmMainPanel();
                mainPanel.Show();
            }
            else {
                MessageBox.Show("Unable to register employee!");
            }

        }

        private void lblSalary_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void dateTimePickerDoh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
