namespace VP_FINAL_PROJECT
{
    partial class Form1
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
            this.Browse = new System.Windows.Forms.Button();
            this.input_pic = new System.Windows.Forms.PictureBox();
            this.path_pic = new System.Windows.Forms.TextBox();
            this.enc_button = new System.Windows.Forms.Button();
            this.enc_key = new System.Windows.Forms.TextBox();
            this.decry_button = new System.Windows.Forms.Button();
            this.decrypt_key = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(714, 602);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(146, 39);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_pic
            // 
            this.input_pic.Location = new System.Drawing.Point(714, 54);
            this.input_pic.Name = "input_pic";
            this.input_pic.Size = new System.Drawing.Size(848, 505);
            this.input_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.input_pic.TabIndex = 1;
            this.input_pic.TabStop = false;
            this.input_pic.Visible = false;
            // 
            // path_pic
            // 
            this.path_pic.Location = new System.Drawing.Point(824, 12);
            this.path_pic.Name = "path_pic";
            this.path_pic.Size = new System.Drawing.Size(544, 26);
            this.path_pic.TabIndex = 2;
            // 
            // enc_button
            // 
            this.enc_button.Location = new System.Drawing.Point(992, 605);
            this.enc_button.Name = "enc_button";
            this.enc_button.Size = new System.Drawing.Size(86, 36);
            this.enc_button.TabIndex = 3;
            this.enc_button.Text = "Encrypt";
            this.enc_button.UseVisualStyleBackColor = true;
            this.enc_button.Click += new System.EventHandler(this.enc_button_Click);
            // 
            // enc_key
            // 
            this.enc_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.enc_key.Location = new System.Drawing.Point(1172, 610);
            this.enc_key.Name = "enc_key";
            this.enc_key.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.enc_key.Size = new System.Drawing.Size(196, 26);
            this.enc_key.TabIndex = 4;
            // 
            // decry_button
            // 
            this.decry_button.Location = new System.Drawing.Point(992, 669);
            this.decry_button.Name = "decry_button";
            this.decry_button.Size = new System.Drawing.Size(86, 35);
            this.decry_button.TabIndex = 5;
            this.decry_button.Text = "Decrypt";
            this.decry_button.UseVisualStyleBackColor = true;
            this.decry_button.Click += new System.EventHandler(this.decry_button_Click);
            // 
            // decrypt_key
            // 
            this.decrypt_key.Location = new System.Drawing.Point(1172, 673);
            this.decrypt_key.Name = "decrypt_key";
            this.decrypt_key.Size = new System.Drawing.Size(196, 26);
            this.decrypt_key.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_FINAL_PROJECT.Properties.Resources.stretched_1920_1080_83516;
            this.ClientSize = new System.Drawing.Size(1584, 770);
            this.Controls.Add(this.decrypt_key);
            this.Controls.Add(this.decry_button);
            this.Controls.Add(this.enc_key);
            this.Controls.Add(this.enc_button);
            this.Controls.Add(this.path_pic);
            this.Controls.Add(this.input_pic);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEGNOGRAPHY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox input_pic;
        private System.Windows.Forms.TextBox path_pic;
        private System.Windows.Forms.Button enc_button;
        private System.Windows.Forms.TextBox enc_key;
        private System.Windows.Forms.Button decry_button;
        private System.Windows.Forms.TextBox decrypt_key;
    }
}

