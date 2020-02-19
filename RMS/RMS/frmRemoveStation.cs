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
    public partial class frmRemoveStation : Form
    {
        private Employee emp;

        public frmRemoveStation()
        {
            InitializeComponent();
        }

        public frmRemoveStation(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void frmRemoveStation_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStationID.Text.Equals(""))
            {
                MessageBox.Show("Error id is empty!");
            }
            else
            {
                Database db = new Database();
                if(db.removeStation(int.Parse(txtStationID.Text)))
                    {
                        MessageBox.Show("Station Successfully removed!");
                        this.Hide();
                        frmAdminPanel frm = new frmAdminPanel();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unable to remove station!");
                    }
            }
        }

        private void btnByName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Error name field is empty!");
            }
            else
            {
                Database db = new Database();
                if (db.removeStation(txtName.Text))
                {
                    MessageBox.Show("Station Successfully removed!");
                    this.Hide();
                    frmAdminPanel frm = new frmAdminPanel();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to remove station!");
                }
            }
        }
    }
}
