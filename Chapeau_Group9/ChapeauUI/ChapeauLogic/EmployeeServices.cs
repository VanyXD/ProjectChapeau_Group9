using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChapeauLogic
{
    public class EmployeeServices
    {
        EmployeeDAO employee_db = new EmployeeDAO();
        List<Employee> employees;
        public List<Employee> GetEmployees()
        {
            try
            {
                employees = new List<Employee>();
                employees = employee_db.GetAllEmployees();
                return employees;
            }
            catch (Exception ex)
            {
                throw(ex);
                return employees;

            }
        }
        public void InsertEmployee(Employee employee)
        {
            try
            {
                employee_db.InsertEmployee(employee);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
           
        }
        public void RemoveEmployee(Employee employee)
        {
            try
            {
                employee_db.DeleteEmployee(employee);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }
        public void EditEmployee(Employee employee)
        {
            try
            {
                employee_db.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw(ex);
            }

        }
        public Employee GetEmployee(int password , string username )
        {
            try
            {
                Employee employee = employee_db.GetEmployee(password, username.ToLower());
                return employee;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

    }
}


