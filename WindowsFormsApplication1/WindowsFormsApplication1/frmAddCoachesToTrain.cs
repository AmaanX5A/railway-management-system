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
    public partial class frmAddCoachesToTrain : Form
    {
        private Train train;
        List<String> ids;
        DataTable dt;
        private CoachTrainLog log;
        private Employee emp;
        public frmAddCoachesToTrain()
        {
            InitializeComponent();
        }

        public frmAddCoachesToTrain(Train train,Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.train = train;
            this.emp = emp;
            txtRegNo.ReadOnly = true;
            txtRegNo.Text = train.getRegNo();
        }

        public frmAddCoachesToTrain(Employee emp)
        {
            InitializeComponent();
       
            // TODO: Complete member initialization
            this.emp = emp;
        }
        
     

        private void frmAddCoachesToTrain_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (!txtRegNo.Text.Equals("") && !cmboCoachIDs.Text.Equals(""))
            {
                if (db.addCoachToTrain(txtRegNo.Text, cmboCoachIDs.Text))
                {
                    MessageBox.Show("Coach added to train");
                    displayTable();

                }
                else
                {
                    MessageBox.Show("Unable to add coach to train");
                }
            }
            else
            {
                MessageBox.Show("Error field(s) are empty");
            }

        }
        private void fillComboBox()
        {
            Database db = new Database();
            ids = new List<String>();
            ids = db.getCoachIDs();
            foreach(String id in ids)
            {
                cmboCoachIDs.Items.Add(id);
            }
            displayTable();
        }
        private void displayTable()
        {
            Database db = new Database();
            DataTable dt = db.getCoachTrainLog(txtRegNo.Text);
            dataGridView1.DataSource = dt;

        }

        private void btnSubmitCoaches_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (!txtRegNo.Text.Equals("") && !cmboCoachIDs.Text.Equals(""))
            {
                if (db.removeCoach(txtRegNo.Text, cmboCoachIDs.Text))
                {
                    MessageBox.Show("Coach is removed from the train");
                    displayTable();

                }
                else
                {
                    MessageBox.Show("Unable to remove coach from train");
                }
            }
            else
            {
                MessageBox.Show("Error field(s) are empty");
            }
        }

        private void btnAllocationDetails_Click(object sender, EventArgs e)
        {
            if (!txtRegNo.Text.Equals(""))
            {
                displayTable();
            }
            else
            {
                MessageBox.Show("Error! Please enter train registration no to view its allocation.");
            }
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
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }
    }
}
