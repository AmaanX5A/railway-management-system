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
    public partial class frmRemoveTrain : Form
    {
        public frmRemoveTrain()
        {
            InitializeComponent();
        }
           Employee active;
        public frmRemoveTrain(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void frmRemoveTrain_Load(object sender, EventArgs e)
        {

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!txtRegistrationNo.Text.Equals(""))
            {
                Database db = new Database();
                if (db.removeTrain(txtRegistrationNo.Text))
                {
                    MessageBox.Show("Train Successfully removed from database.");
                }
                else 
                {
                    MessageBox.Show("Unable to remove train from database.");
                }
            }
            else {
                MessageBox.Show("Unable to remove train from database.");
            }
        }
    }
}
