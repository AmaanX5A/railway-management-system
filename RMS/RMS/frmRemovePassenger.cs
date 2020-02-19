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
    public partial class frmRemovePassenger : Form
    {
        private Employee emp;

        public frmRemovePassenger()
        {
            InitializeComponent();
        }

        public frmRemovePassenger(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
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
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.getPassenger(int.Parse(txtPassengerID.Text));
            dataGridViewEmployee.DataSource = dt;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
              
            Database db = new Database();
            if (db.removePassenger(int.Parse(txtPassengerID.Text)))
            {
                MessageBox.Show("Passenger Successfully removed!");
                this.Hide();
                frmOperatorPanel frm = new frmOperatorPanel(emp);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Unable to remove Passenger!");
            }
        }

        private void btnByCNIC_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.removePassenger(txtPassengerCNIC.Text))
            {
                MessageBox.Show("Passenger Successfully removed!");
                this.Hide();
                frmOperatorPanel frm = new frmOperatorPanel(emp);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Unable to remove Passenger!");
            }
        }
    }
}
