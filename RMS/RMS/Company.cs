using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Company
    {
        private int company_id;
        private String name;
        private String email;
        private String cellNo;
        private String phoneNo;
        public Company()
        {
            company_id = 0;
            name = null;
            email = null;
            cellNo = null;
            phoneNo = null;
        }
        public Company(int company_id, String name, String email, String cellNo, String phoneNo)
        {
            this.company_id = company_id;
            this.name = name;
            this.email = email;
            this.cellNo = cellNo;
            this.phoneNo = phoneNo;
        }
        public int getCompanyId()
        {
            return company_id;
        }
        public void setCompanyId(int id)
        {
            company_id = id;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getCellNo()
        {
            return cellNo;
        }
        public void setCellNo(String cellNo)
        {
            this.cellNo = cellNo;
        }
        public String getPhoneNo()
        {
            return phoneNo;
        }
        public void setPhoneNo(String phoneNo)
        {
            this.phoneNo = phoneNo;
        }      
    }
}
