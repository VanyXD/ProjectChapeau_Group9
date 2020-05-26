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
        private List<Tables> tables;
        TablesServices tablesServices = new TablesServices();
        private Employee employee;

        public TablesOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Hide();
            // close().
            // get off the hiden from 
            new Chapeau().ShowDialog();
        }
        private void DisplayTables()
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                tables = (List<Tables>)button.Tag;
                if(tables.Status == TableStatus.Free)
                {
                    button.BackColor = Color.Green;
                }
                else if(tables.Status == TableStatus.Occupied)
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.Orange;
                }
            }
                //foreach (Tables table in tables)
                //{

                //    if (table.TableNumber == 1)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable1.BackColor = Color.Green;
                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable1.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable1.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 2)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable2.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable2.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable2.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 3)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable3.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable3.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable3.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 4)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable4.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable4.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable4.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 5)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable5.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable5.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable5.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 6)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable6.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable6.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable6.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 7)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable7.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable7.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable7.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 8)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable8.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable8.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable8.BackColor = Color.Orange;
                //    }
                //    else if (table.TableNumber == 9)
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable9.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable9.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable9.BackColor = Color.Orange;
                //    }
                //    else
                //    {
                //        if (table.Status == TableStatus.Free)
                //        {
                //            btnTable10.BackColor = Color.Green;

                //        }
                //        else if (table.Status == TableStatus.Occupied)
                //        {
                //            btnTable10.BackColor = Color.Red;
                //        }
                //        else
                //            btnTable10.BackColor = Color.Orange;
                //    }
                //}

        }
        private void TablesOverview_Load_1(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            tables = tablesServices.GetALLTables();
            DisplayTables();

        }
    }
}







