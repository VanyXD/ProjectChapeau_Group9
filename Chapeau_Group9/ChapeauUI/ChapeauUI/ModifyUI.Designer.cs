﻿namespace ChapeauUI
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
            btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            btn_plus.Location = new System.Drawing.Point(350, 108);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new System.Drawing.Size(75, 75);
            btn_plus.TabIndex = 2;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            btn_minus.Location = new System.Drawing.Point(38, 108);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new System.Drawing.Size(75, 75);
            btn_minus.TabIndex = 3;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // lbl_modify_Title
            // 
            this.lbl_modify_Title.AutoSize = true;
            this.lbl_modify_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modify_Title.Location = new System.Drawing.Point(33, 32);
            this.lbl_modify_Title.Name = "lbl_modify_Title";
            this.lbl_modify_Title.Size = new System.Drawing.Size(49, 25);
            this.lbl_modify_Title.TabIndex = 4;
            this.lbl_modify_Title.Text = "Title";
            this.lbl_modify_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Kitchen_Modify_Done
            // 
            this.btn_Kitchen_Modify_Done.Location = new System.Drawing.Point(158, 215);
            this.btn_Kitchen_Modify_Done.Name = "btn_Kitchen_Modify_Done";
            this.btn_Kitchen_Modify_Done.Size = new System.Drawing.Size(150, 70);
            this.btn_Kitchen_Modify_Done.TabIndex = 6;
            this.btn_Kitchen_Modify_Done.Text = "Done";
            this.btn_Kitchen_Modify_Done.UseVisualStyleBackColor = true;
            this.btn_Kitchen_Modify_Done.Click += new System.EventHandler(this.btn_Kitchen_Modify_Done_Click);
            // 
            // richTxtBox_Modify
            // 
            this.richTxtBox_Modify.Font = new System.Drawing.Font("Microsoft PhagsPa", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBox_Modify.Location = new System.Drawing.Point(189, 102);
            this.richTxtBox_Modify.Name = "richTxtBox_Modify";
            this.richTxtBox_Modify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTxtBox_Modify.Size = new System.Drawing.Size(90, 96);
            this.richTxtBox_Modify.TabIndex = 7;
            this.richTxtBox_Modify.Text = "00";
            // 
            // ModifyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(227)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(468, 297);
            this.Controls.Add(this.richTxtBox_Modify);
            this.Controls.Add(this.btn_Kitchen_Modify_Done);
            this.Controls.Add(this.lbl_modify_Title);
            this.Controls.Add(btn_minus);
            this.Controls.Add(btn_plus);
            this.Name = "ModifyUI";
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