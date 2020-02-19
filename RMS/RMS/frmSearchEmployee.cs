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
    public partial class frmSearchEmployee : Form
    {
        Employee active;
        public frmSearchEmployee()
        {
            InitializeComponent();
        }
        public frmSearchEmployee(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(active);
            frm.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchEmployeeByID(int.Parse(txtEmployeeID.Text));
            if(dt == null)
            {
                MessageBox.Show("Unable To find Employee!");
                return;
            }
            dataGridView1.DataSource = dt;
        }

        private void btnSearchByCNIC_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchEmployeeByCNIC(txtCNIC.Text);
            if (dt == null)
            {
                MessageBox.Show("Unable To find Employee!");
                return;
            }
            dataGridView1.DataSource = dt;
        }

        private void btnSearchByDesignation_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchEmployeeByDesignation(txtDesignation.Text);
            if (dt == null)
            {
                MessageBox.Show("Unable To find Employee!");
                return;
            }
            dataGridView1.DataSource = dt;
        }

        private void btnSearchAllEmployees_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.searchAllEmployees();
            if (dt == null)
            {
                MessageBox.Show("Unable To find Employee!");
                return;
            }
            dataGridView1.DataSource = dt;
        }
    }
}
