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
    public partial class frmGMTicketDetails : Form
    {
        private Employee emp;

        public frmGMTicketDetails()
        {
            InitializeComponent();
        }

        public frmGMTicketDetails(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnAllTickets_Click(object sender, EventArgs e)
        {
            ticketDetailsAll rpt = new ticketDetailsAll();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void bySchedule_Click(object sender, EventArgs e)
        {
            byScheduleID rpt = new byScheduleID();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnBySourceOrDestination_Click(object sender, EventArgs e)
        {
            ticketsBySource rpt = new ticketsBySource();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnByDestination_Click(object sender, EventArgs e)
        {
            ticketByDestination rpt = new ticketByDestination();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnByTicketID_Click(object sender, EventArgs e)
        {

            ticketByID rpt = new ticketByID();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmGMPanel frm = new frmGMPanel(emp);
            this.Hide();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmGMLogin frm = new frmGMLogin();
            this.Hide();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile(emp);
            this.Hide();
            frm.Show();
        }
    }
}
