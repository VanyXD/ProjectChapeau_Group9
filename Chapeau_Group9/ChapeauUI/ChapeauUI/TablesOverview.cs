﻿using System;
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
        private TablesServices tablesServices;
        private Employee employee;
        private List<Button> buttons;
        private List<Tables> tables;
        private List<Label> labels;
        private List<Order> orders;
        private Order order;
        private Timer timer;

        public TablesOverview(Form login ,Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.Login = login;
            tablesServices = new TablesServices();
            tables = new List<Tables>();
            orders = new List<Order>();
            order = new Order();
            timer = new Timer();


        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }

        private void DisplayTables()
        {                    
            tables = tablesServices.GetALLTables();
            orders = tablesServices.GetAllOrders();
            //orders = tablesServices.GetAllOrderTime();
           

            buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };
            labels = new List<Label> { lbltable1time, lbltable2time, lbltable3time , lbltable4time , lbltable5time , lbltable6time , lbltable7time , lbltable8time , lbltable9time, lbltable10time };

            for (int i = 0; i < buttons.Count; i++)
            {
                if(tables[i].Status == TableStatus.Free || orders[i].OrderStatus == OrderStatus.Closed)
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
            this.Hide();

        }
        private void TakeOrderBtnClick(int tableNum)
        {
            TakeOrder takeOrder = new TakeOrder(this,employee, tableNum);
            takeOrder.ShowDialog();
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            DisplayTable(2);
            this.Hide();

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
            this.Hide();

        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            DisplayTable(4);
            this.Hide();
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            DisplayTable(5);
            this.Hide();
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            DisplayTable(6);
            this.Hide();
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            DisplayTable(7);
            this.Hide();
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            DisplayTable(8);
            this.Hide();
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            DisplayTable(9);
            this.Hide();
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            DisplayTable(10);
            this.Hide();
        }
    }
}







