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
                throw new Exception("Couldn't connect to the database");
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
                throw new Exception ("Couldn't connect to the database");
            }

           
        }
        public List<Order> GetAllOrders()
        {
            try
            {
                orderservice = tabledao.ReadAllOrders();
                return orderservice;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

    }
}
