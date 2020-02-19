using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public  class CoachTrainLog
    {
        
        private Train train;
        private List<Coach> coaches;
        private int availableSeats;
        public CoachTrainLog()
        {
            train = new Train();
            coaches = null;
        }
        public CoachTrainLog(Train train, List<Coach> coaches)
        {
            this.train = train;
            this.coaches = coaches;
        }

        public Train getTrain()
        {
            return train;
        }

        public void setTrain(Train train)
        {
            this.train = train;
        }
        public void setCoaches(List<Coach> coaches)
        {
            this.coaches = coaches;
        }

        public void addCoach(Coach coach)
        {
            coaches.Add(coach);
        }
        public bool removeCoach(Coach coach)
        {
            return coaches.Remove(coach);
        }
        public bool findCoach(Coach coach)
        {
           if(false == coaches.Equals(coach))
           {
            return false;
           }
           else
           {
            return true;
           }
        }
        public int getAvailableSeats()
        {
            return availableSeats;
        }
        public void setAvailableSeats(int val)
        {
            availableSeats = val;
        }
    }
}
