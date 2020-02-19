using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ScheduleDateLog
    {
        private int schedule_id;
        private int seats_booked;
        private int serial_no;
        private DateTime date;
        public ScheduleDateLog()
        {
            schedule_id = 0;
            seats_booked = 0;
            serial_no = 0;
           
        }
        public ScheduleDateLog(int schedule_id, int seats_booked, int serial_no, DateTime date)
        {
            this.serial_no = serial_no;
            this.seats_booked = seats_booked;
            this.schedule_id = schedule_id;
            this.date = date;
        }

        public void setSerialNo(int serial_no)
        { 
            this.serial_no = serial_no;
        }
        public int getSerialNo()
        { 
            return serial_no;
        }
        public void setScheduleID(int schedule_id)
        {
            this.schedule_id = schedule_id;
        }
        public int getScheduleID()
        {
            return schedule_id;
        }
        public void setSeatsBooked(int seats_booked)
        {
            this.seats_booked = seats_booked;
        }
        public int getSeatsBooked()
        {
            return seats_booked;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }
        public DateTime getDate()
        {
            return date;
        }


    }
}
