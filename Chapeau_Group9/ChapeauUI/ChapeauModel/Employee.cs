﻿using System;
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
        
        public Employee() { }
        public Employee(int employeeid)
        {
            this.EmployeeID = employeeid;
        }
    }
}
