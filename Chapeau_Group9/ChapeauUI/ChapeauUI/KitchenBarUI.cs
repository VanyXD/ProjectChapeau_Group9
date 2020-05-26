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

        public KitchenBarUI()
        {
            InitializeComponent();
            GetStock();
        }

        private void btn_Kitchen_Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }


        private void GetStock()
        {
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

        private void GetStock(CategoryID category)
        {
            lv_stock.Clear();
            GetMenuItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Category == category)
                    PrintItem(item, lv_stock);
            }
        }
        void GetMenuItems()
        {
            MenuItemServices service = new MenuItemServices();
            menuItems = service.GetMenuItems();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GetMenuItems();
        }
        private void Logout()
        {
            Close();
            Chapeau loginWindow = new Chapeau();
            loginWindow.Show();
        }
        private void btn_Kitchen_Logout2_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btn_Kitchen_Modify_Click(object sender, EventArgs e)
        {
            ModifyUI modUI = new ModifyUI();
            modUI.Show();
        }
    }
}
