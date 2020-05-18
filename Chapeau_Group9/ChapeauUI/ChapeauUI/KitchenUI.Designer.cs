namespace ChapeauUI
{
    partial class KitchenUI
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
            this.tabs_Kitchen = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Kitchen_Notes = new System.Windows.Forms.Button();
            this.btn_Kitchen_Ready = new System.Windows.Forms.Button();
            this.btn_Kitchen_View = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.col_table6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.col_table1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_table5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Kitchen_Modify = new System.Windows.Forms.Button();
            this.Lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Kitchen_Catergory = new System.Windows.Forms.Label();
            this.lbl_Kitche_Menu = new System.Windows.Forms.Label();
            this.cbox_Kitchen_Category = new System.Windows.Forms.ComboBox();
            this.cbox_Kitchen_Menu = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabs_Kitchen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_Kitchen
            // 
            this.tabs_Kitchen.Controls.Add(this.tabPage1);
            this.tabs_Kitchen.Controls.Add(this.tabPage2);
            this.tabs_Kitchen.Location = new System.Drawing.Point(12, 12);
            this.tabs_Kitchen.Name = "tabs_Kitchen";
            this.tabs_Kitchen.SelectedIndex = 0;
            this.tabs_Kitchen.Size = new System.Drawing.Size(918, 484);
            this.tabs_Kitchen.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.btn_Kitchen_Notes);
            this.tabPage1.Controls.Add(this.btn_Kitchen_Ready);
            this.tabPage1.Controls.Add(this.btn_Kitchen_View);
            this.tabPage1.Controls.Add(this.listView3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orders";
            // 
            // btn_Kitchen_Notes
            // 
            this.btn_Kitchen_Notes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Kitchen_Notes.Location = new System.Drawing.Point(574, 0);
            this.btn_Kitchen_Notes.Name = "btn_Kitchen_Notes";
            this.btn_Kitchen_Notes.Size = new System.Drawing.Size(159, 45);
            this.btn_Kitchen_Notes.TabIndex = 37;
            this.btn_Kitchen_Notes.Text = "Notes";
            this.btn_Kitchen_Notes.UseVisualStyleBackColor = false;
            // 
            // btn_Kitchen_Ready
            // 
            this.btn_Kitchen_Ready.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Kitchen_Ready.Location = new System.Drawing.Point(739, 0);
            this.btn_Kitchen_Ready.Name = "btn_Kitchen_Ready";
            this.btn_Kitchen_Ready.Size = new System.Drawing.Size(159, 45);
            this.btn_Kitchen_Ready.TabIndex = 36;
            this.btn_Kitchen_Ready.Text = "Ready";
            this.btn_Kitchen_Ready.UseVisualStyleBackColor = false;
            // 
            // btn_Kitchen_View
            // 
            this.btn_Kitchen_View.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Kitchen_View.Location = new System.Drawing.Point(409, 0);
            this.btn_Kitchen_View.Name = "btn_Kitchen_View";
            this.btn_Kitchen_View.Size = new System.Drawing.Size(159, 45);
            this.btn_Kitchen_View.TabIndex = 35;
            this.btn_Kitchen_View.Text = "View";
            this.btn_Kitchen_View.UseVisualStyleBackColor = false;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_table6,
            this.col_table7,
            this.col_table8,
            this.col_table9,
            this.col_table10});
            this.listView3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(6, 244);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(880, 200);
            this.listView3.TabIndex = 34;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // col_table6
            // 
            this.col_table6.Text = "Table 6";
            this.col_table6.Width = 175;
            // 
            // col_table7
            // 
            this.col_table7.Text = "Table 7";
            this.col_table7.Width = 175;
            // 
            // col_table8
            // 
            this.col_table8.Text = "Table 8";
            this.col_table8.Width = 175;
            // 
            // col_table9
            // 
            this.col_table9.Text = "Table 9";
            this.col_table9.Width = 175;
            // 
            // col_table10
            // 
            this.col_table10.Text = "Table 10";
            this.col_table10.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Orders";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_table1,
            this.col_table2,
            this.col_table3,
            this.col_table4,
            this.col_table5});
            this.listView2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(880, 200);
            this.listView2.TabIndex = 32;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // col_table1
            // 
            this.col_table1.Text = "Table 1";
            this.col_table1.Width = 175;
            // 
            // col_table2
            // 
            this.col_table2.Text = "Table 2";
            this.col_table2.Width = 175;
            // 
            // col_table3
            // 
            this.col_table3.Text = "Table 3";
            this.col_table3.Width = 175;
            // 
            // col_table4
            // 
            this.col_table4.Text = "Table 4";
            this.col_table4.Width = 175;
            // 
            // col_table5
            // 
            this.col_table5.Text = "Table 5";
            this.col_table5.Width = 175;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.btn_Kitchen_Modify);
            this.tabPage2.Controls.Add(this.Lbl_Stock);
            this.tabPage2.Controls.Add(this.lbl_Kitchen_Catergory);
            this.tabPage2.Controls.Add(this.lbl_Kitche_Menu);
            this.tabPage2.Controls.Add(this.cbox_Kitchen_Category);
            this.tabPage2.Controls.Add(this.cbox_Kitchen_Menu);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            // 
            // btn_Kitchen_Modify
            // 
            this.btn_Kitchen_Modify.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Kitchen_Modify.Location = new System.Drawing.Point(654, 389);
            this.btn_Kitchen_Modify.Name = "btn_Kitchen_Modify";
            this.btn_Kitchen_Modify.Size = new System.Drawing.Size(159, 45);
            this.btn_Kitchen_Modify.TabIndex = 32;
            this.btn_Kitchen_Modify.Text = "Modify";
            this.btn_Kitchen_Modify.UseVisualStyleBackColor = false;
            // 
            // Lbl_Stock
            // 
            this.Lbl_Stock.AutoSize = true;
            this.Lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Stock.Location = new System.Drawing.Point(32, 12);
            this.Lbl_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Stock.Name = "Lbl_Stock";
            this.Lbl_Stock.Size = new System.Drawing.Size(88, 33);
            this.Lbl_Stock.TabIndex = 31;
            this.Lbl_Stock.Text = "Stock";
            // 
            // lbl_Kitchen_Catergory
            // 
            this.lbl_Kitchen_Catergory.AutoSize = true;
            this.lbl_Kitchen_Catergory.Location = new System.Drawing.Point(694, 23);
            this.lbl_Kitchen_Catergory.Name = "lbl_Kitchen_Catergory";
            this.lbl_Kitchen_Catergory.Size = new System.Drawing.Size(69, 17);
            this.lbl_Kitchen_Catergory.TabIndex = 4;
            this.lbl_Kitchen_Catergory.Text = "Category:";
            // 
            // lbl_Kitche_Menu
            // 
            this.lbl_Kitche_Menu.AutoSize = true;
            this.lbl_Kitche_Menu.Location = new System.Drawing.Point(392, 25);
            this.lbl_Kitche_Menu.Name = "lbl_Kitche_Menu";
            this.lbl_Kitche_Menu.Size = new System.Drawing.Size(47, 17);
            this.lbl_Kitche_Menu.TabIndex = 3;
            this.lbl_Kitche_Menu.Text = "Menu:";
            // 
            // cbox_Kitchen_Category
            // 
            this.cbox_Kitchen_Category.FormattingEnabled = true;
            this.cbox_Kitchen_Category.Location = new System.Drawing.Point(769, 20);
            this.cbox_Kitchen_Category.Name = "cbox_Kitchen_Category";
            this.cbox_Kitchen_Category.Size = new System.Drawing.Size(121, 24);
            this.cbox_Kitchen_Category.TabIndex = 2;
            // 
            // cbox_Kitchen_Menu
            // 
            this.cbox_Kitchen_Menu.FormattingEnabled = true;
            this.cbox_Kitchen_Menu.Location = new System.Drawing.Point(445, 20);
            this.cbox_Kitchen_Menu.Name = "cbox_Kitchen_Menu";
            this.cbox_Kitchen_Menu.Size = new System.Drawing.Size(121, 24);
            this.cbox_Kitchen_Menu.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Item,
            this.col_Stock});
            this.listView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 309);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_Item
            // 
            this.col_Item.Text = "Item";
            this.col_Item.Width = 402;
            // 
            // col_Stock
            // 
            this.col_Stock.Text = "Stock";
            this.col_Stock.Width = 399;
            // 
            // KitchenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.tabs_Kitchen);
            this.Name = "KitchenUI";
            this.Text = "Kitchen";
            this.tabs_Kitchen.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_Kitchen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_Kitche_Menu;
        private System.Windows.Forms.ComboBox cbox_Kitchen_Category;
        private System.Windows.Forms.ComboBox cbox_Kitchen_Menu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_Kitchen_Catergory;
        private System.Windows.Forms.ColumnHeader col_Item;
        private System.Windows.Forms.ColumnHeader col_Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader col_table1;
        private System.Windows.Forms.ColumnHeader col_table2;
        private System.Windows.Forms.Label Lbl_Stock;
        private System.Windows.Forms.Button btn_Kitchen_Modify;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader col_table6;
        private System.Windows.Forms.ColumnHeader col_table7;
        private System.Windows.Forms.ColumnHeader col_table8;
        private System.Windows.Forms.ColumnHeader col_table9;
        private System.Windows.Forms.ColumnHeader col_table10;
        private System.Windows.Forms.ColumnHeader col_table3;
        private System.Windows.Forms.ColumnHeader col_table4;
        private System.Windows.Forms.ColumnHeader col_table5;
        private System.Windows.Forms.Button btn_Kitchen_Notes;
        private System.Windows.Forms.Button btn_Kitchen_Ready;
        private System.Windows.Forms.Button btn_Kitchen_View;
    }
}