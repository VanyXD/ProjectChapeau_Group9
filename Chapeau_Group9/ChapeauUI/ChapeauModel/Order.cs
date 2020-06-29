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
            OrderItems = new List<OrderItem>();
            totalprice = 0;
        }
        public Employee Employee { get; set; }

        public int OrderID { get; set; }
        private decimal totalprice;
        public decimal TotalPrice 
        {
            get
            {
                foreach (OrderItem item in OrderItems)
                {
                    totalprice += item.TotaPrice;
                }
                return totalprice;
            }
            set
            {
                totalprice = value;
            }
        }
        public List<OrderItem> OrderItems { get; set; } 
        public DateTime Time { get; set; }
        public Table Table { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
