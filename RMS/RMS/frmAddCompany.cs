using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmAddCompany : Form
    {
        int id;
        private Employee emp;
        public frmAddCompany()
        {
            InitializeComponent();
            fillCompanyIDBox();
        }

        public frmAddCompany(Employee emp)
        {
            InitializeComponent();
            fillCompanyIDBox();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        void fillCompanyIDBox()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=rms;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "SELECT MAX(company_id) FROM companyTable";
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.IsDBNull(0))
                {
                    id = 0;
                }
                else
                {
                    id = reader.GetInt32(0);
                }
                id++;
                cmd.Cancel();
                con.Close();

                txtCompanyID.Text = Convert.ToString(id);

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            bool flag = false;

            if ((txtCompanyEmail.Text == "") || (txtCompanyName.Text == "") || (txtCompanyPhone.Text == "") || (txtCompanyCell.Text == ""))
            {
                MessageBox.Show("Feild(s) Are Missing");
                flag = true;
            }
            else
            {
                Company company = new Company();
                company.setCompanyId(id);
                company.setName(txtCompanyName.Text);
                company.setEmail(txtCompanyEmail.Text);
                company.setPhoneNo(txtCompanyPhone.Text);
                company.setCellNo(txtCompanyCell.Text);
                if (db.addCompnay(company))
                {
                    MessageBox.Show("Company Added Successfully!");
                    flag = true;
                    txtCompanyName.Text = "";
                    txtCompanyEmail.Text = "";
                    txtCompanyPhone.Text = "";
                    txtCompanyCell.Text = "";
                    txtCompanyID.Text = "";
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Unable To Add Company");
            }
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
    }
}
