namespace ChapeauUI
{
    partial class ModifyUI
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
            System.Windows.Forms.Button btn_plus;
            System.Windows.Forms.Button btn_minus;
            this.lbl_modify_Title = new System.Windows.Forms.Label();
            this.btn_Kitchen_Modify_Done = new System.Windows.Forms.Button();
            this.richTxtBox_Modify = new System.Windows.Forms.RichTextBox();
            btn_plus = new System.Windows.Forms.Button();
            btn_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            btn_plus.Location = new System.Drawing.Point(262, 88);
            btn_plus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new System.Drawing.Size(56, 61);
            btn_plus.TabIndex = 2;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            btn_minus.Location = new System.Drawing.Point(28, 88);
            btn_minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new System.Drawing.Size(56, 61);
            btn_minus.TabIndex = 3;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // lbl_modify_Title
            // 
            this.lbl_modify_Title.AutoSize = true;
            this.lbl_modify_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modify_Title.Location = new System.Drawing.Point(25, 26);
            this.lbl_modify_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_modify_Title.Name = "lbl_modify_Title";
            this.lbl_modify_Title.Size = new System.Drawing.Size(38, 20);
            this.lbl_modify_Title.TabIndex = 4;
            this.lbl_modify_Title.Text = "Title";
            this.lbl_modify_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Kitchen_Modify_Done
            // 
            this.btn_Kitchen_Modify_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.btn_Kitchen_Modify_Done.Location = new System.Drawing.Point(118, 175);
            this.btn_Kitchen_Modify_Done.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Kitchen_Modify_Done.Name = "btn_Kitchen_Modify_Done";
            this.btn_Kitchen_Modify_Done.Size = new System.Drawing.Size(112, 57);
            this.btn_Kitchen_Modify_Done.TabIndex = 6;
            this.btn_Kitchen_Modify_Done.Text = "Done";
            this.btn_Kitchen_Modify_Done.UseVisualStyleBackColor = false;
            this.btn_Kitchen_Modify_Done.Click += new System.EventHandler(this.btn_Kitchen_Modify_Done_Click);
            // 
            // richTxtBox_Modify
            // 
            this.richTxtBox_Modify.Font = new System.Drawing.Font("Microsoft PhagsPa", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox_Modify.Location = new System.Drawing.Point(142, 83);
            this.richTxtBox_Modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtBox_Modify.Name = "richTxtBox_Modify";
            this.richTxtBox_Modify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTxtBox_Modify.Size = new System.Drawing.Size(68, 79);
            this.richTxtBox_Modify.TabIndex = 7;
            this.richTxtBox_Modify.Text = "00";
            // 
            // ModifyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 241);
            this.Controls.Add(this.richTxtBox_Modify);
            this.Controls.Add(this.btn_Kitchen_Modify_Done);
            this.Controls.Add(this.lbl_modify_Title);
            this.Controls.Add(btn_minus);
            this.Controls.Add(btn_plus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_modify_Title;
        private System.Windows.Forms.Button btn_Kitchen_Modify_Done;
        private System.Windows.Forms.RichTextBox richTxtBox_Modify;
    }
}