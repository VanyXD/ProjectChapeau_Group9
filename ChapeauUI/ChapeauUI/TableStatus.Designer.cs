namespace ChapeauUI
{
    partial class TableChanges
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
            this.btnAvailable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnOccupy = new System.Windows.Forms.Button();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailable.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.Location = new System.Drawing.Point(18, 117);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(117, 44);
            this.btnAvailable.TabIndex = 7;
            this.btnAvailable.Text = "Available";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Table Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnTakeOrder);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Controls.Add(this.btnOccupy);
            this.panel1.Controls.Add(this.lblTableNum);
            this.panel1.Controls.Add(this.btnAvailable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 218);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(180, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Current Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(191, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(33, 20);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "____";
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeOrder.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOrder.Location = new System.Drawing.Point(387, 117);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(117, 44);
            this.btnTakeOrder.TabIndex = 25;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(264, 117);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(117, 44);
            this.btnReserve.TabIndex = 24;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnOccupy
            // 
            this.btnOccupy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnOccupy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupy.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupy.Location = new System.Drawing.Point(141, 117);
            this.btnOccupy.Name = "btnOccupy";
            this.btnOccupy.Size = new System.Drawing.Size(117, 44);
            this.btnOccupy.TabIndex = 23;
            this.btnOccupy.Text = "Occupy";
            this.btnOccupy.UseVisualStyleBackColor = false;
            this.btnOccupy.Click += new System.EventHandler(this.btnOccupy_Click);
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(14, 53);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(33, 20);
            this.lblTableNum.TabIndex = 22;
            this.lblTableNum.Text = "____";
            // 
            // TableChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 244);
            this.Controls.Add(this.panel1);
            this.Name = "TableChanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableStatus";
            this.Load += new System.EventHandler(this.TableStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnOccupy;
        private System.Windows.Forms.Button button1;
    }
}