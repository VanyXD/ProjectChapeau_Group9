using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenViewItem : Form
    {
        public KitchenViewItem()
        {
            InitializeComponent();
        }

        private void btn_ViewItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
