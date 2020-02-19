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
    public partial class frmAddStation : Form
    {
        private Employee emp;

        public frmAddStation()
        {
            InitializeComponent();
        }

        public frmAddStation(Employee emp)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.emp = emp;
        }

        private void frmAddStation_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool flag =false;

            if ((txtLatitude.Text == "") || (txtLongitude.Text == "") || (txtName.Text == ""))
            {
                MessageBox.Show("Feilds are missing");
                flag = true;
            }
            else
            {
                Station station = new Station();
                station.setName(txtName.Text);
                station.setLatitude(Convert.ToDouble(txtLatitude.Text));
                station.setLongitude(Convert.ToDouble(txtLongitude.Text));
                if (db.addStation(station))
                {
                    MessageBox.Show("Station Added Successfully!");
                    flag = true;
                    txtLatitude.Text = "";
                    txtLongitude.Text = "";
                    txtName.Text = "";
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Unable To Add Station");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel mainPanel = new frmMainPanel();
            mainPanel.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanle = new frmAdminPanel();
            adminPanle.Show();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            
            if ((txtLatitude.Text == "") || (txtLongitude.Text == "") || (txtName.Text == ""))
            {
                MessageBox.Show("Feilds are missing");
            }
            else
            {
                Station station = new Station();
                station.setName(txtName.Text);
                station.setLatitude(Convert.ToDouble(txtLatitude.Text));
                station.setLongitude(Convert.ToDouble(txtLongitude.Text));
                if (db.addStation(station))
                {
                    MessageBox.Show("Station Added Successfully!");
                    txtLatitude.Text = "";
                    txtLongitude.Text = "";
                    txtName.Text = "";
                }
                else
                {
                    MessageBox.Show("Unable To Add Station");
            
                }
                }
           }

        private void btnAddNewStation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddStation frm = new frmAddStation(emp);
            frm.Show();

        }
    }
}
