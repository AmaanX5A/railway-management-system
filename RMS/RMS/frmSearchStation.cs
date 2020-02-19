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
    public partial class frmSearchStation : Form
    {
        private Employee emp;

        public frmSearchStation()
        {
            InitializeComponent();
        }

        public frmSearchStation(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
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
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (txtStationId.Text.Equals(""))
            {
                MessageBox.Show("Error id is empty!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.getStation(int.Parse(txtStationId.Text));
                dataGridView1.DataSource = dt;
            }
        }

        private void btnSearchByCNIC_Click(object sender, EventArgs e)
        {
            if (txtStationName.Text.Equals(""))
            {
                MessageBox.Show("Error name is empty!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.getStation(txtStationName.Text);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
