using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Forms
{
    public partial class frmAddTrain : Form
    {
        public frmAddTrain()
        {
            InitializeComponent();
        }
        Employee active;
        public frmAddTrain(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void frmAddTrain_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(active);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.setStartingDate(startingDate.Value);
            train.setEngineNo(txtEngineNumber.Text);
            train.setModelNo(txtModelNo.Text);
            train.setRegNo(txtRegNo.Text);
            train.setType(txtType.Text);
            Database db = new Database();
            if (db.addTrain(train))
            {
                frmAddCoachesToTrain frm = new frmAddCoachesToTrain(train, active);
                this.Hide();
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Unable to add the train!");
            }
        }

   
    }
}
