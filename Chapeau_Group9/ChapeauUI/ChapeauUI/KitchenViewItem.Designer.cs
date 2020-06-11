namespace ChapeauUI
{
    partial class KitchenViewItem
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
            this.label = new System.Windows.Forms.Label();
            this.lv_ViewTable = new System.Windows.Forms.ListView();
            this.col_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_kitchen_notes = new System.Windows.Forms.RichTextBox();
            this.btn_ViewItem_Ready = new System.Windows.Forms.Button();
            this.btn_ViewItem_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Order:";
            // 
            // lv_ViewTable
            // 
            this.lv_ViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_quantity,
            this.col_name,
            this.col_time});
            this.lv_ViewTable.GridLines = true;
            this.lv_ViewTable.HideSelection = false;
            this.lv_ViewTable.Location = new System.Drawing.Point(16, 75);
            this.lv_ViewTable.Name = "lv_ViewTable";
            this.lv_ViewTable.Size = new System.Drawing.Size(380, 409);
            this.lv_ViewTable.TabIndex = 1;
            this.lv_ViewTable.UseCompatibleStateImageBehavior = false;
            this.lv_ViewTable.View = System.Windows.Forms.View.Details;
            // 
            // col_quantity
            // 
            this.col_quantity.Text = "quantity";
            this.col_quantity.Width = 65;
            // 
            // col_name
            // 
            this.col_name.Text = "name";
            this.col_name.Width = 160;
            // 
            // col_time
            // 
            this.col_time.Text = "time";
            this.col_time.Width = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // txtbox_kitchen_notes
            // 
            this.txtbox_kitchen_notes.Location = new System.Drawing.Point(450, 75);
            this.txtbox_kitchen_notes.Name = "txtbox_kitchen_notes";
            this.txtbox_kitchen_notes.Size = new System.Drawing.Size(313, 144);
            this.txtbox_kitchen_notes.TabIndex = 3;
            this.txtbox_kitchen_notes.Text = "";
            // 
            // btn_ViewItem_Ready
            // 
            this.btn_ViewItem_Ready.Location = new System.Drawing.Point(450, 334);
            this.btn_ViewItem_Ready.Name = "btn_ViewItem_Ready";
            this.btn_ViewItem_Ready.Size = new System.Drawing.Size(153, 75);
            this.btn_ViewItem_Ready.TabIndex = 4;
            this.btn_ViewItem_Ready.Text = "Ready";
            this.btn_ViewItem_Ready.UseVisualStyleBackColor = true;
            // 
            // btn_ViewItem_Close
            // 
            this.btn_ViewItem_Close.Location = new System.Drawing.Point(610, 334);
            this.btn_ViewItem_Close.Name = "btn_ViewItem_Close";
            this.btn_ViewItem_Close.Size = new System.Drawing.Size(153, 75);
            this.btn_ViewItem_Close.TabIndex = 5;
            this.btn_ViewItem_Close.Text = "Close";
            this.btn_ViewItem_Close.UseVisualStyleBackColor = true;
            this.btn_ViewItem_Close.Click += new System.EventHandler(this.btn_ViewItem_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Table";
            // 
            // KitchenViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ViewItem_Close);
            this.Controls.Add(this.btn_ViewItem_Ready);
            this.Controls.Add(this.txtbox_kitchen_notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_ViewTable);
            this.Controls.Add(this.label);
            this.Name = "KitchenViewItem";
            this.Text = "View Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListView lv_ViewTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtbox_kitchen_notes;
        private System.Windows.Forms.Button btn_ViewItem_Ready;
        private System.Windows.Forms.Button btn_ViewItem_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader col_quantity;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_time;
    }
}