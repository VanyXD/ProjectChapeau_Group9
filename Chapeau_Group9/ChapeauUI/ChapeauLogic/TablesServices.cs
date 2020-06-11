using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class TablesServices
    {
        TablesDAO tabledao = new TablesDAO();
        List<Tables> tablesservices = new List<Tables>();
        List<Order> orders = new List<Order>();
        public List<Tables> GetALLTables()
        {
            try
            {              
                tablesservices = tabledao.GetALLTables();
                return tablesservices;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public void Updatetable(Tables table)
        {

            tabledao.UpdateTableStatus(table);

        }
        public void ReadOrderStatus(Order order)
        {
            tabledao.ReadOrdersStatus(order);
        }
    }
}
