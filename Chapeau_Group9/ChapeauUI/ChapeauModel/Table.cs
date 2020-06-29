namespace ChapeauModel
{
    public class Table
    {
        public int TableID { get; set; }
        public TableStatus Status { get; set; } 
        public int TableNumber { get; set; }


        public Table(int tableid, TableStatus status, int tablenumber)
        {
            this.TableID = tableid;
            this.Status = status;
            this.TableNumber = tablenumber;
        }
        public Table(int tableid)
        {
            TableID = tableid;
        }
        public Table() { }
    }
    

}
