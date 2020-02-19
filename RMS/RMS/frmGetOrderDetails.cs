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
    public partial class frmGetOrderDetails : Form
    {
        private Employee emp;
        private DataTable dt;
        public frmGetOrderDetails()
        {
            InitializeComponent();
            emp = new Employee();
            dt = new DataTable();
        }

        public frmGetOrderDetails(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
            dt = new DataTable();
        }

        private void btnByOrderID_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Equals(""))
            {
                MessageBox.Show("Error Order ID is empty!");
            }
            else
            {
                Database db = new Database();
                DataTable dt = null;
                dt = db.getOrderByID(int.Parse(txtOrderID.Text));
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to find entry on this id!");
                }
            }
        }

        private void frmGetOrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnByCompanyName_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Equals(""))
            {
                MessageBox.Show("Error Order ID is empty!");
            }
            else
            {
                Database db = new Database();
               
                dt = db.getOrderByCompanyName(txtCompanyName.Text);
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to find entry on this id!");
                }
            }
        }

        private void btnByCompanyID_Click(object sender, EventArgs e)
        {
            if (txtCompanyID.Equals(""))
            {
                MessageBox.Show("Error Order ID is empty!");
            }
            else
            {
                Database db = new Database();
               
                dt = db.getOrderByCompanyID(int.Parse(txtCompanyID.Text));
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to find entry on this id!");
                }
            }
        }

        private void btnByDate_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date > DateTime.Today.Date || dateTo.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Error Dates are out of range!");
            }
            else
            {
                Database db = new Database();
               
                dt = db.getOrderByDate(dateFrom.Value.Date, dateTo.Value.Date);
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to find entry on this id!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value.Date > DateTime.Today.Date || dateTo.Value.Date > DateTime.Today.Date || txtCompanyName.Text.Equals(""))
            {
                MessageBox.Show("Error Dates are out of range!");
            }
            else
            {
                Database db = new Database();
              
                dt = db.getOrderByCompNameAndDate(txtCompanyName.Text, dateFrom.Value.Date, dateTo.Value.Date);
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Unable to find entry on this id!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGenerateOrdersReport frm = new frmGenerateOrdersReport(dt, emp);
            frm.Show();
        }

        
    }
}
