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
    public partial class ModifyUI : Form
    {
        public ModifyUI()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            lbl_modify_Nr.Text = (Convert.ToInt32(lbl_modify_Nr.Text) + 1).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            lbl_modify_Nr.Text = (Convert.ToInt32(lbl_modify_Nr.Text) - 1).ToString();
        }
    }
}
