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
        List<Order> orders;
        Timer orderTimer;
        public KitchenBarUI(Form loginForm, Employee user)
        {
            InitializeComponent();
            SetHeight(lv_stock, 45);
            SetHeight(lv_ViewOrders, 45);
            this.loginForm = loginForm;
            this.user = user;
            GetOrders();
            DisplayOrderItems();
            DisplayStock();
            if (user.position == Position.Cook)
            {
                lbl_OrderView.Text += "Kitchen";
                cmb_Bar_Category.Hide();
            }
            else
            {
                lbl_OrderView.Text += "Bar";
                cbox_Kitchen_Category.Hide();
                cbox_Kitchen_Menu.Hide();
                lbl_Kitche_Menu.Hide();
            }
            lbl_current_user.Text = $"{user.FirstName} {user.LastName}";
            InitTimer();
        }
        //Orders Part
        public void InitTimer()
        {
            orderTimer = new Timer();
            orderTimer.Tick += new EventHandler(Timer1_Tick);
            orderTimer.Interval = 10000;
            orderTimer.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            GetOrders();
            DisplayOrderItems();
        }
        void GetOrders()
        {
            OrderService service = new OrderService();
            if (user.position == Position.Cook)
            {
                orders = service.GetOrders(MenuItemType.dinner);
                foreach (Order order in orders)
                {
                    order.OrderItems = service.GetOrderItems(order.OrderID, MenuItemType.dinner);
                }
            }
            else
            {
                orders = service.GetOrders(MenuItemType.drink);
                foreach (Order order in orders)
                {
                    order.OrderItems = service.GetOrderItems(order.OrderID, MenuItemType.drink);
                }
            }
        }
        void DisplayOrderItems()
        {
            lv_ViewOrders.Items.Clear();
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    PrintOrderItem(order, item, lv_ViewOrders);
                }
            }
        }
        void PrintOrderItem(Order order, OrderItem item, ListView lv)
        {
            var row = new string[] { order.Table.TableID.ToString(), item.MenuItem.Name, "x" + item.Quantity.ToString(), order.Time.ToString("HH:mm") };
            var lvi = new ListViewItem(row)
            {
                Tag = item
            };
            lv.Items.Add(lvi);
        }

        //Stock Part
        void GetStockItems()
        {
            MenuItemService service = new MenuItemService();
            if (user.position == Position.Cook)
            {
                menuItems = service.GetFoodItems();
            }
            else
            {
                menuItems = service.GetDrinkItems();
            }
        }
        public void DisplayStock()
        {
            lv_stock.Items.Clear();
            GetStockItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                PrintStockItem(item, lv_stock);
            }
        }
        private void DisplayStock(CategoryID category)
        {
            lv_stock.Items.Clear();
            GetStockItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Category == category)
                    PrintStockItem(item, lv_stock);
            }
        }
        private void DisplayStock(MenuItemType type)
        {
            lv_stock.Items.Clear();
            GetStockItems();
            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Type == type)
                    PrintStockItem(item, lv_stock);
            }
        }
        private void PrintStockItem(ChapeauModel.MenuItem item, ListView lv)
        {
            var row = new string[] { item.MenuItemID.ToString(), item.Name, item.Stock.ToString() };
            var lvi = new ListViewItem(row)
            {
                Tag = item
            };
            lv.Items.Add(lvi);
        }
        //Modify stock of selected menu item
        private void btn_Kitchen_Modify_Click(object sender, EventArgs e)
        {
            if (lv_stock.SelectedItems.Count != 0)
            {
                ModifyUI modUI = new ModifyUI((ChapeauModel.MenuItem)lv_stock.SelectedItems[0].Tag);
                modUI.Show();
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DisplayStock();
            cmb_Bar_Category.ResetText();
            cbox_Kitchen_Category.ResetText();
            cbox_Kitchen_Menu.ResetText();
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
        //Common Part
        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList
            {
                ImageSize = new Size(1, height)
            };
            listView.SmallImageList = imgList;
        }
        private void btn_Kitchen_Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Item_Ready_Click(object sender, EventArgs e)
        {
            if (lv_ViewOrders.SelectedItems.Count > 0)
            {
                OrderService services = new OrderService();
                foreach (ListViewItem item in lv_ViewOrders.SelectedItems)
                {
                    {
                        OrderItem orderItem = (OrderItem)lv_ViewOrders.SelectedItems[0].Tag;
                        services.OrderReady(orderItem.OrderItemID);
                        if (services.CheckStatusReady(orderItem.OrderId))
                        {
                            services.OrderCompeteReady(orderItem.OrderId);
                        }
                        lv_ViewOrders.Items.Remove(item);
                    }
                }
            }
        }

        private void lv_ViewOrders_Item_Click(object sender, EventArgs e)
        {
            if (lv_ViewOrders.SelectedItems.Count > 0)
            {
                txtbox_notes.Text = ((OrderItem)(lv_ViewOrders.SelectedItems[0].Tag)).Comment;
            }
        }

        private void KitchenBarUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
