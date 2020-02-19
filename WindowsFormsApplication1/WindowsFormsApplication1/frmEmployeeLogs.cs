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
    public partial class frmEmployeeLogs : Form
    {
        private Employee emp;

        public frmEmployeeLogs()
        {
            InitializeComponent();
        }

        public frmEmployeeLogs(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnAllEmployeeDetails_Click(object sender, EventArgs e)
        {
            allEmployeesReport rpt = new allEmployeesReport();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void byEmployeeID_Click(object sender, EventArgs e)
        {
            allEmployeesReportByID rpt = new allEmployeesReportByID();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            allEmployeesReportBySalary rpt = new allEmployeesReportBySalary();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnByDate_Click(object sender, EventArgs e)
        {
            allEmployeesReportByHireDate rpt = new allEmployeesReportByHireDate();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void byCompanyName_Click(object sender, EventArgs e)
        {
            allEmployeesReportByDesignation rpt = new allEmployeesReportByDesignation();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            frmGMPanel frm = new frmGMPanel(emp);
            this.Hide();
            frm.Show();
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
