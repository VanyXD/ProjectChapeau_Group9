using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using System.Configuration;


namespace ChapeauDAL
{
    public class MenuItemDAO : Base
    {
        public void UpdateItem(MenuItem menu)
        {
            string query = $"update Menu Set articleID = {menu.MenuItemID},Name = '{menu.Name}', Price = {menu.Price},Stock= {menu.Stock},VAT = {menu.HighVAT}, Lunch = {menu.Type}, Category_ID = {menu.Category}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //I added this method from the Employee class
        public void RemoveItem(MenuItem menu)
        {
            string query = $"Delete from Menu where articleID = {menu.MenuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //I added this method from the Employee class
        public void AddItem(MenuItem menu)
        {
            string query = $"insert into Menu(articleID,Name,Price,Stock,VAT,item_type_id,Category_ID) values({menu.MenuItemID}, '{menu.Name}', {menu.Price}, " +
                $"{menu.Stock}, {menu.HighVAT}, {menu.Type}, {menu.Category}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateStock(int newStock)
        {
            MenuItem menu = new MenuItem();
            string query = $"update Menu Set Stock = {newStock} Where articleID = {menu.MenuItemID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "SELECT article_id, name, stock, VAT, price, category_id,item_type_id from menu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadMenu(DataTable datatable)
        {
            List<MenuItem> articleList = new List<MenuItem>();
            foreach (DataRow dr in datatable.Rows)
            {
                MenuItem article = new MenuItem()
                {
                    MenuItemID = (int)dr["article_id"],
                    Name = (string)dr["name"],
                    Price = (decimal)dr["price"],
                    Stock = (int)dr["stock"],
                    HighVAT = (bool)dr["VAT"],
                    Type = (MenuItemType)dr["item_type_id"],
                    Category = (CategoryID)dr["category_id"]
                };
                articleList.Add(article);
            }
            return articleList;
        }
    }
}
