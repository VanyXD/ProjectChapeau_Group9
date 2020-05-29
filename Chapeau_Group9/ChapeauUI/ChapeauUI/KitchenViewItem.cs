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

namespace ChapeauUI
{
    public partial class KitchenViewItem : Form
    {
        public KitchenViewItem(Order order)
        {
            InitializeComponent();
        }

        private void btn_ViewItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void PrintItem(Order order)
        {
            var row = new string[] { order.Quantity.ToString(), order.Items.ToString() };
            var lvi = new ListViewItem(row);
            lv_ViewTable.Items.Add(lvi);
        }
    }
}
