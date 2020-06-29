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
        Chapeau logIn = new Chapeau();
        private TablesService tablesServices;
        private Employee employee;
 
        public TablesOverview( Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            tablesServices = new TablesService();
        }
        private void TablesOverview_Load(object sender, EventArgs e)
        {
            if (employee.position != Position.Manager)
            {
                btnManagerUI.Visible = false;
            }
            lblCurrentUser.Text = employee.FirstName;
            List<Label> labels = new List<Label> { lbltable1time, lbltable2time, lbltable3time, lbltable4time, lbltable5time, lbltable6time, lbltable7time, lbltable8time, lbltable9time, lbltable10time };           
            DisplayTables();
            DisplayTablesTimeAndOrder(labels);
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            logIn.Show();
        }

        private void DisplayTables()
        {
            List<Button> buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };
            List<Table> tables = tablesServices.GetALLTables();
            if(tables != null)
            {
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
            else
            {
                MessageBox.Show("database connection failed"); 
            }
        }
        private void DisplayTablesTimeAndOrder(List<Label> labels)
        {
            
            List<Order> orders = tablesServices.GetAllRunningOrders(); 
            if(orders != null)
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].OrderStatus == OrderStatus.Pending && ((DateTime.Now.Minute - orders[i].Time.Minute) > 15))
                    {
                        labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(192, 0, 192);
                        labels[orders[i].Table.TableID - 1].Text = "Pending";
                    }
                    else if (orders[i].OrderStatus == OrderStatus.Served)
                    {
                        labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(64, 64, 64);
                        labels[orders[i].Table.TableID - 1].Text = "Served";
                    }
                    else if (orders[i].OrderStatus == OrderStatus.Ready)
                    {
                        labels[orders[i].Table.TableID - 1].BackColor = Color.FromArgb(128, 128, 255);
                        labels[orders[i].Table.TableID - 1].Text = "Ready";
                    }
                }
            }        
             else
            {
                MessageBox.Show("database connection failed"); 
            }
        }
        

        private void btnTable1_Click(object sender, EventArgs e)
        {
            TableClicked(1);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            TableClicked(2);
        }

        private void TableClicked(int tableNum) 
        {

            Table table = tablesServices.GetTableForID(tableNum); // getting the status and the table ID for the order
            if (table != null)
            {
                Table_Options Table_Options = new Table_Options(table);
                DialogResult result = Table_Options.ShowDialog();
                if (result == DialogResult.Abort) // to take order
                {
                    TakeOrder orderUI = new TakeOrder(this, employee, table);
                    orderUI.Show();
                    this.Hide();
                }
                else
                {
                    if (result == DialogResult.Yes) // to occupy
                    {
                        table.Status = TableStatus.Occupied;

                    }
                    else if (result == DialogResult.No) // to reserve
                    {
                        table.Status = TableStatus.Reserved;

                    }
                    else if (result == DialogResult.OK) // make available
                    {
                        table.Status = TableStatus.Free;

                    }
                    tablesServices.Updatetable(table);
                    DisplayTables();

                }
            }
            else
            {
                MessageBox.Show("Database connection failed");
            }
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            TableClicked(3);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            TableClicked(4);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            TableClicked(5);

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            TableClicked(6);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            TableClicked(7);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            TableClicked(8);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            TableClicked(9);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            TableClicked(10);
        }    
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            TablesOverview_Load(sender, e);
        }

        private void btnManagerUI_Click(object sender, EventArgs e)
        {
            ManagerUI managerUI = new ManagerUI(logIn, employee);
            managerUI.Show();
            this.Close();
        }
    }
}







