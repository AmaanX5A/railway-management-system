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
    public partial class frmTicketDetails : Form
    {
        private Employee emp;

        public frmTicketDetails()
        {
            InitializeComponent();
        }

        public frmTicketDetails(Employee emp)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.emp = emp;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!txtTicketID.Text.Equals(""))
            {
                Database db = new Database();
                DataTable dt = new DataTable();
                dt = db.getTicketInformation(int.Parse(txtTicketID.Text));
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error field is empty");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
        }
    }
}
