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
        private List<Button> buttons;
<<<<<<< HEAD
        private List<Table> tables;
        private List<Label> labels;
        private List<Order> orders;
        private Order order;
=======
        private List<Tables> tables; // move this to display tables 
        private List<Label> labels; 
        private List<Order> orders; // make it a local varables 
>>>>>>> 896274f4722729128e42cbb1be95b0520917385a

        public TablesOverview(Form login ,Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.Login = login;
<<<<<<< HEAD
            tablesServices = new TablesService();
            tables = new List<Table>();
            orders = new List<Order>();
            order = new Order();


=======
            tablesServices = new TablesServices();
        //    tables = new List<Tables>();
       //     orders = new List<Order>();
>>>>>>> 896274f4722729128e42cbb1be95b0520917385a
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }
     
        private void DisplayTables()
        {
            tables = tablesServices.GetALLTables();

            for (int i = 0; i < buttons.Count  ; i++)
            {
                if(tables[i].Status == TableStatus.Free)
                {
                    buttons[i].BackColor = Color.Green;
                }
                else if(tables[i].Status == TableStatus.Occupied)
                {
                    buttons[i].BackColor = Color.Red;
                }
                else
                    buttons[i].BackColor = Color.Orange;
            }

        }
        private void DisplayTablesTimeAndOrder()
        {
            orders = tablesServices.GetAllOrders(); // name it get all running orders

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderStatus == OrderStatus.Pending)
                {
                    labels[orders[i].Table.TableID - 1].Text = $" Order is pending {orders[i].Time}";
                }
                else if (orders[i].OrderStatus == OrderStatus.Served)
                {
                    labels[orders[i].Table.TableID - 1].Text = $"Order is served !!";
                }
                else if (orders[i].OrderStatus == OrderStatus.Ready)
                {
                    labels[orders[i].Table.TableID - 1].Text = $"Order is Ready !!";
                }
                else
                {
                    labels[orders[i].Table.TableID - 1].Text = $"There is no order{0.00}";
                }
            }
        }
        private void TablesOverview_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };
            labels = new List<Label> { lbltable1time, lbltable2time, lbltable3time, lbltable4time, lbltable5time, lbltable6time, lbltable7time, lbltable8time, lbltable9time, lbltable10time };
            DisplayTables();
            DisplayTablesTimeAndOrder();
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
            TakeOrder orderUI = new TakeOrder(this,employee, tableNum); 
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {        
            DisplayTables();
            DisplayTablesTimeAndOrder();
        }
    }
}







