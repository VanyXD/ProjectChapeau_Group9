using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position position { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int Password { get; set; }

        //public Employee(int employeeid , string firstname , string lastname , Position position , string email , int phonenum , int passwprd)
        //{
        //    this.EmployeeID = employeeid;
        //    this.FirstName = firstname;
        //    this.LastName = lastname;
        //    this.position = position;
        //    this.Email = email;
        //    this.PhoneNumber = phonenum;
        //    this.Password = passwprd;
        //}
    }
}
