using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class EmployeeAddress
    {
        private String country;
        private String city;
        private String province;
        private String house_no;
        private String street;
        private int zip_code;
        public EmployeeAddress()
        {
            country = null;
            city = null;
            province = null;
            house_no = null;
            street = null;
            zip_code = 0;
        }
        public EmployeeAddress(String country, String city, String province, String house_no, String street, int zip_code)
        {
            this.country = country;
            this.city = city;
            this.province = province;
            this.house_no = house_no;
            this.street = street;
            this.zip_code = zip_code;
        }
        public void setCountry(String country)
        {
            this.country = country;
        }
        public String getCountry()
        {
            return country;
        }
        public String getCity()
        {
            return city;
        }
        public void setCity(String city)
        {
            this.city = city;
        }
        public String getProvince()
        {
            return province;
        }
        public void setProvince(String province)
        {
            this.province = province;
        }
        public void setHouseNo(String house_no)
        {
            this.house_no = house_no;
        }
        public String getHouseNo()
        {
            return house_no;
        }
        public String getStreet()
        {
            return street;
        }
        public void setStreet(String street)
        {
            this.street = street;
        }
        public void setZipCode(int zip_code)
        {
            this.zip_code = zip_code;
        }
        public int getZipCode()
        {
            return zip_code;
        }
    }
}
