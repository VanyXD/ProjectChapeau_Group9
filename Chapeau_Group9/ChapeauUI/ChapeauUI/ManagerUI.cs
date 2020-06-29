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
using System.Runtime.InteropServices.ComTypes;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class ManagerUI : Form
    {
        Form logIn;
        private Employee employee;
        public ManagerUI(Form LogIn, Employee employee)
        {
            this.logIn = LogIn;
            InitializeComponent();
            this.employee = employee;
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;

        }

       
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeUI employeeui = new EmployeeUI(this, employee);
            this.Hide();
            employeeui.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockUI stockUi = new StockUI(this, employee);
            this.Hide();
            stockUi.Show();
        }

        private void btnTablesOverview_Click(object sender, EventArgs e)
        {
            TablesOverview tablesOverview = new TablesOverview(logIn, employee);
            tablesOverview.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            logIn.Show();
        }

    }
}
