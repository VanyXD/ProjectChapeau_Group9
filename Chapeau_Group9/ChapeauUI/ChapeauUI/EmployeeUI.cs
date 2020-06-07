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
    public partial class EmployeeUI : Form
    {
        private Employee employee;
        EmployeeServices employeeServices = new EmployeeServices();
        public EmployeeUI( Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            AddEmployeePNL.Hide();

            List<Employee> employees = employeeServices.GetEmployees();

            employeeList.Items.Clear();

            foreach (Employee employe in employees)
            {
                ListViewItem li = new ListViewItem(employe.Password.ToString());
                li.SubItems.Add(employe.FirstName);
                li.SubItems.Add(employe.LastName);
                li.SubItems.Add(employe.position.ToString());
                employeeList.Items.Add(li);
            }
        }

        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (employeeList.Items.Count > 0)
            {
                ListViewItem items = employeeList.SelectedItems[0];
                int EmployeeCode = int.Parse(items.SubItems[0].Text);
                employeeServices.RemoveEmployee(EmployeeCode);
            }
            employeeList.Refresh();
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
                position = (Position)int.Parse(txtPositionID.Text)
                //position = (Position)Enum.Parse(typeof(Position), txtPositionID.Text)
            };
            employeeServices.InsertEmployee(employee);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePNL.Show();
        }
    }
}
