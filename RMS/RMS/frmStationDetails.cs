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
    public partial class frmStationDetails : Form
    {
        public frmStationDetails()
        {
            InitializeComponent();
        }
        Employee active;
        public frmStationDetails(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmAdminPanel admin = new frmAdminPanel();
            this.Hide();
            admin.Show();

        }

        private void lblHeaderRMS_Click(object sender, EventArgs e)
        {

        }

        private void frmStationDetails_Load(object sender, EventArgs e)
        {

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
