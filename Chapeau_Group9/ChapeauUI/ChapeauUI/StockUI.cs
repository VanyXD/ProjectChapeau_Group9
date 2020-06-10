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
        MenuItemServices Itemservices = new MenuItemServices();
        List<ChapeauModel.MenuItem> menuItems;
        public StockUI(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            GetMenuItems();
        }
        public void GetMenuItems()
        {
            menuItems = Itemservices.GetMenuItems();
            ItemList.Items.Clear();

            foreach(ChapeauModel.MenuItem item in menuItems)
            {
                ListViewItem li = new ListViewItem(item.MenuItemID.ToString());
                li.SubItems.Add(item.Name);
                li.SubItems.Add(item.Stock.ToString());

                ItemList.Items.Add(li);
            }
        }
        private void StockUI_Load_1(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            GetMenuItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerUI managerui = new ManagerUI(employee);
            this.Close();
            managerui.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            GetMenuItems();
        }
    }
}
