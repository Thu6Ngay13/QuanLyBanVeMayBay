using QuanLyBanVeMayBay.BLL;
using System;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_ThanhToan : Form
    {
        private int ThoiGianConLai = 600;

        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        private void Tmr_ThoiGianThanhToan_Tick(object sender, System.EventArgs e)
        {
            --ThoiGianConLai;
            Lbl_ThoiGianThanhToan.Text =
                (ThoiGianConLai / 60).ToString() + ":" + (ThoiGianConLai % 60);
            if (ThoiGianConLai == 0)
                this.Tmr_ThoiGianConLai.Stop();
        }

        private void Btn_Xong_Click(object sender, EventArgs e)
        {
            int mahoadon = khoitao_HoaDon();
            int manguoilon = them_KhachHangNguoiLon(
                "Nguyen Van A",
                "Nam",
                new DateTime(1985, 01, 01),
                "0987654321",
                "nguyenvana@example.com",
                "Hanoi",
                1,
                1,
                mahoadon);
            int matreem = them_KhachHangTreEm(
                "Nguyen Van X",
                "Nam",
                new DateTime(2010, 02, 15),
                4,
                3,
                mahoadon);
            bool success1 = them_ThongTinNguoiDungMuaVe(1, 1);
            bool success2 = them_NguoiLonQuanLyTreEm(manguoilon, matreem);
        }

        public int khoitao_HoaDon()
        {
            BLL_HoaDon bll = new BLL_HoaDon();
            string error = "";

            int mahoadon = bll.khoitao_HoaDon(ref error);
            return mahoadon;
        }

        public int them_KhachHangNguoiLon(
            string hoten,
            string gioitinh,
            DateTime ngaysinh,
            string sodienthoai,
            string email,
            string diachi,
            int mave,
            int magoi,
            int mahoadon)
        {
            BLL_KhachHang bll = new BLL_KhachHang();
            string error = "";

            int manguoilon = bll.them_KhachHangNguoiLon(
                hoten,
                gioitinh,
                ngaysinh,
                sodienthoai,
                email,
                diachi,
                mave,
                magoi,
                mahoadon,
                ref error);
            return manguoilon;
        }

        public int them_KhachHangTreEm(
            string hoten,
            string gioitinh,
            DateTime ngaysinh,
            int mave,
            int magoi,
            int mahoadon)
        {
            BLL_KhachHang bll = new BLL_KhachHang();
            string error = "";

            int matreem = bll.them_KhachHangTreEm(
                hoten,
                gioitinh,
                ngaysinh,
                mave,
                magoi,
                mahoadon,
                ref error);
            return matreem;
        }

        public bool them_NguoiLonQuanLyTreEm(int manguoilon, int matreem)
        {
            BLL_KhachHang bll = new BLL_KhachHang();
            string error = "";

            bool success = bll.them_NguoiLonQuanLyTreEm(
                manguoilon, 
                matreem,
                ref error);

            return success;
        }

        public bool them_ThongTinNguoiDungMuaVe(int mave, int manguoidung)
        {
            BLL_NguoiDung bll = new BLL_NguoiDung();
            string error = "";

            bool success = bll.them_ThongTinNguoiDungMuaVe(
                mave,
                manguoidung,
                ref error);
            return success;
        }
    }
}
