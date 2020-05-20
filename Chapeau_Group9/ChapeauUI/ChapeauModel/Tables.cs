namespace ChapeauModel
{
    public class Tables
    {
        public Reservations reservations { get; set; }
        public int TableID { get; set; }
        public TableStatus Status { get; set; } 
        public int OrderID { get; set; }
    }

}
