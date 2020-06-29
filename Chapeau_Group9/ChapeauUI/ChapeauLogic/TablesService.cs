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
        
        List<Order> orderservice = new List<Order>();

        public List<Table> GetALLTables()
        {
            try
            {
                return tabledao.GetALLTables();
                
            }
            catch 
            {
                return null;
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
            //try
            //{
                //orderservice = tabledao.GetAllRunningOrders();
                return tabledao.GetAllRunningOrders();
            //}
            //catch (Exception)
            //{
            //    //MessageBox.Show("Couldn't connect to the database"); // wtf elias?!!!
            //    //return orderservice; // just return null NOOB
            //    return null;
            //}
        }
        // you dont have a method to get a specific table's status or details, so I created it cuz u need it NOOB
        // will also create it in dal
        public Table GetTableForID(int tableID)
        {
            try
            {
                return tabledao.GetTableForID(tableID);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
