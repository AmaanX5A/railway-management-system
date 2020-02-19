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
    public partial class frmAdminPanel : Form
    {
        Employee emp;
        public frmAdminPanel()
        {
            InitializeComponent();
        }
        public frmAdminPanel(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchStation frm = new frmSearchStation(emp);
            this.Hide();
            frm.Show();
        }

        private void adminrolepage_Load(object sender, EventArgs e)
        {

        }

        private void btnTrainDetails_Click(object sender, EventArgs e)
        {
            frmTrainDetails frm = new frmTrainDetails(emp);
            this.Hide();
            frm.Show();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddSchedule addSchedule = new frmAddSchedule(emp);
            addSchedule.Show();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchRoute frm = new frmSearchRoute(emp);
            frm.Show();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveEmployee removeEmployee = new frmRemoveEmployee(emp);
            removeEmployee.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEmployee addEmployee = new frmAddEmployee(emp);
            addEmployee.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditEmployee editEmployee = new frmEditEmployee(emp);
            editEmployee.Show();
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            frmAddRoute frm = new frmAddRoute(emp);
            this.Hide();
            frm.Show();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            frmSearchEmployee frm = new frmSearchEmployee(emp);
            this.Hide();
            frm.Show();
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnSetCoaches_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCoach coachform = new frmAddCoach(emp);
            coachform.Show();
        }

        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchSchedule frm = new frmSearchSchedule(emp);
            frm.Show();
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveSchedule removeSchedule = new frmRemoveSchedule(emp);
            removeSchedule.Show();
        }

        private void BtnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            Forms.frmAddTrain frm = new Forms.frmAddTrain(emp);
            this.Hide();
            frm.Show();
          
        }

        private void btnRemoveTrain_Click(object sender, EventArgs e)
        {
            frmRemoveTrain frm = new frmRemoveTrain(emp);
            this.Hide();
            frm.Show();
        }

        private void btnEditTrain_Click(object sender, EventArgs e)
        {
            frmEditTrain frm = new frmEditTrain(emp);
            this.Hide();
            frm.Show();
        }

        private void btnSearchTrain_Click(object sender, EventArgs e)
        {
            frmSearchTrain frm = new frmSearchTrain(emp);
            this.Hide();
            frm.Show();
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            frmSearchStation frm = new frmSearchStation(emp);
            this.Hide();
            frm.Show();
        }

        private void btnSearchPassenger_Click(object sender, EventArgs e)
        {
            frmSearchPassenger frm = new frmSearchPassenger(emp);
            this.Hide();
            frm.Show();
        }

        private void btnRemoveStation_Click(object sender, EventArgs e)
        {
            frmRemoveStation frm = new frmRemoveStation(emp);
            this.Hide();
            frm.Show();
        }

        private void btnEmployeeDetails_Click(object sender, EventArgs e)
        {
            frmGetEmployeeDetails frm = new frmGetEmployeeDetails(emp);
            this.Hide();
            frm.Show();
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            frmAddStation frm = new frmAddStation(emp);
            this.Hide();
            frm.Show();
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            frmEditRoute frm = new frmEditRoute(emp);
            this.Hide();
            frm.Show();
        }

        private void btnRemoveRoute_Click(object sender, EventArgs e)
        {
            frmRemoveRoute frm = new frmRemoveRoute(emp);
            this.Hide();
            frm.Show();
        }

      

        private void btnRemovePassenger_Click(object sender, EventArgs e)
        {
            frmRemovePassenger frm = new frmRemovePassenger(emp);
            this.Hide();
            frm.Show();
        }

        private void btnSetCoachesToTrain_Click(object sender, EventArgs e)
        {
            frmAddCoachesToTrain frm = new frmAddCoachesToTrain(emp);
            this.Hide();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddStationsToRoute frm = new frmAddStationsToRoute(emp);
            this.Hide();
            frm.Show();
        }
    }
}
