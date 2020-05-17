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
    public class Manager_DAO : Base
    {
        //employee dao
        //separte menu dao
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Manager_DAO()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT employee_ID,first_Name,last_Name,position_ID,email,phone_NR,password FROM [Employee]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetMenu()
        {
            string query = "SELECT articleID,Name,Price,Stock,VAT,Lunch,Category_ID FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu(ExecuteSelectQuery(query, sqlParameters));
        }
        public void InsertEmployee(Employee employee)
        {
            string query = $"insert into Employee(employee_ID,first_Name,last_Name,position_ID,email,phone_NR,password) values({employee.EmployeeID}, '{employee.FirstName}', '{employee.LastName}', " +
                $"{employee.Position}, '{employee.Email}', {employee.PhoneNumber}, {employee.Password}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteEmployee(Employee employee)
        {
            string query = $"Delete from Employee where employee_ID = {employee.EmployeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void UpdateEmployee(Employee employee)
        {
            string query = $"update Employee Set employee_ID = {employee.EmployeeID},first_Name = '{employee.FirstName}', last_Name = '{employee.LastName}',position_ID = {employee.Position}," +
                $"email = '{employee.Email}', phone_NR = {employee.PhoneNumber}, password = {employee.PhoneNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdatePassword(int newPassword)
        {
            Employee employee = new Employee();
            string query = $"update Employee Set password = {newPassword} Where employee_ID = {employee.EmployeeID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateArticle(MenuItem menu)
        {
            string query = $"update Menu Set articleID = {menu.MenuItemID},Name = '{menu.Name}', Price = {menu.Price},Stock= {menu.Stock},VAT = {menu.VAT}, Lunch = {menu.Lunch}, Category_ID = {menu.Category}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void InsertArticle(MenuItem menu)
        {
            string query = $"insert into Menu(articleID,Name,Price,Stock,VAT,Lunch,Category_ID) values({menu.MenuItemID}, '{menu.Name}', {menu.Price}, " +
                $"{menu.Stock}, {menu.VAT}, {menu.Lunch}, {menu.Category}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteArticle(MenuItem menu)
        {
            string query = $"Delete from Menu where articleID = {menu.MenuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

        }
        public void UpdateStock(int newStock)
        {
            MenuItem menu = new MenuItem();
            string query = $"update Menu Set Stock = {newStock} Where articleID = {menu.MenuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<MenuItem> ReadMenu(DataTable datatable)
        {
            List<MenuItem> articleList = new List<MenuItem>();

            foreach (DataRow dr in datatable.Rows)
            {

                MenuItem article = new MenuItem()
                {
                    MenuItemID = (int)dr["articleID"],
                    Name = (String)dr["Name"],
                    Price = (decimal)dr["Price"],
                    Stock = (int)dr["Stock"],
                    VAT = (bool)dr["VAT"],
                    Lunch = (bool)dr["Lunch"],
                    Category = (Category)dr["Category_ID"]
                };
                articleList.Add(article);
            }
            return articleList;
        }
        private List<Employee> ReadEmployees(DataTable datatable)
        {
            List<Employee> employeeList = new List<Employee>();

            foreach (DataRow dr in datatable.Rows)
            {

                Employee employee = new Employee()
                {
                    EmployeeID = (int)dr["employee_ID"],
                    FirstName = (String)dr["first_Name"],
                    LastName = (string)dr["last_Name"],
                    Position = (Position)dr["position_ID"],
                    Email = (string)dr["email"],
                    PhoneNumber = (int)dr["phone_NR"],
                    Password = (int)dr["password"]
                };
                employeeList.Add(employee);
            }
            return employeeList;
        }
    }
}
