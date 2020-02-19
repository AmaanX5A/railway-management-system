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
    public partial class frmGMPanel : Form
    {
        private Employee emp;

        public frmGMPanel()
        {
            InitializeComponent();
        }

        public frmGMPanel(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            frmGMOrderDetails frm = new frmGMOrderDetails(emp);
            this.Hide();
            frm.Show();
        }

        private void btnRevenueDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnTicketLogs_Click(object sender, EventArgs e)
        {
            frmGMTicketDetails frm = new frmGMTicketDetails(emp);
            this.Hide();
            frm.Show();
        }

        private void btnEmployeeLogs_Click(object sender, EventArgs e)
        {
            frmEmployeeLogs frm = new frmEmployeeLogs(emp);
            this.Hide();
            frm.Show();
        }

        private void btnPassnegerLogs_Click(object sender, EventArgs e)
        {
            frmPassengerLogs frm = new frmPassengerLogs(emp);
            this.Hide();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmGMLogin frm = new frmGMLogin();
            this.Hide();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile(emp);
            this.Hide();
            frm.Show();
        }

        private void frmGMPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnTrainDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
