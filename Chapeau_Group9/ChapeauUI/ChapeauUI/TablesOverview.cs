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
        private TablesServices tablesServices;
        private Employee employee;
        private List<Button> buttons;
        public TablesOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            tablesServices = new TablesServices();
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayTables()
        {
            List<Tables> tables = new List<Tables>();                      
            tables = tablesServices.GetALLTables();
            buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };

            for (int i = 0; i < buttons.Count; i++)
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
        private void TablesOverview_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            DisplayTables();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            //TakeOrder takeOrder = new TakeOrder(employee);
            //takeOrder.ShowDialog();
            //TakeOrderBtnClick(int.Parse(this.ActiveControl.Text));
            DisplayTable(1);

        }
        private void TakeOrderBtnClick(int tableNum)
        {
            
            TakeOrder takeOrder = new TakeOrder(employee, tableNum);
            takeOrder.ShowDialog();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            DisplayTable(2);
        }

        private void DisplayTable(int tableNum)
        {
            TakeOrder orderUI = new TakeOrder(employee, tableNum);
            orderUI.Show();


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
    }
}







