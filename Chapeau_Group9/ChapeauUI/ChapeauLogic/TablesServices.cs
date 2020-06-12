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
    public class TablesServices
    {
        TablesDAO tabledao = new TablesDAO();
        List<Tables> tablesservices = new List<Tables>();
        List<Order> orderservice = new List<Order>();

        public List<Tables> GetALLTables()
        {
            try
            {
                tablesservices = tabledao.GetALLTables();
                return tablesservices;
            }
            catch 
            {
                MessageBox.Show("Couldn't connect to the database");
                List<Tables> teststock = new List<Tables>();
                Tables S = new Tables(1, TableStatus.Free, 1);
                teststock.Add(S);
                return teststock;
            }
        }
        public void Updatetable(Tables table)
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
        public List<Order> GetAllOrders(Order order)
        {
            try
            {
                orderservice = tabledao.ReadAllOrders(order);
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
