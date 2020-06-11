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
using ChapeauDAL;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class Chapeau : Form
    {
        Employee user;
        private int LoginPassword;
        private List<Employee> employees;
        EmployeeServices employeeServices = new EmployeeServices();
        public Chapeau()
        {
            InitializeComponent();
            employees = new List<Employee>();
            user = new Employee();
        }

        private void lblloginbox_TextChanged(object sender, EventArgs e)
        {
            bool status = int.TryParse(logintextbox.Text, out LoginPassword);
        }
        private void lbllogin_Click(object sender, EventArgs e)
        {
            employees = employeeServices.GetEmployees();

            foreach (Employee emp in employees)
            {
                if (emp.Password == LoginPassword)
                {
                    user = emp;
                    break;
                }

            }
                if (user.position == Position.Manager)
                {
                    ManagerUI ManagerUI = new ManagerUI(this, user);
                    Hide();
                    ManagerUI.Show();
                }
                else if (user.position == Position.waiter)
                {

                    TablesOverview WaiterOverview = new TablesOverview(this, user);
                    Hide();
                    WaiterOverview.Show();
                }
                else if (user.position == Position.cook)
                {
                    KitchenBarUI kitchenUI = new KitchenBarUI(this, user);
                    Hide();
                    kitchenUI.Show();
                }
                else if (user.position == Position.Bartender)
                {
                    KitchenBarUI barUI = new KitchenBarUI(this, user);
                    Hide();
                    barUI.Show();
                }
                else
                   MessageBox.Show("User Does not Exist");
            

        }
    }
}
