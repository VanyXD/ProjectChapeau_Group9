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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUI));
            this.ItemList = new System.Windows.Forms.ListView();
            this.ItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Currentuser = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BTNLowStock = new System.Windows.Forms.Button();
            this.BTNAllItems = new System.Windows.Forms.Button();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.name,
            this.Stock});
            this.ItemList.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemList.FullRowSelect = true;
            this.ItemList.GridLines = true;
            this.ItemList.HideSelection = false;
            this.ItemList.Location = new System.Drawing.Point(48, 131);
            this.ItemList.Name = "ItemList";
            this.ItemList.OwnerDraw = true;
            this.ItemList.Size = new System.Drawing.Size(797, 448);
            this.ItemList.TabIndex = 0;
            this.ItemList.UseCompatibleStateImageBehavior = false;
            this.ItemList.View = System.Windows.Forms.View.Details;
            this.ItemList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ItemList_DrawColumnHeader);
            this.ItemList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ItemList_DrawItem);
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            this.ItemID.Width = 218;
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
            // Currentuser
            // 
            this.Currentuser.AutoSize = true;
            this.Currentuser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currentuser.Location = new System.Drawing.Point(12, 9);
            this.Currentuser.Name = "Currentuser";
            this.Currentuser.Size = new System.Drawing.Size(145, 25);
            this.Currentuser.TabIndex = 15;
            this.Currentuser.Text = "Current User : ";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(176, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(42, 25);
            this.lblCurrentUser.TabIndex = 16;
            this.lblCurrentUser.Text = "......";
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModify.Location = new System.Drawing.Point(48, 629);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(155, 50);
            this.BtnModify.TabIndex = 19;
            this.BtnModify.Text = "Modify";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BTNLowStock
            // 
            this.BTNLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BTNLowStock.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLowStock.Location = new System.Drawing.Point(192, 79);
            this.BTNLowStock.Name = "BTNLowStock";
            this.BTNLowStock.Size = new System.Drawing.Size(119, 46);
            this.BTNLowStock.TabIndex = 21;
            this.BTNLowStock.Text = "Low Stock";
            this.BTNLowStock.UseVisualStyleBackColor = false;
            this.BTNLowStock.Click += new System.EventHandler(this.BTNLowStock_Click);
            // 
            // BTNAllItems
            // 
            this.BTNAllItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.BTNAllItems.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAllItems.Location = new System.Drawing.Point(48, 79);
            this.BTNAllItems.Name = "BTNAllItems";
            this.BTNAllItems.Size = new System.Drawing.Size(119, 46);
            this.BTNAllItems.TabIndex = 22;
            this.BTNAllItems.Text = "All Items";
            this.BTNAllItems.UseVisualStyleBackColor = false;
            this.BTNAllItems.Click += new System.EventHandler(this.BTNAllItems_Click);
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.pnlAddItem.Controls.Add(this.btnClose);
            this.pnlAddItem.Controls.Add(this.btnEdit);
            this.pnlAddItem.Controls.Add(this.label3);
            this.pnlAddItem.Controls.Add(this.txtPrice);
            this.pnlAddItem.Controls.Add(this.txtStock);
            this.pnlAddItem.Controls.Add(this.label2);
            this.pnlAddItem.Controls.Add(this.label1);
            this.pnlAddItem.Controls.Add(this.txtName);
            this.pnlAddItem.Controls.Add(this.label7);
            this.pnlAddItem.Controls.Add(this.lblID);
            this.pnlAddItem.Controls.Add(this.label5);
            this.pnlAddItem.Controls.Add(this.cmbCategory);
            this.pnlAddItem.Controls.Add(this.label4);
            this.pnlAddItem.Controls.Add(this.cmbType);
            this.pnlAddItem.Location = new System.Drawing.Point(48, 49);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(868, 569);
            this.pnlAddItem.TabIndex = 24;
            this.pnlAddItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddItem_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(822, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 45);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(373, 503);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(122, 50);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit Item";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(80, 253);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(189, 29);
            this.txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(527, 102);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(189, 29);
            this.txtStock.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(80, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 29);
            this.txtName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Article ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(420, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "___";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(342, 394);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(189, 29);
            this.cmbCategory.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Type";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(527, 253);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(189, 29);
            this.cmbType.TabIndex = 6;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Location = new System.Drawing.Point(239, 629);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(155, 50);
            this.btnEditItem.TabIndex = 26;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(935, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 61);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.Currentuser);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.BTNAllItems);
            this.Controls.Add(this.BTNLowStock);
            this.Name = "StockUI";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockUI_Load_1);
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemList;
        private System.Windows.Forms.Label Currentuser;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BTNLowStock;
        private System.Windows.Forms.Button BTNAllItems;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button button1;
    }
}