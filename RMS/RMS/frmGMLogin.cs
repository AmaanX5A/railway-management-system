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
    public partial class frmGMLogin : Form
    {
        public frmGMLogin()
        {
            InitializeComponent();
            this.FormClosing += gmloginpage_FormClosing;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gmloginpage_Load(object sender, EventArgs e)
        {

        }
        private void gmloginpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.loginManager(txtEmail.Text, txtPassword.Text))
            {
                Employee emp = db.searchEmployee("" + db.getEmployeeID(txtEmail.Text, txtPassword.Text));
                frmGMPanel gmPanel = new frmGMPanel(emp);
                this.Hide();
                gmPanel.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Please Try Again...");
            }
        }
    }
}
