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
        TablesDAO table = new TablesDAO();

        public List<Tables> GetALLTables()
        {
            try
            {
                List<Tables> tablesservices = new List<Tables>();
                tablesservices = table.GetALLTables();
                return tablesservices;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
