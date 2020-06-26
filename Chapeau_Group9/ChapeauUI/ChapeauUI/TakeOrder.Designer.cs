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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeOrder));
            this.lstvMenu = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvSelected = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.checkBoxComment = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvMenu
            // 
            this.lstvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.lstvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader8});
            this.lstvMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvMenu.FullRowSelect = true;
            this.lstvMenu.GridLines = true;
            this.lstvMenu.HideSelection = false;
            this.lstvMenu.Location = new System.Drawing.Point(3, 51);
            this.lstvMenu.Name = "lstvMenu";
            this.lstvMenu.Size = new System.Drawing.Size(415, 473);
            this.lstvMenu.TabIndex = 0;
            this.lstvMenu.UseCompatibleStateImageBehavior = false;
            this.lstvMenu.View = System.Windows.Forms.View.Details;
            this.lstvMenu.SelectedIndexChanged += new System.EventHandler(this.lstvMenu_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            this.columnHeader8.Width = 75;
            // 
            // lstvSelected
            // 
            this.lstvSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.lstvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader10});
            this.lstvSelected.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvSelected.FullRowSelect = true;
            this.lstvSelected.GridLines = true;
            this.lstvSelected.HideSelection = false;
            this.lstvSelected.Location = new System.Drawing.Point(3, 49);
            this.lstvSelected.Name = "lstvSelected";
            this.lstvSelected.Size = new System.Drawing.Size(415, 473);
            this.lstvSelected.TabIndex = 1;
            this.lstvSelected.UseCompatibleStateImageBehavior = false;
            this.lstvSelected.View = System.Windows.Forms.View.Details;
            this.lstvSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvSelected_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Quantity";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Comment";
            this.columnHeader10.Width = 150;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(219, 619);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Item";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.lblMenu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMenu.Location = new System.Drawing.Point(0, 11);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Padding = new System.Windows.Forms.Padding(5);
            this.lblMenu.Size = new System.Drawing.Size(69, 34);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(145, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Items";
            // 
            // btnShowFull
            // 
            this.btnShowFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnShowFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFull.ForeColor = System.Drawing.Color.Black;
            this.btnShowFull.Location = new System.Drawing.Point(7, 6);
            this.btnShowFull.Name = "btnShowFull";
            this.btnShowFull.Size = new System.Drawing.Size(120, 45);
            this.btnShowFull.TabIndex = 5;
            this.btnShowFull.Text = "Full Menu";
            this.btnShowFull.UseVisualStyleBackColor = false;
            this.btnShowFull.Click += new System.EventHandler(this.btnShowFull_Click);
            this.btnShowFull.MouseLeave += new System.EventHandler(this.btnShowFull_MouseLeave);
            this.btnShowFull.MouseHover += new System.EventHandler(this.btnShowFull_MouseHover);
            // 
            // btnLunchMains
            // 
            this.btnLunchMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchMains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchMains.ForeColor = System.Drawing.Color.Black;
            this.btnLunchMains.Location = new System.Drawing.Point(7, 104);
            this.btnLunchMains.Name = "btnLunchMains";
            this.btnLunchMains.Size = new System.Drawing.Size(120, 45);
            this.btnLunchMains.TabIndex = 9;
            this.btnLunchMains.Text = "Lunch Main";
            this.btnLunchMains.UseVisualStyleBackColor = false;
            this.btnLunchMains.Click += new System.EventHandler(this.btnLunchMains_Click);
            this.btnLunchMains.MouseLeave += new System.EventHandler(this.btnLunchMains_MouseLeave);
            this.btnLunchMains.MouseHover += new System.EventHandler(this.btnLunchMains_MouseHover);
            // 
            // btnLunchSpecials
            // 
            this.btnLunchSpecials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchSpecials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchSpecials.ForeColor = System.Drawing.Color.Black;
            this.btnLunchSpecials.Location = new System.Drawing.Point(7, 57);
            this.btnLunchSpecials.Name = "btnLunchSpecials";
            this.btnLunchSpecials.Size = new System.Drawing.Size(120, 45);
            this.btnLunchSpecials.TabIndex = 10;
            this.btnLunchSpecials.Text = "Lunch Specials";
            this.btnLunchSpecials.UseVisualStyleBackColor = false;
            this.btnLunchSpecials.Click += new System.EventHandler(this.btnLunchSpecials_Click);
            this.btnLunchSpecials.MouseLeave += new System.EventHandler(this.btnLunchSpecials_MouseLeave);
            this.btnLunchSpecials.MouseHover += new System.EventHandler(this.btnLunchSpecials_MouseHover);
            // 
            // btnDinnerDesserts
            // 
            this.btnDinnerDesserts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerDesserts.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerDesserts.Location = new System.Drawing.Point(7, 300);
            this.btnDinnerDesserts.Name = "btnDinnerDesserts";
            this.btnDinnerDesserts.Size = new System.Drawing.Size(120, 45);
            this.btnDinnerDesserts.TabIndex = 11;
            this.btnDinnerDesserts.Text = "Dinner Desserts";
            this.btnDinnerDesserts.UseVisualStyleBackColor = false;
            this.btnDinnerDesserts.Click += new System.EventHandler(this.btnDinnerDesserts_Click);
            // 
            // btnDinnerMains
            // 
            this.btnDinnerMains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerMains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerMains.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerMains.Location = new System.Drawing.Point(7, 251);
            this.btnDinnerMains.Name = "btnDinnerMains";
            this.btnDinnerMains.Size = new System.Drawing.Size(120, 45);
            this.btnDinnerMains.TabIndex = 12;
            this.btnDinnerMains.Text = "Dinner Mains";
            this.btnDinnerMains.UseVisualStyleBackColor = false;
            this.btnDinnerMains.Click += new System.EventHandler(this.btnDinnerMains_Click);
            // 
            // btnDinnerStarters
            // 
            this.btnDinnerStarters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnDinnerStarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinnerStarters.ForeColor = System.Drawing.Color.Black;
            this.btnDinnerStarters.Location = new System.Drawing.Point(7, 202);
            this.btnDinnerStarters.Name = "btnDinnerStarters";
            this.btnDinnerStarters.Size = new System.Drawing.Size(120, 45);
            this.btnDinnerStarters.TabIndex = 13;
            this.btnDinnerStarters.Text = "Dinner Starters";
            this.btnDinnerStarters.UseVisualStyleBackColor = false;
            this.btnDinnerStarters.Click += new System.EventHandler(this.btnDinnerStarters_Click);
            // 
            // btnLunchBites
            // 
            this.btnLunchBites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnLunchBites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchBites.ForeColor = System.Drawing.Color.Black;
            this.btnLunchBites.Location = new System.Drawing.Point(7, 153);
            this.btnLunchBites.Name = "btnLunchBites";
            this.btnLunchBites.Size = new System.Drawing.Size(120, 45);
            this.btnLunchBites.TabIndex = 14;
            this.btnLunchBites.Text = "Lunch Bites";
            this.btnLunchBites.UseVisualStyleBackColor = false;
            this.btnLunchBites.Click += new System.EventHandler(this.btnLunchBites_Click);
            // 
            // btnAlcoholics
            // 
            this.btnAlcoholics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnAlcoholics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlcoholics.ForeColor = System.Drawing.Color.Black;
            this.btnAlcoholics.Location = new System.Drawing.Point(7, 447);
            this.btnAlcoholics.Name = "btnAlcoholics";
            this.btnAlcoholics.Size = new System.Drawing.Size(120, 45);
            this.btnAlcoholics.TabIndex = 15;
            this.btnAlcoholics.Text = "Beers/Wines";
            this.btnAlcoholics.UseVisualStyleBackColor = false;
            this.btnAlcoholics.Click += new System.EventHandler(this.btnAlcoholics_Click);
            // 
            // btnHotDrinks
            // 
            this.btnHotDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotDrinks.ForeColor = System.Drawing.Color.Black;
            this.btnHotDrinks.Location = new System.Drawing.Point(7, 349);
            this.btnHotDrinks.Name = "btnHotDrinks";
            this.btnHotDrinks.Size = new System.Drawing.Size(120, 45);
            this.btnHotDrinks.TabIndex = 16;
            this.btnHotDrinks.Text = "Hot Drinks";
            this.btnHotDrinks.UseVisualStyleBackColor = false;
            this.btnHotDrinks.Click += new System.EventHandler(this.btnHotDrinks_Click);
            // 
            // btnSoftDrinks
            // 
            this.btnSoftDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSoftDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftDrinks.ForeColor = System.Drawing.Color.Black;
            this.btnSoftDrinks.Location = new System.Drawing.Point(7, 398);
            this.btnSoftDrinks.Name = "btnSoftDrinks";
            this.btnSoftDrinks.Size = new System.Drawing.Size(120, 45);
            this.btnSoftDrinks.TabIndex = 17;
            this.btnSoftDrinks.Text = "Soft Drinks";
            this.btnSoftDrinks.UseVisualStyleBackColor = false;
            this.btnSoftDrinks.Click += new System.EventHandler(this.btnSoftDrinks_Click);
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSendOrder.Location = new System.Drawing.Point(286, 619);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(132, 55);
            this.btnSendOrder.TabIndex = 18;
            this.btnSendOrder.Text = "Send Order";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            this.btnSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(219, 569);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(148, 34);
            this.numericUpDownQuantity.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(215, 532);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select Quantity:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(478, 681);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 32);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // checkBoxComment
            // 
            this.checkBoxComment.AutoSize = true;
            this.checkBoxComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.checkBoxComment.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxComment.ForeColor = System.Drawing.Color.Black;
            this.checkBoxComment.Location = new System.Drawing.Point(3, 532);
            this.checkBoxComment.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxComment.Name = "checkBoxComment";
            this.checkBoxComment.Size = new System.Drawing.Size(116, 28);
            this.checkBoxComment.TabIndex = 22;
            this.checkBoxComment.Text = "Comment";
            this.checkBoxComment.UseVisualStyleBackColor = false;
            this.checkBoxComment.CheckedChanged += new System.EventHandler(this.checkBoxComment_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(3, 568);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(207, 96);
            this.txtComment.TabIndex = 23;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btnRemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveOrder.Location = new System.Drawing.Point(3, 619);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(144, 55);
            this.btnRemoveOrder.TabIndex = 24;
            this.btnRemoveOrder.Text = "Remove Order";
            this.btnRemoveOrder.UseVisualStyleBackColor = false;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.lblTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(433, 44);
            this.lblTable.Name = "lblTable";
            this.lblTable.Padding = new System.Windows.Forms.Padding(5);
            this.lblTable.Size = new System.Drawing.Size(47, 30);
            this.lblTable.TabIndex = 25;
            this.lblTable.Text = "____";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstvSelected);
            this.panel1.Controls.Add(this.btnRemoveOrder);
            this.panel1.Controls.Add(this.btnSendOrder);
            this.panel1.Location = new System.Drawing.Point(574, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 677);
            this.panel1.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(183, 543);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotal.Size = new System.Drawing.Size(52, 33);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 543);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total Price:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.checkBoxComment);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.lstvMenu);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Controls.Add(this.numericUpDownQuantity);
            this.panel2.Location = new System.Drawing.Point(8, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 677);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Order for Table:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnlButtons.Controls.Add(this.btnSoftDrinks);
            this.pnlButtons.Controls.Add(this.btnHotDrinks);
            this.pnlButtons.Controls.Add(this.btnDinnerMains);
            this.pnlButtons.Controls.Add(this.btnAlcoholics);
            this.pnlButtons.Controls.Add(this.btnLunchMains);
            this.pnlButtons.Controls.Add(this.btnDinnerDesserts);
            this.pnlButtons.Controls.Add(this.btnShowFull);
            this.pnlButtons.Controls.Add(this.btnLunchSpecials);
            this.pnlButtons.Controls.Add(this.btnLunchBites);
            this.pnlButtons.Controls.Add(this.btnDinnerStarters);
            this.pnlButtons.Location = new System.Drawing.Point(435, 99);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(134, 499);
            this.pnlButtons.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Low Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(83, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(349, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Deplated";
            // 
            // TakeOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "TakeOrder";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "TakeOrder";
            this.Load += new System.EventHandler(this.TakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstvSelected;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblMenu;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox checkBoxComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}