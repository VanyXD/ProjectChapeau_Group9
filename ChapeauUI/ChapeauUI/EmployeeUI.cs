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
        Form LogIn;
        ManagerUI managerUI;
        EmployeeServices employeeServices = new EmployeeServices();
        public EmployeeUI(ManagerUI managerUI, Employee employee, Form LogIn)
        {
            InitializeComponent();
            this.LogIn = LogIn;
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
                li.Tag = employe;
                employeeList.Items.Add(li);
            }
        }

        private void EmployeeUI_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = employee.FirstName;
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (employeeList.SelectedItems.Count < 1)
            {
                return;
            }
            Employee employee = (Employee)employeeList.SelectedItems[0].Tag;

            string message = $"Do you want to remove {employee.FirstName}?";
            string header = "Remove";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                employeeServices.RemoveEmployee(employee);
                MessageBox.Show("Employee is removed!");
                UpDate();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (ValidFields())
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


                string message = $"Do you want to Add {employee.FirstName}?";
                string header = "Add";
                MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    employeeServices.InsertEmployee(employee);
                    MessageBox.Show("Employee is added!");
                    ResetText();
                    AddEmployeePNL.Hide();
                    UpDate();
                } 

            }
            else
            {
                MessageBox.Show("Fill up all the fields!");
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (AddEmployeePNL.Visible)
            {
                AddEmployeePNL.Visible = false;
            }
            else
            {
                AddEmployeePNL.Visible = true;
            }
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Employee employee = FillEmployee();
            string message = $"Do you want to edit {employee.FirstName}?";
            string header = "Edit employee!";
            MessageBoxButtons btns = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, header, btns, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
            if (result == DialogResult.Yes)
            {
                employeeServices.EditEmployee(employee);
                MessageBox.Show("Employee is edited!");
                ResetText();
                AddEmployeePNL.Hide();
                UpDate();
            }
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            if (AddEmployeePNL.Visible)
            {
                AddEmployeePNL.Visible = false;
            }
            else
            {
                AddEmployeePNL.Visible = true;
            }
            if (employeeList.SelectedItems.Count < 1)
            {
                return;
            }
            
            Employee employee = (Employee)employeeList.SelectedItems[0].Tag;
            FillDetails(employee);
   
        }

        private void FillDetails(Employee employee)
        {
            lblID.Text = employee.EmployeeID.ToString();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPositionID.Text = Convert.ToInt32(employee.position).ToString();
            txtPhoneNumber.Text = employee.PhoneNumber.ToString();
            txtPassword.Text = employee.Password.ToString();
            txtEmail.Text = employee.Email;
        }
        private Employee FillEmployee()
        {
            Employee employee = new Employee();
            employee.EmployeeID = Convert.ToInt32(lblID.Text); 
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.position = (Position)Convert.ToInt32(txtPositionID.Text);
            employee.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
            employee.Password = Convert.ToInt32(txtPassword.Text);
            employee.Email = txtEmail.Text;
            return employee;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            managerUI.Show();
        }
        private bool ValidFields()
        {
            if (txtFirstName.Text != null && txtLastName.Text != null && txtPositionID != null && txtPhoneNumber.Text != null && txtPassword != null && txtEmail != null)
            {
                return true;
            }

            return false;
        }
        private void ResetText()
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtPositionID.ResetText();
            txtEmail.ResetText();
            txtPassword.ResetText();
            txtPhoneNumber.ResetText();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            AddEmployeePNL.Visible = false;
        }

        

        private void Home_Click(object sender, EventArgs e)
        {
            
            managerUI.Show();
            this.Close();
        }
    }
}
