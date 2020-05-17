using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class ManagerServices
    {
        Manager_DAO manager_db = new Manager_DAO();

        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                employees = manager_db.GetAllEmployees();
                return employees;
            }
            catch (Exception)
            {
                List<Employee> employees = new List<Employee>();
                Employee employee1 = new Employee();
                employee1.EmployeeID = 0000;
                employee1.FirstName = "Test";
                employee1.LastName = "Again";
                employee1.Position = null;
                employee1.Email = "No Email";
                employee1.PhoneNumber = 00000;
                employee1.Password = 00000;

                employees.Add(employee1);
                return employees;
                throw new Exception("Couldn't connect to the database");


            }

        }

        public List<MenuItem> GetArticles()
        {
            try
            {
                List<MenuItem> articles = new List<MenuItem>();
                articles = manager_db.GetMenu();
                return articles;
            }
            catch (Exception)
            {
                List<MenuItem> articles = new List<MenuItem>();
                MenuItem article1 = new MenuItem();
                article1.MenuItemID = 00000;
                article1.Name = "Empty";
                article1.Price = 00000;
                article1.Stock = 00000;
                article1.VAT = false;
                article1.Lunch = false;
                article1.Category = null;

                articles.Add(article1);
                return articles;
                throw new Exception("Couldn't connect to the database");

            }
        }
    }
}
