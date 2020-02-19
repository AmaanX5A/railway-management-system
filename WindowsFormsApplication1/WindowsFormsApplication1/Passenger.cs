using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Passenger
    {
        private Person personalInformation;
        private int pid;
        public Passenger()
        {
            personalInformation = new Person();
            pid = 0;
        }
        public Passenger(Person personalInformation)
        {
            pid = 0;
            this.personalInformation = personalInformation;
        }
        public void setPid(int pid)
        {
            this.pid = pid;        
        }
        public int getPid()
        {
            return pid;
        }
        public Person getPersonalInformation()
        {
            return personalInformation;
        }
        public void setPersonalInformation(Person personalInformation)
        {
            this.personalInformation = personalInformation;
        }

    }
}
