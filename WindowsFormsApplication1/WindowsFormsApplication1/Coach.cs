using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Coach
    {
        private int coach_id;
        private int no_of_seats;
        private String coach_type;
        private int price;

        public Coach()
        {
            coach_id = 0;
            no_of_seats = 0;
            coach_type = null;
            price = 0;
        }

        public Coach(int coach_id, int no_of_seats, String coach_type, int price)
        {
            this.coach_id = coach_id;
            this.no_of_seats = no_of_seats;
            this.coach_type = coach_type;
            this.price = price;
        }

        public int getCoachId()
        {
            return coach_id;
        }
        public void setCoachId(int id)
        {
            coach_id = id;
        }
        public int getNoOfSeats()
        {
            return no_of_seats;
        }
        public void setNoOfSeats(int no_of_seats)
        {
            this.no_of_seats = no_of_seats;
        }
        public String getCoachType()
        {
            return coach_type;
        }
        public void setCoachType(String type)
        {
            coach_type = type;
        }
        public int getPrice()
        {
            return price;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
    }
}
