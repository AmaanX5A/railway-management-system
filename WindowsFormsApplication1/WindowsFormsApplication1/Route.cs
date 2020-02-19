using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Route
    {
        private int routeId;
        private int price;
        private String name;
        public Route()
        {
            routeId = 0;
            price = 0;
            name = "";
        }
        public Route(int id, int price, String name)
        {
            routeId = id;
            this.price = price;
            
            this.name = name;
        }
        public int getRouteId()
        {
            return routeId;
        }
        public void setRouteId(int id)
        {
            routeId = id;
        }
        public int getPrice()
        {
            return price;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
   
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
    }
}
