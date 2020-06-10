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

        //private SqlConnection dbConnection;
        //public EmployeeDAO()
        //{
        //    string connString = ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString;
        //    dbConnection = new SqlConnection(connString);
        //}
        //public List<Employee> GetAllEmployees()
        //{
        //    dbConnection.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT employee_id,first_name,last_name,email,phone,password, position_id FROM [employees]", dbConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    List<Employee> employees = new List<Employee>();
        //    while (reader.Read())
        //    {
        //        Employee employee = ReadEmployees(reader);
        //        employees.Add(employee);
        //    }
        //    reader.Close();
        //    dbConnection.Close();
        //    return employees;
        //}
        //public Employee ReadEmployees(SqlDataReader reader)
        //{
        //    Employee employee = new Employee
        //    {
        //        EmployeeID = (int)reader["employee_id"],
        //        FirstName = (string)reader["first_name"],
        //        LastName = (string)reader["last_name"],
        //        position = (Position)reader["position_id"],
        //        PhoneNumber = (int)reader["phone"],
        //        Email = (string)reader["email"],
        //        Password = (int)reader["password"],
        //    };
        //    return employee;    
        //}

        public void InsertEmployee(Employee employee)
        {
            int posID = (int)employee.position;
            string query = $"insert into employees(first_name,last_name,email,phone,password,position_id) " +
                $"values('{employee.FirstName}', '{employee.LastName}', '{employee.Email}', {employee.PhoneNumber}, {employee.Password},{posID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteEmployee(int employeeID)
        {
            string query = $"DELETE FROM employees WHERE employee_id = {employeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void UpdateEmployee(Employee employee)
        {
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
    }
}
