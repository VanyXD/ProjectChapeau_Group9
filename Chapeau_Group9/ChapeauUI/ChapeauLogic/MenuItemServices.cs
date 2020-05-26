using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuItemServices
    {
        MenuItemDAO menuItem = new MenuItemDAO();
        public List<MenuItem> GetMenuItems()
        {
            try
            {
                List<MenuItem> items = new List<MenuItem>();
                items = menuItem.GetAllMenuItems();
                return items;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
    }
}
