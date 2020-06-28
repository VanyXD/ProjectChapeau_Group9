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
        private Timer timer1;
        public KitchenViewItem(int tableId, Employee user)
        {
            InitializeComponent();
            this.user = user;
            this.tableId = tableId;
            lbl_title.Text += " " + tableId.ToString();
            SetHeight(lv_ViewTable, 40);
            GetOrderItems();
        }
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetOrderItems();
        }

        private void btn_ViewItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        void GetOrderItems()
        {


            OrderService orderService = new OrderService();
            if (user.position == Position.cook)
            {
                List<OrderItem> items = orderService.GetKitchenBarTableItems(tableId, MenuItemType.dinner);
                PrintItems(items);
            }
            else
            {
                List<OrderItem> items = orderService.GetKitchenBarTableItems(tableId, MenuItemType.drink);
                PrintItems(items);
            }
        }

        public void PrintItems(List<OrderItem> items)
        {
            foreach (OrderItem item in items)
            {
                var row = new string[] { item.MenuItem.Name, "x" + item.Quantity.ToString(), item.Time.ToString("HH:mm") };
                var lvi = new ListViewItem(row)
                {
                    Tag = item
                };
                lv_ViewTable.Items.Add(lvi);
            }
        }

        private void btn_ViewItem_Ready_Click(object sender, EventArgs e)
        {
            if (lv_ViewTable.SelectedItems.Count > 0)
            {
                OrderService services = new OrderService();
                foreach (ListViewItem item in lv_ViewTable.SelectedItems)
                {
                    {
                        OrderItem orderItem = (OrderItem)lv_ViewTable.SelectedItems[0].Tag;
                        services.OrderReady(orderItem.OrderItemID);
                        if (services.CheckStatusReady(orderItem.OrderId))
                        {
                            services.OrderCompeteReady(orderItem.OrderId);
                        }
                        lv_ViewTable.Items.Remove(item);
                    }
                }
            }
        }

        private void lv_item_Click(object sender, EventArgs e)
        {
            if (lv_ViewTable.SelectedItems.Count > 0)
            {
                txtbox_kitchen_notes.Text = ((OrderItem)(lv_ViewTable.SelectedItems[0].Tag)).Comment;
            }
        }
        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList
            {
                ImageSize = new Size(1, height)
            };
            listView.SmallImageList = imgList;
        }
    }
}
