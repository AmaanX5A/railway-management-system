using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Ticket
    {
        private int id;
        private Passenger passenger;
        private int fare;
        private int seat;
        private Station source;
        private Station destination;
        private Coach coach;
        private ScheduleDateLog log;
        public Ticket()
        {
            id = 0;
            passenger = new Passenger();
            fare = 0;
            source = new Station();
            destination = new Station();
            coach = new Coach();
            log = new ScheduleDateLog();
        }
        public Ticket(int id, int fare, Passenger passenger, Train train, DateTime date, int seat,
                      Station source, Station destination, DateTime time, Coach coach, ScheduleDateLog log)
        {
            this.log = log;
            this.coach = coach;
            this.id = id;
            this.passenger = passenger;
            this.fare = fare;
            this.seat = seat;
            this.source = source;
            this.destination = destination;
        }
        public void setCoach(Coach coach)
        {
            this.coach = coach;
        }
        public Coach getCoach()
        {
            return coach;
        }

        public void setScheduleDateLog(ScheduleDateLog log)
        {
            this.log = log;
        }
        public ScheduleDateLog getScheduleDateLog()
        {
            return log;
        }
        public Passenger getPassenger()
        {
            return passenger;
        }
        public void setPassenger(Passenger passenger)
        {
            this.passenger = passenger;
        }
       
       
        public int getFare()
        {
            return fare;
        }
        public void setFare(int fare)
        {
            this.fare = fare;
        }
        public void setSeat(int seat)
        {
            this.seat = seat;
        }
        public int getSeat()
        {
            return seat;
        }
        public Station getDestination()
        {
            return destination;
        }
        public Station getSource()
        {
            return source;
        }
         public int getId()
        {
            return id;
        }
        public void setDestination(Station destination)
        {
            this.destination = destination;
        }
        public void setSource(Station source)
        {
            this.source = source;
        }
        public void setId(int id)
        {
            this.id = id;
        }
    }
}
