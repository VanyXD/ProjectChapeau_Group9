using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeServices
    {
        EmployeeDAO employee_db = new EmployeeDAO();

        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                employees = employee_db.GetAllEmployees();
                return employees;
            }
            catch (Exception)
            {
                List<Employee> employees = new List<Employee>();
                Employee employee1 = new Employee();
                employee1.EmployeeID = 0000;
                employee1.FirstName = "Test";
                employee1.LastName = "Again";
                employee1.position = Position.Empty;
                employee1.Email = "No Email";
                employee1.PhoneNumber = 00000;
                employee1.Password = 00000;

                employees.Add(employee1);
                return employees;
                throw new Exception("Couldn't connect to the database");


            }

        }

    }
}
    

