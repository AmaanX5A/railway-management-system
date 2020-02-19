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
    public partial class frmCoachDetails : Form
    {
        private Employee emp;

        public frmCoachDetails()
        {
            InitializeComponent();
        }

        public frmCoachDetails(Employee emp)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }
    }
}
