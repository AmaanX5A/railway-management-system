using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPlaceOrder : Form
    {
        List<Company> companylist = new List<Company>();
        private Order order;
        private Employee emp;

        public frmPlaceOrder(Order order)
        {
            this.order = order;
            InitializeComponent();
            hideFeilds();
            fillCompanyBox();
        }

        public frmPlaceOrder(Order order, Employee emp)
        {
            this.order = order;
            InitializeComponent();
            hideFeilds();
            fillCompanyBox();
            // TODO: Complete member initialization
            this.emp = emp;
        }
        public void hideFeilds()
        {
            cmboCompanyName.Hide();
            txtCompanyID.Hide();
            lblCompanyName.Hide();
            lblCompanyID.Hide();
            txtOrderID.Text = Convert.ToString(order.getOrderId());
        }

        public void fillCompanyBox()
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=rms; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM companyTable";
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    String companyNames = reader.GetString(1);
                    cmboCompanyName.Items.Add(companyNames);

                    Company company = new Company();

                    company.setCompanyId(reader.GetInt32(0));
                    company.setName(reader.GetString(1));
                    company.setEmail(reader.GetString(2));

                    companylist.Add(company);
                }

                con.Close();

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel mainPanel = new frmMainPanel();
            mainPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCompany addCompany = new frmAddCompany();
            addCompany.Show();
        }

        private void btnAddByCompanyID_Click(object sender, EventArgs e)
        {
            cmboCompanyName.Hide();
            lblCompanyName.Hide();
            txtCompanyID.Show();
            lblCompanyID.Show();
        }

        private void btnAddByCompanyName_Click(object sender, EventArgs e)
        {
            txtCompanyID.Hide();
            lblCompanyID.Hide();
            cmboCompanyName.Show();
            lblCompanyName.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            PlaceOrder pc = new PlaceOrder();

            foreach (Company cm in companylist)
            {
                if (cmboCompanyName.Text.Equals(cm.getName()))
                {
                    pc.setCompnany(cm);
                    pc.setOrder(this.order);
                }
                if (txtCompanyID.Text.Equals(Convert.ToString(cm.getCompanyId())))
                {
                    pc.setCompnany(cm);
                    pc.setOrder(this.order);
                }
            }

            if ((cmboCompanyName.Text == "") && (txtCompanyID.Text == ""))
            {
                MessageBox.Show("Please Select Atleast One Method To Continue\n\nAdd By Company Name\n\tOr\rAdd By Company ID");
            }
            else if (db.placeOrder(pc))
            {
                MessageBox.Show("Order Has Been Placed Successfully!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unable To Place Order");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorLogin op = new frmOperatorLogin();
            op.Show();
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
    }
}
