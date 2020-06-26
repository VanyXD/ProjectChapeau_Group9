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
using System.Data.SqlClient;
using ChapeauLogic;


namespace ChapeauUI
{
    public partial class TablesOverview : Form
    {
        Form Login;
        private TablesService tablesServices;
        private Employee employee;
        

        
        
        public TablesOverview(Form login, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.Login = login;

            tablesServices = new TablesService();
            
            


        }
        private void TablesOverview_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            List<Button> buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };
            List<Label> labels = new List<Label> { lbltable1time, lbltable2time, lbltable3time, lbltable4time, lbltable5time, lbltable6time, lbltable7time, lbltable8time, lbltable9time, lbltable10time };
            
            DisplayTables(buttons);
            DisplayTablesTimeAndOrder(labels);
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }

        private void DisplayTables(List<Button> buttons)
        {
            List<Table> tables = tablesServices.GetALLTables();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (tables[i].Status == TableStatus.Free)
                {
                    buttons[i].BackColor = Color.Green;
                }
                else if (tables[i].Status == TableStatus.Occupied)
                {
                    buttons[i].BackColor = Color.Red;
                }
                else
                    buttons[i].BackColor = Color.Orange;
            }

        }
        private void DisplayTablesTimeAndOrder(List<Label> labels)
        {
            
            List<Order> orders = tablesServices.GetAllRunningOrders(); 
            
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderStatus == OrderStatus.Pending && ((DateTime.Now.Minute - orders[i].Time.Minute) > 15) )
                {
                    labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(192, 0, 192);
                    labels[orders[i].Table.TableID - 1].Text = "delayed";
                }
                else if (orders[i].OrderStatus == OrderStatus.Served)
                {

                    labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(224, 224, 224);
                    labels[orders[i].Table.TableID - 1].Text = "Served";
                }
                else if (orders[i].OrderStatus == OrderStatus.Ready)
                {
                    labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(128, 128, 255);
                    labels[orders[i].Table.TableID - 1].Text = "Ready";
                }
            }
        }
        

        private void btnTable1_Click(object sender, EventArgs e)
        {
            DisplayTable(1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            DisplayTable(2);
        }

        private void DisplayTable(int tableNum)
        {
            TakeOrder orderUI = new TakeOrder(this, employee, tableNum);
            orderUI.Show();
            this.Hide();
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            DisplayTable(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            DisplayTable(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            DisplayTable(5);

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            DisplayTable(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            DisplayTable(7);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            DisplayTable(8);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            DisplayTable(9);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            DisplayTable(10);
        }    
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            TablesOverview_Load(sender, e);
        }
    }
}







