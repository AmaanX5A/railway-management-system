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
    public partial class frmTrainDetails : Form
    {
        public frmTrainDetails()
        {
            InitializeComponent();
        }
        Employee emp;
        public frmTrainDetails(Employee emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (emp.getDesignation().Equals("Admin"))
            {
                this.Hide();
                frmAdminPanel adminPanel = new frmAdminPanel();
                adminPanel.Show();
            }
            else if(emp.getDesignation().Equals("Operator"))
            {
                this.Hide();
                frmOperatorPanel frm = new frmOperatorPanel();
                frm.Show();
            }
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

        private void btnSearchAllTrains_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchAllTrains();
            if (dt == null)
            {
                MessageBox.Show("Error unable to search trains,");
            }
            else {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnSearchTrainsWithCoaches_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchTrainsWithCoaches();
            if (dt == null)
            {
                MessageBox.Show("Error no train found!");
            }
            else
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
