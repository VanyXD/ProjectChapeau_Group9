using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class KitchenUI : Form
    {
        List<ChapeauModel.MenuItem> menuItems;
        public KitchenUI()
        {
            InitializeComponent();
            GetStock();
        }

        private void btn_Kitchen_Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void AddStockItem(ChapeauModel.MenuItem item)
        {
            var row = new string[] { item.Stock.ToString(), item.Name };
            var lvi = new ListViewItem(row);
            lv_stock.Items.Add(lvi);
        }
        private void Logout()
        {
            Close();
            Chapeau loginWindow = new Chapeau();
            loginWindow.Show();
        }

        private void GetStock()
        {
            lv_stock.Clear();
            RefreshMenu();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                AddStockItem(item);
            }
        }

        private void GetStock(CategoryID category)
        {
            lv_stock.Clear();
            RefreshMenu();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Category == category)
                    AddStockItem(item);
            }
        }
        void RefreshMenu()
        {
            MenuItemServices service = new MenuItemServices();
            menuItems = service.GetMenuItems();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void btn_Kitchen_Logout2_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btn_kitchen_table1_Click(object sender, EventArgs e)
        {

        }
    }
}
