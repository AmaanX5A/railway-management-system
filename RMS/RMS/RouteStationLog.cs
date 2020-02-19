using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RouteStationLog
    {
        private Route route;
        private Station station;
        private DateTime startingTime;
        private DateTime endingTime;
        private int sequence_no;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker departureTime;
        private Station searchedStation;
        private int p;
     
        public RouteStationLog()
        {
            route = new Route();
            station = new Station();
            
        }
        public RouteStationLog(Route route, DateTime sTime, DateTime eTime, Station station, int sequence_no)
        {
            this.sequence_no = sequence_no;
            this.route = route;
            this.station = station;
            startingTime = sTime;
            endingTime = eTime;
        }

      
        public void setStation(Station station)
        {
            this.station = station;
        }
        public void setRoute(Route route)
        {
            this.route = route;
        }
        public Station getStation()
        {
            return station;
        }
        public Route getRoute()
        {
            return route;
        }
        public DateTime getStartingTime()
        {
            return startingTime;
        }
        public DateTime getEndingTime()
        {
            return endingTime;
        }
        public int getSequenceNo()
        {
            return sequence_no;
        }
        public void setSequenceNo(int num)
        {
            sequence_no = num;
        }
        public void setStartingTime(DateTime time)
        {
            startingTime = time;
        }
        public void setEndingTime(DateTime time)
        {
            endingTime = time;
        }
    }
}
