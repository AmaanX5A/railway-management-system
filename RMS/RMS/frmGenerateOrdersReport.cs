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
    public partial class frmGenerateOrdersReport : Form
    {
        private DataTable dt;
        private Employee emp;

        public frmGenerateOrdersReport()
        {
            emp = new Employee();
            InitializeComponent();
            dt = new DataTable();
        }

        public frmGenerateOrdersReport(DataTable dt, Employee emp)
        {
            // TODO: Complete member initialization
            this.dt = dt;
            this.emp = emp;
            InitializeComponent();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGetOrderDetails frm = new frmGetOrderDetails(emp);
            frm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void frmGenerateOrdersReport_Load(object sender, EventArgs e)
        {
            ordersReport rpt = new ordersReport();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
