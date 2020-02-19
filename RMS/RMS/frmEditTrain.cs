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
    public partial class frmEditTrain : Form
    {
        public frmEditTrain()
        {
            InitializeComponent();
        }
           Employee active;
        public frmEditTrain(Employee emp)
        {
            InitializeComponent();
            active = emp;
        }
        private void frmEditTrain_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
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

        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            if (!txtRegistrationNo.Text.Equals(""))
            {
                Database db = new Database();
                Train train = db.getTrain(txtRegistrationNo.Text);
                if (train == null)
                {
                    MessageBox.Show("Unable to find train!");
                    return;
                }
                else
                {
                    pnlEditPanel.Visible = true;
                    txtEngineNumber.Text = train.getEngineNo();
                    txtModelNo.Text = train.getModelNo();
                    txtType.Text = train.getType();
                    startingDate.Text = train.getStartingDate().Date.ToString();
                    txtRegistrationNo.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter registration no to search!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlEditPanel.Visible == true)
            {
                txtEngineNumber.Text = "";
                txtModelNo.Text = "";
                txtType.Text = "";
                startingDate.Text = "";
                txtRegistrationNo.ReadOnly = false;
                pnlEditPanel.Visible = false;
            }
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            if (pnlEditPanel.Visible == false)
            {
                return;
            }
            if (txtModelNo.Text.Equals("") || txtEngineNumber.Text.Equals("") || txtType.Text.Equals(""))
            {
                MessageBox.Show("Error! Fields are empty!");
            }
            else
            {
                Train train = new Train();
                Database db = new Database();
                train.setRegNo(txtRegistrationNo.Text);
                train.setEngineNo(txtEngineNumber.Text);
                train.setModelNo(txtModelNo.Text);
                train.setType(txtType.Text);
                train.setStartingDate(startingDate.Value);
                if (db.updateTrain(train))
                {
                    txtRegistrationNo.ReadOnly = false;
                    pnlEditPanel.Visible = false;
                    MessageBox.Show("Successfully Update train!");
                }
                else
                {
                    MessageBox.Show("Unable to update train");
                }



            }
        }

        private void btnEditCoaches_Click(object sender, EventArgs e)
        {
            if (txtRegistrationNo.Text.Equals(""))
            {
                MessageBox.Show("Error! Registration no is empty!");
                return;
            }
            else {
                Train train = new Train();
                train.setRegNo(txtRegistrationNo.Text);
                frmAddCoachesToTrain frm = new frmAddCoachesToTrain(train, active);
                this.Hide();
                frm.Show();
            }
        }
    }
}
