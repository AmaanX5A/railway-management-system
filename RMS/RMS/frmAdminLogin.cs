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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
            this.FormClosing += aloginpage_FormClosing;
        }

        private void aloginpage_Load(object sender, EventArgs e)
        {

        }
        private void aloginpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainPanel tp = new frmMainPanel();
            tp.Show();
        }

        private void a_auth_btn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.loginAdmin(txtEmail.Text, txtPassword.Text))
            {
                Employee emp = db.searchEmployee(""+db.getEmployeeID(txtEmail.Text, txtPassword.Text));
                frmAdminPanel adminPanel = new frmAdminPanel(emp);
                this.Hide();
                adminPanel.Show();
            }
            else {
                MessageBox.Show("Invalid Credentials! Please Try Again...");
            }
        }
    }
}
