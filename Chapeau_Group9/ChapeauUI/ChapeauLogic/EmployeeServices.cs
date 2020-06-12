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
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return employees;

            }

        }
        public void InsertEmployee(Employee employee)
        {
            try
            {
                employee_db.InsertEmployee(employee);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
            }
           
        }
        public void RemoveEmployee(int employeeID)
        {
            try
            {
                employee_db.DeleteEmployee(employeeID);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
            }

        }
        public void EditEmployee(Employee employee)
        {
            try
            {
                employee_db.UpdateEmployee(employee);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
            }

        }

    }
}


