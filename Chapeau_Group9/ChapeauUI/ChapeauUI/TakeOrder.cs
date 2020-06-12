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


namespace ChapeauUI
{
    public partial class TakeOrder : Form
    {
        TablesOverview overview;
        MenuItemServices menuItemService;
        List<OrderItem> selectedItems;
        OrderServices orderService;
        MenuItemServices menuIt;
        TablesServices TablesServices;

        Timer timer = new Timer();
        Employee employee;
        Tables table;
        Order order;
        public TakeOrder(TablesOverview overview,Employee employee, int tableNum)
        {
            InitializeComponent();
            this.overview = overview;
            menuItemService = new MenuItemServices();
            selectedItems = new List<OrderItem>();
            this.employee = employee;
            orderService = new OrderServices();
            menuIt = new MenuItemServices();
            TablesServices = new TablesServices();

            // fix
            order = new Order();
            order.Employee = this.employee;
            order.OrderStatus = OrderStatus.Pending;

            table = new Tables(tableNum, TableStatus.Occupied, tableNum);

            order.Table = table;
            //orderdao.WriteOrder(order);
        }

        private void TakeOrder_Load(object sender, EventArgs e)
        {
            List<MenuItem> fullMenu = menuItemService.GetMenuItems();
            order.OrderItems = selectedItems;
            txtComment.Enabled = false;
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
                item.SubItems.Add(mt.Stock.ToString());
                if(mt.Stock < 10)
                {
                    item.SubItems.Add("low Stock");
                }
                else if(mt.Stock == 0)
                {
                    item.SubItems.Add("out of stock");
                }
                else
                {
                    item.SubItems.Add("sufficient");
                }
                item.Tag = mt;
                lstvMenu.Items.Add(item);
            }
            if(menu[0].MenuItemID == 000)
            {
                MessageBox.Show("database connection failed");
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstvMenu.SelectedItems.Count <= 0)
            {
                return;
            }
            if(numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("please select a quantity to add");
                return;
            }
            

            else
            {
                MenuItem chosen = (MenuItem)lstvMenu.SelectedItems[0].Tag;
                if(chosen.Stock >= numericUpDownQuantity.Value)
                {
                    chosen.Stock -= Convert.ToInt32(numericUpDownQuantity.Value);
                    
                    
                    OrderItem orderItem = new OrderItem { MenuItem = chosen, Quantity = Convert.ToInt32(numericUpDownQuantity.Value) };

                    if (txtComment.Enabled && txtComment.Text != null)
                    {
                        orderItem.Comment = txtComment.Text;
                    }
                    else
                    {
                        orderItem.Comment = "none";
                    }
                    selectedItems.Add(orderItem);
                }
                else
                {
                    MessageBox.Show($"the amount chosen is not available in the stock, the available amount is {chosen.Stock}");
                }
                

                
            }
            checkBoxComment.Checked = false;
            txtComment.Text = "";
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
            List<MenuItem> items = menuItemService.GetForCategory("DinnerMains");
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

            OrderItem item = (OrderItem)lstvSelected.SelectedItems[0].Tag;

            string message = $"do you want to remove {item.MenuItem.Name}?";
            string title = "Remove item";
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
            foreach(OrderItem m in selectedItems)
            {
                ListViewItem item = new ListViewItem(m.MenuItem.MenuItemID.ToString());
                item.SubItems.Add(m.MenuItem.Name);
                item.SubItems.Add(m.Quantity.ToString());
                item.SubItems.Add(m.MenuItem.Price.ToString("0.00"));
                item.SubItems.Add(m.Comment);
                item.Tag = m;
                lstvSelected.Items.Add(item);
            }


        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            //add total price to the table Order
            if(selectedItems.Count <= 0) // when no items are selected (added to list of order)
            {
                MessageBox.Show("you need to choose items to order");
                return;
            }
            

            int num = orderService.WriteOrder(order);
            table.Status = TableStatus.Occupied;
            TablesServices.Updatetable(table);
            foreach (OrderItem item in order.OrderItems)
            {
                menuItemService.ChangeStockAmount(item.MenuItem);
            }

            if (num > 0)
            {
                MessageBox.Show("order is sent");

            }
            else if(num == -1)
            {
                MessageBox.Show("database connection failed");
            }
            else
            {
                MessageBox.Show("some unhandled error");
            }
            lstvSelected.Items.Clear();

            btnShowFull_Click(sender, e);

            RenewOrder();
        }
        private void RenewOrder()
        {
            order = new Order();
            selectedItems = new List<OrderItem>();
            order.OrderItems = selectedItems;
            order.Table = this.table;

            numericUpDownQuantity.Value = 0;
            order.Employee = this.employee;
        }

        private void lstvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Hide();
            
            overview.Show();
        }

        private void checkBoxComment_CheckedChanged(object sender, EventArgs e)
        {
            if (txtComment.Enabled)
            {
                txtComment.Enabled = false;
            }
            else
            {
                txtComment.Enabled = true;
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            
            RenewOrder();
            ShowSelectedItems();
        }

        private void TakeOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
