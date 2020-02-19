using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Train
    {
       private String regNo;
       private String engineNo;
       private String type;
       private String modelNo;
       private DateTime startingDate;
       public Train()
       {
           regNo = null;
           engineNo = null;
           type = null;
           modelNo = null;
       }

       public Train(String regNo, String engineNo, String type, String modelNo, DateTime date)
       {
           this.regNo = regNo;
           this.engineNo = engineNo;
           this.type = type;
           this.startingDate = date;
           this.modelNo = modelNo;
       }
       public void setRegNo(String regNo)
       {
           this.regNo = regNo;
       }
       public String getRegNo()
       {
           return regNo;
       }
       public void setEngineNo(String engineNo)
       {
           this.engineNo = engineNo;
       }
       public String getEngineNo()
       {
           return engineNo;
       }
       public String getType()
       {
           return type;
       }
       public void setType(String type)
       {
           this.type = type;
       }
       public void setModelNo(String modelNo)
       {
           this.modelNo = modelNo;
       }
       public String getModelNo()
       {
           return modelNo;
       }
       public void setStartingDate(DateTime date)
       {
           this.startingDate = date;
       }

       public DateTime getStartingDate()
       {
           return startingDate;
       }
    }
}
