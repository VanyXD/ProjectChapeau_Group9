using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Reservations
    {
        public int CustomerContact;
        public string CustomerName;
        private DateTime DateTime;

        public Reservations(int customercontact, string customername, DateTime dateTime)
        {
            this.CustomerContact= customercontact;
            this.CustomerName = customername;
            this.DateTime = dateTime; 
        }
    }
}
