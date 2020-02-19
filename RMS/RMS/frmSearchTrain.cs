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
    public partial class frmSearchTrain : Form
    {
        private Employee emp;

        public frmSearchTrain()
        {
            InitializeComponent();
        }

        public frmSearchTrain(Employee emp)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchAllTrainInformation(txtRegistrationNo.Text);
            if (null != dt)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid registration no!");
            }
        }
    }
}
