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
    public partial class frmMainPanel : Form
    {
        public frmMainPanel()
        {
            InitializeComponent();
        }

        private void title_gml_Click(object sender, EventArgs e)
        {

        }

        private void titlepage_Load(object sender, EventArgs e)
        {

        }

        private void gml_btn_Click(object sender, EventArgs e)
        {
            frmGMLogin gmlp = new frmGMLogin();
            Hide();
            gmlp.Show();
        }

        private void al_btn_Click(object sender, EventArgs e)
        {
          
            frmAdminLogin alp = new frmAdminLogin();
            Hide();
            alp.Show();
        }

        private void ol_btn_Click(object sender, EventArgs e)
        {
            frmOperatorLogin olp = new frmOperatorLogin();
            Hide();
            olp.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            this.Hide();
            signUp.Show();
        }

        
    }

}