﻿namespace PRL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel_login = new Panel();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            txtMK = new TextBox();
            pictureBox1 = new PictureBox();
            txtTK = new TextBox();
            label3 = new Label();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.FromArgb(190, 0, 0);
            panel_login.Controls.Add(btnLogin);
            panel_login.Controls.Add(pictureBox2);
            panel_login.Controls.Add(txtMK);
            panel_login.Controls.Add(pictureBox1);
            panel_login.Controls.Add(txtTK);
            panel_login.Controls.Add(label3);
            panel_login.Location = new Point(15, 15);
            panel_login.Margin = new Padding(4);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(754, 679);
            panel_login.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(189, 341);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(152, 52);
            btnLogin.TabIndex = 59;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(391, 240);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.FromArgb(217, 217, 217);
            txtMK.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.Location = new Point(72, 240);
            txtMK.Margin = new Padding(4);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(376, 53);
            txtMK.TabIndex = 57;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox1.BackgroundImage = Properties.Resources.solar_user_broken;
            pictureBox1.Location = new Point(391, 147);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.FromArgb(217, 217, 217);
            txtTK.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTK.Location = new Point(72, 136);
            txtTK.Margin = new Padding(4);
            txtTK.Multiline = true;
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(376, 53);
            txtTK.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(189, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 41);
            label3.TabIndex = 52;
            label3.Text = "Đăng Nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(539, 525);
            Controls.Add(panel_login);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_login;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox txtMK;
        private PictureBox pictureBox1;
        private TextBox txtTK;
        private Button btnLogin;
    }
}