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
            string query = $"insert into employees(employee_id,first_name,last_name,email,phone,password,position_id) values({employee.EmployeeID}, '{employee.FirstName}', '{employee.LastName}', " +
                $"{employee.position}, '{employee.Email}', {employee.PhoneNumber}, {employee.Password}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteEmployee(Employee employee)
        {
            string query = $"Delete from Employees where employee_id = {employee.EmployeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void UpdateEmployee(Employee employee)
        {
            string query = $"update Employees Set employee_id = {employee.EmployeeID},first_name = '{employee.FirstName}', last_name = '{employee.LastName}'," +
                $"email = '{employee.Email}', phone = {employee.PhoneNumber}, password = {employee.PhoneNumber},position_id = {employee.position}";
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
