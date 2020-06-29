using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauLogic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDao = new MenuItemDAO();
        public List<ChapeauModel.MenuItem> GetMenuItems()
        {
            try
            {
                return menuItemDao.GetAllMenuItems();
            }
            catch (Exception)
            {
                return new List<ChapeauModel.MenuItem>();
            }
        }
        public List<ChapeauModel.MenuItem> GetFoodItems()
        {
            try
            {
                List<ChapeauModel.MenuItem> items = new List<ChapeauModel.MenuItem>();
                items = menuItemDao.GetFoodMenuItems();
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ChapeauModel.MenuItem> GetDrinkItems()
        {
            try
            {
                List<ChapeauModel.MenuItem> items = new List<ChapeauModel.MenuItem>();
                items = menuItemDao.GetDrinkMenuItems();
                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ChapeauModel.MenuItem> GetForCategory(CategoryID categoryID)
        {
            try
            {
                List<ChapeauModel.MenuItem> items;
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

                return new List<ChapeauModel.MenuItem>();
                //return null;
            }
            
        }
        //add total price to table order
        public int ChangeStockAmount(ChapeauModel.MenuItem item)
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

        public void EditMenuItems(ChapeauModel.MenuItem item)
        {
            try
            {
                if (item.Category == CategoryID.Beers || item.Category == CategoryID.Wines)
                {
                    item.HighVAT = true;
                }
                else
                {
                    item.HighVAT = false;
                }
                menuItemDao.EditMenuItem(item);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void RemoveMenuItem(ChapeauModel.MenuItem item)
        {
            try
            {
                menuItemDao.RemoveMenuItem(item);
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
        public void AddMenuItem(ChapeauModel.MenuItem item)
        {
                if (item.Category == CategoryID.Beers || item.Category == CategoryID.Wines)
                {
                    item.HighVAT = true;
                }
                else
                {
                    item.HighVAT = false;
                }
                menuItemDao.AddMenuItem(item);
            
            //catch(Exception)
            //{
            //    throw new Exception("Couldent connect to database!");
            //}
        }
    }
}
