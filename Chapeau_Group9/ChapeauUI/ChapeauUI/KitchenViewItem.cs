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
            lbl_title.Text += " " + tableId.ToString();
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
                var row = new string[] { item.OrderItemID.ToString(), item.MenuItem.Name, "x" + item.Quantity.ToString(), item.Time.ToString("HH:mm") , item.OrderId.ToString(), item.Comment};
                var lvi = new ListViewItem(row);
                lv_ViewTable.Items.Add(lvi);
            }
        }

        private void btn_ViewItem_Ready_Click(object sender, EventArgs e)
        {
            OrderServices services = new OrderServices();
            if (lv_ViewTable.SelectedItems.Count > 0)
                foreach (ListViewItem item in lv_ViewTable.SelectedItems)
                {
                    {
                        services.OrderReady(int.Parse(item.SubItems[0].Text));
                        int orderId = int.Parse(item.SubItems[4].Text);
                        if (services.CheckStatusReady(orderId))
                        {
                            services.OrderCompeteReady(orderId);
                        }
                        lv_ViewTable.Items.Remove(item);
                    }
                }
        }

        private void lv_item_Click(object sender, EventArgs e)
        {
            if(lv_ViewTable.SelectedItems.Count > 0)
            {
                txtbox_kitchen_notes.Text = lv_ViewTable.SelectedItems[0].SubItems[5].Text;
            }
        }
    }
}
