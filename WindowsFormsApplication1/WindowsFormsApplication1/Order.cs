using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Order
    {
        private int order_id;
        private Station source;
        private Station destination;
        private DateTime dop;
        private String category;
        private int payment;

        public Order()
        {
            order_id = 0;
            source = new Station();
            destination = new Station();
            payment = 0;
            category = null;
            dop = new DateTime();
        }
        public Order(int id, int payment, Station source, Station destination, String category, DateTime dop)
        {
            order_id = id;
            this.source = source;
            this.destination = destination;
            this.payment = payment;
            this.category = category;
            this.dop = dop;
        }
        public void setOrderId(int order_id)
        {
            this.order_id = order_id;
        }
        public int getOrderId()
        {
            return order_id;
        }
        public void setSourceStation(Station station)
        {
            this.source=station;
        }
        public Station getSourceStation()
        {
            return this.source;
        }
        public void setDestinationStation(Station station)
        {
            this.destination = station;
        }
        public Station getDestinationStation()
        {
            return this.destination;
        }
        public void setDop(DateTime dop)
        {
            this.dop = dop;
        }
        public DateTime getDop()
        {
            return this.dop;
        }
        public void setCatagory(String catagory)
        {
            this.category = catagory;
        }
        public String getCatagory()
        {
            return this.category;
        }
        public void setPayment(int payment)
        {
            this.payment = payment;
        }
        public int getPayment()
        {
            return this.payment;
        }
    }
    
}
