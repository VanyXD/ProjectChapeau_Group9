namespace ChapeauUI
{
    partial class Chapeau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chapeau));
            this.lbllogin = new System.Windows.Forms.Button();
            this.lblloginbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbllogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lbllogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllogin.Location = new System.Drawing.Point(161, 268);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(162, 45);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login";
            this.lbllogin.UseVisualStyleBackColor = false;
            this.lbllogin.Click += new System.EventHandler(this.lbllogin_Click);
            // 
            // lblloginbox
            // 
            this.lblloginbox.Location = new System.Drawing.Point(161, 191);
            this.lblloginbox.Name = "lblloginbox";
            this.lblloginbox.Size = new System.Drawing.Size(162, 20);
            this.lblloginbox.TabIndex = 1;
            this.lblloginbox.TextChanged += new System.EventHandler(this.lblloginbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Chapeau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(468, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblloginbox);
            this.Controls.Add(this.lbllogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chapeau";
            this.Text = "Chapeau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbllogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox lblloginbox;
    }
}

