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
        MenuItemDAO menuItemDao = new MenuItemDAO();
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> items = new List<MenuItem>();
            try
            {
                
                items = menuItemDao.GetAllMenuItems();
                return items;
            }
            catch (Exception)
            {
                MenuItem dummy = new MenuItem
                {
                    MenuItemID = 000,
                    Name = "Test"
                };
                items.Add(dummy);
                return items;
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
        public List<MenuItem> GetForCategory(string category)
        {

            try
            {
                CategoryID categoryID = CategoryID.empty;
                switch (category.ToLower())
                {
                    case "lunchmains":
                        categoryID = CategoryID.LunchMain;
                        break;
                    case "lunchspecials":
                        categoryID = CategoryID.LunchSpecials;
                        break;
                    case "lunchbites":
                        categoryID = CategoryID.LunchBites;
                        break;
                    case "dinnermains":
                        categoryID = CategoryID.DinnerMains;
                        break;
                    case "dinnerstarters":
                        categoryID = CategoryID.DinnerStarters;
                        break;
                    case "dinnerdesserts":
                        categoryID = CategoryID.DinnerDesserts;
                        break;
                    case "softdrinks":
                        categoryID = CategoryID.SoftDrinks;
                        break;
                    case "hotdrinks":
                        categoryID = CategoryID.HotDrinks;
                        break;
                    case "alcohol":
                        categoryID = CategoryID.Wines;
                        break;

                }

                List<MenuItem> items = menuItemDao.GetForCategory(categoryID);

                return items;
            }
            catch (Exception)
            {
                List<MenuItem> items = new List<MenuItem>();
                MenuItem dummy = new MenuItem
                {
                    MenuItemID = 000,
                    Name = "Test"
                };
                items.Add(dummy);
                return items;
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
