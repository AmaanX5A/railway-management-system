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
    public partial class frmViewProfile : Form
    {
        Employee emp;
        public frmViewProfile()
        {
            InitializeComponent();
        }
        public frmViewProfile(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }
        public void loadProfile()
        {
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
                Database db = new Database();
                txtID.Text = "" + emp.getEmp_id();
               }
                catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
                }
        }

        private void frmViewProfile_Load(object sender, EventArgs e)
        {
            loadProfile();
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if (emp.getDesignation().Equals("Admin"))
            {
                frmAdminPanel frm = new frmAdminPanel(emp);
                frm.Show();
            }
            else if (emp.getDesignation().Equals("Manager"))
            {
                frmGMPanel frm = new frmGMPanel(emp);
                frm.Show();
            }
            else if (emp.getDesignation().Equals("Operator"))
            {
                frmOperatorPanel frm = new frmOperatorPanel(emp);
                frm.Show();
            }
            else
            {
                frmMainPanel frm = new frmMainPanel();
                this.Hide();
                frm.Show();
            
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel frm = new frmMainPanel();
            this.Hide();
            frm.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtCity.ReadOnly = false;
            txtCNIC.ReadOnly = false;
            txtCountry.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtProvince.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtHouseNo.ReadOnly = false;
            txtLastName.ReadOnly =  false;
            txtMiddleName.ReadOnly = false;
            txtQualification.ReadOnly = false;
            txtStreet.ReadOnly = false;
            txtZipCode.ReadOnly = false;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCity.ReadOnly = true;
            txtCNIC.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtProvince.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtHouseNo.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtMiddleName.ReadOnly = true;
            txtQualification.ReadOnly = true;
            txtStreet.ReadOnly = true;
            txtZipCode.ReadOnly = true;
            loadProfile();
            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
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
            emp.setEmp_id(int.Parse(txtID.Text));
            Database db = new Database();
            if (db.editProfile(emp))
            {
                MessageBox.Show("Employee Successfully Registered!");

            }
            else
            {
                MessageBox.Show("Unable to register employee!");
            }
         
        }
     
    }
}
