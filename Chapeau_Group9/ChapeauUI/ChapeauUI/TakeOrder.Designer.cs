namespace ChapeauUI
{
    partial class TakeOrder
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
            this.lstvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvSelected = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowFull = new System.Windows.Forms.Button();
            this.btnLunchMains = new System.Windows.Forms.Button();
            this.btnLunchSpecials = new System.Windows.Forms.Button();
            this.btnDinnerDesserts = new System.Windows.Forms.Button();
            this.btnDinnerMains = new System.Windows.Forms.Button();
            this.btnDinnerStarters = new System.Windows.Forms.Button();
            this.btnLunchBites = new System.Windows.Forms.Button();
            this.btnAlcoholics = new System.Windows.Forms.Button();
            this.btnHotDrinks = new System.Windows.Forms.Button();
            this.btnSoftDrinks = new System.Windows.Forms.Button();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvMenu
            // 
            this.lstvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader9});
            this.lstvMenu.FullRowSelect = true;
            this.lstvMenu.HideSelection = false;
            this.lstvMenu.Location = new System.Drawing.Point(56, 55);
            this.lstvMenu.Name = "lstvMenu";
            this.lstvMenu.Size = new System.Drawing.Size(522, 778);
            this.lstvMenu.TabIndex = 0;
            this.lstvMenu.UseCompatibleStateImageBehavior = false;
            this.lstvMenu.View = System.Windows.Forms.View.Details;
            this.lstvMenu.SelectedIndexChanged += new System.EventHandler(this.lstvMenu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // lstvSelected
            // 
            this.lstvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6});
            this.lstvSelected.FullRowSelect = true;
            this.lstvSelected.HideSelection = false;
            this.lstvSelected.Location = new System.Drawing.Point(1126, 55);
            this.lstvSelected.Name = "lstvSelected";
            this.lstvSelected.Size = new System.Drawing.Size(473, 778);
            this.lstvSelected.TabIndex = 1;
            this.lstvSelected.UseCompatibleStateImageBehavior = false;
            this.lstvSelected.View = System.Windows.Forms.View.Details;
            this.lstvSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvSelected_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 100;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(824, 539);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(139, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Item";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1123, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected";
            // 
            // btnShowFull
            // 
            this.btnShowFull.Location = new System.Drawing.Point(602, 87);
            this.btnShowFull.Name = "btnShowFull";
            this.btnShowFull.Size = new System.Drawing.Size(139, 23);
            this.btnShowFull.TabIndex = 5;
            this.btnShowFull.Text = "Show Full Menu";
            this.btnShowFull.UseVisualStyleBackColor = true;
            this.btnShowFull.Click += new System.EventHandler(this.btnShowFull_Click);
            // 
            // btnLunchMains
            // 
            this.btnLunchMains.Location = new System.Drawing.Point(602, 132);
            this.btnLunchMains.Name = "btnLunchMains";
            this.btnLunchMains.Size = new System.Drawing.Size(139, 23);
            this.btnLunchMains.TabIndex = 9;
            this.btnLunchMains.Text = "Lunch Main";
            this.btnLunchMains.UseVisualStyleBackColor = true;
            this.btnLunchMains.Click += new System.EventHandler(this.btnLunchMains_Click);
            // 
            // btnLunchSpecials
            // 
            this.btnLunchSpecials.Location = new System.Drawing.Point(602, 177);
            this.btnLunchSpecials.Name = "btnLunchSpecials";
            this.btnLunchSpecials.Size = new System.Drawing.Size(139, 23);
            this.btnLunchSpecials.TabIndex = 10;
            this.btnLunchSpecials.Text = "Lunch Specials";
            this.btnLunchSpecials.UseVisualStyleBackColor = true;
            this.btnLunchSpecials.Click += new System.EventHandler(this.btnLunchSpecials_Click);
            // 
            // btnDinnerDesserts
            // 
            this.btnDinnerDesserts.Location = new System.Drawing.Point(602, 357);
            this.btnDinnerDesserts.Name = "btnDinnerDesserts";
            this.btnDinnerDesserts.Size = new System.Drawing.Size(139, 23);
            this.btnDinnerDesserts.TabIndex = 11;
            this.btnDinnerDesserts.Text = "Dinner Desserts";
            this.btnDinnerDesserts.UseVisualStyleBackColor = true;
            this.btnDinnerDesserts.Click += new System.EventHandler(this.btnDinnerDesserts_Click);
            // 
            // btnDinnerMains
            // 
            this.btnDinnerMains.Location = new System.Drawing.Point(602, 267);
            this.btnDinnerMains.Name = "btnDinnerMains";
            this.btnDinnerMains.Size = new System.Drawing.Size(139, 23);
            this.btnDinnerMains.TabIndex = 12;
            this.btnDinnerMains.Text = "Dinner Mains";
            this.btnDinnerMains.UseVisualStyleBackColor = true;
            this.btnDinnerMains.Click += new System.EventHandler(this.btnDinnerMains_Click);
            // 
            // btnDinnerStarters
            // 
            this.btnDinnerStarters.Location = new System.Drawing.Point(602, 312);
            this.btnDinnerStarters.Name = "btnDinnerStarters";
            this.btnDinnerStarters.Size = new System.Drawing.Size(139, 23);
            this.btnDinnerStarters.TabIndex = 13;
            this.btnDinnerStarters.Text = "Dinner Starters";
            this.btnDinnerStarters.UseVisualStyleBackColor = true;
            this.btnDinnerStarters.Click += new System.EventHandler(this.btnDinnerStarters_Click);
            // 
            // btnLunchBites
            // 
            this.btnLunchBites.Location = new System.Drawing.Point(602, 222);
            this.btnLunchBites.Name = "btnLunchBites";
            this.btnLunchBites.Size = new System.Drawing.Size(139, 23);
            this.btnLunchBites.TabIndex = 14;
            this.btnLunchBites.Text = "Lunch Bites";
            this.btnLunchBites.UseVisualStyleBackColor = true;
            this.btnLunchBites.Click += new System.EventHandler(this.btnLunchBites_Click);
            // 
            // btnAlcoholics
            // 
            this.btnAlcoholics.Location = new System.Drawing.Point(602, 492);
            this.btnAlcoholics.Name = "btnAlcoholics";
            this.btnAlcoholics.Size = new System.Drawing.Size(139, 23);
            this.btnAlcoholics.TabIndex = 15;
            this.btnAlcoholics.Text = "Beers/Wines";
            this.btnAlcoholics.UseVisualStyleBackColor = true;
            this.btnAlcoholics.Click += new System.EventHandler(this.btnAlcoholics_Click);
            // 
            // btnHotDrinks
            // 
            this.btnHotDrinks.Location = new System.Drawing.Point(602, 447);
            this.btnHotDrinks.Name = "btnHotDrinks";
            this.btnHotDrinks.Size = new System.Drawing.Size(139, 23);
            this.btnHotDrinks.TabIndex = 16;
            this.btnHotDrinks.Text = "Hot Drinks";
            this.btnHotDrinks.UseVisualStyleBackColor = true;
            this.btnHotDrinks.Click += new System.EventHandler(this.btnHotDrinks_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.Location = new System.Drawing.Point(602, 402);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(139, 23);
            this.btnSoftDrinks.TabIndex = 17;
            this.btnSoftDrinks.Text = "Soft Drinkls";
            this.btnSoftDrinks.UseVisualStyleBackColor = true;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Location = new System.Drawing.Point(1496, 890);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(139, 23);
            this.btnSendOrder.TabIndex = 18;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = true;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(860, 307);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "select quantity";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "availability";
            this.columnHeader9.Width = 100;
            // 
            // TakeOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.btnSendOrder);
            this.Controls.Add(this.btnSoftDrinks);
            this.Controls.Add(this.btnHotDrinks);
            this.Controls.Add(this.btnAlcoholics);
            this.Controls.Add(this.btnLunchBites);
            this.Controls.Add(this.btnDinnerStarters);
            this.Controls.Add(this.btnDinnerMains);
            this.Controls.Add(this.btnDinnerDesserts);
            this.Controls.Add(this.btnLunchSpecials);
            this.Controls.Add(this.btnLunchMains);
            this.Controls.Add(this.btnShowFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstvSelected);
            this.Controls.Add(this.lstvMenu);
            this.Name = "TakeOrder";
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstvSelected;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowFull;
        private System.Windows.Forms.Button btnLunchMains;
        private System.Windows.Forms.Button btnLunchSpecials;
        private System.Windows.Forms.Button btnDinnerDesserts;
        private System.Windows.Forms.Button btnDinnerMains;
        private System.Windows.Forms.Button btnDinnerStarters;
        private System.Windows.Forms.Button btnLunchBites;
        private System.Windows.Forms.Button btnAlcoholics;
        private System.Windows.Forms.Button btnHotDrinks;
        private System.Windows.Forms.Button btnSoftDrinks;
        private System.Windows.Forms.Button btnSendOrder;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}