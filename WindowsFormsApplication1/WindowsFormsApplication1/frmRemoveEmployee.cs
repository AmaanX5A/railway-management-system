using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmRemoveEmployee : Form
    {
        public frmRemoveEmployee()
        {
            InitializeComponent();
        }
        Employee active;
        public frmRemoveEmployee(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlDataAdapter da = db.employeeDetails(int.Parse(txtEmployeeID.Text));
            DataTable dt = new DataTable();
            if (da != null)
            {
                da.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Unable to find Employee!");
            }
       }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.removeEmployee(int.Parse(txtEmployeeID.Text)))
            {
                MessageBox.Show("Employee Successfully removed from database!");
            }
            else
            {
                MessageBox.Show("Unable to remove Employee!");
            }
        }

        private void frmRemoveEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
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
