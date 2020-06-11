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

        public List<Tables> GetALLTables()
        {
            try
            {
                List<Tables> tablesservices = new List<Tables>();
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
<<<<<<< HEAD
            tabledao.UpdateTableStatus(table);
            //try
            //{

            //    tabledao.UpdateTableStatus(table);

            //}
            ////error here cant connect to the db
=======
           // try
           // {
                
                tabledao.UpdateTableStatus(table);
              
          //  }
            //error here cant connect to the db
>>>>>>> ad1a809adec212f5d3d8cb29091c2fea4a4dbc1d
            //catch
            //{
            //    throw new Exception("Couldn't connect to the database");
            //}
        }
    }
}
