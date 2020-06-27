using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class StockUI : Form
    {
        Employee employee;
        ManagerUI managerUi;
        Form LogIn;
        MenuItemService Itemservices = new MenuItemService();
        List<ChapeauModel.MenuItem> menuItems;
        public StockUI(ManagerUI managerUi, Employee employee, Form LogIn)
        {
            InitializeComponent();
            this.LogIn = LogIn;
            this.managerUi = managerUi;
            this.employee = employee;
            LoadMenuItems();
        }
        public void LoadMenuItems()
        {
            menuItems = Itemservices.GetMenuItems();
            ItemList.Items.Clear();

            foreach(ChapeauModel.MenuItem item in menuItems)
            {
                ListViewItem li = new ListViewItem(item.MenuItemID.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Stock.ToString());
                li.Tag = item;
                ItemList.Items.Add(li);
            }
        }
        private void StockUI_Load_1(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            LoadMenuItems();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            
            if (ItemList.SelectedItems.Count != 0)
            {
                int itemId = int.Parse(ItemList.SelectedItems[0].SubItems[0].Text);
                string itemName = ItemList.SelectedItems[0].SubItems[1].Text;
                int stock = int.Parse(ItemList.SelectedItems[0].SubItems[2].Text);
                ModifyUI modUI = new ModifyUI(itemName, itemId, stock);
                modUI.Show();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ItemList.Items.Clear();
            LoadMenuItems();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            managerUi.Show();
        }

        private void BTNLowStock_Click(object sender, EventArgs e)
        {
            menuItems = Itemservices.GetMenuItems();
            ItemList.Items.Clear();

            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Stock < 15)
                {
                    ListViewItem li = new ListViewItem(item.MenuItemID.ToString()); ;
                    li.SubItems.Add(item.Name);
                    li.SubItems.Add(item.Stock.ToString());
                    li.Tag = item;
                    ItemList.Items.Add(li);
                }
            }
        }

        private void BTNAllItems_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
        }
    }
}
