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
    public partial class frmAddSchedule : Form
    {
        List<Route> routes = new List<Route>();
        List<Train> trainlist = new List<Train>();
        private Employee emp;

        public frmAddSchedule()
        {
            InitializeComponent();
          
        }

        public frmAddSchedule(Employee emp)
        {
            
            InitializeComponent();
            // TODO: Complete member initialization
            this.emp = emp;
        }

        void fillBoxes()
        {
            Database db = new Database();
            routes = db.getAllRoutes();
            trainlist = db.getAllTrains();
            if (routes != null && trainlist != null)
            {
                try
                {
                    txtScheduleID.Text = "" + db.getScheduleID();
                    foreach (Train train in trainlist)
                    {
                        String id = train.getRegNo();

                        cmboTrain.Items.Add(id);
                    }
                    foreach (Route route in routes)
                    {
                        String name = route.getName();
                        cmboRouteName.Items.Add(name);
                    }

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Unable to add Schedule!");   
            }
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=rms;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;

            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT * FROM stationTable";
            //try
            //{
            //    con.Open();
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
                    
            //        String stationNames = reader.GetString(0);
            //        cmboRouteName.Items.Add(stationNames);
            //        cmboDestinationStation.Items.Add(stationNames);

            //        Station station = new Station();
                    
            //        station.setName(reader.GetString(0));
            //        station.setStationId(reader.GetInt32(1));
                    
            //        stationlist.Add(station);
            //    }

            //    con.Close();
            //    cmd.CommandText = "SELECT * FROM trainTable";
            //    con.Open();
            //    reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
                    
            //        String trainNames = reader.GetString(0);
            //        cmboTrain.Items.Add(trainNames);

            //        Train train = new Train();

            //        train.setRegNo(reader.GetString(0));
            //        train.setEngineNo(reader.GetString(1));
            //        train.setType(reader.GetString(2));
            //        train.setModelNo(reader.GetString(3));

            //        trainlist.Add(train);
            //    }

            //    con.Close();
            //    cmd.CommandText = "SELECT MAX(schedule_id) FROM scheduleTable";
            //    con.Open();
            //    reader = cmd.ExecuteReader();
            //    reader.Read();
            //    id = reader.GetInt32(0);
            //    cmd.Cancel();
            //    con.Close();
                
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database db = new Database();
         
            if (cmboTrain.Text.Equals("") || cmboRouteName.Text.Equals(""))
            {
                MessageBox.Show("invalid Fields");

            }
            else
            {
                Schedule schedule = new Schedule();
                schedule.setId(int.Parse(txtScheduleID.Text));
                Route route = null;
                Train train = null;
                foreach (Train val in trainlist)
                {
                    if (val.getRegNo().Equals(cmboTrain.Text))
                    {
                        train = val;
                        break;
                    }
                }
                foreach (Route val in routes)
                {
                    if (val.getName().Equals(cmboRouteName.Text))
                    {
                        route = val;
                        break;
                    }
                }
                if (route != null && train != null)
                {
                    schedule.setRoute(route);
                    schedule.setTrain(train);
                }
                else
                {
                    MessageBox.Show("Error nullsss");
                }
                if (db.addSchedule(schedule))
                {
                    MessageBox.Show("Schedule Successfully added in database!");
                    this.Hide();
                    frmAdminPanel frm = new frmAdminPanel(emp);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to add schedule!");
                }


            }
        }
            //Station src = new Station();
            //Station dest = new Station();
            //Train t = new Train();
            //Schedule schedule = new Schedule();

            //foreach (Station st in stationlist)
            //{
            //    if (cmboSourceStation.Text.Equals(st.getName()))
            //    {
            //        src.setName(st.getName());
            //        src.setStationId(st.getStationId());
            //    }
            //    if (cmboDestinationStation.Text.Equals(st.getName()))
            //    {
            //        dest.setName(st.getName());
            //        dest.setStationId(st.getStationId());
            //    }
            //}

            //foreach (Train tr in trainlist)
            //{
            //    if (cmboTrain.Text.Equals(tr.getRegNo()))
            //    {
            //        t.setRegNo(tr.getRegNo());
            //    }
            //}
            
            //schedule.setSource(src);
            //schedule.setDestination(dest);
            //schedule.setId(id+1);
            //schedule.setTime(dateTimePicker1.Value);
            //schedule.setTrain(t);

            //Database db = new Database();

            //if (cmboDestinationStation.Text == cmboSourceStation.Text)
            //{
            //    MessageBox.Show("Cannot Select Same Source and Destinations Stations At Once");
            //}
            //else if (db.addSchedule(schedule))
            //{
            //    MessageBox.Show("Schedule Added Successfully!");
            //    this.Hide();
            //    frmAdminPanel adminPanel = new frmAdminPanel();
            //    adminPanel.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Unable to add Schedule!");
            //}
        
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

        private void frmAddSchedule_Load(object sender, EventArgs e)
        {
            fillBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
       

    }
}
