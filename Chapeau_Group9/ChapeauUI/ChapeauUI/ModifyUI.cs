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
        ChapeauModel.MenuItem item;
        public ModifyUI(ChapeauModel.MenuItem item)
        {
            InitializeComponent();
            this.item = item;
            lbl_modify_Title.Text = item.Name;
            richTxtBox_Modify.Text = item.Stock.ToString(); ;
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
            menuServices.UpdateStock(item.MenuItemID, int.Parse(richTxtBox_Modify.Text));
            this.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
