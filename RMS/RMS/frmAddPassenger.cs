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
    public partial class frmAddPassenger : Form
    {
        private Employee emp;

        public frmAddPassenger()
        {
            InitializeComponent();
        }

        public frmAddPassenger(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCNIC.Text.Equals("") || txtEmail.Text.Equals("") || txtFirstName.Text.Equals("") || txtLastName.Text.Equals("") || (rdoFemale.Checked == false && rdoMale.Checked == false) || dateTimePickerDob.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Error fields are empty!");
            }
            else
            {
                Passenger passenger = new Passenger();
                Person person = new Person();
                person.setCNIC(txtCNIC.Text);
                person.setDateOfBirth(dateTimePickerDob.Value.Date);
                person.setEmail(txtEmail.Text);
                person.setFirstName(txtFirstName.Text);
                person.setLastName(txtLastName.Text);
                person.setMiddleName(txtMiddleName.Text);
                if (rdoFemale.Checked)
                {
                    person.setGender("Female");
                }
                else if (rdoMale.Checked)
                {
                    person.setGender("Male");
                }
                passenger.setPersonalInformation(person);
                Database db = new Database();
                if (db.addPassenger(passenger))
                {
                    MessageBox.Show("Passenger Successfully added!");
                    passenger.setPid(db.getPassengerID(txtCNIC.Text));
                    frmAddTicket frm = new frmAddTicket(emp, passenger);
                    this.Hide();
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("Unable to add passenger!");

                }

            }
        }
    }
}
