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
    public partial class frmViewSchedule : Form
    {
private   Employee emp;

        public frmViewSchedule()
        {
            InitializeComponent();
        }

public    frmViewSchedule(Employee emp)
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
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel frm = new frmMainPanel();
            frm.Show();
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (txtScheduleID.Text.Equals(""))
            {
                MessageBox.Show("Error field is empty!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.searchSchedule(int.Parse(txtScheduleID.Text));
                dataGridView1.DataSource =dt;
                
            }
        }

        private void btnViewAllSchedule_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = db.seachAllScheduleLog();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtScheduleID.Text.Equals(""))
            {
                MessageBox.Show("Error field is empty!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.searchScheduleLog(int.Parse(txtScheduleID.Text));
                dataGridView1.DataSource = dt;

            }
        }

        private void btnViewScheduleByDate_Click(object sender, EventArgs e)
        {
            if (from.Value.Date > To.Value.Date)
            {
                MessageBox.Show("Error input is wrong!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = db.searchScheduleLog(To.Value.Date, from.Value.Date);
                dataGridView1.DataSource = dt;
            }
        }
        }
    }

