namespace ChapeauModel
{
    public class Tables
    {
        public int TableID { get; set; }
        public TableStatus Status { get; set; } 
        public int TableNumber { get; set; }

        public Tables(int tableid, TableStatus status , int tablenumber)
        {
            this.TableID = tableid;
            this.Status = status;
            this.TableNumber = tablenumber;
        }
        public Tables(int tableid)
        {
            TableID = tableid;
        }
    }
    

}
