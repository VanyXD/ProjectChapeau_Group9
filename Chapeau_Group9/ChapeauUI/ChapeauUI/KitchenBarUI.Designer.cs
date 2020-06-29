namespace ChapeauUI
{
    partial class KitchenBarUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarUI));
            this.tabs_Kitchen = new System.Windows.Forms.TabControl();
            this.tab_Kitchen_Orders = new System.Windows.Forms.TabPage();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.btn_Item_Ready = new System.Windows.Forms.Button();
            this.txtbox_comments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_ViewOrders = new System.Windows.Forms.ListView();
            this.col_table = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Kitchen_Stock = new System.Windows.Forms.TabPage();
            this.cmb_Bar_Category = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Kitchen_Modify = new System.Windows.Forms.Button();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Kitchen_Catergory = new System.Windows.Forms.Label();
            this.lbl_Kitche_Menu = new System.Windows.Forms.Label();
            this.cbox_Kitchen_Category = new System.Windows.Forms.ComboBox();
            this.cbox_Kitchen_Menu = new System.Windows.Forms.ComboBox();
            this.lv_stock = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_current_user = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabs_Kitchen.SuspendLayout();
            this.tab_Kitchen_Orders.SuspendLayout();
            this.tab_Kitchen_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs_Kitchen
            // 
            this.tabs_Kitchen.Controls.Add(this.tab_Kitchen_Orders);
            this.tabs_Kitchen.Controls.Add(this.tab_Kitchen_Stock);
            this.tabs_Kitchen.Location = new System.Drawing.Point(48, 93);
            this.tabs_Kitchen.Name = "tabs_Kitchen";
            this.tabs_Kitchen.SelectedIndex = 0;
            this.tabs_Kitchen.Size = new System.Drawing.Size(921, 596);
            this.tabs_Kitchen.TabIndex = 0;
            // 
            // tab_Kitchen_Orders
            // 
            this.tab_Kitchen_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.tab_Kitchen_Orders.Controls.Add(this.lbl_OrderView);
            this.tab_Kitchen_Orders.Controls.Add(this.btn_Item_Ready);
            this.tab_Kitchen_Orders.Controls.Add(this.txtbox_comments);
            this.tab_Kitchen_Orders.Controls.Add(this.label1);
            this.tab_Kitchen_Orders.Controls.Add(this.lv_ViewOrders);
            this.tab_Kitchen_Orders.Location = new System.Drawing.Point(4, 25);
            this.tab_Kitchen_Orders.Name = "tab_Kitchen_Orders";
            this.tab_Kitchen_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Kitchen_Orders.Size = new System.Drawing.Size(913, 567);
            this.tab_Kitchen_Orders.TabIndex = 0;
            this.tab_Kitchen_Orders.Text = "Orders";
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderView.Location = new System.Drawing.Point(9, 12);
            this.lbl_OrderView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(169, 33);
            this.lbl_OrderView.TabIndex = 32;
            this.lbl_OrderView.Text = "Order View ";
            // 
            // btn_Item_Ready
            // 
            this.btn_Item_Ready.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btn_Item_Ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Item_Ready.Location = new System.Drawing.Point(645, 394);
            this.btn_Item_Ready.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Item_Ready.Name = "btn_Item_Ready";
            this.btn_Item_Ready.Size = new System.Drawing.Size(239, 106);
            this.btn_Item_Ready.TabIndex = 11;
            this.btn_Item_Ready.Text = "Ready";
            this.btn_Item_Ready.UseVisualStyleBackColor = false;
            this.btn_Item_Ready.Click += new System.EventHandler(this.btn_Item_Ready_Click);
            // 
            // txtbox_comments
            // 
            this.txtbox_comments.Location = new System.Drawing.Point(645, 91);
            this.txtbox_comments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_comments.Name = "txtbox_comments";
            this.txtbox_comments.ReadOnly = true;
            this.txtbox_comments.Size = new System.Drawing.Size(239, 106);
            this.txtbox_comments.TabIndex = 10;
            this.txtbox_comments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comments:";
            // 
            // lv_ViewOrders
            // 
            this.lv_ViewOrders.BackColor = System.Drawing.Color.White;
            this.lv_ViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_table,
            this.col_name,
            this.col_quant,
            this.col_time,
            this.col_comment});
            this.lv_ViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ViewOrders.FullRowSelect = true;
            this.lv_ViewOrders.HideSelection = false;
            this.lv_ViewOrders.Location = new System.Drawing.Point(15, 56);
            this.lv_ViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_ViewOrders.Name = "lv_ViewOrders";
            this.lv_ViewOrders.Size = new System.Drawing.Size(578, 462);
            this.lv_ViewOrders.TabIndex = 8;
            this.lv_ViewOrders.UseCompatibleStateImageBehavior = false;
            this.lv_ViewOrders.View = System.Windows.Forms.View.Details;
            this.lv_ViewOrders.Click += new System.EventHandler(this.lv_ViewOrders_Item_Click);
            // 
            // col_table
            // 
            this.col_table.Text = "Table";
            this.col_table.Width = 58;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 146;
            // 
            // col_quant
            // 
            this.col_quant.Text = "Quantity";
            this.col_quant.Width = 79;
            // 
            // col_time
            // 
            this.col_time.Text = "Time";
            this.col_time.Width = 72;
            // 
            // col_comment
            // 
            this.col_comment.Text = "Comment";
            this.col_comment.Width = 129;
            // 
            // tab_Kitchen_Stock
            // 
            this.tab_Kitchen_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.tab_Kitchen_Stock.Controls.Add(this.cmb_Bar_Category);
            this.tab_Kitchen_Stock.Controls.Add(this.btn_Refresh);
            this.tab_Kitchen_Stock.Controls.Add(this.btn_Kitchen_Modify);
            this.tab_Kitchen_Stock.Controls.Add(this.lbl_Stock);
            this.tab_Kitchen_Stock.Controls.Add(this.lbl_Kitchen_Catergory);
            this.tab_Kitchen_Stock.Controls.Add(this.lbl_Kitche_Menu);
            this.tab_Kitchen_Stock.Controls.Add(this.cbox_Kitchen_Category);
            this.tab_Kitchen_Stock.Controls.Add(this.cbox_Kitchen_Menu);
            this.tab_Kitchen_Stock.Controls.Add(this.lv_stock);
            this.tab_Kitchen_Stock.Location = new System.Drawing.Point(4, 25);
            this.tab_Kitchen_Stock.Name = "tab_Kitchen_Stock";
            this.tab_Kitchen_Stock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Kitchen_Stock.Size = new System.Drawing.Size(913, 567);
            this.tab_Kitchen_Stock.TabIndex = 1;
            this.tab_Kitchen_Stock.Text = "Stock";
            // 
            // cmb_Bar_Category
            // 
            this.cmb_Bar_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bar_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bar_Category.FormattingEnabled = true;
            this.cmb_Bar_Category.Items.AddRange(new object[] {
            "Soft Drinks",
            "Hot Drinks",
            "Beer",
            "Wine"});
            this.cmb_Bar_Category.Location = new System.Drawing.Point(574, 12);
            this.cmb_Bar_Category.Name = "cmb_Bar_Category";
            this.cmb_Bar_Category.Size = new System.Drawing.Size(164, 37);
            this.cmb_Bar_Category.TabIndex = 66;
            this.cmb_Bar_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Bar_Category_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(731, 492);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(159, 45);
            this.btn_Refresh.TabIndex = 33;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Kitchen_Modify
            // 
            this.btn_Kitchen_Modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btn_Kitchen_Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kitchen_Modify.Location = new System.Drawing.Point(15, 492);
            this.btn_Kitchen_Modify.Name = "btn_Kitchen_Modify";
            this.btn_Kitchen_Modify.Size = new System.Drawing.Size(159, 45);
            this.btn_Kitchen_Modify.TabIndex = 32;
            this.btn_Kitchen_Modify.Text = "Modify";
            this.btn_Kitchen_Modify.UseVisualStyleBackColor = false;
            this.btn_Kitchen_Modify.Click += new System.EventHandler(this.btn_Kitchen_Modify_Click);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.Location = new System.Drawing.Point(9, 12);
            this.lbl_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(96, 33);
            this.lbl_Stock.TabIndex = 31;
            this.lbl_Stock.Text = "Stock ";
            // 
            // lbl_Kitchen_Catergory
            // 
            this.lbl_Kitchen_Catergory.AutoSize = true;
            this.lbl_Kitchen_Catergory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kitchen_Catergory.Location = new System.Drawing.Point(475, 20);
            this.lbl_Kitchen_Catergory.Name = "lbl_Kitchen_Catergory";
            this.lbl_Kitchen_Catergory.Size = new System.Drawing.Size(90, 24);
            this.lbl_Kitchen_Catergory.TabIndex = 4;
            this.lbl_Kitchen_Catergory.Text = "Category:";
            // 
            // lbl_Kitche_Menu
            // 
            this.lbl_Kitche_Menu.AutoSize = true;
            this.lbl_Kitche_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kitche_Menu.Location = new System.Drawing.Point(176, 20);
            this.lbl_Kitche_Menu.Name = "lbl_Kitche_Menu";
            this.lbl_Kitche_Menu.Size = new System.Drawing.Size(64, 24);
            this.lbl_Kitche_Menu.TabIndex = 3;
            this.lbl_Kitche_Menu.Text = "Menu:";
            // 
            // cbox_Kitchen_Category
            // 
            this.cbox_Kitchen_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Kitchen_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Kitchen_Category.FormattingEnabled = true;
            this.cbox_Kitchen_Category.Items.AddRange(new object[] {
            "Lunch Main",
            "Specials",
            "Bites",
            "Starters",
            "Mains",
            "Desserts"});
            this.cbox_Kitchen_Category.Location = new System.Drawing.Point(574, 12);
            this.cbox_Kitchen_Category.Name = "cbox_Kitchen_Category";
            this.cbox_Kitchen_Category.Size = new System.Drawing.Size(164, 37);
            this.cbox_Kitchen_Category.TabIndex = 2;
            this.cbox_Kitchen_Category.SelectedIndexChanged += new System.EventHandler(this.cbox_Kitchen_Category_SelectedIndexChanged);
            // 
            // cbox_Kitchen_Menu
            // 
            this.cbox_Kitchen_Menu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Kitchen_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Kitchen_Menu.FormattingEnabled = true;
            this.cbox_Kitchen_Menu.Items.AddRange(new object[] {
            "Lunch",
            "Dinner"});
            this.cbox_Kitchen_Menu.Location = new System.Drawing.Point(249, 12);
            this.cbox_Kitchen_Menu.Name = "cbox_Kitchen_Menu";
            this.cbox_Kitchen_Menu.Size = new System.Drawing.Size(142, 37);
            this.cbox_Kitchen_Menu.TabIndex = 1;
            this.cbox_Kitchen_Menu.SelectedIndexChanged += new System.EventHandler(this.cbox_Kitchen_Menu_SelectedIndexChanged);
            // 
            // lv_stock
            // 
            this.lv_stock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lv_stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_ItemName,
            this.col_Stock});
            this.lv_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lv_stock.FullRowSelect = true;
            this.lv_stock.HideSelection = false;
            this.lv_stock.Location = new System.Drawing.Point(15, 60);
            this.lv_stock.Name = "lv_stock";
            this.lv_stock.Size = new System.Drawing.Size(875, 411);
            this.lv_stock.TabIndex = 0;
            this.lv_stock.UseCompatibleStateImageBehavior = false;
            this.lv_stock.View = System.Windows.Forms.View.Details;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            // 
            // col_ItemName
            // 
            this.col_ItemName.Text = "Name";
            this.col_ItemName.Width = 402;
            // 
            // col_Stock
            // 
            this.col_Stock.Text = "Stock";
            this.col_Stock.Width = 100;
            // 
            // lbl_current_user
            // 
            this.lbl_current_user.AutoSize = true;
            this.lbl_current_user.Location = new System.Drawing.Point(159, 58);
            this.lbl_current_user.Name = "lbl_current_user";
            this.lbl_current_user.Size = new System.Drawing.Size(23, 17);
            this.lbl_current_user.TabIndex = 68;
            this.lbl_current_user.Text = "---";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(45, 58);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(93, 17);
            this.lbl_user.TabIndex = 67;
            this.lbl_user.Text = "Current User:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(898, 25);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 50);
            this.btnLogout.TabIndex = 70;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btn_Kitchen_Logout_Click);
            // 
            // KitchenBarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_current_user);
            this.Controls.Add(this.tabs_Kitchen);
            this.Controls.Add(this.lbl_user);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitchenBarUI";
            this.Text = "Order View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitchenBarUI_FormClosing);
            this.tabs_Kitchen.ResumeLayout(false);
            this.tab_Kitchen_Orders.ResumeLayout(false);
            this.tab_Kitchen_Orders.PerformLayout();
            this.tab_Kitchen_Stock.ResumeLayout(false);
            this.tab_Kitchen_Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_Kitchen;
        private System.Windows.Forms.TabPage tab_Kitchen_Orders;
        private System.Windows.Forms.TabPage tab_Kitchen_Stock;
        private System.Windows.Forms.Label lbl_Kitche_Menu;
        private System.Windows.Forms.ComboBox cbox_Kitchen_Category;
        private System.Windows.Forms.ComboBox cbox_Kitchen_Menu;
        private System.Windows.Forms.ListView lv_stock;
        private System.Windows.Forms.Label lbl_Kitchen_Catergory;
        private System.Windows.Forms.ColumnHeader col_ItemName;
        private System.Windows.Forms.ColumnHeader col_Stock;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Button btn_Kitchen_Modify;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ComboBox cmb_Bar_Category;
        private System.Windows.Forms.Label lbl_current_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Button btn_Item_Ready;
        private System.Windows.Forms.RichTextBox txtbox_comments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_ViewOrders;
        private System.Windows.Forms.ColumnHeader col_table;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_quant;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader col_comment;
    }
}