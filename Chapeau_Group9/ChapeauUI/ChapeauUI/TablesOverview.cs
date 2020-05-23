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
        public TablesOverview()
        {
            InitializeComponent();
            EmployeeServices employeeServices = new EmployeeServices();
            employees = employeeServices.GetEmployees();
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
    }
}





