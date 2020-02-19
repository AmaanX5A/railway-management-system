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
    public partial class frmRemoveOrder : Form
    {
        private Employee emp;

        public frmRemoveOrder()
        {
            InitializeComponent();
        }

        public frmRemoveOrder(Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel frm = new frmOperatorPanel();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
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

      

        private void btnSubmitOrderID_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Equals(""))
            {
                MessageBox.Show("Error! Order id field is empty!");
            }
            else
            {
                Database db = new Database();
                if (db.removeOrderByID(int.Parse(txtOrderID.Text)))
                {
                    MessageBox.Show("Order successfully removed!");
                }
                else
                {
                    MessageBox.Show("Unable to remove Order!");
                }

            }
        }
    }
}
