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
        private List<Employee> employees;
        private List<Tables> tables;
        public TablesOverview()
        {
            InitializeComponent();
            EmployeeServices employeeServices = new EmployeeServices();
            employees = employeeServices.GetEmployees();

            TablesServices tablesServices = new TablesServices();
            tables = tablesServices.GetALLTables();

            foreach (Tables table in tables)
            {
                if(table.TableNumber == 1)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table1btn.BackColor = Color.Green;
                   
                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table1btn.BackColor = Color.Red;
                    }
                    else
                        Table1btn.BackColor = Color.Orange;

                }
                else if(table.TableNumber == 2)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table2btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table2btn.BackColor = Color.Red;
                    }
                    else
                        Table2btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 3)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table3btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table3btn.BackColor = Color.Red;
                    }
                    else
                        Table3btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 4)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table4btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table4btn.BackColor = Color.Red;
                    }
                    else
                        Table4btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 5)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table5btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table5btn.BackColor = Color.Red;
                    }
                    else
                        Table5btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 6)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table6btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table6btn.BackColor = Color.Red;
                    }
                    else
                        Table6btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 7)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table7btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table7btn.BackColor = Color.Red;
                    }
                    else
                        Table7btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 8)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table8btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table8btn.BackColor = Color.Red;
                    }
                    else
                        Table8btn.BackColor = Color.Orange;
                }
                else if (table.TableNumber == 9)
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table9btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table9btn.BackColor = Color.Red;
                    }
                    else
                        Table9btn.BackColor = Color.Orange;
                }
                else 
                {
                    if (table.Status == TableStatus.Free)
                    {
                        Table10btn.BackColor = Color.Green;

                    }
                    else if (table.Status == TableStatus.Occupied)
                    {
                        Table10btn.BackColor = Color.Red;
                    }
                    else
                        Table10btn.BackColor = Color.Orange;
                }
            }

        }
        private void lbllogoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Chapeau().ShowDialog();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {

        }
        private void btnUnpay_Click(object sender, EventArgs e)
        {

        }

        private void Table1btn_Click(object sender, EventArgs e)
        {

        }


        private void Table2btn_Click(object sender, EventArgs e)
        {

        }

        private void Table3btn_Click(object sender, EventArgs e)
        {

        }

        private void Table4btn_Click(object sender, EventArgs e)
        {

        }

        private void Table5btn_Click(object sender, EventArgs e)
        {

        }

        private void Table6btn_Click(object sender, EventArgs e)
        {

        }

        private void Table7btn_Click(object sender, EventArgs e)
        {

        }

        private void Table8btn_Click(object sender, EventArgs e)
        {

        }

        private void Table9btn_Click(object sender, EventArgs e)
        {

        }

        private void Table10btn_Click(object sender, EventArgs e)
        {

        }
    }
}





