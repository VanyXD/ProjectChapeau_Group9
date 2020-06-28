namespace ChapeauUI
{
    partial class EmployeeUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Currentuser = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.employeeList = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddEmployeePNL = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPositionID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddEmployeePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Currentuser
            // 
            this.Currentuser.AutoSize = true;
            this.Currentuser.Location = new System.Drawing.Point(1, 9);
            this.Currentuser.Name = "Currentuser";
            this.Currentuser.Size = new System.Drawing.Size(75, 13);
            this.Currentuser.TabIndex = 14;
            this.Currentuser.Text = "Current User : ";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(82, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(25, 13);
            this.lblCurrentUser.TabIndex = 15;
            this.lblCurrentUser.Text = "......";
            // 
            // employeeList
            // 
            this.employeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.FirstName,
            this.LastName,
            this.Position,
            this.EmployeeID});
            this.employeeList.FullRowSelect = true;
            this.employeeList.GridLines = true;
            this.employeeList.HideSelection = false;
            this.employeeList.Location = new System.Drawing.Point(110, 93);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(762, 432);
            this.employeeList.TabIndex = 16;
            this.employeeList.UseCompatibleStateImageBehavior = false;
            this.employeeList.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "Employee Code";
            this.Code.Width = 108;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 181;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 197;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 139;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "EmployeeID";
            this.EmployeeID.Width = 200;
            // 
            // AddEmployeePNL
            // 
            this.AddEmployeePNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.AddEmployeePNL.Controls.Add(this.Close);
            this.AddEmployeePNL.Controls.Add(this.label5);
            this.AddEmployeePNL.Controls.Add(this.lblID);
            this.AddEmployeePNL.Controls.Add(this.label4);
            this.AddEmployeePNL.Controls.Add(this.label3);
            this.AddEmployeePNL.Controls.Add(this.label2);
            this.AddEmployeePNL.Controls.Add(this.label1);
            this.AddEmployeePNL.Controls.Add(this.Edit);
            this.AddEmployeePNL.Controls.Add(this.Add);
            this.AddEmployeePNL.Controls.Add(this.txtEmail);
            this.AddEmployeePNL.Controls.Add(this.txtPassword);
            this.AddEmployeePNL.Controls.Add(this.txtPhoneNumber);
            this.AddEmployeePNL.Controls.Add(this.txtPositionID);
            this.AddEmployeePNL.Controls.Add(this.txtLastName);
            this.AddEmployeePNL.Controls.Add(this.txtFirstName);
            this.AddEmployeePNL.Controls.Add(this.label6);
            this.AddEmployeePNL.Controls.Add(this.label7);
            this.AddEmployeePNL.Controls.Add(this.label9);
            this.AddEmployeePNL.Controls.Add(this.label11);
            this.AddEmployeePNL.Controls.Add(this.label12);
            this.AddEmployeePNL.Controls.Add(this.label10);
            this.AddEmployeePNL.Location = new System.Drawing.Point(110, 93);
            this.AddEmployeePNL.Name = "AddEmployeePNL";
            this.AddEmployeePNL.Size = new System.Drawing.Size(762, 432);
            this.AddEmployeePNL.TabIndex = 17;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Close.Location = new System.Drawing.Point(735, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(24, 23);
            this.Close.TabIndex = 23;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Employee ID: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(379, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "4 = Cook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "3 = Bartender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "2 = Waitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "1 = Manager";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Edit.Location = new System.Drawing.Point(394, 372);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 38);
            this.Edit.TabIndex = 16;
            this.Edit.Text = "EDIT";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Add.Location = new System.Drawing.Point(277, 372);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 38);
            this.Add.TabIndex = 15;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(539, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(55, 246);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtPositionID
            // 
            this.txtPositionID.Location = new System.Drawing.Point(539, 55);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.Size = new System.Drawing.Size(160, 20);
            this.txtPositionID.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(55, 155);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(55, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(253, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(565, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Position ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Phone Number";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(243, 542);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(131, 37);
            this.btnRemoveEmployee.TabIndex = 18;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(393, 542);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(131, 37);
            this.btnAddEmployee.TabIndex = 19;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.EditEmployee.Location = new System.Drawing.Point(542, 542);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(131, 37);
            this.EditEmployee.TabIndex = 37;
            this.EditEmployee.Text = "Edit Employee";
            this.EditEmployee.UseVisualStyleBackColor = false;
            this.EditEmployee.Click += new System.EventHandler(this.EditEmployee_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BtnHome.Location = new System.Drawing.Point(1012, 32);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 38);
            this.BtnHome.TabIndex = 38;
            this.BtnHome.Text = "HOME";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.Home.Location = new System.Drawing.Point(921, 48);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 39);
            this.Home.TabIndex = 39;
            this.Home.Text = "HOME";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.EditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.Currentuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddEmployeePNL);
            this.Controls.Add(this.employeeList);
            this.Name = "EmployeeUI";
            this.Text = "EmployeeUI";
            this.Load += new System.EventHandler(this.EmployeeUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddEmployeePNL.ResumeLayout(false);
            this.AddEmployeePNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Currentuser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ListView employeeList;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Panel AddEmployeePNL;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPositionID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.ColumnHeader EmployeeID;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Home;
    }
}