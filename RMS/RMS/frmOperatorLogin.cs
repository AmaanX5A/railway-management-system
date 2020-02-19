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
    public partial class frmOperatorLogin : Form
    {
        public frmOperatorLogin()
        {
            InitializeComponent();
            this.FormClosing += ologinpage_FormClosing;
        }

        private void title_ol_Click(object sender, EventArgs e)
        {

        }

        private void ologinpage_Load(object sender, EventArgs e)
        {

        }
        private void ologinpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.loginOperator(txtEmail.Text, txtPassword.Text))
            {
                Employee emp = db.searchEmployee("" + db.getEmployeeID(txtEmail.Text, txtPassword.Text));
                frmOperatorPanel operatorPanel = new frmOperatorPanel(emp);
                this.Hide();
                operatorPanel.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Please Try Again...");
            }
        }
    }
}
