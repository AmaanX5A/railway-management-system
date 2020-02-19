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
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }
         Employee active;
        public frmEditEmployee(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Employee emp = db.searchEmployee(txtSearchEmployeeID.Text);
            try
            {
                txtFirstName.Text = emp.getPersonalInformation().getFirstName();
                txtMiddleName.Text = emp.getPersonalInformation().getMiddleName();
                txtLastName.Text = emp.getPersonalInformation().getLastName();
                txtCNIC.Text = emp.getPersonalInformation().getCNIC();
                txtQualification.Text = emp.getQualification();
                txtRank.Text = emp.getRank();
                txtSalary.Text = emp.getSalary().ToString();
                txtEmail.Text = emp.getPersonalInformation().getEmail();
                txtDesignation.Text = emp.getDesignation();
                txtPassword.Text = emp.getPassword();
                txtAllowedSignin.Text = emp.getAllowedSignIn();
                if (emp.getPersonalInformation().getGender().Equals("male"))
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                dateTimePickerDob.Text = emp.getPersonalInformation().getDateOfBirth().Date.ToString();
                dateTimePickerDoh.Text = emp.getDateOfHire().Date.ToString();
                txtCountry.Text = emp.getAddress().getCountry();
                txtCity.Text = emp.getAddress().getCity();
                txtProvince.Text = emp.getAddress().getProvince();
                txtStreet.Text = emp.getAddress().getStreet();
                txtHouseNo.Text = emp.getAddress().getHouseNo();
                txtZipCode.Text = emp.getAddress().getZipCode().ToString();
                int i = 0, j = 0;
                while (i < emp.getPersonalInformation().getPhoneNo().Length || j < emp.getPersonalInformation().getCellNo().Length)
                {
                    if (i < emp.getPersonalInformation().getPhoneNo().Length)
                    {
                        if (i == 0)
                        {
                            txtPhoneNo1.Text = emp.getPersonalInformation().getPhoneNo()[i];
                        }
                        else if (i == 1)
                        {
                            txtPhoneNo2.Text = emp.getPersonalInformation().getPhoneNo()[i];
                        }
                        else if (i == 2)
                        {
                            txtPhoneNo3.Text = emp.getPersonalInformation().getPhoneNo()[i];
                        }
                        i++;
                    }
                    if (j < emp.getPersonalInformation().getCellNo().Length)
                    {
                        if (j == 0)
                        {
                            txtCellNo1.Text = emp.getPersonalInformation().getCellNo()[j];
                        }
                        else if (j == 1)
                        {
                            txtCellNo2.Text = emp.getPersonalInformation().getCellNo()[j];
                        }
                        else if (j == 2)
                        {
                            txtCellNo3.Text = emp.getPersonalInformation().getCellNo()[j];
                        }
                        j++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            emp.setEmp_id(int.Parse(txtSearchEmployeeID.Text));
            Database db = new Database();
            if (db.editEmployee(emp))
            {
                MessageBox.Show("Employee Successfully Registered!");
               
            }
            else
            {
                MessageBox.Show("Unable to register employee!");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(active);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }
        }
    
}
