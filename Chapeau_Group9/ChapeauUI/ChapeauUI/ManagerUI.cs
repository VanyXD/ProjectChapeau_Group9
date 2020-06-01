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

        private void EmployeePNL_Paint(object sender, PaintEventArgs e)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            List<Employee> employees = employeeServices.GetEmployees();

            employeeList.Items.Clear();

            foreach(Employee employee in employees)
            {
                ListViewItem li = new ListViewItem(employee.FirstName);
                li.SubItems.Add(employee.LastName);
                li.SubItems.Add(employee.position.ToString());
                employeeList.Items.Add(li);
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AddEmployeePNL.Hide();
            EmployeePNL.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePNL.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeID = int.Parse(txtEmployeeID.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = int.Parse(txtPhoneNumber.Text),
                Password = int.Parse(txtPassword.Text),
                position = (Position)Enum.Parse(typeof(Position), txtPositionID.Text)
            };
            employeeServices.InsertEmployee(employee);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeeServices.GetEmployees();

            if (employeeList.Items.Count > 0)
            {
                ListViewItem items = employeeList.SelectedItems[0];
                int EmployeeID = int.Parse(items.SubItems[0].Text);
                employeeServices.RemoveEmployee(EmployeeID);
                
            }

        }
    }
}
