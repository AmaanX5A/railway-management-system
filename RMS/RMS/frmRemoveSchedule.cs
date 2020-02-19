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
    public partial class frmRemoveSchedule : Form
    {
        private Employee emp;

        public frmRemoveSchedule()
        {
            InitializeComponent();
        }

        public frmRemoveSchedule(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPasengerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblScheduleID_Click(object sender, EventArgs e)
        {

        }

        private void lblSearchPasenger_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtScheduleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            if (txtScheduleID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Schedule ID First");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.searchSchedule(int.Parse(txtScheduleID.Text));
                dataGrid.DataSource = dt;
            }
        }

        private void btnConfirmDeletion_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.removeSchedule(Convert.ToInt32(txtScheduleID.Text)))
            { 
                MessageBox.Show("Schedule Deleted Successfully!");
                dataGrid.DataSource = null;
                txtScheduleID.Clear();
            }
            else
            {
                MessageBox.Show("Unable To Delete Schedule!");
            }

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmAdminPanel adminPanel = new frmAdminPanel();
            this.Hide();
            adminPanel.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnViewProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }
    }
}
