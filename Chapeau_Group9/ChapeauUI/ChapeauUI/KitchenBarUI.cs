using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class KitchenBarUI : Form
    {
        List<ChapeauModel.MenuItem> menuItems;
        Form loginForm;
        Employee user;
        public KitchenBarUI(Form loginForm, Employee user)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.user = user;
            DisplayStock();
            if (user.position == Position.cook)
            {
                cmb_Bar_Category.Hide();
            }
            else
            {
                cbox_Kitchen_Category.Hide();
                cbox_Kitchen_Menu.Hide();
                lbl_Kitche_Menu.Hide();
            }
        }

        private void btn_Kitchen_Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }


        public void DisplayStock()
        {
            lv_stock.Items.Clear();
            GetMenuItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                PrintItem(item, lv_stock);
            }
        }
        private void PrintItem(ChapeauModel.MenuItem item, ListView lv)
        {
            var row = new string[] { item.MenuItemID.ToString(), item.Name, item.Stock.ToString()};
            var lvi = new ListViewItem(row);
            lv.Items.Add(lvi);
        }

        private void DisplayStock(CategoryID category)
        {
            lv_stock.Items.Clear();
            GetMenuItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Category == category)
                    PrintItem(item, lv_stock);
            }
        }
        private void DisplayStock(MenuItemType type)
        {
            lv_stock.Items.Clear();
            GetMenuItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Type == type)
                    PrintItem(item, lv_stock);
            }
        }
        void GetMenuItems()
        {
            MenuItemServices service = new MenuItemServices();
            if (user.position == Position.cook)
            {
                menuItems = service.GetFoodItems();
            }
            else
            {
                menuItems = service.GetDrinkItems();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DisplayStock();
            cmb_Bar_Category.ResetText();
            cbox_Kitchen_Category.ResetText();
            cbox_Kitchen_Menu.ResetText();
        }
        private void Logout()
        {
            Close();
            loginForm.Show();
        }
        private void btn_Kitchen_Logout2_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btn_Kitchen_Modify_Click(object sender, EventArgs e)
        {
            if (lv_stock.SelectedItems.Count != 0)
            {
                int itemId = int.Parse(lv_stock.SelectedItems[0].SubItems[0].Text);
                string itemName = lv_stock.SelectedItems[0].SubItems[1].Text;
                int stock = int.Parse(lv_stock.SelectedItems[0].SubItems[2].Text);
                ModifyUI modUI = new ModifyUI(itemName, itemId, stock);
                modUI.Show();
            }
        }

        private void cbox_Kitchen_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_Kitchen_Menu.SelectedItem.ToString())
            {
                case "Lunch":
                    DisplayStock(MenuItemType.lunch);
                    break;
                case "Dinner":
                    DisplayStock(MenuItemType.dinner);
                    break;
            }
        }

        private void cbox_Kitchen_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbox_Kitchen_Category.SelectedItem.ToString())
            {
                case "Lunch Main":
                    DisplayStock(CategoryID.LunchMain);
                    break;
                case "Specials":
                    DisplayStock(CategoryID.LunchSpecials);
                    break;
                case "Bites":
                    DisplayStock(CategoryID.LunchBites);
                    break;
                case "Starters":
                    DisplayStock(CategoryID.DinnerStarters);
                    break;
                case "Mains":
                    DisplayStock(CategoryID.DinnerMains);
                    break;
                case "Desserts":
                    DisplayStock(CategoryID.DinnerDesserts);
                    break;
            }
        }

        private void cmb_Bar_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Bar_Category.SelectedItem.ToString())
            {
                case "Soft Drinks":
                    DisplayStock(CategoryID.SoftDrinks);
                    break;
                case "Hot Drinks":
                    DisplayStock(CategoryID.HotDrinks);
                    break;
                case "Beer":
                    DisplayStock(CategoryID.Beers);
                    break;
                case "Wine":
                    DisplayStock(CategoryID.Wines);
                    break;
            }
        }
    }
}
