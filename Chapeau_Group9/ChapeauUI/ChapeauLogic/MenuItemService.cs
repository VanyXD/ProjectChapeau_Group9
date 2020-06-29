using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDao = new MenuItemDAO();
        public List<MenuItem> GetMenuItems()
        {
            try
            {
                return menuItemDao.GetAllMenuItems();
            }
            catch (Exception)
            {
                return new List<MenuItem>();
            }
        }
        public List<MenuItem> GetFoodItems()
        {
            try
            {
                List<MenuItem> items = new List<MenuItem>();
                items = menuItemDao.GetFoodMenuItems();
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MenuItem> GetDrinkItems()
        {
            try
            {
                List<MenuItem> items = new List<MenuItem>();
                items = menuItemDao.GetDrinkMenuItems();
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MenuItem> GetForCategory(CategoryID categoryID)
        {
            try
            {
                List<MenuItem> items;
                if (categoryID == CategoryID.Beers || categoryID == CategoryID.Wines) //rename enum
                {
                    items = menuItemDao.GetForCategory(CategoryID.Wines);

                    // adding the list of wines and beers together
                    items.AddRange(menuItemDao.GetForCategory(CategoryID.Beers));
                }
                else
                {
                    items = menuItemDao.GetForCategory(categoryID);
                }
                return items;
            }
            catch (Exception)
            {

                return new List<MenuItem>();
                //return null;
            }
            
        }
        //add total price to table order
        public int ChangeStockAmount(MenuItem item)
        {
            try
            {
                return menuItemDao.ChangeStockAmount(item);
            }
            catch (Exception)
            {
                return -1;
            }
            

        }
        public bool UpdateStock(int id, int stock)
        {
            try
            {
                menuItemDao.UpdateStock(id, stock);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
