using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public Order()
        {
            OrderStatus = OrderStatus.Pending;
        }
        public Employee Employee { get; set; }

        public int OrderID { get; set; }

        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; } 

        public DateTime Time { get; set; }
        public Tables Table { get; set; }

        public OrderStatus OrderStatus { get; set; }

    }
}
