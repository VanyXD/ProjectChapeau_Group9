namespace ChapeauModel
{
    public class OrderItem // the class that will contain the order object, it will have a menu item and a quantity for it, we can create a list of it in the order class
    {
        public MenuItem MenuItem { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal TotaPrice { get { return MenuItem.Price * Quantity; } } 
    }
}
