namespace ChapeauUI
{
    partial class StockUI
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
            this.ItemList = new System.Windows.Forms.ListView();
            this.Currentuser = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BTNLowStock = new System.Windows.Forms.Button();
            this.BTNAllItems = new System.Windows.Forms.Button();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.name,
            this.Stock});
            this.ItemList.FullRowSelect = true;
            this.ItemList.GridLines = true;
            this.ItemList.HideSelection = false;
            this.ItemList.Location = new System.Drawing.Point(82, 114);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(797, 448);
            this.ItemList.TabIndex = 0;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.View = System.Windows.Forms.View.Details;
            // 
            // Currentuser
            // 
            this.Currentuser.AutoSize = true;
            this.Currentuser.Location = new System.Drawing.Point(12, 9);
            this.Currentuser.Name = "Currentuser";
            this.Currentuser.Size = new System.Drawing.Size(75, 13);
            this.Currentuser.TabIndex = 15;
            this.Currentuser.Text = "Current User : ";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(93, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(25, 13);
            this.lblCurrentUser.TabIndex = 16;
            this.lblCurrentUser.Text = "......";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BtnHome.Location = new System.Drawing.Point(921, 9);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 39);
            this.BtnHome.TabIndex = 17;
            this.BtnHome.Text = "HOME";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BtnModify.Location = new System.Drawing.Point(285, 592);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(142, 42);
            this.BtnModify.TabIndex = 19;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BtnRefresh.Location = new System.Drawing.Point(505, 592);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(142, 42);
            this.BtnRefresh.TabIndex = 20;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BTNLowStock
            // 
            this.BTNLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BTNLowStock.Location = new System.Drawing.Point(82, 62);
            this.BTNLowStock.Name = "BTNLowStock";
            this.BTNLowStock.Size = new System.Drawing.Size(75, 31);
            this.BTNLowStock.TabIndex = 21;
            this.BTNLowStock.Text = "Low Stock";
            this.BTNLowStock.UseVisualStyleBackColor = false;
            this.BTNLowStock.Click += new System.EventHandler(this.BTNLowStock_Click);
            // 
            // BTNAllItems
            // 
            this.BTNAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BTNAllItems.Location = new System.Drawing.Point(181, 62);
            this.BTNAllItems.Name = "BTNAllItems";
            this.BTNAllItems.Size = new System.Drawing.Size(75, 31);
            this.BTNAllItems.TabIndex = 22;
            this.BTNAllItems.Text = "All Items";
            this.BTNAllItems.UseVisualStyleBackColor = false;
            this.BTNAllItems.Click += new System.EventHandler(this.BTNAllItems_Click);
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 194;
            // 
            // name
            // 
            this.name.Text = "Item Name";
            this.name.Width = 297;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 301;
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BTNAllItems);
            this.Controls.Add(this.BTNLowStock);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.Currentuser);
            this.Controls.Add(this.ItemList);
            this.Name = "StockUI";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockUI_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.Label Currentuser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BTNLowStock;
        private System.Windows.Forms.Button BTNAllItems;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Stock;
    }
}