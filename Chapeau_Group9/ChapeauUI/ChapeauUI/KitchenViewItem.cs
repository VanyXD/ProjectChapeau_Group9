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
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class KitchenViewItem : Form
    {
        int tableId;
        Employee user;
        List<OrderItem> items;
        public KitchenViewItem(int tableId, Employee user)
        {
            InitializeComponent();
            this.user = user;
            this.tableId = tableId;
            GetOrderItems();
        }

        private void btn_ViewItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        void GetOrderItems()
        {
            OrderServices orderService = new OrderServices();
            if (user.position == Position.cook)
            {
                items = orderService.GetKitchenTableItems(tableId);
            }
            else
            {
                items = orderService.GetBarTableItems(tableId);
            }
            PrintItems();
        }

        public void PrintItems()
        {
            foreach (OrderItem item in items)
            {
                var row = new string[] { item.Quantity.ToString(), item.MenuItem.Name, item.Time.ToString("HH:mm")};
                var lvi = new ListViewItem(row);
                lv_ViewTable.Items.Add(lvi);
            }
        }
    }
}
