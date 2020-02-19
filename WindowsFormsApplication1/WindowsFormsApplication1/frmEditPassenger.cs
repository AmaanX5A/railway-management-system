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
    public partial class frmEditPassenger : Form
    {
        private Employee emp;

        public frmEditPassenger()
        {
            InitializeComponent();
        }

        public frmEditPassenger(Employee emp)
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }
    }
}
