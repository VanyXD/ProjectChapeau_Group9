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
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvSelected = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxComment = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvMenu
            // 
            this.lstvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.lstvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8,
            this.columnHeader9});
            this.lstvMenu.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvMenu.FullRowSelect = true;
            this.lstvMenu.GridLines = true;
            this.lstvMenu.HideSelection = false;
            this.lstvMenu.Location = new System.Drawing.Point(56, 55);
            this.lstvMenu.Name = "lstvMenu";
            this.lstvMenu.Size = new System.Drawing.Size(582, 823);
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
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "availability";
            this.columnHeader9.Width = 120;
            // 
            // lstvSelected
            // 
            this.lstvSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.lstvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader10});
            this.lstvSelected.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvSelected.FullRowSelect = true;
            this.lstvSelected.GridLines = true;
            this.lstvSelected.HideSelection = false;
            this.lstvSelected.Location = new System.Drawing.Point(1179, 55);
            this.lstvSelected.Name = "lstvSelected";
            this.lstvSelected.Size = new System.Drawing.Size(701, 822);
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
            // columnHeader10
            // 
            this.columnHeader10.Text = "Comment";
            this.columnHeader10.Width = 250;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(880, 565);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(139, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Item";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1175, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected";
            // 
            // btnShowFull
            // 
            this.btnShowFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnShowFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFull.ForeColor = System.Drawing.Color.Black;
            this.btnShowFull.Location = new System.Drawing.Point(644, 174);
            this.btnShowFull.Name = "btnShowFull";
            this.btnShowFull.Size = new System.Drawing.Size(139, 45);
            this.btnShowFull.TabIndex = 5;
            this.btnShowFull.Text = "Show Full Menu";
            this.btnShowFull.UseVisualStyleBackColor = false;
            this.btnShowFull.Click += new System.EventHandler(this.btnShowFull_Click);
            // 
            // btnLunchMains
            // 
            this.btnLunchMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchMains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchMains.ForeColor = System.Drawing.Color.Black;
            this.btnLunchMains.Location = new System.Drawing.Point(644, 223);
            this.btnLunchMains.Name = "btnLunchMains";
            this.btnLunchMains.Size = new System.Drawing.Size(139, 45);
            this.btnLunchMains.TabIndex = 9;
            this.btnLunchMains.Text = "Lunch Main";
            this.btnLunchMains.UseVisualStyleBackColor = false;
            this.btnLunchMains.Click += new System.EventHandler(this.btnLunchMains_Click);
            // 
            // btnLunchSpecials
            // 
            this.btnLunchSpecials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchSpecials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchSpecials.ForeColor = System.Drawing.Color.Black;
            this.btnLunchSpecials.Location = new System.Drawing.Point(644, 272);
            this.btnLunchSpecials.Name = "btnLunchSpecials";
            this.btnLunchSpecials.Size = new System.Drawing.Size(139, 45);
            this.btnLunchSpecials.TabIndex = 10;
            this.btnLunchSpecials.Text = "Lunch Specials";
            this.btnLunchSpecials.UseVisualStyleBackColor = false;
            this.btnLunchSpecials.Click += new System.EventHandler(this.btnLunchSpecials_Click);
            // 
            // btnDinnerDesserts
            // 
            this.btnDinnerDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerDesserts.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerDesserts.Location = new System.Drawing.Point(644, 468);
            this.btnDinnerDesserts.Name = "btnDinnerDesserts";
            this.btnDinnerDesserts.Size = new System.Drawing.Size(139, 45);
            this.btnDinnerDesserts.TabIndex = 11;
            this.btnDinnerDesserts.Text = "Dinner Desserts";
            this.btnDinnerDesserts.UseVisualStyleBackColor = false;
            this.btnDinnerDesserts.Click += new System.EventHandler(this.btnDinnerDesserts_Click);
            // 
            // btnDinnerMains
            // 
            this.btnDinnerMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerMains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerMains.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerMains.Location = new System.Drawing.Point(644, 370);
            this.btnDinnerMains.Name = "btnDinnerMains";
            this.btnDinnerMains.Size = new System.Drawing.Size(139, 45);
            this.btnDinnerMains.TabIndex = 12;
            this.btnDinnerMains.Text = "Dinner Mains";
            this.btnDinnerMains.UseVisualStyleBackColor = false;
            this.btnDinnerMains.Click += new System.EventHandler(this.btnDinnerMains_Click);
            // 
            // btnDinnerStarters
            // 
            this.btnDinnerStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerStarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerStarters.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerStarters.Location = new System.Drawing.Point(644, 419);
            this.btnDinnerStarters.Name = "btnDinnerStarters";
            this.btnDinnerStarters.Size = new System.Drawing.Size(139, 45);
            this.btnDinnerStarters.TabIndex = 13;
            this.btnDinnerStarters.Text = "Dinner Starters";
            this.btnDinnerStarters.UseVisualStyleBackColor = false;
            this.btnDinnerStarters.Click += new System.EventHandler(this.btnDinnerStarters_Click);
            // 
            // btnLunchBites
            // 
            this.btnLunchBites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchBites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchBites.ForeColor = System.Drawing.Color.Black;
            this.btnLunchBites.Location = new System.Drawing.Point(644, 321);
            this.btnLunchBites.Name = "btnLunchBites";
            this.btnLunchBites.Size = new System.Drawing.Size(139, 45);
            this.btnLunchBites.TabIndex = 14;
            this.btnLunchBites.Text = "Lunch Bites";
            this.btnLunchBites.UseVisualStyleBackColor = false;
            this.btnLunchBites.Click += new System.EventHandler(this.btnLunchBites_Click);
            // 
            // btnAlcoholics
            // 
            this.btnAlcoholics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAlcoholics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlcoholics.ForeColor = System.Drawing.Color.Black;
            this.btnAlcoholics.Location = new System.Drawing.Point(644, 615);
            this.btnAlcoholics.Name = "btnAlcoholics";
            this.btnAlcoholics.Size = new System.Drawing.Size(139, 45);
            this.btnAlcoholics.TabIndex = 15;
            this.btnAlcoholics.Text = "Beers/Wines";
            this.btnAlcoholics.UseVisualStyleBackColor = false;
            this.btnAlcoholics.Click += new System.EventHandler(this.btnAlcoholics_Click);
            // 
            // btnHotDrinks
            // 
            this.btnHotDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotDrinks.ForeColor = System.Drawing.Color.Black;
            this.btnHotDrinks.Location = new System.Drawing.Point(644, 566);
            this.btnHotDrinks.Name = "btnHotDrinks";
            this.btnHotDrinks.Size = new System.Drawing.Size(139, 45);
            this.btnHotDrinks.TabIndex = 16;
            this.btnHotDrinks.Text = "Hot Drinks";
            this.btnHotDrinks.UseVisualStyleBackColor = false;
            this.btnHotDrinks.Click += new System.EventHandler(this.btnHotDrinks_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSoftDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftDrinks.ForeColor = System.Drawing.Color.Black;
            this.btnSoftDrinks.Location = new System.Drawing.Point(644, 517);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(139, 45);
            this.btnSoftDrinks.TabIndex = 17;
            this.btnSoftDrinks.Text = "Soft Drinkls";
            this.btnSoftDrinks.UseVisualStyleBackColor = false;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSendOrder.Location = new System.Drawing.Point(1014, 762);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(139, 45);
            this.btnSendOrder.TabIndex = 18;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(871, 264);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(148, 29);
            this.numericUpDownQuantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(871, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select Quantity:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 988);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxComment
            // 
            this.checkBoxComment.AutoSize = true;
            this.checkBoxComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.checkBoxComment.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComment.ForeColor = System.Drawing.Color.Black;
            this.checkBoxComment.Location = new System.Drawing.Point(875, 318);
            this.checkBoxComment.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComment.Name = "checkBoxComment";
            this.checkBoxComment.Padding = new System.Windows.Forms.Padding(5);
            this.checkBoxComment.Size = new System.Drawing.Size(116, 36);
            this.checkBoxComment.TabIndex = 22;
            this.checkBoxComment.Text = "comment";
            this.checkBoxComment.UseVisualStyleBackColor = false;
            this.checkBoxComment.CheckedChanged += new System.EventHandler(this.checkBoxComment_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(814, 383);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(279, 151);
            this.txtComment.TabIndex = 23;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnRemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveOrder.Location = new System.Drawing.Point(778, 762);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(139, 45);
            this.btnRemoveOrder.TabIndex = 24;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.lblTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(640, 55);
            this.lblTable.Name = "lblTable";
            this.lblTable.Padding = new System.Windows.Forms.Padding(5);
            this.lblTable.Size = new System.Drawing.Size(43, 30);
            this.lblTable.TabIndex = 25;
            this.lblTable.Text = "____";
            this.lblTable.Click += new System.EventHandler(this.lblTable_Click);
            // 
            // TakeOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.checkBoxComment);
            this.Controls.Add(this.button1);
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
            this.MinimumSize = new System.Drawing.Size(1718, 1028);
            this.Name = "TakeOrder";
            this.Padding = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lblTable;
    }
}