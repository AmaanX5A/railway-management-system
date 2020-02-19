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
    public partial class frmAddStationsToRoute : Form
    {
        Employee emp;
        private Route route;
        List<Station> stations;
        public frmAddStationsToRoute()
        {
            InitializeComponent();
        }
        public frmAddStationsToRoute(Employee emp)
        {
            this.emp = emp;
            route = new Route();
            InitializeComponent();
        }

        public frmAddStationsToRoute(Route route, Employee emp)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.route = route;
            this.emp = emp;
            txtRouteID.Text = "" + route.getRouteId();
            txtRouteID.ReadOnly = true;
            loadTable();
        }

        private void frmAddStationsToRoute_Load(object sender, EventArgs e)
        {
            fillStationsComboBox();
            
        }
        private void fillStationsComboBox()
        {
            Database db = new Database();
            stations = db.getAllStations();
            if (stations != null)
            {
                foreach (Station station in stations)
                {
                    cmboStations.Items.Add(station.getName());
                }
            }
            else
            {
                MessageBox.Show("Error! unable to find stations");
            }
        }

  
        private void btnAddToTable_Click(object sender, EventArgs e)
        {
            if (txtSequenceNo.Text.Equals("") || startTime.Value.TimeOfDay.TotalSeconds > departureTime.Value.TimeOfDay.TotalSeconds || cmboStations.Text.Equals("") || txtRouteID.Text.Equals(""))
            {
                MessageBox.Show("Error! wrong fields are selected!");
            }
            else
            {
                Database db = new Database();
                Station searchedStation = null;
                foreach (Station station in stations)
                {
                    if(station.getName().Equals(cmboStations.Text))
                    {
                        searchedStation = station;
                    }
                }
                RouteStationLog rsl = new RouteStationLog(route, startTime.Value, departureTime.Value, searchedStation, int.Parse(txtSequenceNo.Text));
                if (db.addStationToRoute(rsl))
                {
                    MessageBox.Show("Station added in the route!");
                    loadTable();

                }
                else {
                    MessageBox.Show("Unable to add station in route!");
                }
            }
        }
        private void loadTable()
        {
            Database db = new Database();
            DataTable dt = db.routeStationLogDetails(int.Parse(txtRouteID.Text));
            if (dt != null)
            {
                dataForm.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Unable to load table");
            }
            
        }

        private void btnRemovStation_Click(object sender, EventArgs e)
        {
            if (cmboStations.Text.Equals("") || txtRouteID.Text.Equals(""))
            {
                MessageBox.Show("Please Enter route ID and Station which you want to remove!");
            }
            else
            {
                Database db = new Database();
                Station searchedStation = null;
                foreach (Station station in stations)
                {
                    if (station.getName().Equals(cmboStations.Text))
                    {
                        searchedStation = station;
                    }
                }
                if (db.removeStationFromRoute(int.Parse(txtRouteID.Text), searchedStation.getStationId()))
                {
                    MessageBox.Show("Station Successfully removed from route!");
                    loadTable();
                }
                else
                {
                    MessageBox.Show("Unable to remove station!");
                }

            
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel adminPanel = new frmAdminPanel();
            adminPanel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile frm = new frmViewProfile(emp);
            frm.Show();
        }

        private void dataForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminPanel frm = new frmAdminPanel();
            frm.Show();
        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {
            if (!txtRouteID.Text.Equals(""))
            {
                route.setRouteId(int.Parse(txtRouteID.Text));
                loadTable();
            }
            else
            {
                MessageBox.Show("Error Route ID is emplty!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSequenceNo.Text.Equals("") || startTime.Value.TimeOfDay.TotalSeconds > departureTime.Value.TimeOfDay.TotalSeconds || cmboStations.Text.Equals("") || txtRouteID.Text.Equals(""))
            {
                MessageBox.Show("Error! wrong fields are selected!");
            }
            else
            {
                Database db = new Database();
                Station searchedStation = null;
                foreach (Station station in stations)
                {
                    if (station.getName().Equals(cmboStations.Text))
                    {
                        searchedStation = station;
                    }
                }
                RouteStationLog rsl = new RouteStationLog(route, startTime.Value, departureTime.Value, searchedStation, int.Parse(txtSequenceNo.Text));
                if (db.updateStationDetails(rsl))
                {
                    MessageBox.Show("Station added in the route!");
                    loadTable();

                }
                else
                {
                    MessageBox.Show("Unable to add station in route!");
                }
            }
        }

    }
}
