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
    public partial class frmGenerateTicket : Form
    {
        Ticket ticket;
        private Employee emp;
        public frmGenerateTicket()
        {
            InitializeComponent();
            ticket = new Ticket();
            crystalReportViewer1.Visible = false;
        }
        public frmGenerateTicket(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            txtTicketID.ReadOnly = true;
            txtTicketID.Text = "" + ticket.getId();
            crystalReportViewer1.Visible = false;
        }
        public frmGenerateTicket(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            ticket = new Ticket();
            crystalReportViewer1.Visible = false;
        }
        public frmGenerateTicket(Employee emp, Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            txtTicketID.ReadOnly = true;
            txtTicketID.Text = "" + ticket.getId();
            crystalReportViewer1.Visible = false;
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void frmGenerateTicket_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!txtTicketID.Text.Equals(""))
            {
                txtTicketID.ReadOnly = true;
                crystalReportViewer1.Visible = true;
                Database db = new Database();
                ticket = db.getTicket(int.Parse(txtTicketID.Text));
                generateTicket report = new generateTicket();
                DataTable dt = new DataTable();
                dt = db.getTicketGenerationTable(int.Parse(txtTicketID.Text));
                report.SetDataSource(dt);
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();

            }
            else
            {
                MessageBox.Show("Error field is empty");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Visible = false;
            txtTicketID.ReadOnly = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            generateTic rpt = new generateTic();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
