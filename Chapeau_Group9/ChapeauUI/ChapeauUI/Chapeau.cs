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
using ChapeauDAL;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class Chapeau : Form
    {
        private int LoginPassword;
        private List<Employee> employees;
        public Chapeau()
        {
            InitializeComponent();
            EmployeeServices employeeServices = new EmployeeServices();
            employees = employeeServices.GetEmployees();        
            
        }

        private void lblloginbox_TextChanged(object sender, EventArgs e)
        {
            bool status = int.TryParse(lblloginbox.Text, out LoginPassword);
        }
        private void lbllogin_Click(object sender, EventArgs e)
        {
           
            foreach(Employee employee in employees)
            {
                if(employee.Password.ToString() == lblloginbox.Text)
                {
                   switch ((int)employee.position)
                    {
                        case 1:
                            // mangerFORM
                            break;
                        case 2:
                            // Waiter 
                            break;
                        case 3:
                            //Bar
                            break;
                        case 4 :
                            // Kitchen
                            KitchenUI kitchenUI = new KitchenUI();
                            Chapeau chap = new Chapeau();
                            Chapeau.ActiveForm.Hide();
                            chap.Hide();
                            kitchenUI.Show();
                            return;
                    }
                }

            }
            MessageBox.Show("You fucked up!!!!");






        }

        private void Chapeau_Load(object sender, EventArgs e)
        {

        }
    }
}
