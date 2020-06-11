using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class OrderItem // the class that will contain the order object, it will have a menu item and a quantity for it, we can create a list of it in the order class
    {
        public int OrderItemID { get; set; }
        public MenuItem MenuItem { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotaPrice { get { return MenuItem.Price * Quantity; } } 
        public DateTime Time { get; set; }
        public string Comment { get; set; }
    }
}
