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
    public partial class frmPassengerLogs : Form
    {
        private Employee emp;

        public frmPassengerLogs()
        {
            InitializeComponent();
        }

        public frmPassengerLogs(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnAllPassengers_Click(object sender, EventArgs e)
        {
            AllPassengersReport rpt = new AllPassengersReport();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnAllByDate_Click(object sender, EventArgs e)
        {
            allPassengerDetailsByDate rpt = new allPassengerDetailsByDate();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnByPassengerName_Click(object sender, EventArgs e)
        {
            allPassengerName rpt = new allPassengerName();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmViewProfile frm = new frmViewProfile(emp);
            this.Hide();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmGMLogin frm = new frmGMLogin();
            this.Hide();
            frm.Show();
        }
       
    }
}