using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Station
    {
        private String name;
        private int station_id;
        private double longitude;
        private double latitude;
        public Station()
        {
            longitude = 0.0;
            latitude = 0.0;
            name = null;
            station_id = 0;
        }
        public Station(String name, int station_id, double longitude, double latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.name = name;
            this.station_id = station_id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public int getStationId()
        {
            return station_id;
        }
        public void setStationId(int station_id)
        {
            this.station_id = station_id;
        }
        public void setLongitude(double longitude)
        {
            this.longitude = longitude;        
        }
        public void setLatitude(double latitude)
        {
            this.latitude = latitude;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongtitude()
        {
            return longitude;
        }
    
       }
}
