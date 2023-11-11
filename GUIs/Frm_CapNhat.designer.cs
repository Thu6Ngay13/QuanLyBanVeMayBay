namespace QuanLyBanVeMayBay.GUI
{
    partial class Frm_CapNhat
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
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_CapNhat = new System.Windows.Forms.Button();
            this.Dtp_NgayDi = new System.Windows.Forms.DateTimePicker();
            this.Lbl_NgayDi = new System.Windows.Forms.Label();
            this.Pnl_NgayDi = new System.Windows.Forms.Panel();
            this.Lbl_DiemDi = new System.Windows.Forms.Label();
            this.Cbb_DiemDi = new System.Windows.Forms.ComboBox();
            this.Pnl_DiemDi = new System.Windows.Forms.Panel();
            this.Pnl_DiemDen = new System.Windows.Forms.Panel();
            this.Lbl_DiemDen = new System.Windows.Forms.Label();
            this.Cbb_DiemDen = new System.Windows.Forms.ComboBox();
            this.Pnl_TinhTrang = new System.Windows.Forms.Panel();
            this.Lbl_TinhTrang = new System.Windows.Forms.Label();
            this.Cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.Pnl_ChucNang = new System.Windows.Forms.Panel();
            this.Btn_TraCuuChuyenBay = new System.Windows.Forms.Button();
            this.Btn_TraCuuHoaDon = new System.Windows.Forms.Button();
            this.Btn_MuaVe = new System.Windows.Forms.Button();
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.Ptb_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_DangKy = new System.Windows.Forms.Button();
            this.Btn_DangNhap = new System.Windows.Forms.Button();
            this.Pnl_ThongTinChuyenBay = new System.Windows.Forms.Panel();
            this.Pnl_NgayDi.SuspendLayout();
            this.Pnl_DiemDi.SuspendLayout();
            this.Pnl_DiemDen.SuspendLayout();
            this.Pnl_TinhTrang.SuspendLayout();
            this.Pnl_ChucNang.SuspendLayout();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Them
            // 
            this.Btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Them.Location = new System.Drawing.Point(13, 151);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(613, 71);
            this.Btn_Them.TabIndex = 9;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = true;
            // 
            // Btn_CapNhat
            // 
            this.Btn_CapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CapNhat.Location = new System.Drawing.Point(652, 151);
            this.Btn_CapNhat.Name = "Btn_CapNhat";
            this.Btn_CapNhat.Size = new System.Drawing.Size(599, 71);
            this.Btn_CapNhat.TabIndex = 10;
            this.Btn_CapNhat.Text = "Cập nhật";
            this.Btn_CapNhat.UseVisualStyleBackColor = true;
            // 
            // Dtp_NgayDi
            // 
            this.Dtp_NgayDi.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_NgayDi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_NgayDi.Location = new System.Drawing.Point(99, 21);
            this.Dtp_NgayDi.Name = "Dtp_NgayDi";
            this.Dtp_NgayDi.ShowCheckBox = true;
            this.Dtp_NgayDi.Size = new System.Drawing.Size(200, 25);
            this.Dtp_NgayDi.TabIndex = 17;
            this.Dtp_NgayDi.Value = new System.DateTime(2023, 10, 22, 9, 0, 29, 82);
            this.Dtp_NgayDi.ValueChanged += new System.EventHandler(this.change_Value);
            // 
            // Lbl_NgayDi
            // 
            this.Lbl_NgayDi.AutoSize = true;
            this.Lbl_NgayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NgayDi.Location = new System.Drawing.Point(8, 23);
            this.Lbl_NgayDi.Name = "Lbl_NgayDi";
            this.Lbl_NgayDi.Size = new System.Drawing.Size(72, 22);
            this.Lbl_NgayDi.TabIndex = 9;
            this.Lbl_NgayDi.Text = "Ngày đi";
            // 
            // Pnl_NgayDi
            // 
            this.Pnl_NgayDi.Controls.Add(this.Dtp_NgayDi);
            this.Pnl_NgayDi.Controls.Add(this.Lbl_NgayDi);
            this.Pnl_NgayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_NgayDi.Location = new System.Drawing.Point(24, 245);
            this.Pnl_NgayDi.Name = "Pnl_NgayDi";
            this.Pnl_NgayDi.Size = new System.Drawing.Size(301, 65);
            this.Pnl_NgayDi.TabIndex = 16;
            // 
            // Lbl_DiemDi
            // 
            this.Lbl_DiemDi.AutoSize = true;
            this.Lbl_DiemDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiemDi.Location = new System.Drawing.Point(18, 23);
            this.Lbl_DiemDi.Name = "Lbl_DiemDi";
            this.Lbl_DiemDi.Size = new System.Drawing.Size(74, 22);
            this.Lbl_DiemDi.TabIndex = 6;
            this.Lbl_DiemDi.Text = "Điểm đi";
            // 
            // Cbb_DiemDi
            // 
            this.Cbb_DiemDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_DiemDi.FormattingEnabled = true;
            this.Cbb_DiemDi.Location = new System.Drawing.Point(109, 19);
            this.Cbb_DiemDi.Name = "Cbb_DiemDi";
            this.Cbb_DiemDi.Size = new System.Drawing.Size(203, 30);
            this.Cbb_DiemDi.TabIndex = 8;
            this.Cbb_DiemDi.TextChanged += new System.EventHandler(this.change_Value);
            // 
            // Pnl_DiemDi
            // 
            this.Pnl_DiemDi.Controls.Add(this.Lbl_DiemDi);
            this.Pnl_DiemDi.Controls.Add(this.Cbb_DiemDi);
            this.Pnl_DiemDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_DiemDi.Location = new System.Drawing.Point(327, 245);
            this.Pnl_DiemDi.Name = "Pnl_DiemDi";
            this.Pnl_DiemDi.Size = new System.Drawing.Size(316, 65);
            this.Pnl_DiemDi.TabIndex = 17;
            // 
            // Pnl_DiemDen
            // 
            this.Pnl_DiemDen.Controls.Add(this.Lbl_DiemDen);
            this.Pnl_DiemDen.Controls.Add(this.Cbb_DiemDen);
            this.Pnl_DiemDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_DiemDen.Location = new System.Drawing.Point(645, 245);
            this.Pnl_DiemDen.Name = "Pnl_DiemDen";
            this.Pnl_DiemDen.Size = new System.Drawing.Size(319, 65);
            this.Pnl_DiemDen.TabIndex = 14;
            // 
            // Lbl_DiemDen
            // 
            this.Lbl_DiemDen.AutoSize = true;
            this.Lbl_DiemDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiemDen.Location = new System.Drawing.Point(17, 23);
            this.Lbl_DiemDen.Name = "Lbl_DiemDen";
            this.Lbl_DiemDen.Size = new System.Drawing.Size(86, 22);
            this.Lbl_DiemDen.TabIndex = 7;
            this.Lbl_DiemDen.Text = "Điểm đến";
            // 
            // Cbb_DiemDen
            // 
            this.Cbb_DiemDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_DiemDen.FormattingEnabled = true;
            this.Cbb_DiemDen.Location = new System.Drawing.Point(110, 19);
            this.Cbb_DiemDen.Name = "Cbb_DiemDen";
            this.Cbb_DiemDen.Size = new System.Drawing.Size(203, 30);
            this.Cbb_DiemDen.TabIndex = 9;
            this.Cbb_DiemDen.TextChanged += new System.EventHandler(this.change_Value);
            // 
            // Pnl_TinhTrang
            // 
            this.Pnl_TinhTrang.Controls.Add(this.Lbl_TinhTrang);
            this.Pnl_TinhTrang.Controls.Add(this.Cbb_TinhTrang);
            this.Pnl_TinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_TinhTrang.Location = new System.Drawing.Point(966, 245);
            this.Pnl_TinhTrang.Name = "Pnl_TinhTrang";
            this.Pnl_TinhTrang.Size = new System.Drawing.Size(277, 65);
            this.Pnl_TinhTrang.TabIndex = 15;
            // 
            // Lbl_TinhTrang
            // 
            this.Lbl_TinhTrang.AutoSize = true;
            this.Lbl_TinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TinhTrang.Location = new System.Drawing.Point(24, 23);
            this.Lbl_TinhTrang.Name = "Lbl_TinhTrang";
            this.Lbl_TinhTrang.Size = new System.Drawing.Size(90, 22);
            this.Lbl_TinhTrang.TabIndex = 7;
            this.Lbl_TinhTrang.Text = "Tình trạng";
            // 
            // Cbb_TinhTrang
            // 
            this.Cbb_TinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_TinhTrang.FormattingEnabled = true;
            this.Cbb_TinhTrang.Location = new System.Drawing.Point(132, 19);
            this.Cbb_TinhTrang.Name = "Cbb_TinhTrang";
            this.Cbb_TinhTrang.Size = new System.Drawing.Size(124, 30);
            this.Cbb_TinhTrang.TabIndex = 9;
            this.Cbb_TinhTrang.TextChanged += new System.EventHandler(this.change_Value);
            // 
            // Pnl_ChucNang
            // 
            this.Pnl_ChucNang.Controls.Add(this.Btn_TraCuuChuyenBay);
            this.Pnl_ChucNang.Controls.Add(this.Btn_TraCuuHoaDon);
            this.Pnl_ChucNang.Controls.Add(this.Btn_MuaVe);
            this.Pnl_ChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_ChucNang.Location = new System.Drawing.Point(10, 74);
            this.Pnl_ChucNang.Name = "Pnl_ChucNang";
            this.Pnl_ChucNang.Size = new System.Drawing.Size(1241, 71);
            this.Pnl_ChucNang.TabIndex = 20;
            // 
            // Btn_TraCuuChuyenBay
            // 
            this.Btn_TraCuuChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TraCuuChuyenBay.Location = new System.Drawing.Point(839, 0);
            this.Btn_TraCuuChuyenBay.Name = "Btn_TraCuuChuyenBay";
            this.Btn_TraCuuChuyenBay.Size = new System.Drawing.Size(398, 71);
            this.Btn_TraCuuChuyenBay.TabIndex = 2;
            this.Btn_TraCuuChuyenBay.Text = "Tra cứu chuyến bay";
            this.Btn_TraCuuChuyenBay.UseVisualStyleBackColor = true;
            // 
            // Btn_TraCuuHoaDon
            // 
            this.Btn_TraCuuHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TraCuuHoaDon.Location = new System.Drawing.Point(421, 0);
            this.Btn_TraCuuHoaDon.Name = "Btn_TraCuuHoaDon";
            this.Btn_TraCuuHoaDon.Size = new System.Drawing.Size(398, 71);
            this.Btn_TraCuuHoaDon.TabIndex = 1;
            this.Btn_TraCuuHoaDon.Text = "Tra cứu hóa đơn";
            this.Btn_TraCuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // Btn_MuaVe
            // 
            this.Btn_MuaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MuaVe.Location = new System.Drawing.Point(3, 0);
            this.Btn_MuaVe.Name = "Btn_MuaVe";
            this.Btn_MuaVe.Size = new System.Drawing.Size(398, 71);
            this.Btn_MuaVe.TabIndex = 0;
            this.Btn_MuaVe.Text = "Mua vé";
            this.Btn_MuaVe.UseVisualStyleBackColor = true;
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_Header.Controls.Add(this.Ptb_Logo);
            this.Pnl_Header.Controls.Add(this.Btn_DangKy);
            this.Pnl_Header.Controls.Add(this.Btn_DangNhap);
            this.Pnl_Header.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_Header.Location = new System.Drawing.Point(10, 3);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1241, 65);
            this.Pnl_Header.TabIndex = 19;
            // 
            // Ptb_Logo
            // 
            this.Ptb_Logo.Location = new System.Drawing.Point(6, 3);
            this.Ptb_Logo.Name = "Ptb_Logo";
            this.Ptb_Logo.Size = new System.Drawing.Size(953, 59);
            this.Ptb_Logo.TabIndex = 3;
            this.Ptb_Logo.TabStop = false;
            // 
            // Btn_DangKy
            // 
            this.Btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DangKy.Location = new System.Drawing.Point(1110, 12);
            this.Btn_DangKy.Name = "Btn_DangKy";
            this.Btn_DangKy.Size = new System.Drawing.Size(119, 36);
            this.Btn_DangKy.TabIndex = 2;
            this.Btn_DangKy.Text = "Đăng ký";
            this.Btn_DangKy.UseVisualStyleBackColor = true;
            // 
            // Btn_DangNhap
            // 
            this.Btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DangNhap.Location = new System.Drawing.Point(965, 12);
            this.Btn_DangNhap.Name = "Btn_DangNhap";
            this.Btn_DangNhap.Size = new System.Drawing.Size(119, 36);
            this.Btn_DangNhap.TabIndex = 1;
            this.Btn_DangNhap.Text = "Đăng nhập";
            this.Btn_DangNhap.UseVisualStyleBackColor = true;
            // 
            // Pnl_ThongTinChuyenBay
            // 
            this.Pnl_ThongTinChuyenBay.AutoScroll = true;
            this.Pnl_ThongTinChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_ThongTinChuyenBay.Location = new System.Drawing.Point(10, 341);
            this.Pnl_ThongTinChuyenBay.Name = "Pnl_ThongTinChuyenBay";
            this.Pnl_ThongTinChuyenBay.Size = new System.Drawing.Size(1241, 316);
            this.Pnl_ThongTinChuyenBay.TabIndex = 21;
            // 
            // Frm_CapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 669);
            this.Controls.Add(this.Pnl_ThongTinChuyenBay);
            this.Controls.Add(this.Pnl_ChucNang);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.Pnl_TinhTrang);
            this.Controls.Add(this.Pnl_DiemDen);
            this.Controls.Add(this.Pnl_DiemDi);
            this.Controls.Add(this.Pnl_NgayDi);
            this.Controls.Add(this.Btn_CapNhat);
            this.Controls.Add(this.Btn_Them);
            this.Name = "Frm_CapNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CapNhat";
            this.Load += new System.EventHandler(this.Frm_CapNhat_Load);
            this.Pnl_NgayDi.ResumeLayout(false);
            this.Pnl_NgayDi.PerformLayout();
            this.Pnl_DiemDi.ResumeLayout(false);
            this.Pnl_DiemDi.PerformLayout();
            this.Pnl_DiemDen.ResumeLayout(false);
            this.Pnl_DiemDen.PerformLayout();
            this.Pnl_TinhTrang.ResumeLayout(false);
            this.Pnl_TinhTrang.PerformLayout();
            this.Pnl_ChucNang.ResumeLayout(false);
            this.Pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Button Btn_CapNhat;
        private System.Windows.Forms.DateTimePicker Dtp_NgayDi;
        private System.Windows.Forms.Label Lbl_NgayDi;
        private System.Windows.Forms.Panel Pnl_NgayDi;
        private System.Windows.Forms.Label Lbl_DiemDi;
        private System.Windows.Forms.ComboBox Cbb_DiemDi;
        private System.Windows.Forms.Panel Pnl_DiemDi;
        private System.Windows.Forms.Panel Pnl_DiemDen;
        private System.Windows.Forms.Label Lbl_DiemDen;
        private System.Windows.Forms.ComboBox Cbb_DiemDen;
        private System.Windows.Forms.Panel Pnl_TinhTrang;
        private System.Windows.Forms.Label Lbl_TinhTrang;
        private System.Windows.Forms.ComboBox Cbb_TinhTrang;
        private System.Windows.Forms.Panel Pnl_ChucNang;
        private System.Windows.Forms.Button Btn_TraCuuChuyenBay;
        private System.Windows.Forms.Button Btn_TraCuuHoaDon;
        private System.Windows.Forms.Button Btn_MuaVe;
        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.PictureBox Ptb_Logo;
        private System.Windows.Forms.Button Btn_DangKy;
        private System.Windows.Forms.Button Btn_DangNhap;
        private System.Windows.Forms.Panel Pnl_ThongTinChuyenBay;
    }
}