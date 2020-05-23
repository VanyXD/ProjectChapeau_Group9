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
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem item1 = new MenuItem();
                item1.MenuItemID = 00000;
                item1.Name = "Empty";
                item1.Price = 00000;
                item1.Stock = 11111;
                item1.HighVAT = false;
                item1.Lunch = false;
                item1.Category = CategoryID.empty;

                menuItems.Add(item1);
                return menuItems;
                throw new Exception("Couldn't connect to the database");

            }
        }
    }
}
