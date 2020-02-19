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
    public partial class frmRemoveCompany : Form
    {
        private Employee emp;

        public frmRemoveCompany()
        {
            InitializeComponent();
        }

        public frmRemoveCompany(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            if (txtCompanyID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Company ID First");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.searchCompany(int.Parse(txtCompanyID.Text));
                dataGrid.DataSource = dt;
            }
        }

        private void btnConfirmDeletion_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.removeCompany(Convert.ToInt32(txtCompanyID.Text)))
            {
                MessageBox.Show("Company Deleted Successfully!");
                dataGrid.DataSource = null;
                txtCompanyID.Clear();
            }
            else
            {
                MessageBox.Show("Unable To Delete Company!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOperatorPanel operatorPanel = new frmOperatorPanel();
            this.Hide();
            operatorPanel.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }
    }
}
