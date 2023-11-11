namespace QuanLyBanVeMayBay.GUI
{
    partial class Frm_ThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.Pnl_NganHang = new System.Windows.Forms.Panel();
            this.Btn_Xong = new System.Windows.Forms.Button();
            this.Lbl_NganHang3 = new System.Windows.Forms.Label();
            this.Lbl_NganHang2 = new System.Windows.Forms.Label();
            this.Lbl_NganHang1 = new System.Windows.Forms.Label();
            this.Lbl_ThoiGianThanhToan = new System.Windows.Forms.Label();
            this.Tmr_ThoiGianConLai = new System.Windows.Forms.Timer(this.components);
            this.Pnl_ThongTinKhachHang = new System.Windows.Forms.Panel();
            this.uC_ThongTinTongTien1 = new QuanLyBanVeMayBay.UC.UC_ThongTinTongTien();
            this.uC_ThongTinChieuBay2 = new QuanLyBanVeMayBay.UC.UC_ThongTinChieuBay();
            this.uC_ThongTinChieuBay1 = new QuanLyBanVeMayBay.UC.UC_ThongTinChieuBay();
            this.Pnl_NganHang.SuspendLayout();
            this.Pnl_ThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_NganHang
            // 
            this.Pnl_NganHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_NganHang.Controls.Add(this.Btn_Xong);
            this.Pnl_NganHang.Controls.Add(this.Lbl_NganHang3);
            this.Pnl_NganHang.Controls.Add(this.Lbl_NganHang2);
            this.Pnl_NganHang.Controls.Add(this.Lbl_NganHang1);
            this.Pnl_NganHang.Controls.Add(this.Lbl_ThoiGianThanhToan);
            this.Pnl_NganHang.Location = new System.Drawing.Point(12, 12);
            this.Pnl_NganHang.Name = "Pnl_NganHang";
            this.Pnl_NganHang.Size = new System.Drawing.Size(756, 652);
            this.Pnl_NganHang.TabIndex = 0;
            // 
            // Btn_Xong
            // 
            this.Btn_Xong.Location = new System.Drawing.Point(298, 405);
            this.Btn_Xong.Name = "Btn_Xong";
            this.Btn_Xong.Size = new System.Drawing.Size(119, 36);
            this.Btn_Xong.TabIndex = 4;
            this.Btn_Xong.Text = "Xong";
            this.Btn_Xong.UseVisualStyleBackColor = true;
            this.Btn_Xong.Click += new System.EventHandler(this.Btn_Xong_Click);
            // 
            // Lbl_NganHang3
            // 
            this.Lbl_NganHang3.Location = new System.Drawing.Point(5, 272);
            this.Lbl_NganHang3.Name = "Lbl_NganHang3";
            this.Lbl_NganHang3.Size = new System.Drawing.Size(748, 95);
            this.Lbl_NganHang3.TabIndex = 3;
            this.Lbl_NganHang3.Text = "Ngân hàng: CCC \n STK: ZZZ.ZZZ.ZZZ \n Đơn vị thụ hưởng: HANG HANG KHONG UTE";
            this.Lbl_NganHang3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_NganHang2
            // 
            this.Lbl_NganHang2.Location = new System.Drawing.Point(5, 139);
            this.Lbl_NganHang2.Name = "Lbl_NganHang2";
            this.Lbl_NganHang2.Size = new System.Drawing.Size(748, 95);
            this.Lbl_NganHang2.TabIndex = 2;
            this.Lbl_NganHang2.Text = "Ngân hàng: BBB \n STK: YYY.YYY.YYY \n Đơn vị thụ hưởng: HANG HANG KHONG UTE";
            this.Lbl_NganHang2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_NganHang1
            // 
            this.Lbl_NganHang1.Location = new System.Drawing.Point(5, 6);
            this.Lbl_NganHang1.Name = "Lbl_NganHang1";
            this.Lbl_NganHang1.Size = new System.Drawing.Size(748, 95);
            this.Lbl_NganHang1.TabIndex = 1;
            this.Lbl_NganHang1.Text = "Ngân hàng: AAA \n STK: XXX.XXX.XXX \n Đơn vị thụ hưởng: HANG HANG KHONG UTE";
            this.Lbl_NganHang1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ThoiGianThanhToan
            // 
            this.Lbl_ThoiGianThanhToan.AutoSize = true;
            this.Lbl_ThoiGianThanhToan.Location = new System.Drawing.Point(6, 624);
            this.Lbl_ThoiGianThanhToan.Name = "Lbl_ThoiGianThanhToan";
            this.Lbl_ThoiGianThanhToan.Size = new System.Drawing.Size(56, 22);
            this.Lbl_ThoiGianThanhToan.TabIndex = 0;
            this.Lbl_ThoiGianThanhToan.Text = "10:00";
            // 
            // Tmr_ThoiGianConLai
            // 
            this.Tmr_ThoiGianConLai.Enabled = true;
            this.Tmr_ThoiGianConLai.Interval = 1000;
            this.Tmr_ThoiGianConLai.Tick += new System.EventHandler(this.Tmr_ThoiGianThanhToan_Tick);
            // 
            // Pnl_ThongTinKhachHang
            // 
            this.Pnl_ThongTinKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_ThongTinKhachHang.Controls.Add(this.uC_ThongTinTongTien1);
            this.Pnl_ThongTinKhachHang.Controls.Add(this.uC_ThongTinChieuBay2);
            this.Pnl_ThongTinKhachHang.Controls.Add(this.uC_ThongTinChieuBay1);
            this.Pnl_ThongTinKhachHang.Location = new System.Drawing.Point(774, 12);
            this.Pnl_ThongTinKhachHang.Name = "Pnl_ThongTinKhachHang";
            this.Pnl_ThongTinKhachHang.Size = new System.Drawing.Size(471, 652);
            this.Pnl_ThongTinKhachHang.TabIndex = 1;
            // 
            // uC_ThongTinTongTien1
            // 
            this.uC_ThongTinTongTien1.BackColor = System.Drawing.Color.Beige;
            this.uC_ThongTinTongTien1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinTongTien1.Location = new System.Drawing.Point(5, 311);
            this.uC_ThongTinTongTien1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_ThongTinTongTien1.Name = "uC_ThongTinTongTien1";
            this.uC_ThongTinTongTien1.Size = new System.Drawing.Size(461, 196);
            this.uC_ThongTinTongTien1.TabIndex = 6;
            // 
            // uC_ThongTinChieuBay2
            // 
            this.uC_ThongTinChieuBay2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinChieuBay2.Location = new System.Drawing.Point(5, 158);
            this.uC_ThongTinChieuBay2.Margin = new System.Windows.Forms.Padding(4);
            this.uC_ThongTinChieuBay2.Name = "uC_ThongTinChieuBay2";
            this.uC_ThongTinChieuBay2.Size = new System.Drawing.Size(461, 147);
            this.uC_ThongTinChieuBay2.TabIndex = 5;
            // 
            // uC_ThongTinChieuBay1
            // 
            this.uC_ThongTinChieuBay1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThongTinChieuBay1.Location = new System.Drawing.Point(5, 5);
            this.uC_ThongTinChieuBay1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_ThongTinChieuBay1.Name = "uC_ThongTinChieuBay1";
            this.uC_ThongTinChieuBay1.Size = new System.Drawing.Size(461, 147);
            this.uC_ThongTinChieuBay1.TabIndex = 4;
            // 
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Pnl_ThongTinKhachHang);
            this.Controls.Add(this.Pnl_NganHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThanhToan";
            this.Pnl_NganHang.ResumeLayout(false);
            this.Pnl_NganHang.PerformLayout();
            this.Pnl_ThongTinKhachHang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_NganHang;
        private System.Windows.Forms.Timer Tmr_ThoiGianConLai;
        private System.Windows.Forms.Panel Pnl_ThongTinKhachHang;
        private System.Windows.Forms.Label Lbl_ThoiGianThanhToan;
        private System.Windows.Forms.Label Lbl_NganHang1;
        private System.Windows.Forms.Label Lbl_NganHang2;
        private System.Windows.Forms.Label Lbl_NganHang3;
        private System.Windows.Forms.Button Btn_Xong;
        private UC.UC_ThongTinChieuBay uC_ThongTinChieuBay2;
        private UC.UC_ThongTinChieuBay uC_ThongTinChieuBay1;
        private UC.UC_ThongTinTongTien uC_ThongTinTongTien1;
    }
}