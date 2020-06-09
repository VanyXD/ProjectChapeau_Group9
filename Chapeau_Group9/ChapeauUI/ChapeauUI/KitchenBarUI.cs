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
        public KitchenBarUI(Form loginForm, Employee user)
        {
            InitializeComponent();
            DisplayStock();
            this.loginForm = loginForm;
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
            menuItems = service.GetMenuItems();// depends on the user login get drink or food
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DisplayStock();
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
    }
}
