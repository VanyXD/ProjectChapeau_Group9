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
                List<Tables> tables = new List<Tables>();
                tables = table.GetAllTabels();
                //return table.GetAllTabels();
                return tables;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
