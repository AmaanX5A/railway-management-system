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
    public partial class frmRemoveTicket : Form
    {
        public frmRemoveTicket()
        {
            InitializeComponent();
        }
        Employee active;
        public frmRemoveTicket(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void frmRemoveTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = null;
            dt = db.getTicketInformation(int.Parse(txtTicketID.Text));
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error! unable to find ticket.");
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (!txtTicketID.Equals(""))
            {
                if (db.deleteTicket(int.Parse(txtTicketID.Text)))
                {
                    MessageBox.Show("Route successfully deleted!");
                    this.Hide();
                    frmOperatorPanel frm = new frmOperatorPanel();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Error! field is empty.");
            }
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
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }
    }
}
