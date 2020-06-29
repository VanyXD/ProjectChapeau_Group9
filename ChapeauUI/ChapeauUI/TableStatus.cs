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
    public partial class TableChanges : Form
    {
        
        Table table;
        
        public TableChanges(Table table)
        {
            InitializeComponent();
            this.table = table;
        }

        private void TableStatus_Load(object sender, EventArgs e)
        {
            lblTableNum.Text = "#"+table.TableID.ToString();
            lblStatus.Text = table.Status.ToString();

        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // for available
        }

        private void btnOccupy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes; // to occupy
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No; // to reserve
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort; // to take order
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // to cancel
        }
    }
}
