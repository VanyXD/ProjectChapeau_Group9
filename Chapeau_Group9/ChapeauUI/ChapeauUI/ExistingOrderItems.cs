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
    public partial class ExistingOrderItems : Form
    {
        List<OrderItem> items;
        public ExistingOrderItems(List<OrderItem> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ExistingOrderItems_Load(object sender, EventArgs e)
        {
            DisplayItems(items);
        }
        private void DisplayItems(List<OrderItem> items)
        {
            lstvItems.Items.Clear();
            foreach(OrderItem orditm in items)
            {
                ListViewItem item = new ListViewItem(orditm.MenuItem.Name);
                item.SubItems.Add(orditm.Quantity.ToString());
                item.Tag = orditm;
                lstvItems.Items.Add(item);
            }
        }
    }
}
