namespace QuanLyBanVeMayBay.GUIs
{
    partial class Frm_DoanhThu
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
            this.Pnl_Body = new System.Windows.Forms.Panel();
            this.pnl_DoanhThu_LoiNhuan = new System.Windows.Forms.Panel();
            this.Btn_LoiNhuan = new System.Windows.Forms.Button();
            this.Btn_DoanhThu = new System.Windows.Forms.Button();
            this.Cmb_Nam = new System.Windows.Forms.ComboBox();
            this.Cmb_Thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Body
            // 
            this.Pnl_Body.Controls.Add(this.pnl_DoanhThu_LoiNhuan);
            this.Pnl_Body.Controls.Add(this.Btn_LoiNhuan);
            this.Pnl_Body.Controls.Add(this.Btn_DoanhThu);
            this.Pnl_Body.Controls.Add(this.Cmb_Nam);
            this.Pnl_Body.Controls.Add(this.Cmb_Thang);
            this.Pnl_Body.Controls.Add(this.label2);
            this.Pnl_Body.Controls.Add(this.label1);
            this.Pnl_Body.Location = new System.Drawing.Point(3, 12);
            this.Pnl_Body.Name = "Pnl_Body";
            this.Pnl_Body.Size = new System.Drawing.Size(1260, 660);
            this.Pnl_Body.TabIndex = 4;
            // 
            // pnl_DoanhThu_LoiNhuan
            // 
            this.pnl_DoanhThu_LoiNhuan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_DoanhThu_LoiNhuan.Location = new System.Drawing.Point(3, 58);
            this.pnl_DoanhThu_LoiNhuan.Name = "pnl_DoanhThu_LoiNhuan";
            this.pnl_DoanhThu_LoiNhuan.Size = new System.Drawing.Size(1244, 599);
            this.pnl_DoanhThu_LoiNhuan.TabIndex = 5;
            // 
            // Btn_LoiNhuan
            // 
            this.Btn_LoiNhuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LoiNhuan.Location = new System.Drawing.Point(656, 7);
            this.Btn_LoiNhuan.Name = "Btn_LoiNhuan";
            this.Btn_LoiNhuan.Size = new System.Drawing.Size(137, 45);
            this.Btn_LoiNhuan.TabIndex = 4;
            this.Btn_LoiNhuan.Text = "Lợi nhuận";
            this.Btn_LoiNhuan.UseVisualStyleBackColor = true;
            // 
            // Btn_DoanhThu
            // 
            this.Btn_DoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DoanhThu.Location = new System.Drawing.Point(488, 7);
            this.Btn_DoanhThu.Name = "Btn_DoanhThu";
            this.Btn_DoanhThu.Size = new System.Drawing.Size(137, 45);
            this.Btn_DoanhThu.TabIndex = 3;
            this.Btn_DoanhThu.Text = "Doanh thu";
            this.Btn_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // Cmb_Nam
            // 
            this.Cmb_Nam.FormattingEnabled = true;
            this.Cmb_Nam.Items.AddRange(new object[] {
            "2022",
            "2023"});
            this.Cmb_Nam.Location = new System.Drawing.Point(292, 11);
            this.Cmb_Nam.Name = "Cmb_Nam";
            this.Cmb_Nam.Size = new System.Drawing.Size(121, 30);
            this.Cmb_Nam.TabIndex = 3;
            // 
            // Cmb_Thang
            // 
            this.Cmb_Thang.FormattingEnabled = true;
            this.Cmb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Cmb_Thang.Location = new System.Drawing.Point(85, 11);
            this.Cmb_Thang.Name = "Cmb_Thang";
            this.Cmb_Thang.Size = new System.Drawing.Size(121, 30);
            this.Cmb_Thang.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // Frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Pnl_Body);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.Pnl_Body.ResumeLayout(false);
            this.Pnl_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Body;
        private System.Windows.Forms.Button Btn_DoanhThu;
        private System.Windows.Forms.ComboBox Cmb_Nam;
        private System.Windows.Forms.ComboBox Cmb_Thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_LoiNhuan;
        private System.Windows.Forms.Panel pnl_DoanhThu_LoiNhuan;
    }
}