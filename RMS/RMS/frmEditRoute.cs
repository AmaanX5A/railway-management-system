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
    public partial class frmEditRoute : Form
    {
        private Employee emp;
        private Route route;
        
        public frmEditRoute()
        {
            InitializeComponent();
        }

        public frmEditRoute(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if(db.searchRoute(int.Parse(txtRouteID.Text)))
            {
               
                route = db.getRoute(int.Parse(txtRouteID.Text));
                if (route != null)
                {
                    txtRouteID.ReadOnly = true;
                    txtRouteID.Text = "" + route.getRouteId();
                    txtRouteName.Visible = true;
                    txtPrice.Visible = true;
                    btnCancel.Visible = true;
                    btnConfirmChanges.Visible = true;
                    btnLoadPreviousChanges.Visible = true;
                    lblPrice.Visible = true;
                    lblRouteName.Visible = true;
                    txtPrice.Text = "" + route.getPrice();
                    txtRouteName.Text = "" + route.getName();
                }
                else
                {
                    MessageBox.Show("Unable to find route!");
                }
            }
        }

        private void frmEditRoute_Load(object sender, EventArgs e)
        {
            txtRouteName.Visible = false;
            txtPrice.Visible = false;
            btnCancel.Visible = false;
            btnConfirmChanges.Visible = false;
            btnLoadPreviousChanges.Visible = false;
            lblPrice.Visible = false;
            lblRouteName.Visible = false;
            txtRouteID.ReadOnly = false;
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
                route.setRouteId(int.Parse(txtRouteID.Text));
                route.setName(txtRouteName.Text);
                route.setPrice(int.Parse(txtPrice.Text));
                Database db = new Database();
                if (db.updateRoute(route))
                {
                    MessageBox.Show("Route successfully updated! Moving on to stations");
                    frmAddStationsToRoute frm = new frmAddStationsToRoute(route, emp);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to update Route!");
                }
          
        }

        private void pnlMainBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoadPreviousChanges_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "" + route.getPrice();
            txtRouteName.Text = route.getName();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            route = null;
            txtRouteID.ReadOnly = false;
            txtRouteName.Visible = false;
            txtPrice.Visible = false;
            btnCancel.Visible = false;
            btnConfirmChanges.Visible = false;
            btnLoadPreviousChanges.Visible = false;
            lblPrice.Visible = false;
            lblRouteName.Visible = false;

        }
    }
}
