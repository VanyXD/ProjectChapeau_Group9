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
        Form passedForm;
        MenuItemService menuItemService;

        OrderService orderService;
        
        Employee employee;
        Table table;
        Order order; // this needs to be global for the buttons to be able to access it
        public TakeOrder(Form passedForm, Employee employee, Table table) // passing Form for future changes, if this form needs to be opened from any other form
        {
            InitializeComponent();
            this.passedForm = passedForm;

            this.employee = employee;
            orderService = new OrderService();
            menuItemService = new MenuItemService();
            

            this.table = table;

        }
        private void TakeOrder_Load(object sender, EventArgs e)
        {
            InitializeOrder();
            List<MenuItem> fullMenu = menuItemService.GetMenuItems();
            DisplayMenu(fullMenu);
            lblMenu.Text = "Full Menu";

            txtComment.Enabled = false;
            lblTable.Text = $"#{this.table.TableID}";
            this.Opacity = 1;
            numericUpDownQuantity.Controls[0].Hide();
        }

        private void InitializeOrder()
        {
            lstvSelected.Items.Clear();

            this.order = new Order();

            this.order.Employee = this.employee;

            order.Table = this.table;
        }


        private void DisplayMenu(List<MenuItem> menu)
        {
            if (menu == null)
            {
                MessageBox.Show("database connection failed");
                return;
            }
            lstvMenu.Items.Clear();
            foreach (MenuItem article in menu)
            {
                ListViewItem lvItem = new ListViewItem(article.Name);
                
                lvItem.SubItems.Add(article.Price.ToString("0.00"));
                lvItem.SubItems.Add(article.Stock.ToString());
                if (article.Stock == 0)
                {
                    lvItem.SubItems[2].BackColor = Color.Red;
                }
                else if (article.Stock < 10)
                {
                    lvItem.SubItems[2].BackColor = Color.Orange;
                }
                lvItem.UseItemStyleForSubItems = false;
                lvItem.Tag = article; // for future use throughout the code
                lstvMenu.Items.Add(lvItem);
            }
        
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstvMenu.SelectedItems.Count <= 0)
            {
                return;
            }
            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("please select a quantity to add");
                return;
            }
            MenuItem chosen = (MenuItem)lstvMenu.SelectedItems[0].Tag;
            if (chosen.Stock >= numericUpDownQuantity.Value)
            {
                chosen.Stock -= Convert.ToInt32(numericUpDownQuantity.Value); // changing the stock amount so it can be updated in db
                OrderItem orderItem = new OrderItem { MenuItem = chosen, Quantity = Convert.ToInt32(numericUpDownQuantity.Value) };
                if (txtComment.Enabled && txtComment.Text != null)
                {
                    orderItem.Comment = txtComment.Text;
                }
                else
                {
                    orderItem.Comment = "none";
                }
                this.order.OrderItems.Add(orderItem);
            }
            else
            {
                MessageBox.Show($"the amount chosen is not available in the stock, the available amount is {chosen.Stock}");
            }
            checkBoxComment.Checked = false;
            txtComment.Text = "";
            ShowSelectedItems(); //change
            lblTotal.Text = order.TotalPrice.ToString();
        }
        private void btnShowFull_Click(object sender, EventArgs e)
        {

            List<MenuItem> items = menuItemService.GetMenuItems();
            DisplayMenu(items);
            lblMenu.Text = "Full Menu";
        }
        private void btnLunchMains_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.LunchMain);
            DisplayMenu(items);
            lblMenu.Text = "Lunch Mains";
        }
        private void btnLunchSpecials_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.LunchSpecials);
            DisplayMenu(items);
            lblMenu.Text = "Lunch Specials";
        }
        private void btnLunchBites_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.LunchBites);
            DisplayMenu(items);
            lblMenu.Text = "Lunch Bites";
        }
        private void btnDinnerMains_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.DinnerMains);
            DisplayMenu(items);
            lblMenu.Text = "Dinner Mains";
        }
        private void btnDinnerStarters_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.DinnerStarters);
            DisplayMenu(items);
            lblMenu.Text = "Dinner Starters";
        }
        private void btnDinnerDesserts_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.DinnerDesserts);
            DisplayMenu(items);
            lblMenu.Text = "Dinner Desserts";
        }
        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            List<MenuItem> items = menuItemService.GetForCategory(CategoryID.SoftDrinks);
            DisplayMenu(items);
            lblMenu.Text = "Soft Drinks";
        }
        private void btnHotDrinks_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory(CategoryID.HotDrinks);
            DisplayMenu(items);
            lblMenu.Text = "Hot Drinks";
        }
        private void btnAlcoholics_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> items = menuItemService.GetForCategory(CategoryID.Beers);
            DisplayMenu(items);
            lblMenu.Text = "Beers/Wines";
        }
        private void lstvSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvSelected.SelectedItems.Count < 1)
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
                order.OrderItems.Remove(item);
                ShowSelectedItems();
            }
        }
        private void ShowSelectedItems()
        {
            lstvSelected.Items.Clear();
            foreach (OrderItem orditm in order.OrderItems)
            {
                ListViewItem item = new ListViewItem(orditm.MenuItem.Name);
                
                item.SubItems.Add(orditm.Quantity.ToString());
                
                item.SubItems.Add(orditm.Comment);
                item.Tag = orditm;
                lstvSelected.Items.Add(item);
            }
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            
            if (order.OrderItems.Count <= 0) // when no items are selected (added to list of order)
            {
                MessageBox.Show("you need to choose items to order");
                return;
            }
            int num = orderService.WriteOrder(order, this.table);
            
            foreach (OrderItem item in order.OrderItems)
            {
                menuItemService.ChangeStockAmount(item.MenuItem);
            }
            if (num > 0)
                MessageBox.Show("order is sent");

            else if (num == -1)
                MessageBox.Show("some error happened while writing orders to the system");

            else if (num == -2)
                MessageBox.Show("database connection failed");

            else
                MessageBox.Show("some unhandled error");


            DisplayMenu(menuItemService.GetMenuItems()); // showing all menu items after the order is sent and finished
            InitializeOrder();

        }
        

        private void lstvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value = 0;

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
            InitializeOrder();
            ShowSelectedItems();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            passedForm.Show();
            this.Close();
        }

        // too many events here but its for the sake of design... has nothing to do with functionality
        // can be completely ignored

        private void btnShowFull_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnShowFull);
        }
        private void MouseHoverEvent(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 83, 83);
            btn.ForeColor = Color.White;

        }
        private void MouseLeaveEvent(Button btn)
        {
            btn.BackColor = Color.FromArgb(189, 245, 244);
            btn.ForeColor = Color.Black;
        }

        private void btnShowFull_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnShowFull);
        }

        private void btnLunchSpecials_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnLunchSpecials);
        }

        private void btnLunchSpecials_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnLunchSpecials);
        }

        private void btnLunchMains_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnLunchMains);
        }

        private void btnLunchMains_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnLunchMains);
        }

        private void btnLunchBites_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnLunchBites);
        }

        private void btnLunchBites_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnLunchBites);
        }

        private void btnDinnerStarters_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnDinnerStarters);
        }

        private void btnDinnerStarters_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnDinnerStarters);
        }

        private void btnDinnerMains_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnDinnerMains);
        }

        private void btnDinnerMains_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnDinnerMains);
        }

        private void btnDinnerDesserts_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnDinnerDesserts);
        }

        private void btnDinnerDesserts_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnDinnerDesserts);
        }

        private void btnHotDrinks_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnHotDrinks);
        }

        private void btnHotDrinks_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnHotDrinks);
        }

        private void btnSoftDrinks_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnSoftDrinks);
        }

        private void btnSoftDrinks_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnSoftDrinks);
        }

        private void btnAlcoholics_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnAlcoholics);
        }

        private void btnAlcoholics_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnAlcoholics);
        }

        private void btnSelect_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnSelect);
        }

        private void btnSelect_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnSelect);
        }

        private void btnRemoveOrder_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnRemoveOrder);
        }

        private void btnRemoveOrder_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnRemoveOrder);
        }

        private void btnSendOrder_MouseHover(object sender, EventArgs e)
        {
            MouseHoverEvent(btnSendOrder);
        }

        private void btnSendOrder_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveEvent(btnSendOrder);
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = null;
            btnBack.Text = "X";
            btnBack.BackColor = Color.Red;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            
            Image img = Image.FromFile("../../../resources/left-arrow.png");
            btnBack.Text = "";
            btnBack.BackColor = Color.FromArgb(189, 245, 244);
            btnBack.BackgroundImage = img;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.FlatStyle = FlatStyle.Flat;
        }

        private void lblTable_MouseHover(object sender, EventArgs e)
        {
            lblTable.Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblTable_MouseLeave(object sender, EventArgs e)
        {
            lblTable.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblTotal_MouseHover(object sender, EventArgs e)
        {
            lblTotal.Font = new Font("Microsoft YaHei", 18F , FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTotal.BackColor = Color.FromArgb(189, 245, 244);
        }

        private void lblTotal_MouseLeave(object sender, EventArgs e)
        {
            lblTotal.Font = new Font("Microsoft YaHei", 13F,FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblTotal.BackColor = Color.FromArgb(189, 227, 236);
        }

        private void TakeOrder_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void TakeOrder_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void TakeOrder_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void TakeOrder_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = .50;
        }

        private void btnUpArrow_Click(object sender, EventArgs e)
        {
            numericUpDownQuantity.Value++;
        }

        private void btnDownArrow_Click(object sender, EventArgs e)
        {
            if(numericUpDownQuantity.Value <= 0)
            {
                numericUpDownQuantity.Value = 0;
                return;
            }
            numericUpDownQuantity.Value--;
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(lstvMenu.SelectedItems.Count < 1)
            {
                return;
            }
            MenuItem item = lstvMenu.SelectedItems[0].Tag as MenuItem;

            if(item.Stock < numericUpDownQuantity.Value)
            {
                numericUpDownQuantity.Value = item.Stock;
            }


        }
    }
}
