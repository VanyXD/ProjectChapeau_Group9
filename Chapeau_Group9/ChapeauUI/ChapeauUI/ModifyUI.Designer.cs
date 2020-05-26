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
            this.lbl_modify_Nr = new System.Windows.Forms.Label();
            btn_plus = new System.Windows.Forms.Button();
            btn_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            btn_plus.Location = new System.Drawing.Point(349, 123);
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
            btn_minus.Location = new System.Drawing.Point(38, 123);
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
            this.lbl_modify_Title.Location = new System.Drawing.Point(117, 33);
            this.lbl_modify_Title.Name = "lbl_modify_Title";
            this.lbl_modify_Title.Size = new System.Drawing.Size(246, 25);
            this.lbl_modify_Title.TabIndex = 4;
            this.lbl_modify_Title.Text = "ITEM_NAMEITEM_NAME";
            this.lbl_modify_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_modify_Nr
            // 
            this.lbl_modify_Nr.AutoSize = true;
            this.lbl_modify_Nr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_modify_Nr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_modify_Nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lbl_modify_Nr.Location = new System.Drawing.Point(187, 123);
            this.lbl_modify_Nr.Name = "lbl_modify_Nr";
            this.lbl_modify_Nr.Size = new System.Drawing.Size(97, 69);
            this.lbl_modify_Nr.TabIndex = 5;
            this.lbl_modify_Nr.Text = "00";
            this.lbl_modify_Nr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 260);
            this.Controls.Add(this.lbl_modify_Nr);
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
        private System.Windows.Forms.Label lbl_modify_Nr;
    }
}