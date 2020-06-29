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
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_order_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_kitchen_notes = new System.Windows.Forms.RichTextBox();
            this.btn_ViewItem_Ready = new System.Windows.Forms.Button();
            this.btn_ViewItem_Close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 45);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Order:";
            // 
            // lv_ViewTable
            // 
            this.lv_ViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_name,
            this.col_quant,
            this.col_time,
            this.col_order_id,
            this.col_comment});
            this.lv_ViewTable.FullRowSelect = true;
            this.lv_ViewTable.GridLines = true;
            this.lv_ViewTable.HideSelection = false;
            this.lv_ViewTable.Location = new System.Drawing.Point(12, 61);
            this.lv_ViewTable.Margin = new System.Windows.Forms.Padding(2);
            this.lv_ViewTable.Name = "lv_ViewTable";
            this.lv_ViewTable.Size = new System.Drawing.Size(335, 333);
            this.lv_ViewTable.TabIndex = 1;
            this.lv_ViewTable.UseCompatibleStateImageBehavior = false;
            this.lv_ViewTable.View = System.Windows.Forms.View.Details;
            this.lv_ViewTable.SelectedIndexChanged += new System.EventHandler(this.lv_ViewTable_SelectedIndexChanged);
            this.lv_ViewTable.Click += new System.EventHandler(this.lv_item_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "id";
            this.col_id.Width = 45;
            // 
            // col_name
            // 
            this.col_name.Text = "name";
            this.col_name.Width = 146;
            // 
            // col_quant
            // 
            this.col_quant.Text = "quantity";
            // 
            // col_time
            // 
            this.col_time.Text = "time";
            this.col_time.Width = 72;
            // 
            // col_order_id
            // 
            this.col_order_id.Text = "order id";
            // 
            // col_comment
            // 
            this.col_comment.Text = "comments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // txtbox_kitchen_notes
            // 
            this.txtbox_kitchen_notes.Location = new System.Drawing.Point(416, 76);
            this.txtbox_kitchen_notes.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_kitchen_notes.Name = "txtbox_kitchen_notes";
            this.txtbox_kitchen_notes.ReadOnly = true;
            this.txtbox_kitchen_notes.Size = new System.Drawing.Size(236, 118);
            this.txtbox_kitchen_notes.TabIndex = 3;
            this.txtbox_kitchen_notes.Text = "";
            // 
            // btn_ViewItem_Ready
            // 
            this.btn_ViewItem_Ready.Location = new System.Drawing.Point(416, 284);
            this.btn_ViewItem_Ready.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewItem_Ready.Name = "btn_ViewItem_Ready";
            this.btn_ViewItem_Ready.Size = new System.Drawing.Size(115, 61);
            this.btn_ViewItem_Ready.TabIndex = 4;
            this.btn_ViewItem_Ready.Text = "Ready";
            this.btn_ViewItem_Ready.UseVisualStyleBackColor = true;
            this.btn_ViewItem_Ready.Click += new System.EventHandler(this.btn_ViewItem_Ready_Click);
            // 
            // btn_ViewItem_Close
            // 
            this.btn_ViewItem_Close.Location = new System.Drawing.Point(536, 284);
            this.btn_ViewItem_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewItem_Close.Name = "btn_ViewItem_Close";
            this.btn_ViewItem_Close.Size = new System.Drawing.Size(115, 61);
            this.btn_ViewItem_Close.TabIndex = 5;
            this.btn_ViewItem_Close.Text = "Close";
            this.btn_ViewItem_Close.UseVisualStyleBackColor = true;
            this.btn_ViewItem_Close.Click += new System.EventHandler(this.btn_ViewItem_Close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_title.Location = new System.Drawing.Point(7, 7);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(148, 31);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "View Table";
            // 
            // KitchenViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 428);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_ViewItem_Close);
            this.Controls.Add(this.btn_ViewItem_Ready);
            this.Controls.Add(this.txtbox_kitchen_notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_ViewTable);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitchenViewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_quant;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.ColumnHeader col_order_id;
        private System.Windows.Forms.ColumnHeader col_comment;
    }
}