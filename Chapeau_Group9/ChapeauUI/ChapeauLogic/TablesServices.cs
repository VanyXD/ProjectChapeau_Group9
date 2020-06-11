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
            try
            {
                tabledao.UpdateTableStatus(table);
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }

<<<<<<< HEAD
            tabledao.UpdateTableStatus(table);
=======
        }
        public void ReadOrderStatus(Order order)
        {
            try
            {
                tabledao.ReadOrdersStatus(order);
            }
           
             catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
>>>>>>> 86123ce713860c10792421c35121cfe6ae0de05f
        }
    }
}
