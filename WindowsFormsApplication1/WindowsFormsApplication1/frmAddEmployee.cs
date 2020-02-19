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
    public partial class frmAddEmployee : Form
    {
       
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        Employee active;
        public frmAddEmployee(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
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
            String[] phoneNo = { txtPhoneNo1.Text, txtPhoneNo2.Text, txtPhoneNo3.Text };
            String[] cellNo = { txtCellNo1.Text, txtCellNo2.Text, txtCellNo3.Text };
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
            emp.setAllowedSignIn(txtAllowedSignin.Text);
            Database db = new Database();
            if (db.addEmployee(emp))
            {
                MessageBox.Show("Employee Successfully Registered!");
                this.Hide();
                frmAdminPanel adminPanel = new frmAdminPanel();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Unable to register employee!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmViewProfile frm = new frmViewProfile(active);
            frm.Show();
        }
    }
}
