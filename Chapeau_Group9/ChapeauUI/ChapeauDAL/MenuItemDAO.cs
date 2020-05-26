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
            string query = $"update Menu Set articleID = {menu.MenuItemID},Name = '{menu.Name}', Price = {menu.Price},Stock= {menu.Stock},VAT = {menu.HighVAT}, Lunch = {menu.Lunch}, Category_ID = {menu.Category}";
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
            string query = $"insert into Menu(articleID,Name,Price,Stock,VAT,Lunch,Category_ID) values({menu.MenuItemID}, '{menu.Name}', {menu.Price}, " +
                $"{menu.Stock}, {menu.HighVAT}, {menu.Lunch}, {menu.Category}";
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
            string query = "SELECT article_id,Name,Price,Stock,VAT,Lunch,Category_ID FROM [Menu]";
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
                    MenuItemID = (int)dr["articleID"],
                    Name = (String)dr["Name"],
                    Price = (decimal)dr["Price"],
                    Stock = (int)dr["Stock"],
                    HighVAT = (bool)dr["VAT"],
                    Lunch = (bool)dr["Lunch"],
                    Category = (CategoryID)dr["Category_ID"]
                };
                articleList.Add(article);
            }
            return articleList;
        }
    }
}
