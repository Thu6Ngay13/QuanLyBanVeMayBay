namespace QuanLyBanVeMayBay.UC
{
    partial class UC_ThongTinChuyenBayDeXuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_ThongTinDeXuat = new System.Windows.Forms.Panel();
            this.Lbl_GiaTien = new System.Windows.Forms.Label();
            this.Lbl_NgayDi = new System.Windows.Forms.Label();
            this.Lbl_DiemDen = new System.Windows.Forms.Label();
            this.Lbl_DiemDi = new System.Windows.Forms.Label();
            this.Pnl_ThongTinDeXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_ThongTinDeXuat
            // 
            this.Pnl_ThongTinDeXuat.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_ThongTinDeXuat.Controls.Add(this.Lbl_GiaTien);
            this.Pnl_ThongTinDeXuat.Controls.Add(this.Lbl_NgayDi);
            this.Pnl_ThongTinDeXuat.Controls.Add(this.Lbl_DiemDen);
            this.Pnl_ThongTinDeXuat.Controls.Add(this.Lbl_DiemDi);
            this.Pnl_ThongTinDeXuat.Location = new System.Drawing.Point(3, 230);
            this.Pnl_ThongTinDeXuat.Name = "Pnl_ThongTinDeXuat";
            this.Pnl_ThongTinDeXuat.Size = new System.Drawing.Size(289, 200);
            this.Pnl_ThongTinDeXuat.TabIndex = 0;
            this.Pnl_ThongTinDeXuat.Click += new System.EventHandler(this.Pnl_ThongTinDeXuat_Click);
            // 
            // Lbl_GiaTien
            // 
            this.Lbl_GiaTien.AutoSize = true;
            this.Lbl_GiaTien.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_GiaTien.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_GiaTien.Location = new System.Drawing.Point(152, 153);
            this.Lbl_GiaTien.Name = "Lbl_GiaTien";
            this.Lbl_GiaTien.Size = new System.Drawing.Size(107, 22);
            this.Lbl_GiaTien.TabIndex = 14;
            this.Lbl_GiaTien.Text = "Giá tiền min";
            this.Lbl_GiaTien.Click += new System.EventHandler(this.Pnl_ThongTinDeXuat_Click);
            // 
            // Lbl_NgayDi
            // 
            this.Lbl_NgayDi.AutoSize = true;
            this.Lbl_NgayDi.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NgayDi.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_NgayDi.Location = new System.Drawing.Point(30, 110);
            this.Lbl_NgayDi.Name = "Lbl_NgayDi";
            this.Lbl_NgayDi.Size = new System.Drawing.Size(72, 22);
            this.Lbl_NgayDi.TabIndex = 12;
            this.Lbl_NgayDi.Text = "Ngày đi";
            this.Lbl_NgayDi.Click += new System.EventHandler(this.Pnl_ThongTinDeXuat_Click);
            // 
            // Lbl_DiemDen
            // 
            this.Lbl_DiemDen.AutoSize = true;
            this.Lbl_DiemDen.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_DiemDen.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_DiemDen.Location = new System.Drawing.Point(30, 67);
            this.Lbl_DiemDen.Name = "Lbl_DiemDen";
            this.Lbl_DiemDen.Size = new System.Drawing.Size(86, 22);
            this.Lbl_DiemDen.TabIndex = 11;
            this.Lbl_DiemDen.Text = "Điểm đến";
            this.Lbl_DiemDen.Click += new System.EventHandler(this.Pnl_ThongTinDeXuat_Click);
            // 
            // Lbl_DiemDi
            // 
            this.Lbl_DiemDi.AutoSize = true;
            this.Lbl_DiemDi.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_DiemDi.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_DiemDi.Location = new System.Drawing.Point(30, 24);
            this.Lbl_DiemDi.Name = "Lbl_DiemDi";
            this.Lbl_DiemDi.Size = new System.Drawing.Size(74, 22);
            this.Lbl_DiemDi.TabIndex = 10;
            this.Lbl_DiemDi.Text = "Điểm đi";
            this.Lbl_DiemDi.Click += new System.EventHandler(this.Pnl_ThongTinDeXuat_Click);
            // 
            // UC_ChuyenBayDeXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanVeMayBay.Properties.Resources.ImageDeXuatChuyenBay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Pnl_ThongTinDeXuat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ChuyenBayDeXuat";
            this.Size = new System.Drawing.Size(295, 433);
            this.Click += new System.EventHandler(this.UC_ChuyenBayDeXuat_Click);
            this.Pnl_ThongTinDeXuat.ResumeLayout(false);
            this.Pnl_ThongTinDeXuat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ThongTinDeXuat;
        public System.Windows.Forms.Label Lbl_GiaTien;
        public System.Windows.Forms.Label Lbl_NgayDi;
        public System.Windows.Forms.Label Lbl_DiemDen;
        public System.Windows.Forms.Label Lbl_DiemDi;
    }
}
