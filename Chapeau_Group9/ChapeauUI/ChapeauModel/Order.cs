using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int EmployeeID { get; set; }

        public int OrderID { get; set; }

        public decimal TotalPrice { get; set; }
        public MenuItem Items { get; set; }

        public DateTime Time { get; set; }
        public int TableID { get; set; }

        public OrderStatus OrderStatus { get; set; }

    }
}
