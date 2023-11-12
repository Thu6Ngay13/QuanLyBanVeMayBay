using HeQuanTriDemo01.Models;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.Models;
using QuanLyBanVeMayBay.UC;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_ThanhToan : Form
    {
        public static int thanhtoanthanhcong = 0;
        private int ThoiGianConLai = 600;
        private ThongTinChuyenBay thongTinChuyenBay = null;
        private List<KhachHangNguoiLon> khachHangNguoiLons = null;
        private List<KhachHangTreEm> khachHangTreEms = null;

        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        public Frm_ThanhToan(
            List<KhachHangNguoiLon> khachHangNguoiLons, 
            List<KhachHangTreEm> khachHangTreEms,
            ThongTinChuyenBay thongTinChuyenBay)
        {
            InitializeComponent();
            this.khachHangNguoiLons = khachHangNguoiLons;
            this.khachHangTreEms = khachHangTreEms;
            this.thongTinChuyenBay = thongTinChuyenBay;
        }

        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            LayThongTinChuyenBay();
            LayThongTinHanhKhach();
        }

        private void Tmr_ThoiGianThanhToan_Tick(object sender, System.EventArgs e)
        {
            --ThoiGianConLai;
            Lbl_ThoiGianThanhToan.Text =
                (ThoiGianConLai / 60).ToString() + ":" + (ThoiGianConLai % 60);
            if (ThoiGianConLai == 0)
            {
                this.Tmr_ThoiGianConLai.Stop();
                thanhtoanthanhcong = 0;
                DialogResult rs = MessageBox.Show("Hết thời gian thanh toán", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (rs == DialogResult.OK) this.Close();
            }
        }

        private void Btn_Xong_Click(object sender, EventArgs e)
        {
            int mahoadon = khoitao_HoaDon();
            bool success1 = true;
            bool success2 = true;

            // Chieu di
            for (int i = 0; i < khachHangNguoiLons.Count; ++i)
            {
                int manguoilon = them_KhachHangNguoiLon(
                    khachHangNguoiLons[i].Hoten,
                    khachHangNguoiLons[i].Gioitinh,
                    khachHangNguoiLons[i].Ngaysinh,
                    khachHangNguoiLons[i].Sodienthoai,
                    khachHangNguoiLons[i].Email,
                    khachHangNguoiLons[i].Diachi,
                    khachHangNguoiLons[i].Magoihanhlychieudi,
                    khachHangNguoiLons[i].Mavechieudi,
                    mahoadon);

                khachHangNguoiLons[i].Makhachhangnguoilon = manguoilon;
                success1 = them_ThongTinNguoiDungMuaVe(khachHangNguoiLons[i].Mavechieudi, manguoilon) && success1;
            }

            // Chieu di
            for (int i = 0; i < khachHangTreEms.Count; ++i)
            {
                int matreem = them_KhachHangTreEm(
                    khachHangTreEms[i].Hoten,
                    khachHangTreEms[i].Gioitinh,
                    khachHangTreEms[i].Ngaysinh,
                    khachHangTreEms[i].Magoihanhlychieudi,
                    khachHangTreEms[i].Mavechieudi,
                    mahoadon);

                khachHangTreEms[i].Makhachhangtreem = matreem;
                success1 = them_ThongTinNguoiDungMuaVe(khachHangTreEms[i].Mavechieudi, matreem) && success1;
            }

            // Chieu di
            for (int i = 0; i < khachHangNguoiLons.Count; ++i)
            {
                for(int j = 0; j < khachHangTreEms.Count; ++j)
                {
                    success2 = them_NguoiLonQuanLyTreEm(khachHangNguoiLons[i].Makhachhangnguoilon, khachHangTreEms[j].Makhachhangtreem) && success2;
                }
            }

            /*---------------------------------------------------------------------------------------*/

            if(thongTinChuyenBay.Machieuve > 0)
            {
                // Chieu ve
                for (int i = 0; i < khachHangNguoiLons.Count; ++i)
                {
                    int manguoilon = them_KhachHangNguoiLon(
                        khachHangNguoiLons[i].Hoten,
                        khachHangNguoiLons[i].Gioitinh,
                        khachHangNguoiLons[i].Ngaysinh,
                        khachHangNguoiLons[i].Sodienthoai,
                        khachHangNguoiLons[i].Email,
                        khachHangNguoiLons[i].Diachi,
                        khachHangNguoiLons[i].Magoihanhlychieuve,
                        khachHangNguoiLons[i].Mavechieuve,
                        mahoadon);

                    khachHangNguoiLons[i].Makhachhangnguoilon = manguoilon;
                    success1 = them_ThongTinNguoiDungMuaVe(khachHangNguoiLons[i].Mavechieuve, manguoilon) && success1;

                }

                // Chieu ve
                for (int i = 0; i < khachHangTreEms.Count; ++i)
                {
                    int matreem = them_KhachHangTreEm(
                        khachHangTreEms[i].Hoten,
                        khachHangTreEms[i].Gioitinh,
                        khachHangTreEms[i].Ngaysinh,
                        khachHangTreEms[i].Magoihanhlychieuve,
                        khachHangTreEms[i].Mavechieuve,
                        mahoadon);

                    khachHangTreEms[i].Makhachhangtreem = matreem;
                    success1 = them_ThongTinNguoiDungMuaVe(khachHangTreEms[i].Mavechieuve, matreem) && success1;
                }

                // Chieu ve
                for (int i = 0; i < khachHangNguoiLons.Count; ++i)
                {
                    for (int j = 0; j < khachHangTreEms.Count; ++j)
                    {
                        success2 = them_NguoiLonQuanLyTreEm(khachHangNguoiLons[i].Makhachhangnguoilon, khachHangTreEms[j].Makhachhangtreem) && success2;
                    }
                }
            }

            thanhtoanthanhcong = 999;
            this.Close();
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

        private void LayThongTinChuyenBay()
        {
            // Thong tin chieu di
            UC_ThongTinChieuBay thongTinChieuBay = new UC_ThongTinChieuBay();
            thongTinChieuBay.Location = new Point(2, 3);
            thongTinChieuBay.Lbl_MaChuyenBay.Text = string.Concat("Mã chuyến bay: ", thongTinChuyenBay.Machieudi);
            thongTinChieuBay.Lbl_MaMayBay.Text = string.Concat("Mã máy bay: ", thongTinChuyenBay.Mamaybaydi);
            thongTinChieuBay.Lbl_DiemDi.Text = thongTinChuyenBay.Diemdi;
            thongTinChieuBay.Lbl_DiemDen.Text = thongTinChuyenBay.Diemden;
            thongTinChieuBay.Lbl_GioDi.Text = thongTinChuyenBay.Thoigiandi.ToString();
            Pnl_HanhTrinh.Controls.Add(thongTinChieuBay);

            // Thong tin ve chieu ve
            if (thongTinChuyenBay.Machieuve != -1)
            {
                thongTinChieuBay = new UC_ThongTinChieuBay();
                thongTinChieuBay.Location = new Point(2, 145);
                thongTinChieuBay.Lbl_MaChuyenBay.Text = string.Concat("Mã chuyến bay: ", thongTinChuyenBay.Machieuve);
                thongTinChieuBay.Lbl_MaMayBay.Text = string.Concat("Mã máy bay: ", thongTinChuyenBay.Mamaybayve);
                thongTinChieuBay.Lbl_DiemDi.Text = thongTinChuyenBay.Diemden;
                thongTinChieuBay.Lbl_DiemDen.Text = thongTinChuyenBay.Diemdi;
                thongTinChieuBay.Lbl_ChieuBay.Text = "Chiều về";
                thongTinChieuBay.Lbl_GioDi.Text = thongTinChuyenBay.Thoigianve.ToString();
                Pnl_HanhTrinh.Controls.Add(thongTinChieuBay);
            }
        }

        private void LayThongTinHanhKhach()
        {
            UC_ThongTinTongTien thongtintongtien = new UC_ThongTinTongTien();
        }
    }
}
