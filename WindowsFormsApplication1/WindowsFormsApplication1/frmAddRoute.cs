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
    public partial class frmAddRoute : Form
    {
        private Employee emp;

        public frmAddRoute()
        {
            InitializeComponent();
        }

        public frmAddRoute(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
            nextRouteId();
        }

        private void txtPasengerName_TextChanged(object sender, EventArgs e)
        {

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

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void cmboStations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddRoute_Load(object sender, EventArgs e)
        {
            nextRouteId();
        }
       

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmitRoute_Click(object sender, EventArgs e)
        {
            int id = 0;
            Database db = new Database();
         
            if (!txtPrice.Text.Equals("") || !txtRouteName.Text.Equals(""))
            {
                Route route = new Route();
                id = int.Parse(txtRouteID.Text);
                route.setRouteId(id);
                route.setName(txtRouteName.Text);
                route.setPrice(int.Parse(txtPrice.Text));
                if (db.addRoute(route))
                {
                    MessageBox.Show("Route added continuing to add stations");
                    this.Hide();
                    frmAddStationsToRoute frm = new frmAddStationsToRoute(route, emp);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Error unable to add route!");
                }
            }
        }
        private void nextRouteId()
        {
            int id = 0;
            Database db = new Database();
            id = db.getNextRouteID();
            txtRouteID.Text = "" + id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
