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
        List<Button> buttons;
        List<ListView> listViews;
        Timer timer1;
        public KitchenBarUI(Form loginForm, Employee user)
        {
            InitializeComponent();
            buttons = MakeButtonsList();
            listViews = MakeListviewList();
            this.loginForm = loginForm;
            this.user = user;
            GetOrders();
            ColorButtons();
            DisplayOrderItems();
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
            lbl_current_user.Text = $"{user.FirstName} {user.LastName}";
            InitTimer();
        }
        //Orders Part
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetOrders();
            ColorButtons();
            DisplayOrderItems();
        }
        void ColorButtons()
        {
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.Gray;
            }
            foreach (Order order in orders)
            {
                if (order.OrderStatus == OrderStatus.Pending)
                    buttons[order.Table.TableID - 1].BackColor = Color.FromArgb(255, 255, 51);
            }
        }
        void DisplayOrderItems()
        {
            foreach (ListView listV in listViews)
            {
                listV.Items.Clear();
            }
            foreach (Order order in orders)
            {
                foreach (OrderItem item in order.OrderItems)
                {
                    PrintOrderItem(item, listViews[order.Table.TableID - 1]);
                }
            }
        }
        void DisplayOrder(int tableId)
        {
            KitchenViewItem display = new KitchenViewItem(tableId, user);
            display.Show();
        }
        private void btn_kitchen_table_Click(object sender, EventArgs e)
        {
            DisplayOrder(buttons.IndexOf((Button)sender) + 1);
        }
        void PrintOrderItem(OrderItem item, ListView lv)
        {
            var row = new string[] { item.Quantity.ToString(), item.MenuItem.Name };
            var lvi = new ListViewItem(row)
            {
                Tag = item
            };
            lv.Items.Add(lvi);
        }

        List<Button> MakeButtonsList()
        {
            List<Button> buttons = new List<Button>
            {
                btn_kitchen_table1,
                btn_kitchen_table2,
                btn_kitchen_table3,
                btn_kitchen_table4,
                btn_kitchen_table5,
                btn_kitchen_table6,
                btn_kitchen_table7,
                btn_kitchen_table8,
                btn_kitchen_table9,
                btn_kitchen_table10
            };
            return buttons;
        }
        List<ListView> MakeListviewList()
        {
            List<ListView> listViews = new List<ListView>
            {
                lv_kitchen_table1,
                lv_kitchen_table2,
                lv_kitchen_table3,
                lv_kitchen_table4,
                lv_kitchen_table5,
                lv_kitchen_table6,
                lv_kitchen_table7,
                lv_kitchen_table8,
                lv_kitchen_table9,
                lv_kitchen_table10
            };
            return listViews;
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
        void GetStockItems()
        {
            MenuItemService service = new MenuItemService();
            if (user.position == Position.cook)
            {
                menuItems = service.GetFoodItems();
            }
            else
            {
                menuItems = service.GetDrinkItems();
            }
        }

        void GetOrders()
        {
            OrderService service = new OrderService();
            if (user.position == Position.cook)
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

        //Stock Part
        private void PrintStockItem(ChapeauModel.MenuItem item, ListView lv)
        {
            var row = new string[] { item.MenuItemID.ToString(), item.Name, item.Stock.ToString() };
            var lvi = new ListViewItem(row)
            {
                Tag = item
            };
            lv.Items.Add(lvi);
        }
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
        private void btn_Kitchen_Logout_Click(object sender, EventArgs e)
        {
            Close();
            loginForm.Show();
        }
    }
}
