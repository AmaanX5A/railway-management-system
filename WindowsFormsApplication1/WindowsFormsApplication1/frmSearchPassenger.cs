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
    public partial class frmSearchPassenger : Form
    {
        private Employee emp;

        public frmSearchPassenger()
        {
            InitializeComponent();
        }

        public frmSearchPassenger(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void frmSearchPasenger_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (emp.getDesignation().Equals("Admin"))
            {
                this.Hide();
                frmAdminPanel adminPanel = new frmAdminPanel();
                adminPanel.Show();
            }
            else if (emp.getDesignation().Equals("Operator"))
            {
                this.Hide();
                frmOperatorPanel frm = new frmOperatorPanel();
                frm.Show();
            }
        }

        private void lblSearchPasenger_Click(object sender, EventArgs e)
        {

        }

        private void lblPasengerName_Click(object sender, EventArgs e)
        {

        }

        private void lblCNIC_Click(object sender, EventArgs e)
        {

        }

        private void txtPasengerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!txtPassengerID.Text.Equals(""))
            {
                Database db = new Database();
                DataTable dt = db.getPassenger(int.Parse(txtPassengerID.Text));
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error id field is empty!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtPassengerCNIC.Text.Equals(""))
            {
                Database db = new Database();
                DataTable dt = db.getPassenger(int.Parse(txtPassengerCNIC.Text));
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error id field is empty!");
            }
        }
    }
}
