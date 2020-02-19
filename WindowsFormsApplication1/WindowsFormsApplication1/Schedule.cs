using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Schedule
    {
        private Route route;
        private Train train;
        private int id;
        public Schedule()
        {
            route = new Route();
            train = new Train();
            id = 0;
        }
        public Schedule(Train train, int id, Route route)
        {
            this.route = route;
            this.id = id;
            this.train = train;
        }
  
        public Train getTrain()
        {
            return train;
        }
        public int getId()
        {
            return id;
        }
   
        public void setTrain(Train train)
        {
            this.train = train;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setRoute(Route route)
        {
            this.route = route;
        }
        public Route getRoute()
        {
            return route;
        }
    }
}
