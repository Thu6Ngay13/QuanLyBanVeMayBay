﻿namespace QuanLyBanVeMayBay.GUIs
{
    partial class Frm_Login
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
            this.Tab_Login_Register = new System.Windows.Forms.TabControl();
            this.Tab_SignIn = new System.Windows.Forms.TabPage();
            this.Txt_Password_DNhap = new System.Windows.Forms.TextBox();
            this.Txt_Username_DNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_DangNhap = new System.Windows.Forms.Button();
            this.Tab_SignUp = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_RePassword_DKy = new System.Windows.Forms.TextBox();
            this.Txt_Password_DKy = new System.Windows.Forms.TextBox();
            this.Btn_DangKy = new System.Windows.Forms.Button();
            this.Txt_Username_DKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Img_HinhNen = new System.Windows.Forms.Panel();
            this.Tab_Login_Register.SuspendLayout();
            this.Tab_SignIn.SuspendLayout();
            this.Tab_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Login_Register
            // 
            this.Tab_Login_Register.Controls.Add(this.Tab_SignIn);
            this.Tab_Login_Register.Controls.Add(this.Tab_SignUp);
            this.Tab_Login_Register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tab_Login_Register.Location = new System.Drawing.Point(761, -1);
            this.Tab_Login_Register.Name = "Tab_Login_Register";
            this.Tab_Login_Register.RightToLeftLayout = true;
            this.Tab_Login_Register.SelectedIndex = 0;
            this.Tab_Login_Register.Size = new System.Drawing.Size(499, 675);
            this.Tab_Login_Register.TabIndex = 0;
            // 
            // Tab_SignIn
            // 
            this.Tab_SignIn.Controls.Add(this.Txt_Password_DNhap);
            this.Tab_SignIn.Controls.Add(this.Txt_Username_DNhap);
            this.Tab_SignIn.Controls.Add(this.label3);
            this.Tab_SignIn.Controls.Add(this.label2);
            this.Tab_SignIn.Controls.Add(this.label1);
            this.Tab_SignIn.Controls.Add(this.Btn_DangNhap);
            this.Tab_SignIn.Location = new System.Drawing.Point(4, 31);
            this.Tab_SignIn.Name = "Tab_SignIn";
            this.Tab_SignIn.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SignIn.Size = new System.Drawing.Size(491, 640);
            this.Tab_SignIn.TabIndex = 0;
            this.Tab_SignIn.Text = "SIGN IN";
            this.Tab_SignIn.UseVisualStyleBackColor = true;
            // 
            // Txt_Password_DNhap
            // 
            this.Txt_Password_DNhap.Location = new System.Drawing.Point(172, 185);
            this.Txt_Password_DNhap.Name = "Txt_Password_DNhap";
            this.Txt_Password_DNhap.Size = new System.Drawing.Size(249, 30);
            this.Txt_Password_DNhap.TabIndex = 5;
            // 
            // Txt_Username_DNhap
            // 
            this.Txt_Username_DNhap.Location = new System.Drawing.Point(172, 109);
            this.Txt_Username_DNhap.Name = "Txt_Username_DNhap";
            this.Txt_Username_DNhap.Size = new System.Drawing.Size(249, 30);
            this.Txt_Username_DNhap.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(170, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập";
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DangNhap.Location = new System.Drawing.Point(314, 242);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(112, 40);
            this.Btn_DangNhap.TabIndex = 0;
            this.Btn_DangNhap.Text = "Đăng nhập";
            this.Btn_DangNhap.UseVisualStyleBackColor = true;
            this.Btn_DangNhap.Click += new System.EventHandler(this.Btn_DangNhap_Click);
            // 
            // Tab_SignUp
            // 
            this.Tab_SignUp.Controls.Add(this.label7);
            this.Tab_SignUp.Controls.Add(this.label6);
            this.Tab_SignUp.Controls.Add(this.Txt_RePassword_DKy);
            this.Tab_SignUp.Controls.Add(this.Txt_Password_DKy);
            this.Tab_SignUp.Controls.Add(this.Btn_DangKy);
            this.Tab_SignUp.Controls.Add(this.Txt_Username_DKy);
            this.Tab_SignUp.Controls.Add(this.label5);
            this.Tab_SignUp.Controls.Add(this.label4);
            this.Tab_SignUp.Location = new System.Drawing.Point(4, 31);
            this.Tab_SignUp.Name = "Tab_SignUp";
            this.Tab_SignUp.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SignUp.Size = new System.Drawing.Size(491, 640);
            this.Tab_SignUp.TabIndex = 1;
            this.Tab_SignUp.Text = "SIGN UP";
            this.Tab_SignUp.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Retype password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password: ";
            // 
            // Txt_RePassword_DKy
            // 
            this.Txt_RePassword_DKy.Location = new System.Drawing.Point(202, 227);
            this.Txt_RePassword_DKy.Name = "Txt_RePassword_DKy";
            this.Txt_RePassword_DKy.Size = new System.Drawing.Size(260, 30);
            this.Txt_RePassword_DKy.TabIndex = 7;
            // 
            // Txt_Password_DKy
            // 
            this.Txt_Password_DKy.Location = new System.Drawing.Point(202, 164);
            this.Txt_Password_DKy.Name = "Txt_Password_DKy";
            this.Txt_Password_DKy.Size = new System.Drawing.Size(260, 30);
            this.Txt_Password_DKy.TabIndex = 6;
            // 
            // Btn_DangKy
            // 
            this.Btn_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DangKy.Location = new System.Drawing.Point(347, 289);
            this.Btn_DangKy.Name = "Btn_DangKy";
            this.Btn_DangKy.Size = new System.Drawing.Size(115, 44);
            this.Btn_DangKy.TabIndex = 5;
            this.Btn_DangKy.Text = "Đăng ký";
            this.Btn_DangKy.UseVisualStyleBackColor = true;
            this.Btn_DangKy.Click += new System.EventHandler(this.Btn_DangKy_Click);
            // 
            // Txt_Username_DKy
            // 
            this.Txt_Username_DKy.Location = new System.Drawing.Point(202, 101);
            this.Txt_Username_DKy.Name = "Txt_Username_DKy";
            this.Txt_Username_DKy.Size = new System.Drawing.Size(260, 30);
            this.Txt_Username_DKy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(195, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đăng Ký";
            // 
            // Img_HinhNen
            // 
            this.Img_HinhNen.BackgroundImage = global::QuanLyBanVeMayBay.Properties.Resources.HinhNen;
            this.Img_HinhNen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img_HinhNen.Location = new System.Drawing.Point(2, -1);
            this.Img_HinhNen.Name = "Img_HinhNen";
            this.Img_HinhNen.Size = new System.Drawing.Size(756, 675);
            this.Img_HinhNen.TabIndex = 1;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Img_HinhNen);
            this.Controls.Add(this.Tab_Login_Register);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.Tab_Login_Register.ResumeLayout(false);
            this.Tab_SignIn.ResumeLayout(false);
            this.Tab_SignIn.PerformLayout();
            this.Tab_SignUp.ResumeLayout(false);
            this.Tab_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl Tab_Login_Register;
        private System.Windows.Forms.TabPage Tab_SignIn;
        private System.Windows.Forms.Button Btn_DangNhap;
        private System.Windows.Forms.TabPage Tab_SignUp;
        private System.Windows.Forms.TextBox Txt_Password_DNhap;
        private System.Windows.Forms.TextBox Txt_Username_DNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_RePassword_DKy;
        private System.Windows.Forms.TextBox Txt_Password_DKy;
        private System.Windows.Forms.Button Btn_DangKy;
        private System.Windows.Forms.TextBox Txt_Username_DKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Img_HinhNen;
    }
}