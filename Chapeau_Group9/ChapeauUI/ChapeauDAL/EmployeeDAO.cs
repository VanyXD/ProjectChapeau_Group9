using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;


namespace ChapeauDAL
{
    public class EmployeeDAO : Base
    {
        private SqlConnection dbConnection;
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            SqlCommand cmd = new SqlCommand("select employee_id, first_name, last_name, phone, position_id from employees", dbConnection);
            dbConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Employee emp = ReadEmployee(reader);
                employees.Add(emp);

            }
            reader.Close();
            dbConnection.Close();
            return employees;
        }
        private Employee ReadEmployee(SqlDataReader reader)
        {
            Employee emp = new Employee();
            emp.EmployeeID = (int)reader["employee_id"];
            emp.FirstName = (string)reader["first_name"];
            emp.LastName = (string)reader["last_name"];
            emp.PhoneNumber = (int)reader["phone"];
            int pos = (int)reader["position_id"];
            switch (pos)
            {
                case 1:
                    emp.Position = Position.Manager;
                    break;
                case 2:
                    emp.Position = Position.Cook;
                    break;
                case 3:
                    emp.Position = Position.Waiter;
                    break;
                case 4:
                    emp.Position = Position.Bartender;
                    break;
                default:
                    emp.Position = Position.Cook;
                    break;
            }
            return emp;

        }
    }
}
