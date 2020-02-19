using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Employee
    {
        private int emp_id;
        private Person personalInformation;
        private String qualification;
        private String designation;
        private String rank;
        private int salary;
        private int station_id;
        private int reg_no;
        private String password;
        private String allowed_signin;
        private DateTime dateOfHire;
        private EmployeeAddress address;
        public Employee()
        {
            emp_id = 0;
            qualification = null;
            personalInformation = null;
            designation = null;
            rank = null;
            salary = 0;
            station_id = 0;
            reg_no = 0;
            password = null;
            address = null;
            allowed_signin = null;
        }
        public Employee(int emp_id, Person personalInformation, String qualification, String designation, String rank,
                        int salary, int station_id, int reg_no, String password, EmployeeAddress address, DateTime dateOfHire )
        {
            this.emp_id = emp_id;
            this.qualification = qualification;
            this.personalInformation = personalInformation;
            this.designation = designation;
            this.rank = rank;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
            this.station_id = station_id;
            this.reg_no = reg_no;
            allowed_signin = null;
            this.address = address;
            this.password = password ;
        }
        public Employee(int emp_id, Person personalInformation, String qualification, String designation, String rank,
                        int salary, String password)
        {
            this.emp_id = emp_id;
            this.qualification = qualification;
            this.personalInformation = personalInformation;
            this.designation = designation;
            this.rank = rank;
            this.salary = salary;
            this.station_id = 0;
            this.reg_no = 0;
            allowed_signin = null;
            this.password = password;
            this.address = new EmployeeAddress();
        }
        public Employee(String password, Person personalInformation)
        {
            emp_id = 0;
            qualification = null;
            this.personalInformation = personalInformation;
            designation = null;
            rank = null;
            salary = 0;
            station_id = 0;
            reg_no = 0;
            this.password = password;
            this.address = new EmployeeAddress();
            allowed_signin = null;
        }
        public int getEmp_id()
        {
            return emp_id;
        }
        public void setEmp_id(int emp_id)
        {
            this.emp_id = emp_id;
        }
        public Person getPersonalInformation()
        {
            return personalInformation;       
        }
        public void setPersonalInformation(Person personalInformation)
        {
            this.personalInformation = personalInformation;
        }
        public void setQualification(String qualification)
        {
            this.qualification = qualification;
        }
        public String getQualification()
        {
            return qualification;
        }
        public void setDesignation(String designation)
        {
            this.designation = designation;
        }
        public String getDesignation()
        {
            return designation;
        }
        public String getRank()
        {
            return rank;
        }
        public void setRank(String rank)
        {
            this.rank = rank;
        }
        public String getPassword()
        {
            return password;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setAllowedSignIn(String allowed_signin)
        {
            this.allowed_signin = allowed_signin;
        }
        public String getAllowedSignIn()
        {
            return this.allowed_signin;
        }
        public EmployeeAddress getAddress()
        {
            return address;
        }
        public void setAddress(EmployeeAddress address)
        {
            this.address = address;
        }
        public DateTime getDateOfHire()
        {
            return dateOfHire;
        }
        public void setDateOfHire(DateTime date)
        {
            dateOfHire = date;
        }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
    }
}
