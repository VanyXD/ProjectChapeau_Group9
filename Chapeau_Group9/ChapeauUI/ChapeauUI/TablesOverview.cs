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
        private TablesServices tablesServices = new TablesServices();
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
            foreach (Tables table in tables)
            {
                foreach (Button button in Controls.OfType<Button>())
                {
                    tables = (List<Tables>)button.Tag;
                    switch (table.Status)
                    {
                        case TableStatus.Free:
                            button.BackColor = Color.Green;
                            break;
                        case TableStatus.Occupied:
                            button.BackColor = Color.Red;
                            break;
                        default:
                            button.BackColor = Color.Orange;
                            break;
                    }
                    //if (table.TableNumber == 1 && button == btnTable1)
                    //{
                    //    if (table.Status == TableStatus.Free)
                    //    {
                    //        btnTable1.BackColor = Color.Green;
                    //    }
                    //    else if (table.Status == TableStatus.Occupied)
                    //    {
                    //        btnTable1.BackColor = Color.Red;
                    //    }
                    //    else
                    //        btnTable1.BackColor = Color.Orange;
                    //}
                    //if (table.TableNumber == 2 && button == btnTable1)
                    //{
                    //    if (table.Status == TableStatus.Free)
                    //    {
                    //        btnTable1.BackColor = Color.Green;
                    //    }
                    //    else if (table.Status == TableStatus.Occupied)
                    //    {
                    //        btnTable1.BackColor = Color.Red;
                    //    }
                    //    else
                    //        btnTable1.BackColor = Color.Orange;
                    //}
                }
            }                     
        }
        private void TablesOverview_Load_1(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
            tables = tablesServices.GetALLTables();
            DisplayTables();

        }
    }
}







