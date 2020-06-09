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
        private Employee employee;
        EmployeeServices employeeServices = new EmployeeServices();
        public ManagerUI(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        public void TableStatus()
        {
            TablesServices tableServices = new TablesServices();
            List<Tables> tables = tableServices.GetALLTables();
            List<Button> buttons = new List<Button> { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };

            for (int i = 0; i < buttons.Count; i++)
            {
                if (tables[i].Status == ChapeauModel.TableStatus.Reserved)
                {
                    buttons[i].BackColor = Color.Orange;
                }
                else if (tables[i].Status == ChapeauModel.TableStatus.Occupied)
                {
                    buttons[i].BackColor = Color.Red;
                }
                else
                {
                    buttons[i].BackColor = Color.Green;
                }
            }
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {
            TableStatus();
            lblCurrentUser.Text = employee.FirstName;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeUI employeeui = new EmployeeUI(employee);
            this.Close();
            employeeui.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockUI stockUi = new StockUI(employee);
            this.Close();
            stockUi.Show();
        }
    }
}
