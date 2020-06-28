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
        Form previousForm;
        
        MenuItemService Itemservices = new MenuItemService();
        
        public StockUI(Form managerUi, Employee employee)
        {
            InitializeComponent();
            
            this.previousForm = managerUi;
            this.employee = employee;
            
        }
        private void StockUI_Load_1(object sender, EventArgs e)
        {
            pnlAddItem.Visible = false;
            lblCurrentUser.Text = employee.FirstName;
            List<ChapeauModel.MenuItem> menuItems = Itemservices.GetMenuItems();
            LoadMenuItems(menuItems);
        }
        public void LoadMenuItems(List<ChapeauModel.MenuItem> menuItems)
        {
            ItemList.Items.Clear();
            if(menuItems != null)
            {
                foreach (ChapeauModel.MenuItem item in menuItems)
                {
                    ListViewItem li = new ListViewItem(item.MenuItemID.ToString());
                    li.SubItems.Add(item.Name);
                    li.SubItems.Add(item.Stock.ToString());
                    li.Tag = item;
                    ItemList.Items.Add(li);
                }
            }
            else
            {
                MessageBox.Show("elis is noob");
            }
            
        }
        

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItems.Count < 1)
            {
                return;
            }
            int itemId = int.Parse(ItemList.SelectedItems[0].SubItems[0].Text);
            string itemName = ItemList.SelectedItems[0].SubItems[1].Text;
            int stock = int.Parse(ItemList.SelectedItems[0].SubItems[2].Text);
            ModifyUI modUI = new ModifyUI(itemName, itemId, stock);
            modUI.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ItemList.Items.Clear();
            BTNAllItems_Click(sender, e);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void BTNLowStock_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> menuItems = Itemservices.GetMenuItems();
            ItemList.Items.Clear();

            foreach (ChapeauModel.MenuItem item in menuItems)
            {
                if (item.Stock < 15)
                {
                    ListViewItem li = new ListViewItem(item.MenuItemID.ToString()); ;
                    li.SubItems.Add(item.Name);
                    li.SubItems.Add(item.Stock.ToString());
                    li.Tag = item; // yay tag
                    ItemList.Items.Add(li);
                }
            }
        }

        private void BTNAllItems_Click(object sender, EventArgs e)
        {
            List<ChapeauModel.MenuItem> menuItems = Itemservices.GetMenuItems();
            LoadMenuItems(menuItems);
        }
        

        private void ItemList_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Cyan, e.Bounds);
            e.DrawText();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if(ItemList.SelectedItems.Count < 1)
            {
                return;
            }
            
            if (pnlAddItem.Visible)
            {
                pnlAddItem.Visible = false;
            }
            else
            {
                pnlAddItem.Visible = true;
                ChapeauModel.MenuItem item = (ChapeauModel.MenuItem)ItemList.SelectedItems[0].Tag;
                
                FillItemDetails(item);
            }

        }
        private void FillItemDetails(ChapeauModel.MenuItem menuItem)
        {
            cmbCategory.DataSource = Enum.GetValues(typeof(Category));
            cmbType.DataSource = Enum.GetValues(typeof(MenuItemType));
            txtName.Text = menuItem.Name;
            txtPrice.Text = menuItem.Price.ToString();
            txtStock.Text = menuItem.Stock.ToString();
            cmbCategory.SelectedItem = menuItem.Category;
            cmbType.SelectedItem = menuItem.Type;
            lblID.Text = menuItem.MenuItemID.ToString();


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlAddItem.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidFields())
            {
                ChapeauModel.MenuItem item = ReadItem();
                string message = $"Do you want to edit {item.Name}?";
                string header = "Edit Item";
                MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    Itemservices.EditMenuItem(item);
                    MessageBox.Show("Item is edited!");
                    BTNAllItems_Click(sender, e);
                }
                

            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }



        }
        private ChapeauModel.MenuItem ReadItem()
        {

            ChapeauModel.MenuItem item = new ChapeauModel.MenuItem();
            item.MenuItemID = Convert.ToInt32(lblID.Text);
            item.Name = txtName.Text;
            item.Price = Convert.ToDecimal(txtPrice.Text);
            item.Stock = Convert.ToInt32(txtStock.Text);
            item.Category = (Category)cmbCategory.SelectedItem;
            item.Type = (MenuItemType)cmbType.SelectedItem;
            return item;
        
        }
        private bool ValidFields()
        {
            if(txtStock.Text == null || txtPrice.Text == null || txtName.Text == null)
            {
                return false;
            }
            return true;
        }

        private void ItemList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
