using System.Collections.Generic;
using Model;
using DAL;

namespace Logic
{
    public class EmployeeService
    {
        EmployeeDAO empdao = new EmployeeDAO();
        public List<Employee> GetAll()
        {
            List<Employee> employees = empdao.GetAll();
            return employees;
        }
        

    }
}
