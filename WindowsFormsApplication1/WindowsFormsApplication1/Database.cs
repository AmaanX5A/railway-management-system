using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter da;
        public Database()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=rms;Integrated Security=True");
        }
        public bool SignUp(Employee Emp)
        {

            return true;
        }
        public bool loginAdmin(String Email, String Password)
        {
            try
            {
                String email;
                String allowed;
                String password;
                String designation;
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT personTable.email, employeeTable.allowed_signin, employeeTable.password, employeeTable.designation " +
                "FROM employeeTable " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "WHERE employeeTable.password LIKE '" + Password + "' AND personTable.email LIKE '" + Email + "'";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = reader.GetString(0);
                    allowed = reader.GetString(1);
                    password = reader.GetString(2);
                    designation = reader.GetString(3);
                    if (email.Equals(Email) && password.Equals(Password) && allowed.Equals("1") && designation.Equals("Admin"))
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            con.Close();
            return false;

        }
        public bool addEmployee(Employee emp)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO personTable (cnic, dob, email, gender) VALUES (@cnic, @dob, @email, @gender)";
                cmd.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                cmd.Parameters.AddWithValue("dob", emp.getPersonalInformation().getDateOfBirth().Date);
                cmd.Parameters.AddWithValue("email", emp.getPersonalInformation().getEmail());
                cmd.Parameters.AddWithValue("gender", emp.getPersonalInformation().getGender());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    cmd.CommandText = "INSERT INTO personName (cnic, first_name, middle_name, last_name) VALUES (@cnic, @first_name, @middle_name, @last_name)";
                    cmd.Parameters.AddWithValue("first_name", emp.getPersonalInformation().getFirstName());
                    cmd.Parameters.AddWithValue("middle_name", emp.getPersonalInformation().getMiddleName());
                    cmd.Parameters.AddWithValue("Last_name", emp.getPersonalInformation().getLastName());

                    count = 0;
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count == 1)
                    {
                        String[] phone = emp.getPersonalInformation().getPhoneNo();
                        String[] cell = emp.getPersonalInformation().getCellNo();
                        int i = 0, j = 0;
                        while (i < phone.Length || j < cell.Length)
                        {
                            SqlCommand cmdTemp = new SqlCommand();
                            cmdTemp.Connection = con;
                            cmdTemp.CommandText = "INSERT INTO personContactNo (cnic, mobile_no, phone_no) VALUES (@cnic, @mobile_no, @phone_no)";
                            cmdTemp.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                            if (i < phone.Length)
                            {
                                cmdTemp.Parameters.AddWithValue("phone_no", phone[i]);
                                i++;
                            }
                            if (j < cell.Length)
                            {
                                cmdTemp.Parameters.AddWithValue("mobile_no", cell[j]);
                                j++;
                            }
                            con.Open();
                            cmdTemp.ExecuteNonQuery();
                            con.Close();
                        }

                        if (count == 1)
                        {
                            cmd.CommandText = "SELECT MAX(emp_id) FROM employeeTable";
                            con.Open();
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            int id = reader.GetInt32(0);
                            cmd.Cancel();
                            con.Close();
                            cmd.CommandText = "INSERT INTO employeeTable (emp_id, qualification, designation, cnic, rank, salary, password, allowed_signin, doh) VALUES (@emp_id, @qualification, @designation, @cnic, @rank, @salary, @password, @allowed_signin, @doh)";
                            cmd.Parameters.AddWithValue("emp_id", id + 1);
                            cmd.Parameters.AddWithValue("qualification", emp.getQualification());
                            cmd.Parameters.AddWithValue("designation", emp.getDesignation());
                            cmd.Parameters.AddWithValue("rank", emp.getRank());
                            cmd.Parameters.AddWithValue("salary", emp.getSalary());
                            cmd.Parameters.AddWithValue("password", emp.getPassword());
                            cmd.Parameters.AddWithValue("allowed_signin", emp.getAllowedSignIn());
                            cmd.Parameters.AddWithValue("doh", emp.getDateOfHire());
                            count = 0;
                            con.Open();
                            count = cmd.ExecuteNonQuery();
                            cmd.Cancel();
                            con.Close();
                            if (count == 1)
                            {
                                cmd.CommandText = "INSERT INTO employeeAddress (emp_id, country, city, province, house_no, street, zip_code) VALUES (@emp_id, @country, @city, @province, @house_no, @street, @zip_code)";
                                cmd.Parameters.AddWithValue("country", emp.getAddress().getCountry());
                                cmd.Parameters.AddWithValue("city", emp.getAddress().getCity());
                                cmd.Parameters.AddWithValue("province", emp.getAddress().getProvince());
                                cmd.Parameters.AddWithValue("house_no", emp.getAddress().getHouseNo());
                                cmd.Parameters.AddWithValue("street", emp.getAddress().getStreet());
                                cmd.Parameters.AddWithValue("zip_code", emp.getAddress().getZipCode());
                                count = 0;
                                con.Open();
                                count = cmd.ExecuteNonQuery();
                                cmd.Cancel();
                                con.Close();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public int getEmployeeID(String Email, String Password)
        {
            int id = 0;
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT employeeTable.emp_id " +
            "FROM employeeTable " +
            "INNER JOIN personTable " +
            "ON employeeTable.cnic = personTable.cnic " +
            "WHERE employeeTable.password LIKE '" + Password + "' AND personTable.email LIKE '" + Email + "'";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            con.Close();
            return id;

        }
        public bool loginManager(String Email, String Password)
        {
            try
            {
                String email;
                String allowed;
                String password;
                String designation;
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT personTable.email, employeeTable.allowed_signin, employeeTable.password, employeeTable.designation " +
                "FROM employeeTable " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "WHERE employeeTable.password LIKE '" + Password + "' AND personTable.email LIKE '" + Email + "'";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = reader.GetString(0);
                    allowed = reader.GetString(1);
                    password = reader.GetString(2);
                    designation = reader.GetString(3);
                    if (email.Equals(Email) && password.Equals(Password) && allowed.Equals("1") && designation.Equals("Manager"))
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            con.Close();
            return false;

        }
        public bool insertEmployee(Employee emp)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO personTable (cnic, dob, email, gender) VALUES (@cnic, @dob, @email, @gender)";
                cmd.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                cmd.Parameters.AddWithValue("dob", emp.getPersonalInformation().getDateOfBirth().Date);
                cmd.Parameters.AddWithValue("email", emp.getPersonalInformation().getEmail());
                cmd.Parameters.AddWithValue("gender", emp.getPersonalInformation().getGender());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    cmd.Dispose();
                    cmd.CommandText = "INSERT INTO personName (cnic, first_name, middle_name, last_name) VALUES (@cnic, @first_name, @middle_name, @last_name)";
                    cmd.Parameters.AddWithValue("first_name", emp.getPersonalInformation().getFirstName());
                    cmd.Parameters.AddWithValue("middle_name", emp.getPersonalInformation().getMiddleName());
                    cmd.Parameters.AddWithValue("Last_name", emp.getPersonalInformation().getLastName());

                    count = 0;
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count == 1)
                    {
                        String[] phone = emp.getPersonalInformation().getPhoneNo();
                        String[] cell = emp.getPersonalInformation().getCellNo();
                        int i = 0, j = 0;
                        while (i < phone.Length || j < cell.Length)
                        {
                            SqlCommand cmdTemp = new SqlCommand();
                            cmdTemp.Connection = con;
                            cmdTemp.CommandText = "INSERT INTO personContactNo (cnic, mobile_no, phone_no) VALUES (@cnic, @mobile_no, @phone_no)";
                            cmdTemp.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                            if (i < phone.Length)
                            {
                                cmdTemp.Parameters.AddWithValue("phone_no", phone[i]);
                                i++;
                            }
                            if (j < cell.Length)
                            {
                                cmdTemp.Parameters.AddWithValue("mobile_no", cell[j]);
                                j++;
                            }
                            con.Open();
                            cmdTemp.ExecuteNonQuery();
                            con.Close();
                        }
                        if (count == 1)
                        {
                            cmd.CommandText = "SELECT MAX(emp_id) FROM employeeTable";
                            con.Open();
                            reader = cmd.ExecuteReader();
                            reader.Read();
                            int id = reader.GetInt32(0);
                            cmd.Cancel();
                            con.Close();
                            cmd.CommandText = "INSERT INTO employeeTable (emp_id, qualification, designation, cnic, rank, salary, password, doh) VALUES (@emp_id, @qualification, @designation, @cnic, @rank, @salary, @password, @doh)";
                            cmd.Parameters.AddWithValue("emp_id", id + 1);
                            cmd.Parameters.AddWithValue("doh", emp.getDateOfHire());
                            cmd.Parameters.AddWithValue("qualification", emp.getQualification());
                            cmd.Parameters.AddWithValue("designation", emp.getDesignation());
                            cmd.Parameters.AddWithValue("rank", emp.getRank());
                            cmd.Parameters.AddWithValue("salary", emp.getSalary());
                            cmd.Parameters.AddWithValue("password", emp.getPassword());
                            count = 0;
                            con.Open();
                            count = cmd.ExecuteNonQuery();
                            cmd.Cancel();
                            con.Close();
                            if (count == 1)
                            {
                                cmd.CommandText = "INSERT INTO employeeAddress (emp_id, country, city, province, house_no, street, zip_code) VALUES (@emp_id, @country, @city, @province, @house_no, @street, @zip_code)";
                                cmd.Parameters.AddWithValue("country", emp.getAddress().getCountry());
                                cmd.Parameters.AddWithValue("city", emp.getAddress().getCity());
                                cmd.Parameters.AddWithValue("province", emp.getAddress().getProvince());
                                cmd.Parameters.AddWithValue("house_no", emp.getAddress().getHouseNo());
                                cmd.Parameters.AddWithValue("street", emp.getAddress().getStreet());
                                cmd.Parameters.AddWithValue("zip_code", emp.getAddress().getZipCode());
                                count = 0;
                                con.Open();
                                count = cmd.ExecuteNonQuery();
                                cmd.Cancel();
                                con.Close();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool loginOperator(String Email, String Password)
        {
            try
            {
                String email;
                String allowed;
                String password;
                String designation;
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT personTable.email, employeeTable.allowed_signin, employeeTable.password, employeeTable.designation " +
                "FROM employeeTable " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "WHERE employeeTable.password LIKE '" + Password + "' AND personTable.email LIKE '" + Email + "'";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = reader.GetString(0);
                    allowed = reader.GetString(1);
                    password = reader.GetString(2);
                    designation = reader.GetString(3);
                    if (email.Equals(Email) && password.Equals(Password) && allowed.Equals("1") && designation.Equals("Operator"))
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            con.Close();
            return false;
        }
        public Employee searchEmployee(String id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT DISTINCT personTable.*, employeeTable.*, personName.*, employeeAddress.*,  personContactNo.* " +
                "FROM employeeTable " +
                "FULL JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "FULL JOIN personName " +
                "ON personName.cnic = personTable.cnic " +
                "FULL JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic " +
                "FULL JOIN employeeAddress " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "WHERE employeeTable.emp_id = " + int.Parse(id);
                con.Open();
                reader = cmd.ExecuteReader();
                Employee emp = new Employee();
                Person person = new Person();
                EmployeeAddress address = new EmployeeAddress();
                String[] phone = new String[3];
                String[] cellno = new String[3];
                int count = 0;
                while (reader.Read())
                {
                    if (count == 0)
                    {
                        person.setFirstName(reader["first_name"].ToString());
                        person.setMiddleName(reader["middle_name"].ToString());
                        person.setLastName(reader["last_name"].ToString());
                        person.setCNIC(reader["cnic"].ToString());
                        person.setGender(reader["gender"].ToString());
                        person.setDateOfBirth(DateTime.Parse(reader["dob"].ToString()));
                        person.setEmail(reader["email"].ToString());
                        address.setCountry(reader["country"].ToString());
                        address.setCity(reader["city"].ToString());
                        address.setHouseNo(reader["house_no"].ToString());
                        address.setProvince(reader["province"].ToString());
                        address.setStreet(reader["street"].ToString());
                        address.setZipCode(int.Parse(reader["zip_code"].ToString()));
                        emp.setEmp_id(int.Parse(reader["emp_id"].ToString()));
                        emp.setPassword(reader["password"].ToString());
                        emp.setDesignation(reader["designation"].ToString());
                        emp.setQualification(reader["qualification"].ToString());
                        emp.setRank(reader["rank"].ToString());
                        emp.setSalary(int.Parse(reader["salary"].ToString()));
                        emp.setDateOfHire(DateTime.Parse(reader["doh"].ToString()));
                        emp.setAllowedSignIn(reader["allowed_signin"].ToString());
                        emp.setAddress(address);
                    }
                    phone[count] = reader["phone_no"].ToString();
                    cellno[count] = reader["mobile_no"].ToString();
                    count++;
                }
                person.setCellNo(cellno);
                person.setPhoneNo(phone);
                emp.setPersonalInformation(person);
                con.Close();
                return emp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool editEmployee(Employee emp)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "UPDATE personTable SET email = @email, personTable.dob = @dob, gender = @gender WHERE cnic = @cnic";
                cmd.Parameters.AddWithValue("dob", emp.getPersonalInformation().getDateOfBirth().Date);
                cmd.Parameters.AddWithValue("email", emp.getPersonalInformation().getEmail());
                cmd.Parameters.AddWithValue("gender", emp.getPersonalInformation().getGender());
                cmd.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE  personName SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name WHERE cnic = @cnic";
                cmd.Parameters.AddWithValue("first_name", emp.getPersonalInformation().getFirstName());
                cmd.Parameters.AddWithValue("middle_name", emp.getPersonalInformation().getMiddleName());
                cmd.Parameters.AddWithValue("Last_name", emp.getPersonalInformation().getLastName());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE employeeTable SET employeeTable.qualification = @qualification, employeeTable.designation = @designation, employeeTable.rank = @rank, employeeTable.salary = @salary, "
                + "employeeTable.password = @password, employeeTable.allowed_signin = @allowed_signin, employeeTable.doh = @doh WHERE emp_id = @emp_id";
                cmd.Parameters.AddWithValue("qualification", emp.getQualification());
                cmd.Parameters.AddWithValue("designation", emp.getDesignation());
                cmd.Parameters.AddWithValue("rank", emp.getRank());
                cmd.Parameters.AddWithValue("salary", emp.getSalary());
                cmd.Parameters.AddWithValue("password", emp.getPassword());
                cmd.Parameters.AddWithValue("allowed_signin", emp.getAllowedSignIn());
                cmd.Parameters.AddWithValue("doh", emp.getDateOfHire());
                cmd.Parameters.AddWithValue("emp_id", emp.getEmp_id());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE employeeAddress SET employeeAddress.country = @country, employeeAddress.city = @city, employeeAddress.province = @province, employeeAddress.house_no = @house_no, employeeAddress.street = @street, employeeAddress.zip_code = @zip_code" +
                " WHERE emp_id = " + emp.getEmp_id();
                cmd.Parameters.AddWithValue("country", emp.getAddress().getCountry());
                cmd.Parameters.AddWithValue("city", emp.getAddress().getCity());
                cmd.Parameters.AddWithValue("province", emp.getAddress().getProvince());
                cmd.Parameters.AddWithValue("house_no", emp.getAddress().getHouseNo());
                cmd.Parameters.AddWithValue("street", emp.getAddress().getStreet());
                cmd.Parameters.AddWithValue("zip_code", emp.getAddress().getZipCode());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool removeEmployee(int id)
        {
            try
            {
                String cnic = getEmployeeCNIC(id);
                if (cnic == null)
                {
                    return false;
                }

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM personContactNo" +
                " WHERE personContactNo.cnic IN (SELECT cnic FROM employeeTable WHERE emp_id = " + id + ")";
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count <= 3)
                {
                    count = 0;
                    cmd.CommandText = "DELETE FROM employeeAddress " +
                    "WHERE emp_id = @id";
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count == 1)
                    {
                        count = 0;
                        cmd.CommandText = "DELETE FROM employeeTable " +
                        "WHERE emp_id = @id";
                        con.Open();
                        count = cmd.ExecuteNonQuery();
                        con.Close();

                        if (count == 1)
                        {
                            count = 0;
                            cmd.CommandText = "DELETE FROM personName " +
                            "WHERE personTable.cnic = @cnic";
                            cmd.Parameters.AddWithValue("cnic", cnic);
                            con.Open();
                            count = cmd.ExecuteNonQuery();
                            con.Close();

                            if (count == 1)
                            {
                                count = 0;
                                cmd.CommandText = "DELETE FROM personTable " +
                                "WHERE personTable.cnic = @cnic";
                                con.Open();
                                count = cmd.ExecuteNonQuery();
                                con.Close();
                                if (count == 1)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public SqlDataAdapter employeeDetails(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT DISTINCT personTable.*, employeeTable.*, personName.*, employeeAddress.*,  personContactNo.* " +
                "FROM employeeTable " +
                "FULL JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "FULL JOIN personName " +
                "ON personName.cnic = personTable.cnic " +
                "FULL JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic " +
                "FULL JOIN employeeAddress " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "WHERE employeeTable.emp_id = " + id;
                da = new SqlDataAdapter(cmd);
                return da;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public bool addCoach(Coach coach)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO coachTable (coach_id, no_of_seats, coach_type, price) VALUES (@coach_id, @no_of_seats, @coach_type, @price)";
                cmd.Parameters.AddWithValue("coach_id", coach.getCoachId());
                cmd.Parameters.AddWithValue("no_of_seats", coach.getNoOfSeats());
                cmd.Parameters.AddWithValue("coach_type", coach.getCoachType());
                cmd.Parameters.AddWithValue("price", coach.getPrice());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool addSchedule(Schedule schedule)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO scheduleTable VALUES (@reg_no, @schedule_id, @route_id)";
                cmd.Parameters.AddWithValue("@reg_no", schedule.getRoute().getRouteId());
                cmd.Parameters.AddWithValue("@schedule_id", schedule.getId());
                cmd.Parameters.AddWithValue("@route_id", schedule.getTrain().getRegNo());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //try
            //{
            //    cmd = new SqlCommand();
            //    cmd.CommandType = System.Data.CommandType.Text;
            //    cmd.Connection = con;
            //    cmd.CommandText = "INSERT INTO scheduleTable (destination, source, reg_no, schedule_id, time) VALUES (@destination, @source, @reg_no, @schedule_id, @time)";
            //    cmd.Parameters.AddWithValue("destination", schedule.getDestination().getStationId());
            //    cmd.Parameters.AddWithValue("source", schedule.getSource().getStationId());
            //    cmd.Parameters.AddWithValue("reg_no", schedule.getTrain().getRegNo());
            //    cmd.Parameters.AddWithValue("schedule_id", schedule.getId());
            //    cmd.Parameters.AddWithValue("time", schedule.getTime().TimeOfDay);
            //    con.Open();
            //    int count = cmd.ExecuteNonQuery();
            //    con.Close();
            //    if (count == 1)
            //    {
            //        return true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //return false;
        }
        public DataTable searchSchedule(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "SELECT ScheduleTable.*, stationTable.name, routeStationLog.* FROM scheduleTable INNER JOIN routeStationLog ON ScheduleTable.route_id = routeStationLog.route_id INNER JOIN stationTable ON routeStationLog.station_id = stationTable.station_id  where schedule_id=" + id;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool removeSchedule(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "DELETE scheduleTable FROM scheduleTable where schedule_id=" + id;
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public DataTable searchEmployeeByCNIC(String CNIC)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT employeeTable.*, employeeAddress.*, personTable.*, personName.*, personContactNo.* " +
                "FROM employeeAddress " +
                "INNER JOIN employeeTable " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "INNER JOIN personName " +
                "ON personTable.cnic = personName.cnic " +
                "INNER JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic " +
                "WHERE employeeTable.CNIC = @CNIC";
                cmd.Parameters.AddWithValue("@CNIC", CNIC);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable searchEmployeeByID(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT employeeTable.*, employeeAddress.*, personTable.*, personName.*, personContactNo.* " +
                "FROM employeeAddress " +
                "INNER JOIN employeeTable " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "INNER JOIN personName " +
                "ON personTable.cnic = personName.cnic " +
                "INNER JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic " +
                "WHERE employeeTable.emp_id = @id";
                cmd.Parameters.AddWithValue("id", id);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable searchEmployeeByDesignation(String desgination)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT employeeTable.*, employeeAddress.*, personTable.*, personName.*, personContactNo.* " +
                "FROM employeeAddress " +
                "INNER JOIN employeeTable " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "INNER JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "INNER JOIN personName " +
                "ON personTable.cnic = personName.cnic " +
                "INNER JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic " +
                "WHERE employeeTable.designation = @designation";
                cmd.Parameters.AddWithValue("@designation", desgination);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable searchAllEmployees()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT employeeTable.*, employeeAddress.*, personTable.*, personName.*, personContactNo.* " +
                "FROM employeeAddress " +
                "FULL JOIN employeeTable " +
                "ON employeeTable.emp_id = employeeAddress.emp_id " +
                "FULL JOIN personTable " +
                "ON employeeTable.cnic = personTable.cnic " +
                "FULL JOIN personName " +
                "ON personTable.cnic = personName.cnic " +
                "FULL JOIN personContactNo " +
                "ON personName.cnic = personContactNo.cnic ";
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public String getEmployeeCNIC(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT cnic FROM employeeTable WHERE emp_id = @id";
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                String cnic = null;
                while (reader.Read())
                {
                    cnic = reader.GetString(0);
                }
                con.Close();
                return cnic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool addStation(Station stn)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT MAX(station_id) FROM stationTable";
                reader = cmd.ExecuteReader();
                int id = 0;
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                id++;
                stn.setStationId(id);
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO stationTable(station_id, name) values(@station_id, @name)";
                cmd.Parameters.AddWithValue("station_id", stn.getStationId());
                cmd.Parameters.AddWithValue("name", stn.getName());
                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count == 1)
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO coordinates(station_id, Longitude, Latitude) values(@station_id, @Longitude, @Latitude)";
                    cmd.Parameters.AddWithValue("Longitude", stn.getLongtitude());
                    cmd.Parameters.AddWithValue("Latitude", stn.getLatitude());
                    int count2 = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count2 == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool addCompnay(Company company)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO companyTable(company_id, name, email) values(@company_id, @name, @email)";
                cmd.Parameters.AddWithValue("company_id", company.getCompanyId());
                cmd.Parameters.AddWithValue("name", company.getName());
                cmd.Parameters.AddWithValue("email", company.getEmail());
                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count == 1)
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO companyContactNo(company_id, phone_no, mobile_no) values(@company_id, @phone_no, @mobile_no)";
                    cmd.Parameters.AddWithValue("phone_no", company.getPhoneNo());
                    cmd.Parameters.AddWithValue("mobile_no", company.getCellNo());
                    int count2 = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count2 == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public DataTable searchCompany(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM companyTable where company_id=" + id;
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool removeCompany(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM companyContactNo where company_id=" + id;
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    cmd.CommandText = "DELETE FROM companyTable where company_id=" + id;
                    con.Open();
                    int count2 = cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool addTrain(Train train)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO trainTable (reg_no, engine_no, type, model_no, starting_date) values(@reg_no, @engine_no, @type, @model_no, @starting_date)";
                cmd.Parameters.AddWithValue("reg_no", train.getRegNo());
                cmd.Parameters.AddWithValue("engine_no", train.getEngineNo());
                cmd.Parameters.AddWithValue("type", train.getType());
                cmd.Parameters.AddWithValue("model_no", train.getType());
                cmd.Parameters.AddWithValue("starting_date", train.getStartingDate().Date);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<String> getCoachIDs()
        {
            try
            {
                List<String> coachIDs = new List<String>();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT coach_id FROM coachTable";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coachIDs.Add("" + reader.GetInt32(0));
                }
                con.Close();
                return coachIDs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool addCoachToTrain(String regNo, String coachID)
        {
            try
            {
                if (searchTrain(regNo))
                {
                    if (!(isCoachAllocated(coachID)))
                    {
                        int count = 0;
                        cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO coachTrainLog (reg_no, coach_id) VALUES (@reg_no, @coachID)";
                        cmd.Parameters.AddWithValue("reg_no", regNo);
                        cmd.Parameters.AddWithValue("coachID", int.Parse(coachID));
                        con.Open();
                        count = cmd.ExecuteNonQuery();
                        con.Close();
                        if (count > 0)
                        {
                            count = 0;
                            cmd.CommandText = "UPDATE coachTable SET allocated = @allocated WHERE coach_id = @coachID";
                            cmd.Parameters.AddWithValue("allocated", '1');
                            con.Open();
                            count = cmd.ExecuteNonQuery();
                            con.Close();
                            if (count > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool searchTrain(String regNo)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT reg_no FROM trainTable WHERE reg_no LIKE @regNo";
                cmd.Parameters.AddWithValue("regNo", regNo);
                con.Open();
                int count = 0;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 0)
                {

                    MessageBox.Show("Error! train not found on this registration no.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool isCoachAllocated(String coachID)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT allocated FROM coachTable WHERE coach_id = @coachID";
                cmd.Parameters.AddWithValue("coachID", int.Parse(coachID));
                con.Open();
                String ch = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ch = reader.GetString(0);

                }
                con.Close();
                if (ch.Equals("1"))
                {

                    MessageBox.Show("Error! Coach is already allocated! Please Choose another coach!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public DataTable getCoachTrainLog(String regNo)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM coachTrainLog WHERE reg_no LIKE @regNo";
                cmd.Parameters.AddWithValue("regNo", regNo);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool removeCoach(String reg_no, String coach_id)
        {
            if (searchTrain(reg_no))
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM coachTrainLog WHERE reg_no = @reg_no AND coach_id = @coach_id";
                    cmd.Parameters.AddWithValue("reg_no", reg_no);
                    cmd.Parameters.AddWithValue("coach_id", int.Parse(coach_id));
                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        deallocateCoach(int.Parse(coach_id));
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool removeTrain(String reg_no)
        {
            if (searchTrain(reg_no))
            {
                try
                {
                    List<int> allocatedCoaches = getAllocatedCoaches(reg_no);
                    for (int i = 0; i < allocatedCoaches.Count; i++)
                    {
                        deallocateCoach(allocatedCoaches[i]);
                    }
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM coachTrainLog WHERE reg_no = @reg_no";
                    cmd.Parameters.AddWithValue("reg_no", reg_no);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.CommandText = "DELETE FROM trainTable WHERE reg_no = @reg_no";
                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {

                return false;
            }
        }
        public List<int> getAllocatedCoaches(String regNo)
        {
            List<int> coach_ids = new List<int>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT coach_id FROM coachTrainLog WHERE reg_no LIKE @regNo";
                cmd.Parameters.AddWithValue("regNo", regNo);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coach_ids.Add(reader.GetInt32(0));
                }
                con.Close();
                return coach_ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public bool deallocateCoach(int coach_id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int count = 0;
                cmd.CommandText = "UPDATE coachTable SET allocated = '0' WHERE coach_id = @coach_id";
                cmd.Parameters.AddWithValue("coach_id", coach_id);
                con.Open();
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public Train getTrain(String reg_no)
        {
            if (searchTrain(reg_no))
            {
                try
                {

                    Train train = new Train();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM trainTable WHERE reg_no LIKE @regNo";
                    cmd.Parameters.AddWithValue("regNo", reg_no);
                    con.Open();
                    int count = 0;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                        train.setRegNo(reader.GetString(0));
                        train.setEngineNo(reader.GetString(1));
                        train.setType(reader.GetString(2));
                        train.setModelNo(reader.GetString(3));
                        train.setStartingDate(DateTime.Parse(reader["starting_date"].ToString()));
                    }
                    con.Close();
                    return train;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        public bool updateTrain(Train train)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                int count = 0;
                cmd.CommandText = "UPDATE trainTable SET engine_no = @engine_no, type = @type, model_no = @model_no, starting_date = @starting_date WHERE reg_no LIKE @reg_no";
                cmd.Parameters.AddWithValue("engine_no", train.getEngineNo());
                cmd.Parameters.AddWithValue("type", train.getType());
                cmd.Parameters.AddWithValue("model_no", train.getModelNo());
                cmd.Parameters.AddWithValue("starting_date", train.getStartingDate().Date);
                cmd.Parameters.AddWithValue("reg_no", train.getRegNo());
                con.Open();
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable searchAllTrainInformation(String reg_no)
        {
            if (searchTrain(reg_no))
            {
                try
                {

                    Train train = new Train();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * " +
                        "FROM trainTable " +
                        "FULL JOIN coachTrainLog " +
                        "ON trainTable.reg_no = coachTrainLog.reg_no " +
                        "WHERE trainTable.reg_no LIKE @regNo";
                    cmd.Parameters.AddWithValue("regNo", reg_no);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        public DataTable searchAllTrains()
        {
            try
            {

                Train train = new Train();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * " +
                    "FROM trainTable " +
                    "FULL JOIN coachTrainLog " +
                    "ON trainTable.reg_no = coachTrainLog.reg_no ";
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable searchTrainsWithCoaches()
        {
            try
            {

                Train train = new Train();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * " +
                    "FROM trainTable " +
                    "FULL JOIN coachTrainLog " +
                    "ON trainTable.reg_no = coachTrainLog.reg_no " +
                    "WHERE coachTrainLog.coach_id IS NOT NULL";
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<Station> getAllStations()
        {
            List<Station> list = new List<Station>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT *" +
                "FROM stationTable ";

                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Station station = new Station();
                    station.setStationId(int.Parse(reader["station_id"].ToString()));
                    station.setName(reader["name"].ToString());
                    list.Add(station);
                }
                con.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return null;
            }
        }
        public int getNextRouteID()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "SELECT MAX(route_id) FROM routeTable WHERE route_id IS NOT NULL";
                con.Open();
                int id = 0;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader != null)
                    {
                        id = reader.GetInt32(0);
                    }
                    else
                    {
                        id = 0;
                    }
                }
                id++;
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 1;
            }
        }
        public bool addOrder(Order order)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO orderTable(order_id, source, destination, dop, category, payment) values(@order_id, @source, @destination, @dop, @category, @payment)";
                cmd.Parameters.AddWithValue("order_id", order.getOrderId());
                cmd.Parameters.AddWithValue("source", order.getSourceStation().getStationId());
                cmd.Parameters.AddWithValue("destination", order.getDestinationStation().getStationId());
                cmd.Parameters.AddWithValue("dop", order.getDop().Date);
                cmd.Parameters.AddWithValue("category", order.getCatagory());
                cmd.Parameters.AddWithValue("payment", order.getPayment());
                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool placeOrder(PlaceOrder placeOrder)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO placeOrder(order_id, company_id) values(@order_id, @company_id)";
                cmd.Parameters.AddWithValue("order_id", placeOrder.getOrder().getOrderId());
                cmd.Parameters.AddWithValue("company_id", placeOrder.getCompany().getCompanyId());
                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool addRoute(Route route)
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO routeTable (route_id, price, name) values(@route_id, @price, @name)";
                cmd.Parameters.AddWithValue("route_id", route.getRouteId());
                cmd.Parameters.AddWithValue("price", route.getPrice());
                cmd.Parameters.AddWithValue("name", route.getName());
                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool searchRoute(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT route_id FROM routeTable WHERE route_id = @route_id";
                cmd.Parameters.AddWithValue("route_id", id);
                con.Open();
                int count = 0;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 0)
                {

                    MessageBox.Show("Error! Route does not exist!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool addStationToRoute(RouteStationLog rsl)
        {
            if (searchRoute(rsl.getRoute().getRouteId()))
            {
                try
                {

                    cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "INSERT INTO routeStationLog (route_id, station_id, sequence_no, start_time, end_time) values (@route_id, @station_id, @sequence_no, @starting_time, @ending_time)";
                    cmd.Parameters.AddWithValue("route_id", rsl.getRoute().getRouteId());
                    cmd.Parameters.AddWithValue("station_id", rsl.getStation().getStationId());
                    cmd.Parameters.AddWithValue("sequence_no", rsl.getSequenceNo());
                    cmd.Parameters.AddWithValue("starting_time", rsl.getStartingTime().TimeOfDay);
                    cmd.Parameters.AddWithValue("ending_time", rsl.getEndingTime().TimeOfDay);

                    int count = cmd.ExecuteNonQuery();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public DataTable routeStationLogDetails(int id)
        {
            try
            {
                if (!searchRoute(id))
                {
                    return null;
                }
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM routeStationLog WHERE route_id = @route_id";
                cmd.Parameters.AddWithValue("route_id", id);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool removeStationFromRoute(int route_id, int station_id)
        {
            try
            {
                if (!searchRoute(route_id))
                {
                    return false;
                }
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM routeStationLog WHERE route_id = @route_id AND station_id = @station_id";
                cmd.Parameters.AddWithValue("route_id", route_id);
                cmd.Parameters.AddWithValue("station_id", station_id);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool updateStationDetails(RouteStationLog rsl)
        {
            if (searchRoute(rsl.getRoute().getRouteId()))
            {
                try
                {

                    cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "UPDATE routeStationLog SET station_id = @station_id, start_time = @startng_time, end_time = @ending_time WHERE route_id = @route_id AND sequence_no = @sequence_no ";
                    cmd.Parameters.AddWithValue("route_id", rsl.getRoute().getRouteId());
                    cmd.Parameters.AddWithValue("station_id", rsl.getStation().getStationId());
                    cmd.Parameters.AddWithValue("sequence_no", rsl.getSequenceNo());
                    cmd.Parameters.AddWithValue("starting_time", rsl.getStartingTime().TimeOfDay);
                    cmd.Parameters.AddWithValue("ending_time", rsl.getEndingTime().TimeOfDay);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public DataTable allRouteDetails(int id)
        {
            try
            {
                if (!searchRoute(id))
                {
                    return null;
                }
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT routeTable.*, routeStationLog.* FROM routeTable INNER JOIN routeStationLog ON routeTable.route_id = routeStationLog.route_id;";
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public bool removeRoute(int route_id)
        {
            try
            {
                if (!searchRoute(route_id))
                {
                    return false;
                }
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM routeStationLog WHERE route_id = @route_id";
                cmd.Parameters.AddWithValue("route_id", route_id);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    cmd.CommandText = "DELETE FROM routeTable WHERE route_id = @route_id";
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public Route getRoute(int id)
        {
            Route route = new Route();
            try
            {
                if (!searchRoute(id))
                {
                    return null;
                }
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM routeTable WHERE route_id = @route_id";
                cmd.Parameters.AddWithValue("@route_id", id);
                cmd.Connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    route.setRouteId(id);
                    route.setName(reader["name"].ToString());
                    route.setPrice(int.Parse(reader["price"].ToString()));
                }
                cmd.Connection.Close();
                return route;

            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public bool updateRoute(Route route)
        {
            if (searchRoute(route.getRouteId()))
            {
                try
                {

                    cmd = new SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "UPDATE routeTable SET name = @name, price = @price WHERE route_id = @route_id";
                    cmd.Parameters.AddWithValue("route_id", route.getRouteId());
                    cmd.Parameters.AddWithValue("name", route.getName());
                    cmd.Parameters.AddWithValue("price", route.getPrice());
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public List<Route> getAllRoutes()
        {
            List<Route> routes = new List<Route>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM routeTable";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Route route = new Route();
                    route.setRouteId(int.Parse(reader["route_id"].ToString()));
                    route.setName(reader["name"].ToString());
                    route.setPrice(int.Parse(reader["price"].ToString()));
                    routes.Add(route);
                }
                con.Close();
                return routes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return routes;
            }
        }
        public List<Train> getAllTrains()
        {
            List<Train> trains = new List<Train>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM trainTable";
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Train train = new Train();
                    train.setRegNo(reader["reg_no"].ToString());
                    train.setEngineNo(reader["engine_no"].ToString());
                    train.setModelNo(reader["model_no"].ToString());
                    train.setType(reader["type"].ToString());
                    train.setStartingDate(DateTime.Parse(reader["starting_date"].ToString()));
                    trains.Add(train);

                }
                con.Close();
                return trains;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return trains;
            }
        }

        public bool searchScheduleDateLog(int schedule_id, DateTime date)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM scheduleDateLog WHERE schedule_id = @schedule_id AND date = @date";
                cmd.Parameters.AddWithValue("schedule_id", schedule_id);
                cmd.Parameters.AddWithValue("date", date.Date);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["schedule_id"].ToString());
                    DateTime dateT = DateTime.Parse(reader["date"].ToString());
                    if (id == schedule_id && dateT.Date.Equals(date.Date))
                    {
                        con.Close();
                        return true;
                    }
                }
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public ScheduleDateLog getScheduleDateLog(int schedule_id, DateTime date)
        {
            ScheduleDateLog log = new ScheduleDateLog();
            if (searchScheduleDateLog(schedule_id, date))
            {
                try
                {

                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM scheduleDateLog WHERE schedule_id = @schedule_id AND date = @date";
                    cmd.Parameters.AddWithValue("schedule_id", schedule_id);
                    cmd.Parameters.AddWithValue("date", date.Date);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        log.setScheduleID(int.Parse(reader["schedule_id"].ToString()));
                        log.setDate(DateTime.Parse(reader["date"].ToString()));
                        log.setSerialNo(int.Parse(reader["serial_no"].ToString()));
                        log.setSeatsBooked(int.Parse(reader["seats_booked"].ToString()));

                    }
                    con.Close();
                    return log;
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                    return log;
                }
            }
            else
            {
                MessageBox.Show("Unable to find Log!");
                return log;
            }
        }
        public bool addScheduleDateLog(ScheduleDateLog log)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO scheduleDateLog (schedule_id, date, seats_booked) VALUES (@schedule_id, @date, @seats_booked)";
                cmd.Parameters.AddWithValue("schedule_id", log.getScheduleID());
                cmd.Parameters.AddWithValue("date", log.getDate().Date);
                cmd.Parameters.AddWithValue("seats_booked", log.getSeatsBooked());
                con.Open();
                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public int getSerialNo(int schedule_id, DateTime date)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT serial_no FROM scheduleDateLog WHERE schedule_id = @schedule_id AND date = @date";
                cmd.Parameters.AddWithValue("schedule_id", schedule_id);
                cmd.Parameters.AddWithValue("date", date.Date);
                con.Open();
                reader = cmd.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = int.Parse(reader["schedule_id"].ToString());
                }
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return 0;
            }
        }
        public bool searchScheduleID(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT schedule_id FROM scheduleTable WHERE schedule_id = @schedule_id";
                cmd.Parameters.AddWithValue("schedule_id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader["schedule_id"].ToString()) == id)
                    {
                        con.Close();
                        return true;
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public Schedule getSchedule(int schedule_id)
        {
            if (searchScheduleID(schedule_id))
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                try
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM scheduleTable WHERE schedule_id = @schedule_id";
                    cmd.Parameters.AddWithValue("schedule_id", schedule_id);
                    cmd.Connection.Open();
                    reader = cmd.ExecuteReader();
                    Schedule schedule = new Schedule();
                    int route_id = 0;
                    String reg_no = null;
                    while (reader.Read())
                    {
                        schedule.setId(int.Parse(reader["schedule_id"].ToString()));
                        route_id = int.Parse(reader["route_id"].ToString());
                        reg_no = reader["reg_no"].ToString();
                        reader["reg_no"].ToString();
                    }
                    cmd.Connection.Close();
                    Train train = getTrain(reg_no);
                    Route route = getRoute(route_id);
                    schedule.setRoute(route);
                    schedule.setTrain(train);

                    return schedule;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmd.Connection.Close();
                    return null;
                }
            }
            else
            {
                cmd.Connection.Close();
                MessageBox.Show("Error! no schedule Found!");
                return null;
            }
        }

        public int getScheduleID()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "SELECT MAX(schedule_id) FROM scheduleTable";
                con.Open();
                int id = 0;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader != null)
                    {
                        id = reader.GetInt32(0);
                    }
                    else
                    {
                        id = 0;
                    }
                }
                id++;
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 1;
            }
        }
        public List<Station> getStationsOfRoute(Route route)
        {
            List<Station> list = new List<Station>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT stationTable.* FROM stationTable INNER JOIN routeStationLog ON stationTable.station_id = routeStationLog.station_id " +
                "WHERE routeStationLog.route_id = @route_id ";
                cmd.Parameters.AddWithValue("route_id", route.getRouteId());
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Station station = new Station();
                    station.setStationId(int.Parse(reader["station_id"].ToString()));
                    station.setName(reader["name"].ToString());
                    list.Add(station);
                }
                con.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return null;
            }
        }
        public List<Coach> getTrainCoaches(Train train)
        {

            List<Coach> coaches = new List<Coach>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT coachTable.* FROM coachTable INNER JOIN coachTrainLog ON coachTable.coach_id = coachTrainLog.coach_id WHERE reg_no = @reg_no";
                cmd.Parameters.AddWithValue("reg_no", train.getRegNo());
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Coach coach = new Coach();
                    coach.setCoachId(int.Parse(reader["coach_id"].ToString()));
                    coach.setCoachType(reader["coach_type"].ToString());
                    coach.setNoOfSeats(int.Parse(reader["no_of_seats"].ToString()));
                    coach.setPrice(int.Parse(reader["price"].ToString()));
                    coaches.Add(coach);
                }
                con.Close();
                return coaches;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<int> getAllScheduleIds()
        {
            List<int> schedules = new List<int>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT schedule_id FROM scheduleTable";

                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    schedules.Add(id);
                }
                con.Close();
                return schedules;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int getSeqNo(int route_id, String station)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT routeStationLog.sequence_no FROM routeStationLog INNER JOIN stationTable ON routeStationLog.station_id = stationTable.station_id WHERE route_id = @route_id AND  stationTable.name = @name";
                cmd.Parameters.AddWithValue("route_id", route_id);
                cmd.Parameters.AddWithValue("name", station);
                con.Open();
                reader = cmd.ExecuteReader();
                int seqno = 0;
                while (reader.Read())
                {
                    seqno = reader.GetInt32(0);
                }
                con.Close();
                return seqno;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public int getBookedSeatsInCoachCount(int serial_no, int coach_id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT COUNT(coach_id) FROM ticketTable WHERE coach_id = @coach_id AND serial_no = @serial_no";
                cmd.Parameters.AddWithValue("coach_id", coach_id);
                cmd.Parameters.AddWithValue("serial_no", serial_no);
                con.Open();
                reader = cmd.ExecuteReader();
                int val = 0;
                while (reader.Read())
                {
                    val = reader.GetInt32(0);
                }
                con.Close();
                return val;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public bool addTicket(Ticket ticket)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO ticketTable (passenger_id, fare, seat_no, source, destination, serial_no, coach_id) VALUES (@passenger_id, @fare, @seat_no, @source, @destination, @serial_no, @coach_id) ";
                cmd.Parameters.AddWithValue("passenger_id", ticket.getPassenger().getPid());
                cmd.Parameters.AddWithValue("fare", ticket.getFare());
                cmd.Parameters.AddWithValue("source", ticket.getSource().getStationId());
                cmd.Parameters.AddWithValue("destination", ticket.getDestination().getStationId());
                cmd.Parameters.AddWithValue("seat_no", ticket.getSeat());
                cmd.Parameters.AddWithValue("serial_no", ticket.getScheduleDateLog().getSerialNo());
                cmd.Parameters.AddWithValue("coach_id", ticket.getCoach().getCoachId());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public int getTicketId(Ticket ticket)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT ticket_id FROM ticketTable WHERE passenger_id = @passenger_id AND  fare = @fare AND seat_no = @seat_no AND source =  @source AND destination = @destination AND " +
                 " serial_no = @serial_no AND coach_id = @coach_id";
                cmd.Parameters.AddWithValue("passenger_id", ticket.getPassenger().getPid());
                cmd.Parameters.AddWithValue("fare", ticket.getFare());
                cmd.Parameters.AddWithValue("source", ticket.getSource().getStationId());
                cmd.Parameters.AddWithValue("destination", ticket.getDestination().getStationId());
                cmd.Parameters.AddWithValue("seat_no", ticket.getSeat());
                cmd.Parameters.AddWithValue("serial_no", ticket.getScheduleDateLog().getSerialNo());
                cmd.Parameters.AddWithValue("coach_id", ticket.getCoach().getCoachId());
                con.Open();
                reader = cmd.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
                return id;

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public bool updateBookedTicketsCount(ScheduleDateLog log)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "UPDATE scheduleDateLog SET seats_booked = @seats_booked WHERE serial_no = @serial_no ";
                cmd.Parameters.AddWithValue("serial_no", log.getSerialNo());
                cmd.Parameters.AddWithValue("seats_booked", log.getSeatsBooked());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool isSeatBooked(int seat_no, Coach coach, ScheduleDateLog log)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT seat_no FROM ticketTable WHERE seat_no = @seat_no AND coach_id = @coach_id AND serial_no = @serial_no ";
                cmd.Parameters.AddWithValue("seat_no", seat_no);
                cmd.Parameters.AddWithValue("coach_id", coach.getCoachId());
                cmd.Parameters.AddWithValue("serial_no", log.getSerialNo());
                con.Open();
                int val = 0;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetInt32(0);
                }
                con.Close();
                if (val == seat_no)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public bool searchTicket(int ticket_id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT ticket_id FROM ticketTable WHERE ticket_id = @ticket_id";
                cmd.Parameters.AddWithValue("ticket_id", ticket_id);
                con.Open();
                reader = cmd.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
                if (id == ticket_id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return false;
            }
        }
        public DataTable getTicketInformation(int ticket_id)
        {
            if (searchTicket(ticket_id))
            {
                try
                {
                    DataTable dt = new DataTable();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = " SELECT ticketTable.ticket_id, ticketTable.passenger_id, ticketTable.fare, ticketTable.seat_no, coachTable.coach_type, scheduleDateLog.date, scheduleDateLog.serial_no, source.name As Source , destination.name AS destination FROM   (((rms.dbo.stationTable destination INNER JOIN rms.dbo.ticketTable ticketTable ON destination.station_id = ticketTable.destination) INNER JOIN rms.dbo.coachTable coachTable ON ticketTable.coach_id = coachTable.coach_id) INNER JOIN rms.dbo.scheduleDateLog scheduleDateLog ON ticketTable.serial_no=scheduleDateLog.serial_no) INNER JOIN rms.dbo.stationTable source ON ticketTable.source = source.station_id";
                    cmd.Parameters.AddWithValue("ticket_id", ticket_id);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); return null;
                }
            }
            else
            {
                MessageBox.Show("Unable to find ticket!");
                return null;
            }
        }
        public bool deleteTicket(int ticket_id)
        {
            if (searchTicket(ticket_id))
            {
                try
                {
                    DataTable dt = new DataTable();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT serial_no FROM ticketTable WHERE ticket_id = @ticket_id";
                    cmd.Parameters.AddWithValue("ticket_id", ticket_id);
                    con.Open();
                    int serial_no = 0;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        serial_no = reader.GetInt32(0);
                    }
                    con.Close();
                    cmd.CommandText = "DELETE FROM ticketTable WHERE ticket_id = @ticket_id";
                    con.Open();
                    int count = 0;
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {

                        cmd.CommandText = "UPDATE scheduleDateLog SET seats_booked = (seats_booked - 1) WHERE serial_no = @serial_no ";
                        cmd.Parameters.AddWithValue("serial_no", serial_no);
                        count = 0;
                        con.Open();
                        count = cmd.ExecuteNonQuery();
                        con.Close();
                        if (count > 0)
                        {
                            return true;
                        }

                        else
                        {
                            MessageBox.Show("Unable to remove ticket!");
                            con.Close();
                            return false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Unable to remove ticket!");
                        con.Close();
                        return false;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Unable to find ticket!");
                return false;
            }
        }
        public Ticket getTicket(int ticket_id)
        {
            if (searchTicket(ticket_id))
            {
                try
                {
                    Ticket ticket = new Ticket();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM ticketTable WHERE ticket_id = @ticket_id";
                    cmd.Parameters.AddWithValue("ticket_id", ticket_id);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    Passenger passenger = new Passenger();
                    Station source = new Station();
                    Station destination = new Station();
                    Coach coach = new Coach();
                    ScheduleDateLog log = new ScheduleDateLog();
                    while (reader.Read())
                    {
                        ticket.setSeat(int.Parse(reader["seat_no"].ToString()));
                        ticket.setId(int.Parse(reader["ticket_id"].ToString()));
                        ticket.setFare(int.Parse(reader["fare"].ToString()));
                        passenger.setPid(int.Parse(reader["passenger_id"].ToString()));
                        source.setStationId(int.Parse(reader["source"].ToString()));
                        destination.setStationId(int.Parse(reader["destination"].ToString()));
                        coach.setCoachId(int.Parse(reader["coach_id"].ToString()));
                        log.setSerialNo(int.Parse(reader["serial_no"].ToString()));
                    }
                    ticket.setPassenger(passenger);
                    ticket.setCoach(coach);
                    ticket.setScheduleDateLog(log);
                    ticket.setSource(source);
                    ticket.setDestination(destination);
                    con.Close();
                    return ticket;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Unable to find ticket!");
                return null;
            }
        }
        public DataTable getTicketGenerationTable(int ticket_id)
        {
            if (searchTicket(ticket_id))
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    //cmd.CommandText = "SELECT ticketTable.ticket_id, ticketTable.passenger_id, ticketTable.seat_no, ticketTable.source, ticketTable.destination, scheduleDateLog.date, passengerTable.cnic, personName.first_name, personName.last_name FROM scheduleDateLog INNER JOIN ticketTable ON ticketTable.serial_no = scheduleDateLog.serial_no " +
                    //"INNER JOIN passengerTable ON passengerTable.passenger_id = ticketTable.passenger_id INNER JOIN personName ON personName.cnic = passengerTable.cnic WHERE ticket_id = @ticket_id";
                    cmd.CommandText = "SELECT * from ticketTable WHERE ticket_id = @ticket_id";
                    cmd.Parameters.AddWithValue("ticket_id", ticket_id);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("ticketDataset");
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Ticket Not found in database!");
                return null;
            }
        }
        public bool removeOrderByID(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM placeOrder WHERE order_id = @order_id";
                cmd.Parameters.AddWithValue("order_id", id);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    cmd.CommandText = "DELETE FROM orderTable WHERE order_id = @order_id";
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool searchOrderByID(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id WHERE orderTable.order_id = @order_id";
                cmd.Parameters.AddWithValue("order_id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                bool flag = false;
                while (reader.Read())
                {
                    if (id == reader.GetInt32(0))
                    {
                        flag = true;
                    }
                }
                con.Close();
                return flag;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable getOrderByID(int id)
        { 
            if(searchOrderByID(id))
            {

              try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id AS ID, orderTable.dop AS DATE, orderTable.category, orderTable.payment , companyTable.company_id, companyTable.name, st.name AS source, st1.name AS destination FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id " +
                " INNER JOIN companyTable ON companyTable.company_id = placeOrder.company_id INNER JOIN stationTable st ON st.station_id = orderTable.source INNER JOIN stationTable st1 ON st1.station_id = orderTable.destination WHERE orderTable.order_id = @order_id";
                cmd.Parameters.AddWithValue("order_id", id);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                  da.Fill(dt);
                  return dt;
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                return null;
            }
            }
            else{
                MessageBox.Show("Order id does not exist in database!");
                return null;
            }
        }
        public DataTable getOrderByCompanyName(string name)
        {
            try {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id AS ID, orderTable.dop AS DATE, orderTable.category, orderTable.payment , companyTable.company_id, companyTable.name, st.name AS source, st1.name AS destination FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id " +
                " INNER JOIN companyTable ON companyTable.company_id = placeOrder.company_id INNER JOIN stationTable st ON st.station_id = orderTable.source INNER JOIN stationTable st1 ON st1.station_id = orderTable.destination WHERE companyTable.name LIKE @name";
                cmd.Parameters.AddWithValue("name", name);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable getOrderByCompanyID(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id AS ID, orderTable.dop AS DATE, orderTable.category, orderTable.payment , companyTable.company_id, companyTable.name, st.name AS source, st1.name AS destination FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id " +
                " INNER JOIN companyTable ON companyTable.company_id = placeOrder.company_id INNER JOIN stationTable st ON st.station_id = orderTable.source INNER JOIN stationTable st1 ON st1.station_id = orderTable.destination WHERE companyTable.company_id = @company_id";
                cmd.Parameters.AddWithValue("company_id", id);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable getOrderByDate(DateTime from, DateTime to)
        {

            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id AS ID, orderTable.dop AS DATE, orderTable.category, orderTable.payment , companyTable.company_id, companyTable.name, st.name AS source, st1.name AS destination FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id " +
                " INNER JOIN companyTable ON companyTable.company_id = placeOrder.company_id INNER JOIN stationTable st ON st.station_id = orderTable.source INNER JOIN stationTable st1 ON st1.station_id = orderTable.destination WHERE orderTable.dop BETWEEN  @from AND @to ";
                cmd.Parameters.AddWithValue("from", from.Date);
                cmd.Parameters.AddWithValue("to", to.Date);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable getOrderByCompNameAndDate(string name, DateTime from, DateTime to)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT orderTable.order_id AS ID, orderTable.dop AS DATE, orderTable.category, orderTable.payment , companyTable.company_id, companyTable.name, st.name AS source, st1.name AS destination FROM orderTable INNER JOIN placeOrder ON orderTable.order_id = placeOrder.order_id " +
                " INNER JOIN companyTable ON companyTable.company_id = placeOrder.company_id INNER JOIN stationTable st ON st.station_id = orderTable.source INNER JOIN stationTable st1 ON st1.station_id = orderTable.destination WHERE companyTable.name = @name AND orderTable.dop BETWEEN  @from AND @to ";
                cmd.Parameters.AddWithValue("from", from.Date);
                cmd.Parameters.AddWithValue("to", to.Date);
                cmd.Parameters.AddWithValue("name", name);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool addPassenger(Passenger passenger)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO personTable (cnic, dob, email, gender) VALUES (@cnic, @dob, @email, @gender)";
                cmd.Parameters.AddWithValue("cnic", passenger.getPersonalInformation().getCNIC());
                cmd.Parameters.AddWithValue("dob", passenger.getPersonalInformation().getDateOfBirth().Date);
                cmd.Parameters.AddWithValue("email", passenger.getPersonalInformation().getEmail());
                cmd.Parameters.AddWithValue("gender", passenger.getPersonalInformation().getGender());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count == 1)
                {
                    cmd.CommandText = "INSERT INTO personName (cnic, first_name, middle_name, last_name) VALUES (@cnic, @first_name, @middle_name, @last_name)";
                    cmd.Parameters.AddWithValue("first_name", passenger.getPersonalInformation().getFirstName());
                    cmd.Parameters.AddWithValue("middle_name", passenger.getPersonalInformation().getMiddleName());
                    cmd.Parameters.AddWithValue("Last_name", passenger.getPersonalInformation().getLastName());

                    count = 0;
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    con.Close();
                    if (count > 0)
                    {
                        cmd.CommandText = "INSERT INTO PassengerTable (cnic) VALUES (@cnic)";
                        count = 0;
                        con.Open();
                        count = cmd.ExecuteNonQuery();
                        con.Close();
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public int getPassengerID(String cnic)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT passenger_id FROM passengerTable WHERE cnic = @cnic";
                cmd.Parameters.AddWithValue("cnic",cnic);
                con.Open();
                reader = cmd.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
                return id;
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public DataTable getPassenger(String cnic)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT passengerTable.passenger_id, personTable.*, personName.* " +
                    " FROM  personName INNER JOIN passengerTable ON personName.cnic = passengerTable.cnic INNER JOIN personTable ON passengerTable.cnic = personTable.cnic WHERE passengerTable.cnic LIKE @cnic";
                cmd.Parameters.AddWithValue("cnic", cnic);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }
        }
        public DataTable getPassenger(int id)
        { 
             try
                {
                    DataTable dt = new DataTable();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText =  "SELECT passengerTable.passenger_id, personTable.*, personName.* "+
                    " FROM  personName INNER JOIN passengerTable ON personName.cnic = passengerTable.cnic INNER JOIN personTable ON passengerTable.cnic = personTable.cnic WHERE passengerTable.passenger_id = @passenger_id";
                    cmd.Parameters.AddWithValue("passenger_id", id);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); return null;
                }
            
        }
        public DataTable getStation(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT stationTable.*, coordinates.Longitude, coordinates.Latitude INNER JOIN coordinates ON stationTable.station_id = coordinates.station_id WHERE stationTable.station_id = @id";
                cmd.Parameters.AddWithValue("id", id);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }
            
        }
        public DataTable getStation(String name)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT stationTable.*, coordinates.Longitude, coordinates.Latitude INNER JOIN coordinates ON stationTable.station_id = coordinates.station_id WHERE stationTable.name = @name";
                cmd.Parameters.AddWithValue("name", name);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }

        }
        public bool removeStation(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM stationTable WHERE station_id = @id";
                cmd.Parameters.AddWithValue("id", @id);
                con.Open();
                int count = 0;
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public bool removeStation(String name)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM stationTable WHERE name LIKE @name";
                cmd.Parameters.AddWithValue("name", @name);
                con.Open();
                int count = 0;
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public bool removePassenger(int id)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM passengerTable WHERE passenger_id = @passenger_id";
                cmd.Parameters.AddWithValue("passenger_id", @id);
                con.Open();
                int count = 0;
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public bool removePassenger(String cnic)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM passengerTable WHERE cnic LIKE @cnic";
                cmd.Parameters.AddWithValue("@cnic", cnic);
                con.Open();
                int count = 0;
                count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
        public DataTable searchScheduleLog(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT scheduleTable.reg_no, scheduleTable.route_id, scheduleDateLog.* FROM scheduleTable INNER JOIN scheduleDateLog ON scheduleTable.schedule_id = scheduleDateLog.schedule_id WHERE scheduleTable.schedule_id = @id";
                cmd.Parameters.AddWithValue("id", id);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }
            
        }
        public DataTable seachAllScheduleLog()
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT scheduleTable.reg_no, scheduleTable.route_id, scheduleDateLog.* FROM scheduleTable INNER JOIN scheduleDateLog ON scheduleTable.schedule_id = scheduleDateLog.schedule_id";
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }
        }
        public DataTable searchScheduleLog(DateTime to, DateTime from)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "SELECT scheduleTable.reg_no, scheduleTable.route_id, scheduleDateLog.* FROM scheduleTable INNER JOIN scheduleDateLog ON scheduleTable.schedule_id = scheduleDateLog.schedule_id WHERE schedulateTable.date BETWEEN @from AND @to";
                cmd.Parameters.AddWithValue("to", to.Date);
                cmd.Parameters.AddWithValue("from", from.Date);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); return null;
            }
        }
        public bool editProfile(Employee emp)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "UPDATE personTable SET email = @email, personTable.dob = @dob, gender = @gender WHERE cnic = @cnic";
                cmd.Parameters.AddWithValue("dob", emp.getPersonalInformation().getDateOfBirth().Date);
                cmd.Parameters.AddWithValue("email", emp.getPersonalInformation().getEmail());
                cmd.Parameters.AddWithValue("gender", emp.getPersonalInformation().getGender());
                cmd.Parameters.AddWithValue("cnic", emp.getPersonalInformation().getCNIC());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE  personName SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name WHERE cnic = @cnic";
                cmd.Parameters.AddWithValue("first_name", emp.getPersonalInformation().getFirstName());
                cmd.Parameters.AddWithValue("middle_name", emp.getPersonalInformation().getMiddleName());
                cmd.Parameters.AddWithValue("Last_name", emp.getPersonalInformation().getLastName());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE employeeTable SET "
                + "employeeTable.password = @password, employeeTable.doh = @doh WHERE emp_id = @emp_id";
                
                cmd.Parameters.AddWithValue("password", emp.getPassword());
               
                cmd.Parameters.AddWithValue("doh", emp.getDateOfHire());
                cmd.Parameters.AddWithValue("emp_id", emp.getEmp_id());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.CommandText = "UPDATE employeeAddress SET employeeAddress.country = @country, employeeAddress.city = @city, employeeAddress.province = @province, employeeAddress.house_no = @house_no, employeeAddress.street = @street, employeeAddress.zip_code = @zip_code" +
                " WHERE emp_id = " + emp.getEmp_id();
                cmd.Parameters.AddWithValue("country", emp.getAddress().getCountry());
                cmd.Parameters.AddWithValue("city", emp.getAddress().getCity());
                cmd.Parameters.AddWithValue("province", emp.getAddress().getProvince());
                cmd.Parameters.AddWithValue("house_no", emp.getAddress().getHouseNo());
                cmd.Parameters.AddWithValue("street", emp.getAddress().getStreet());
                cmd.Parameters.AddWithValue("zip_code", emp.getAddress().getZipCode());
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        //public bool removePassenger(int id)
        //{
        //    try
        //    {
        //        cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;
        //        cmd.CommandText = "SELECT cnic FROM passengerTable WHERE passenger_id = @passenger_id";
        //        cmd.Parameters.AddWithValue("passenger_id", id);
        //        con.Open();
        //        reader = cmd.ExecuteReader();
        //        String cnic = null;
        //        while (reader.Read())
        //        {
        //            cnic = reader.GetString(0);
        //        }
        //        con.Close();
        //        if (cnic == null)
        //        {
        //            return false;
        //        }
        //        cmd.CommandText = "DELETE FROM ticketTable WHERE passenger_id = @passenger_id";
        //        con.Open();
        //        int count = 0; 
        //        count = cmd.ExecuteNonQuery();
        //        con.Close();
        //        if (count > 0)
        //        {
        //            cmd.CommandText = "UPDATE scheduleDateLog SET  WHERE passenger_id = @passenger_id";
        //            con.Open();
                
        //        }
        //        cmd.CommandText = "DELETE FROM passengerTable WHERE passenger_id = @passenger_id";
        //            con.Open();
        //            count = cmd.ExecuteNonQuery();
        //            con.Close();
        //            if (count > 0)
        //            {
        //                cmd.CommandText = "DELETE FROM personName WHERE cnic LIKE @cnic";
        //                cmd.Parameters.AddWithValue("cnic", cnic);
        //            con.Open();
        //            count = cmd.ExecuteNonQuery();
        //            con.Close();
        //                if(count > 0)
        //                {
        //             cmd.CommandText = "DELETE FROM personTable WHERE cnic LIKE @cnic";              
        //            con.Open();
        //            count = cmd.ExecuteNonQuery();
        //            con.Close();
        //                    if(count > 0)
        //                    {
        //                    return true;
        //                    }else
        //                    {
                            
        //                        return false;
        //                    }
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
             
        //    catch (Exception ex)
        //    {
        //        con.Close();
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}
    }
}
