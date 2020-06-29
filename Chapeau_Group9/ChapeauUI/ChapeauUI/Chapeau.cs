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
using System.Security.Cryptography;

namespace ChapeauUI
{
    public partial class Chapeau : Form
    {
        
        
        
        EmployeeServices employeeServices = new EmployeeServices();
        public Chapeau()
        {
            InitializeComponent();
            
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            bool correctPass = int.TryParse(logintextbox.Text, out int LoginPassword);
      

            if (correctPass)
            {
                Employee user = employeeServices.GetEmployee(LoginPassword,userName);
                if(user != null)
                {
                    if (user.position == Position.Manager)
                    {
                        ManagerUI managerUI = new ManagerUI(this, user);

                        Hide();
                        managerUI.Show();
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
                }
                else
                {
                    MessageBox.Show("Wrong Password!!");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter the password in the correct format.");
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to contact your manager to reset your password.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
