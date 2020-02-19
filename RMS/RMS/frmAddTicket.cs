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
    public partial class frmAddTicket : Form
    {
        public frmAddTicket()
        {
            InitializeComponent();
        }
        ScheduleDateLog scheduleDateLog = new ScheduleDateLog();
        Employee active;
        Schedule schedule = new Schedule();
        List<Station> stations;
        List<Coach> coaches;
        Passenger passenger = new Passenger();

        public frmAddTicket(Employee emp)
        {
            InitializeComponent();
            active = emp;
            passenger = new Passenger();
        }
        public frmAddTicket(Employee emp, Passenger passenger)
        {
            InitializeComponent();
            active = emp;
            this.passenger = passenger;
            txtPassengerID.ReadOnly = true;
            txtPassengerID.Text = "" + passenger.getPid();
        }
        private void frmAddTicket_Load(object sender, EventArgs e)
        {
            fillScheduleIds();
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
            frmViewProfile frm = new frmViewProfile(active);
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMainPanel mainPanel = new frmMainPanel();
            this.Hide();
            mainPanel.Show();
        }

     

        private void fillScheduleIds()
        {
            Database db = new Database();
            List<int> schedules = db.getAllScheduleIds();
            foreach (int id in schedules)
            {
                cmboScheduleID.Items.Add("" + id);
            }
            
        }
        private void btnSearchAvailablility_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if(cmboScheduleID.Text.Equals("") || date.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Error! invalid fields!");
            }
            else
            {
                if (db.searchScheduleDateLog(int.Parse(cmboScheduleID.Text), date.Value))
                {
                    scheduleDateLog = db.getScheduleDateLog(int.Parse(cmboScheduleID.Text), date.Value);
                    txtSeatsBooked.Text = "" + scheduleDateLog.getSeatsBooked();
                    txtSerialNo.Text ="" + scheduleDateLog.getSerialNo();
                }
                else
                {
                    try
                    {
                 
                        scheduleDateLog.setDate(date.Value.Date);
                        scheduleDateLog.setScheduleID(int.Parse(cmboScheduleID.Text));
                        scheduleDateLog.setSeatsBooked(0);
                        db.addScheduleDateLog(scheduleDateLog);
                        txtSeatsBooked.Text = "" + 0;
                        txtSerialNo.Text = "" + db.getSerialNo(int.Parse(cmboScheduleID.Text), date.Value);
                        
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                try
                {
                   
                    schedule = db.getSchedule(int.Parse(cmboScheduleID.Text));
                    if (schedule != null)
                    {
                        stations = db.getStationsOfRoute(schedule.getRoute());
                        foreach (Station station in stations)
                        {
                            cmboSourceStation.Items.Add(station.getName());
                            cmboDestinationStation.Items.Add(station.getName());
                        }
                        txtTrain.Text = schedule.getTrain().getRegNo();
                        coaches = db.getTrainCoaches(schedule.getTrain());
                        if (coaches != null)
                        {
                            foreach (Coach coach in coaches)
                            {
                                cmboCoachType.Items.Add(coach.getCoachId());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Coaches not found");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unable to find Schedule!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnsubmitTicket_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (txtPassengerID.Text.Equals("") || txtSeatNo.Text.Equals("") || txtFare.Equals(""))
            {
                MessageBox.Show("Error! passenger id, seat or fare is empty!");
            }
            else
            { 
                Coach findCoach = new Coach();
                foreach (Coach coach in coaches)
                {

                    if (coach.getCoachId() == int.Parse(cmboCoachType.Text))
                    {
                        findCoach = coach;
                    }
                }
               
                try
                {
                    if (db.getBookedSeatsInCoachCount(scheduleDateLog.getSerialNo(), findCoach.getCoachId()) < findCoach.getNoOfSeats())
                    {
                        int seat_no = int.Parse(txtSeatNo.Text);
                        if (db.isSeatBooked(seat_no, findCoach, scheduleDateLog))
                        {
                            MessageBox.Show("Error! seat is already booked.");
                            return;
                        }
                
                        Ticket ticket = new Ticket();
                        ticket.setSeat(int.Parse(txtSeatNo.Text));
                        passenger.setPid(int.Parse(txtPassengerID.Text));
                        ticket.setPassenger(passenger);
                        ticket.setFare(int.Parse(txtFare.Text));
                        Station srcStation = new Station();
                        Station dstStation = new Station();
                        foreach(Station station in stations)
                        {
                            if (station.getName().Equals(cmboSourceStation.Text))
                            {
                                srcStation = station;
                            }
                            if (station.getName().Equals(cmboDestinationStation.Text))
                            {
                                dstStation = station;
                            }
                        }
                        ticket.setSource(srcStation);
                        ticket.setDestination(dstStation);
                        ticket.setCoach(findCoach);
                        scheduleDateLog = db.getScheduleDateLog(int.Parse(cmboScheduleID.Text), date.Value);
                        ticket.setScheduleDateLog(scheduleDateLog);
                        if (db.addTicket(ticket))
                        {
                            ticket.setId(db.getTicketId(ticket));
                           
                          
                                scheduleDateLog.setSeatsBooked(scheduleDateLog.getSeatsBooked() + 1);
                                txtSeatsBooked.Text = "" + scheduleDateLog.getSeatsBooked();
                                if (db.updateBookedTicketsCount(scheduleDateLog))
                                {
                                    MessageBox.Show("Ticket successfully added!");
                                    this.Hide();
                                    frmGenerateTicket frm = new frmGenerateTicket(active, ticket);
                                    frm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Unable to update booked seats counter!");
                                }
                        }
                        else
                        {
                            MessageBox.Show("Unable to add ticket!");
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("All seats are booked in this coach!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCalculateFare_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (!cmboCoachType.Text.Equals("") && !cmboDestinationStation.Text.Equals(cmboSourceStation.Text) && !cmboSourceStation.Text.Equals("") && !cmboDestinationStation.Text.Equals(""))
            {

                Coach findCoach = new Coach();
                foreach (Coach coach in coaches)
                {

                    if (coach.getCoachId() == int.Parse(cmboCoachType.Text))
                    {
                        findCoach = coach;
                    }
                }
                int coach_price = findCoach.getPrice();

                int route_price = schedule.getRoute().getPrice();
                 
                int srcSeqNo = db.getSeqNo(schedule.getRoute().getRouteId(), cmboSourceStation.Text);
                int dstSeqNo = db.getSeqNo(schedule.getRoute().getRouteId(), cmboDestinationStation.Text);
                int multiplier = Math.Abs(dstSeqNo - srcSeqNo);
                txtFare.Text = "" + ((multiplier * route_price) + coach_price);
            }
            else
            {
                MessageBox.Show("Error! field(s) are empty"); 
            }
        }
       
    }
}
