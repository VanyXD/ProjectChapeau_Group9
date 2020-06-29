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
            try
            {
                
                return tabledao.GetAllRunningOrders();
            }
            catch (Exception)
            {  
                return null;
            }
        }
 
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
