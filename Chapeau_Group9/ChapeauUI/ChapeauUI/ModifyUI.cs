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

namespace ChapeauUI
{
    public partial class ModifyUI : Form
    {
        int itemId;
        string itemName;
        int amount;
        public ModifyUI(string name, int id, int stock)
        {
            InitializeComponent();
            itemId = id;
            itemName = name;
            amount = stock;
            lbl_modify_Title.Text = itemName;
            richTxtBox_Modify.Text = amount.ToString();
        }
        public ModifyUI(string name, int stock)
        {
            itemName = name;
            amount = stock;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            richTxtBox_Modify.Text = (Convert.ToInt32(richTxtBox_Modify.Text) + 1).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            richTxtBox_Modify.Text = (Convert.ToInt32(richTxtBox_Modify.Text) - 1).ToString();
        }

        private void btn_Kitchen_Modify_Done_Click(object sender, EventArgs e)
        {
            MenuItemService menuServices = new MenuItemService();
            menuServices.UpdateStock(itemId, int.Parse(richTxtBox_Modify.Text));
            Close();
        }
    }
}
