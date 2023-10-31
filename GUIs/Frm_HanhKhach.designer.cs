namespace QuanLyBanVeMayBay.GUI
{
    partial class Frm_HanhKhach
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
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pnl_TreEm = new System.Windows.Forms.Panel();
            this.Lbl_TreEm = new System.Windows.Forms.Label();
            this.Pnl_NguoiLon = new System.Windows.Forms.Panel();
            this.Lbl_NguoiLon = new System.Windows.Forms.Label();
            this.Btn_Chon = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Pnl_TreEm.SuspendLayout();
            this.Pnl_NguoiLon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(331, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(31, 31);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pnl_TreEm
            // 
            this.Pnl_TreEm.Controls.Add(this.numericUpDown2);
            this.Pnl_TreEm.Controls.Add(this.Lbl_TreEm);
            this.Pnl_TreEm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_TreEm.Location = new System.Drawing.Point(2, 134);
            this.Pnl_TreEm.Name = "Pnl_TreEm";
            this.Pnl_TreEm.Size = new System.Drawing.Size(360, 89);
            this.Pnl_TreEm.TabIndex = 2;
            // 
            // Lbl_TreEm
            // 
            this.Lbl_TreEm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TreEm.Location = new System.Drawing.Point(32, 34);
            this.Lbl_TreEm.Name = "Lbl_TreEm";
            this.Lbl_TreEm.Size = new System.Drawing.Size(75, 28);
            this.Lbl_TreEm.TabIndex = 1;
            this.Lbl_TreEm.Text = "Trẻ em";
            // 
            // Pnl_NguoiLon
            // 
            this.Pnl_NguoiLon.Controls.Add(this.numericUpDown1);
            this.Pnl_NguoiLon.Controls.Add(this.Lbl_NguoiLon);
            this.Pnl_NguoiLon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_NguoiLon.Location = new System.Drawing.Point(2, 39);
            this.Pnl_NguoiLon.Name = "Pnl_NguoiLon";
            this.Pnl_NguoiLon.Size = new System.Drawing.Size(360, 89);
            this.Pnl_NguoiLon.TabIndex = 1;
            // 
            // Lbl_NguoiLon
            // 
            this.Lbl_NguoiLon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NguoiLon.Location = new System.Drawing.Point(32, 34);
            this.Lbl_NguoiLon.Name = "Lbl_NguoiLon";
            this.Lbl_NguoiLon.Size = new System.Drawing.Size(98, 28);
            this.Lbl_NguoiLon.TabIndex = 0;
            this.Lbl_NguoiLon.Text = "Người lớn";
            // 
            // Btn_Chon
            // 
            this.Btn_Chon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Chon.Location = new System.Drawing.Point(151, 229);
            this.Btn_Chon.Name = "Btn_Chon";
            this.Btn_Chon.Size = new System.Drawing.Size(75, 34);
            this.Btn_Chon.TabIndex = 3;
            this.Btn_Chon.Text = "Chọn";
            this.Btn_Chon.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(178, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(178, 32);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown2.TabIndex = 2;
            // 
            // Frm_HanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 275);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Chon);
            this.Controls.Add(this.Pnl_TreEm);
            this.Controls.Add(this.Pnl_NguoiLon);
            this.Controls.Add(this.Btn_Close);
            this.MinimizeBox = false;
            this.Name = "Frm_HanhKhach";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hành Khách";
            this.Pnl_TreEm.ResumeLayout(false);
            this.Pnl_NguoiLon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel Pnl_TreEm;
        private System.Windows.Forms.Panel Pnl_NguoiLon;
        private System.Windows.Forms.Label Lbl_NguoiLon;
        private System.Windows.Forms.Label Lbl_TreEm;
        private System.Windows.Forms.Button Btn_Chon;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}