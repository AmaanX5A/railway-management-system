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
    public partial class frmGMOrderDetails : Form
    {
        private Employee emp;

        public frmGMOrderDetails()
        {
            InitializeComponent();
        }

        public frmGMOrderDetails(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            allGMOrders rpt = new allGMOrders();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            gmTodayOrders rpt = new gmTodayOrders();
            //rpt.SetParameterValue("SelectDate", DateTime.Today.Date);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            gmOrdersToFromDate rpt = new gmOrdersToFromDate();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        
        }

        private void byCompanyName_Click(object sender, EventArgs e)
        {
            gmAllOrdersByComp rp = new gmAllOrdersByComp();
            crystalReportViewer1.ReportSource = rp;
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmGMPanel frm = new frmGMPanel(emp);
            this.Hide();
            frm.Show();
        }
    }
}
