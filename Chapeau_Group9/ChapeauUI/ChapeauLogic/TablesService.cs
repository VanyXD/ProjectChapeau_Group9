using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;


namespace ChapeauLogic
{
    public class TablesService
    {
        TablesDAO tabledao = new TablesDAO();
        List<Table> tablesservices = new List<Table>();
        List<Order> orderservice = new List<Order>();

        public List<Table> GetALLTables()
        {
            try
            {
                tablesservices = tabledao.GetALLTables();
                return tablesservices;
            }
            catch 
            {
                MessageBox.Show("Couldn't connect to the database");
                List<Table> teststock = new List<Table>();
                Table S = new Table(1, TableStatus.Free, 1);
                teststock.Add(S);
                return teststock;
            }
        }
        public void Updatetable(Table table)
        {
            try
            {
                tabledao.UpdateTableStatus(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
            }

           
        }
        public List<Order> GetAllRunningOrders()
        {
            try
            {
                orderservice = tabledao.GetAllRunningOrders();
                return orderservice;
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't connect to the database");
                return orderservice;
            }
        }

    }
}
