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
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ChapeauUI
{
    public partial class EmployeeUI : Form
    {
        private Employee employee;
        ManagerUI managerUI;
        EmployeeServices employeeServices = new EmployeeServices();
        public EmployeeUI(ManagerUI managerUI, Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.managerUI = managerUI;
            AddEmployeePNL.Hide();
            UpDate();
        }
        public void UpDate()
        {
            List<Employee> employees = employeeServices.GetEmployees();

            employeeList.Items.Clear();

            foreach (Employee employe in employees)
            {
                ListViewItem li = new ListViewItem(employe.Password.ToString());
                li.SubItems.Add(employe.FirstName);
                li.SubItems.Add(employe.LastName);
                li.SubItems.Add(employe.position.ToString());
                li.SubItems.Add(employe.EmployeeID.ToString());

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
                int EmployeeID = int.Parse(items.SubItems[4].Text);
                employeeServices.RemoveEmployee(EmployeeID);
            }
            UpDate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = int.Parse(txtPhoneNumber.Text),
                Password = int.Parse(txtPassword.Text),
                position = (Position)(int.Parse(txtPositionID.Text))
            };
            employeeServices.InsertEmployee(employee);
            UpDate();
            ;
            
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePNL.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeeServices.GetEmployees();
            if (employeeList.SelectedItems.Count > 0)
            {
                ListViewItem item = employeeList.SelectedItems[0];
                int employeeID = int.Parse(item.SubItems[4].Text);
                foreach (Employee employe in employees)
                {
                    if (employeeID == employe.EmployeeID)
                    {
                        employe.FirstName = txtFirstName.Text;
                        employe.LastName = txtLastName.Text;
                        employe.Email = txtEmail.Text;
                        employe.PhoneNumber = int.Parse(txtPhoneNumber.Text);
                        employe.Password = int.Parse(txtPassword.Text);
                        employe.position = (Position)(int.Parse(txtPositionID.Text));
                        employeeServices.EditEmployee(employe);
                    }
                }
                UpDate();
            }
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeeServices.GetEmployees();
            if (employeeList.SelectedItems.Count > 0)
            {
                ListViewItem item = employeeList.SelectedItems[0];
                int employeeID = int.Parse(item.SubItems[4].Text);

                foreach (Employee employe in employees)
                {
                    if (employeeID == employe.EmployeeID)
                    {
                        txtFirstName.Text = employe.FirstName;
                        txtLastName.Text = employe.LastName;
                        txtPositionID.Text = Convert.ToInt32(employe.position).ToString();
                        txtPhoneNumber.Text = employe.PhoneNumber.ToString();
                        txtPassword.Text = employe.Password.ToString();
                        txtEmail.Text = employe.Email;
                    }
                }
            }
                AddEmployeePNL.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            managerUI.Show();
        }
    }
}
