using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Person
    {
        private String firstName;
        private String middleName;
        private String lastName;
        private String CNIC;
        private String[] cellNo;
        private String[] phoneNo;
        private DateTime dob;
        private String gender;
        private String email;
        public Person()
        {
            firstName = null;
            middleName = null;
            lastName = null;
            CNIC = null;
            cellNo = null;
            phoneNo = null;
            email = null;
            gender = null;
        }
        public Person(String firstName, String middleName, String lastName, String CNIC, String[] cellNo, String[] phoneNo, DateTime date, String email, String gender)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.gender = gender;
            this.lastName = lastName;
            this.CNIC = CNIC;
            this.cellNo = cellNo;
            this.phoneNo = phoneNo;
            this.dob = date;
            this.email = email;
  
        }
        public String getFirstName()
        {
            return firstName;
        }
        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getMiddleName()
        {
            return middleName;
        }
        public void setMiddleName(String middleName)
        {
            this.middleName = middleName;
        }
        public String getLastName()
        {
            return lastName;
        }
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getCNIC()
        {
            return CNIC;
        }
        public void setCNIC(String CNIC)
        {
            this.CNIC = CNIC;
        }
        public String[] getCellNo()
        {
            return cellNo;
        }
        public void setCellNo(String[] cellNo)
        {
            this.cellNo = cellNo;
        }
        public void addCellNo(String cellNo)
        { 
            
        }
        public bool isCellNo(String cellNo)
        {
            if (this.cellNo.Contains(cellNo))
            {
                return true;
            }
            return false;
        }
        public String[] getPhoneNo()
        {
            return phoneNo;
        }
        public void setPhoneNo(String[] phoneNo)
        {
            this.phoneNo = phoneNo;
        }
        public void addPhoneNo(String phoneNo)
        { 
            
        }
        public bool isPhoneNo(String phoneNo)
        {
            if (this.phoneNo.Contains(phoneNo))
            {
                return true;
            }
            return false;
        }
        public void setDateOfBirth(DateTime date)
        {
            this.dob = date;
        }
        public DateTime getDateOfBirth()
        {
            return dob;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }
        public void setGender(String gender)
        {
            this.gender = gender;
        }
        public String getGender()
        {
            return gender;
        }
    }
}
