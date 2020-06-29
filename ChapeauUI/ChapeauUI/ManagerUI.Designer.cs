﻿namespace ChapeauUI
{
    partial class ManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTablesOverview = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.BTNHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.btnTablesOverview);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(247, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 479);
            this.panel1.TabIndex = 0;
            // 
            // btnTablesOverview
            // 
            this.btnTablesOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnTablesOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablesOverview.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablesOverview.Location = new System.Drawing.Point(141, 302);
            this.btnTablesOverview.Name = "btnTablesOverview";
            this.btnTablesOverview.Size = new System.Drawing.Size(208, 78);
            this.btnTablesOverview.TabIndex = 36;
            this.btnTablesOverview.Text = "Tables Overview";
            this.btnTablesOverview.UseVisualStyleBackColor = false;
            this.btnTablesOverview.Click += new System.EventHandler(this.btnTablesOverview_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(141, 98);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(208, 78);
            this.btnStock.TabIndex = 35;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Location = new System.Drawing.Point(141, 200);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(208, 78);
            this.btnEmployees.TabIndex = 34;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Current user:";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(12, 58);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(57, 28);
            this.lblCurrentUser.TabIndex = 33;
            this.lblCurrentUser.Text = "-----";
            // 
            // BTNHome
            // 
            this.BTNHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.BTNHome.Location = new System.Drawing.Point(1016, 18);
            this.BTNHome.Name = "BTNHome";
            this.BTNHome.Size = new System.Drawing.Size(75, 41);
            this.BTNHome.TabIndex = 38;
            this.BTNHome.Text = "HOME";
            this.BTNHome.UseVisualStyleBackColor = false;
            this.BTNHome.Click += new System.EventHandler(this.BTNHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNHome);
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerUI";
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button BTNHome;
        private System.Windows.Forms.Button btnTablesOverview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}