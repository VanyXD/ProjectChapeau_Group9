﻿using System;
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
                throw new Exception("Couldn't connect to the database");
            }

        }
        public void InsertEmployee(Employee employee)
        {
            employee_db.InsertEmployee(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employee_db.DeleteEmployee(employee);
        }
        public void EditEmployee(Employee employee)
        {
            employee_db.UpdateEmployee(employee);
        }

    }
}


