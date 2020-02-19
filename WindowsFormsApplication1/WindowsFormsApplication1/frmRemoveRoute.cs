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
    public partial class frmRemoveRoute : Form
    {
        private Employee emp;

        public frmRemoveRoute()
        {
            InitializeComponent();
        }

        public frmRemoveRoute(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            if (txtRouteID.Text.Equals(""))
            {
                MessageBox.Show("Error invalid routeID");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.allRouteDetails(int.Parse(txtRouteID.Text));
                dataGrid.DataSource = dt;
            }
        }

        private void btnConfirmDeletion_Click(object sender, EventArgs e)
        {
            if (txtRouteID.Text.Equals(""))
            {
                MessageBox.Show("Error invalid routeID");
            }
            else
            {
                Database db = new Database();
                if (db.removeRoute(int.Parse(txtRouteID.Text)))
                {
                    MessageBox.Show("Route Successfully removed from database!");
                }
                else
                {
                    MessageBox.Show("Unable to remove route!");
                }
            }
        }
    }
}
