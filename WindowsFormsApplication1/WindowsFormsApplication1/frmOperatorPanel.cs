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
    public partial class frmOperatorPanel : Form
    {
        private Employee emp;

        public frmOperatorPanel()
        {
            InitializeComponent();
        }

        public frmOperatorPanel(Employee emp)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.emp = emp;
        }

        private void gm_auth_btn_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void operator_title_Click(object sender, EventArgs e)
        {

        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGetOrder getOrder = new frmGetOrder(emp);
            getOrder.Show();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveOrder frm = new frmRemoveOrder(emp);
            frm.Show();
        }

        private void btnGetOrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGetOrderDetails frm = new frmGetOrderDetails(emp);
            frm.Show();
        }

        private void btnRemoveCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCompany frm = new frmRemoveCompany(emp);
            frm.Show();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCompany addCompany = new frmAddCompany(emp);
            addCompany.Show();
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTicket frm = new frmAddTicket(emp);
            frm.Show();
        }

        private void btnRemoveTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveTicket frm = new frmRemoveTicket(emp);
            frm.Show();
        }

        private void btnGenerateTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenerateTicket frm = new frmGenerateTicket(emp);
            frm.Show();
        }

        private void btnGetTicketDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTicketDetails frm = new frmTicketDetails(emp);
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnGetTrainDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainDetails frm = new frmTrainDetails(emp);
            frm.Show();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewSchedule frm = new frmViewSchedule(emp);
            frm.Show();
        }

        private void btnAddPassengerDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPassenger frm = new frmAddPassenger(emp);
            frm.Show();
        }

        private void btnEditPassengerDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditPassenger frm = new frmEditPassenger(emp);
            frm.Show();
        }

        private void btnViewPassengerDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchPassenger frm = new frmSearchPassenger(emp);
            frm.Show();
        }

        private void btnGetCoachDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCoachDetails frm = new frmCoachDetails(emp);
            frm.Show();
        }

        private void btnCompanyDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompanyDetails frm = new frmCompanyDetails(emp);
            frm.Show();
        }

        private void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchPassenger frm = new frmSearchPassenger(emp);
            frm.Show();
        }
    }
}
