﻿using System;
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
        public void UpdateStock(int id, int stock)
        {
            string query = "update menu " +
                "set[stock] = @stock " +
                "where article_id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@stock", stock);
            sqlParameters[1] = new SqlParameter("@id", id);
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "SELECT article_id, name, stock, VAT, price, category_id,item_type_id from menu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetFoodMenuItems()
        {
            string query = "SELECT article_id, name, stock, VAT, price, category_id,item_type_id from menu WHERE item_type_id < 3";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenu(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetDrinkMenuItems()
        {
            string query = "SELECT article_id, name, stock, VAT, price, category_id,item_type_id from menu WHERE item_type_id = 3";
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
                    Category = (Category)dr["category_id"]
                };
                articleList.Add(article);
            }
            return articleList;
        }
        public List<MenuItem> GetForCategory(Category category)
        {
            List<MenuItem> items = new List<MenuItem>();
            SqlCommand cmd = new SqlCommand($"SELECT article_id, [name], stock, VAT, price, category_id FROM menu WHERE category_id = @id", conn);
            cmd.Parameters.AddWithValue("@id", category);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MenuItem item = ReadItem(reader);
                items.Add(item);
            }
            reader.Close();
            conn.Close();
            return items;
        }
        public MenuItem ReadItem(SqlDataReader reader)
        {
            MenuItem item = new MenuItem
            {
                MenuItemID = (int)reader["article_id"],
                Stock = (int)reader["stock"],
                Category = (Category)reader["category_id"],
                HighVAT = (bool)reader["VAT"],
                Name = (string)reader["name"],
                Price = (decimal)reader["price"]

            };
            return item;

        }
        public int ChangeStockAmount(MenuItem item)
        {
            SqlCommand cmd = new SqlCommand("UPDATE menu SET stock = @stock WHERE article_id = @id", conn);
            cmd.Parameters.AddWithValue("@stock", item.Stock);
            cmd.Parameters.AddWithValue("@id", item.MenuItemID);

            conn.Open();

            int num = cmd.ExecuteNonQuery();

            conn.Close();
            
            return num;
        }
        public void EditMenuItem(MenuItem item)
        {
            SqlCommand cmd = new SqlCommand("update menu set [name] = @name , stock = @stock , vat = @vat , price = @price , category_id = @cat , item_type_id = @type where article_id = @id", conn);
            cmd.Parameters.AddWithValue("@name", item.Name);
            cmd.Parameters.AddWithValue("@stock", item.Stock);
            cmd.Parameters.AddWithValue("@vat", item.HighVAT);
            cmd.Parameters.AddWithValue("@price", item.Price);
            cmd.Parameters.AddWithValue("@cat", item.Category);
            cmd.Parameters.AddWithValue("@type", item.Type);
            cmd.Parameters.AddWithValue("@id", item.MenuItemID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //string query = $"update menu set [name] = '{item.Name}' , stock = {item.Stock} , vat = {item.HighVAT} , price = {item.Price} , category_id = {item.Category} , item_type_id = {item.Type} where article_id = {item.MenuItemID}";
            //SqlParameter[] sqlParameters = new SqlParameter[0];
            //ExecuteSelectQuery(query, sqlParameters);
        }
    }
}