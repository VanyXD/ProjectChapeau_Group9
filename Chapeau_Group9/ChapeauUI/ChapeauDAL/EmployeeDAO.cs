﻿using System;
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
<<<<<<< HEAD
                    PhoneNumber = (int)dr["phone_NR"],
                    Password = (int)dr["password"]

=======
                    PhoneNumber = (int)dr["phone"],
                    Password = (int)dr["password"],
                    position = (Position)dr["position_id"]
>>>>>>> 123c8647e1db0a47414d3af96ee2db340149e939
                };
                employeeList.Add(employee);
            }
            return employeeList;
        }
        
        //public void UpdatePassword(int newPassword)
        //{
        //    Employee employee = new Employee();
        //    string query = $"update Employee Set password = {newPassword} Where employee_ID = {employee.EmployeeID}";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}
        //public void UpdateArticle(MenuItem menu)
        //{
        //    string query = $"update Menu Set articleID = {menu.MenuItemID},Name = '{menu.Name}', Price = {menu.Price},Stock= {menu.Stock},VAT = {menu.VAT}, Lunch = {menu.Lunch}, Category_ID = {menu.Category}";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}
        //public void InsertArticle(MenuItem menu)
        //{
        //    string query = $"insert into Menu(articleID,Name,Price,Stock,VAT,Lunch,Category_ID) values({menu.MenuItemID}, '{menu.Name}', {menu.Price}, " +
        //        $"{menu.Stock}, {menu.VAT}, {menu.Lunch}, {menu.Category}";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}
        //public void DeleteArticle(MenuItem menu)
        //{
        //    string query = $"Delete from Menu where articleID = {menu.MenuItemID}";
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    ExecuteEditQuery(query, sqlParameters);
        //}

      

        


    }
}
