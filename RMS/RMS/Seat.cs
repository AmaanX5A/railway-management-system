using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Seat
    {
        private int seat_no;
        private int seat_id;

        public Seat()
        {
            this.seat_no = 0;
            this.seat_id = 0;
        }
        public Seat(int seat_no, int seat_id)
        {
            this.seat_id = seat_id;
            this.seat_no = seat_no;
        }

        public void setSeatId(int seat_id)
        {
            this.seat_id = seat_id;
        }
        public int getSeatId()
        {
            return seat_id;
        }
        public int getSeatNo()
        {
            return seat_no;  
        }
        public void setSeatNo(int seat_no)
        {
            this.seat_no = seat_no;
        }
    }
}
