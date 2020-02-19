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
    public partial class frmGetOrder : Form
    {
        List<Station> stationlist = new List<Station>();
        int id;
        private Employee emp;
        int bill;
        Station srcstation, deststation;

        public frmGetOrder()
        {
            InitializeComponent();
            fillComboBoxes();
        }

        public frmGetOrder(Employee emp)
        {
            InitializeComponent();
            fillComboBoxes();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        void fillComboBoxes()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=rms;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM stationTable";
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    String stationNames = reader.GetString(0);
                    cmboSourceStation.Items.Add(stationNames);
                    cmboDestinationStation.Items.Add(stationNames);

                    Station station = new Station();
                    
                    station.setName(reader.GetString(0));
                    station.setStationId(reader.GetInt32(1));
                    
                    stationlist.Add(station);
                }

                con.Close();
                
                cmd.CommandText = "SELECT MAX(order_id) FROM orderTable";
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
                txtOrderID.Text = Convert.ToString(++id);
                cmd.Cancel();
                con.Close();
                
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void pnlMainBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCalculateBill_Click(object sender, EventArgs e)
        {
            if ((txtOrderID.Text.Equals("")) || (cmboSourceStation.Text.Equals("")) || (cmboDestinationStation.Text.Equals("")) || (txtCategory.Text.Equals("")))
            {
                MessageBox.Show("Please Fill All Fields To Continue");
            }
            else if (cmboDestinationStation.Text == cmboSourceStation.Text)
            {
                MessageBox.Show("Cannot Select Same Source and Destinations Stations At Once");
            }
            else
            {
                int distance = new int();
                int dest = new int();
                int src = new int();

                foreach (Station st in stationlist)
                {
                    if (cmboSourceStation.Text.Equals(st.getName()))
                    {
                        src = st.getStationId();
                        srcstation = st;
                    }
                    if (cmboDestinationStation.Text.Equals(st.getName()))
                    {
                        dest = st.getStationId();
                        deststation = st;
                    }
                }

                distance = dest - src;
                bill = Math.Abs(distance) * 800;
                txtAmountToPay.Text = Convert.ToString(bill);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Order order = new Order(id, bill, srcstation, deststation, txtCategory.Text, dateTimePicker.Value);
            
            if (txtAmountToPay.Text.Equals(""))
            {
                MessageBox.Show("Please Select Approriate Values To Calculate Bill First");
            }
            else if (cmboDestinationStation.Text == cmboSourceStation.Text)
            {
                MessageBox.Show("Cannot Select Same Source and Destinations Stations At Once");
            }
            else if ((txtOrderID.Text.Equals("")) || (cmboSourceStation.Text.Equals("")) || (cmboDestinationStation.Text.Equals("")) || (txtCategory.Text.Equals("")) || (txtAmountToPay.Text.Equals("")))
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else if (db.addOrder(order))
            {
                MessageBox.Show("Order Added Successfully!");
                frmPlaceOrder placeOrder = new frmPlaceOrder(order, emp);
                this.Hide();
                placeOrder.Show();
            }
            else
            {
                MessageBox.Show("Unable To Add Order");
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorPanel operatorPanel = new frmOperatorPanel();
            operatorPanel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainPanel mainPanel = new frmMainPanel();
            mainPanel.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOperatorLogin op = new frmOperatorLogin();
            op.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }
    }
}
