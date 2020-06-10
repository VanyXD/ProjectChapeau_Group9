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
using MenuItem = ChapeauModel.MenuItem;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class TakeOrder : Form
    {
        
        MenuItemServices menuItemService;
        List<ChapeauModel.MenuItem> selectedItems;
        OrderDAO orderdao = new OrderDAO();

        Employee employee;
        Tables table;
        Order order;
        public TakeOrder(Employee employee, int tableNum)
        {
            InitializeComponent();
            menuItemService = new MenuItemServices();
            selectedItems = new List<ChapeauModel.MenuItem>();
            this.employee = employee;

            order = new Order();
            order.Employee = employee;
            order.OrderStatus = OrderStatus.Pending;

            table = new Tables(tableNum, TableStatus.Occupied, tableNum);

            order.Table = table;
            orderdao.WriteOrder(order); //error here
        }

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            List<MenuItem> fullMenu = menuItemService.GetMenuItems();
            LoadMenu(fullMenu);


        }
        private void LoadMenu(List<MenuItem> menu)
        {
            lstvMenu.Items.Clear();
            foreach (MenuItem mt in menu)
            {
                ListViewItem item = new ListViewItem(mt.MenuItemID.ToString());
                item.SubItems.Add(mt.Name);
                item.SubItems.Add(mt.Price.ToString("0.00"));
                item.Tag = mt;
                lstvMenu.Items.Add(item);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstvMenu.SelectedItems.Count < 1)
            {
                return;
            }

            MenuItem chosen = (MenuItem)lstvMenu.SelectedItems[0].Tag;

            selectedItems.Add(chosen);

            ShowSelectedItems();

        }

        private void btnShowFull_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetMenuItems();
            LoadMenu(items);
        }

        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory("LunchMains");
            LoadMenu(items);
        }

        private void btnLunchSpecials_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory("LunchSpecials");
            LoadMenu(items);
        }

        private void btnLunchBites_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory("Lunchbites");
            LoadMenu(items);
        }

        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory("DinnerMains");
            LoadMenu(items);
        }

        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory("DinnerStarters");
            LoadMenu(items);
        }

        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory("DinnerDesserts");
            LoadMenu(items);
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory("SoftDrinks");
            LoadMenu(items);
        }

        private void btnHotDrinks_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory("HotDrinks");
            LoadMenu(items);
        }

        private void btnAlcoholics_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory("alcohol");
            LoadMenu(items);
        }

        

        private void lstvSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstvSelected.SelectedItems.Count < 1)
            {
                return;
            }

            ChapeauModel.MenuItem item = (ChapeauModel.MenuItem)lstvSelected.SelectedItems[0].Tag;

            string message = $"do you want to remove {item.Name}?";
            string title = "Remove Food";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                selectedItems.Remove(item);
            }
            else
            {
                return;
            }
            ShowSelectedItems();


        }
        private void ShowSelectedItems()
        {
            lstvSelected.Items.Clear();
            foreach(ChapeauModel.MenuItem m in selectedItems)
            {
                ListViewItem item = new ListViewItem(m.MenuItemID.ToString());
                item.SubItems.Add(m.Name);
                item.SubItems.Add(m.Price.ToString("0.00"));
                item.Tag = m;
                lstvSelected.Items.Add(item);
            }


        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            //button send order!!!!
            //SqlCommand cmd = new SqlCommand();



            //for (int i = 0; i < selectedItems.Count; i++)
            //{
            //    OrderItem orderItem;

            //    if (itens.Any(x => x.MenuItem.MenuItemID == selectedItems.ElementAt(i).MenuItemID))
            //    {
            //        orderItem = itens.FirstOrDefault(x => x.MenuItem.MenuItemID == selectedItems.ElementAt(i).MenuItemID);
            //        orderItem.Quantity++;
            //    }
            //    else
            //    {
            //        orderItem = new OrderItem
            //        {
            //            OrderId = order.OrderID,
            //            MenuItem = selectedItems.ElementAt(i),
            //            Quantity = 1
            //        };
            //        itens.Add(orderItem);
            //    }
            //}

            //order.OrderItems = itens;

            //orderdao.WriteOrderItems(order); //here

            //SqlCommand cmd = new SqlCommand(cmd);

            List<Order> itens = new List<Order>();
            foreach (Order item in itens)
            {
                orderdao.InsertOrder(item);
            }
        }
    }
}
