using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.UC;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_QuanLyNguoiDung : Form
    {
        public Frm_QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            BLL_HoaDon bll = new BLL_HoaDon();
            string error = "";

            DataSet dataset = bll.timkiem_LichSuGiaoDich(1, -1, ref error);
            DataTable datatable = dataset.Tables[0];

            this.SuspendLayout();
            this.Pnl_ThongTinHoaDon.SuspendLayout();
            this.Pnl_DanhSachHoaDon.SuspendLayout();

            for(int i = 0; i < 10; ++i)
            {
                UC_ThongTinGiaoDich hoadon = new UC_ThongTinGiaoDich();
                hoadon.Location = new System.Drawing.Point(1, 5 + 92 * i);

                this.Pnl_DanhSachHoaDon.Controls.Add(hoadon);
            }


            this.ResumeLayout(false);
            this.Pnl_ThongTinHoaDon.ResumeLayout(false);
            this.Pnl_DanhSachHoaDon.ResumeLayout(false);
        }
    }
}
