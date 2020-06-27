using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;

namespace ChapeauDAL
{
    public class EmployeeDAO : Base
    {
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT employee_id,first_name,last_name,email,phone,password, position_id FROM [employees]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertEmployee(Employee employee)
        {
            int posID = (int)employee.position;
            string query = $"insert into employees(first_name,last_name,email,phone,password,position_id) " +
                $"values('{employee.FirstName}', '{employee.LastName}', '{employee.Email}', {employee.PhoneNumber}, {employee.Password},{posID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        //public void DeleteEmployee(int employeeID)
        //{
        //    string query = $"DELETE FROM employees WHERE employee_id = {employeeID}";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}
        public void DeleteEmployee(Employee employee)
        {
            string query = $"DELETE FROM employees WHERE employee_id = {employee.EmployeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateEmployee(Employee employee)
        {
            //SqlCommand cmd = new SqlCommand($"update employees Set first_name = @name, last_name = @lastName," +
            //   $"email = @email, phone = @phone, password = @password,position_id = @posID WHERE employee_id = @ID", conn);
            //cmd.Parameters.AddWithValue("@name", employee.FirstName);
            //cmd.Parameters.AddWithValue("@lastName", employee.LastName);
            //cmd.Parameters.AddWithValue("@email", employee.Email);
            //cmd.Parameters.AddWithValue("@phone", employee.PhoneNumber);
            //cmd.Parameters.AddWithValue("@password", employee.Password);
            //cmd.Parameters.AddWithValue("@posID", employee.position);
            //cmd.Parameters.AddWithValue("@ID", employee.EmployeeID);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();


            int posID = (int)employee.position;
            string query = $"update employees Set first_name = '{employee.FirstName}', last_name = '{employee.LastName}'," +
                $"email = '{employee.Email}', phone = {employee.PhoneNumber}, password = {employee.Password},position_id = {posID} WHERE employee_id = {employee.EmployeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Employee> ReadEmployees(DataTable datatable)
        {
            List<Employee> employeeList = new List<Employee>();
            foreach (DataRow dr in datatable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeID = (int)dr["employee_id"],
                    FirstName = (String)dr["first_name"],
                    LastName = (string)dr["last_name"],
                    Email = (string)dr["email"],

                    PhoneNumber = (int)dr["phone"],
                    Password = (int)dr["password"],
                    position = (Position)dr["position_id"]

                };
                employeeList.Add(employee);
            }
            return employeeList;
        }
        public Employee GetEmployee(int password , string userName)
        {
            SqlCommand cmd = new SqlCommand("select employee_id, first_name, last_name, email, phone, [password], position_id from employees where [password] = @pass and first_name = @name", conn);
            cmd.Parameters.AddWithValue("@pass" , password);
            cmd.Parameters.AddWithValue("@name", userName);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Employee employee = ReadEmployee(reader);
            conn.Close();
            reader.Close();
            if (employee == null)
            {
                return null;
            }
            
            return employee;

        }
        private Employee ReadEmployee(SqlDataReader reader)
        {
            try
            {
                Employee employee = new Employee
                {
                    EmployeeID = (int)reader["employee_id"],
                    Email = (string)reader["email"],
                    FirstName = (string)reader["first_name"],
                    LastName = (string)reader["last_name"],
                    Password = (int)reader["password"],
                    PhoneNumber = (int)reader["phone"],
                    position = (Position)reader["position_id"]

                };
                return employee;
            }
            catch (Exception)
            {
                
                return null;
                
            }
            




            
        }
    }
}
