using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    class ManagerServices
    {
        Manager_DAO manager = new Manager_DAO();

        public public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                employees = manager.GetAllEmployees();
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

        public List<Menu> GetArticles()
        {
            try
            {
                List<Menu> articles = new List<Menu>();
                articles = manager.GetMenu();
                return articles;
            }
            catch (Exception)
            {
                List<Menu> articles = new List<Menu>();
                Menu article1 = new Menu();
                article1.ArticleID = 00000;
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
