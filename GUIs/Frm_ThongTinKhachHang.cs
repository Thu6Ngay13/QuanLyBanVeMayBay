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
    public partial class Frm_ThongTinKhachHang : Form
    {
        BLL_KhachHang themThongTinKhachHang = null;
        string error = null;
        string Ho = null;
        string Ten = null;
        string GioiTinh = null;
        string NgaySinh = null;
        string SoDienThoai = null;
        string Email = null;
        string DiaChi = null;

        int SoVeNguoiLon;
        int SoVeTreEm;
        List<ThongTinChuyenBay> thongTinChuyenBays = null;

        public Frm_ThongTinKhachHang(int SoVeNguoiLon, int SoVeTreEm, List<ThongTinChuyenBay> thongTinChuyenBays)
        {
            InitializeComponent();

            this.SoVeNguoiLon = SoVeNguoiLon;
            this.SoVeTreEm = SoVeTreEm;
            this.thongTinChuyenBays = thongTinChuyenBays;
        }

        public void Init()
        {
            themThongTinKhachHang = new BLL_KhachHang();
        }

        private void Frm_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            // Load form dien thong tin khach hang 
            int X = 3;
            int Y = 0;
            for (int i = 0; i < SoVeNguoiLon; i++)
            {
                UC_ThongTinNguoiLon nl = new UC_ThongTinNguoiLon();
                Y = 540 * i;
                nl.Lbl_NguoiLon.Text = string.Concat("NGƯỜI LỚN ", i + 1);
                nl.Location = new Point(X, Y);
                Pnl_ThongTinKhachHang.Controls.Add(nl);
            }

            for (int i = SoVeNguoiLon; i < (SoVeNguoiLon + SoVeTreEm); i++)
            {
                UC_ThongTinTreEm te = new UC_ThongTinTreEm();
                Y = i == SoVeNguoiLon ? 540 * i : Y + 350;
                te.Lbl_TreEm.Text = string.Concat("TRẺ EM ", i - SoVeNguoiLon + 1);
                te.Location = new Point(X, Y); ;
                Pnl_ThongTinKhachHang.Controls.Add(te);
            }

            // Lay thong tin chuyen bay
            ThongTinChuyenBay();
        }

        private bool KiemTraThongTinNguoiLon(UC_ThongTinNguoiLon thongTinNguoiLon)
        {
            Ho = thongTinNguoiLon.Txt_Ho.Text.Trim();
            Ten = thongTinNguoiLon.Txt_TenDemVaTen.Text.Trim();
            GioiTinh = thongTinNguoiLon.Cmb_GioiTinh.Text.Trim();
            NgaySinh = thongTinNguoiLon.Mtb_NgaySinh.Text.Trim();
            SoDienThoai = thongTinNguoiLon.Txt_SoDienThoai.Text.Trim();
            Email = thongTinNguoiLon.Txt_Email.Text.Trim();
            DiaChi = thongTinNguoiLon.Txt_DiaChi.Text.Trim();

            return string.IsNullOrEmpty(Ho)
                || string.IsNullOrEmpty(Ten)
                || string.IsNullOrEmpty(GioiTinh)
                || string.IsNullOrEmpty(SoDienThoai)
                || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(DiaChi) ? false : true;
        }

        private bool KiemTraThongTinTreEm(UC_ThongTinTreEm thongTinTreEm)
        {
            Ho = thongTinTreEm.Txt_Ho.Text.Trim();
            Ten = thongTinTreEm.Txt_TenDemVaTen.Text.Trim();
            GioiTinh = thongTinTreEm.Cmb_GioiTinh.Text.Trim();
            NgaySinh = thongTinTreEm.Mtb_NgaySinh.Text.Trim();

            return string.IsNullOrEmpty(Ho)
                || string.IsNullOrEmpty(Ten)
                || string.IsNullOrEmpty(GioiTinh) ? false : true;
        }

        private bool DanhSachNguoiLon(ref List<KhachHangNguoiLon> khachHangNguoiLons)
        {
            foreach (Control control in Pnl_ThongTinKhachHang.Controls)
            {
                if (control is UC_ThongTinNguoiLon)
                {
                    UC_ThongTinNguoiLon thongTinNguoiLon = (UC_ThongTinNguoiLon)control;

                    string HoTen = string.Concat(thongTinNguoiLon.Txt_Ho.Text.Trim(), " ",
                                                 thongTinNguoiLon.Txt_TenDemVaTen.Text.Trim());
                    GioiTinh = thongTinNguoiLon.Cmb_GioiTinh.Text.Trim();
                    NgaySinh = thongTinNguoiLon.Mtb_NgaySinh.Text.Trim();
                    SoDienThoai = thongTinNguoiLon.Txt_SoDienThoai.Text.Trim();
                    Email = thongTinNguoiLon.Txt_Email.Text.Trim();
                    DiaChi = thongTinNguoiLon.Txt_DiaChi.Text.Trim();

                    KhachHangNguoiLon khachHangNguoiLon =
                        new KhachHangNguoiLon(HoTen, GioiTinh, NgaySinh, SoDienThoai, Email, DiaChi);

                    if (!KiemTraThongTinNguoiLon(thongTinNguoiLon)) return false;

                    khachHangNguoiLons.Add(khachHangNguoiLon);
                }
            }
            return true;
        }

        private bool DanhSachTreEm(ref List<KhachHangTreEm> khachHangTreEms)
        {
            foreach (Control control in Pnl_ThongTinKhachHang.Controls)
            {
                if (control is UC_ThongTinTreEm)
                {
                    UC_ThongTinTreEm thongTinTreEm = (UC_ThongTinTreEm)control;

                    string HoTen = string.Concat(thongTinTreEm.Txt_Ho.Text.Trim(), " ",
                                                 thongTinTreEm.Txt_TenDemVaTen.Text.Trim());
                    GioiTinh = thongTinTreEm.Cmb_GioiTinh.Text.Trim();
                    NgaySinh = thongTinTreEm.Mtb_NgaySinh.Text.Trim();

                    KhachHangTreEm khachHangTreEm = new KhachHangTreEm(HoTen, GioiTinh, NgaySinh);

                    if (!KiemTraThongTinTreEm(thongTinTreEm)) return false;

                    khachHangTreEms.Add(khachHangTreEm);
                }
            }
            return true;
        }

        private void ThongTinChuyenBay()
        {
            for (int i = 0; i < thongTinChuyenBays.Count; i++)
            {
                UC_ChiTietChuyenBay uC_ChiTietChuyenBay = new UC_ChiTietChuyenBay();
                uC_ChiTietChuyenBay.Lbl_TenMayBay.Text = thongTinChuyenBays[i].TenMayBay;
                uC_ChiTietChuyenBay.Lbl_DiemDi.Text = thongTinChuyenBays[i].DiemDi;
                uC_ChiTietChuyenBay.Lbl_DiemDen.Text = thongTinChuyenBays[i].DiemDen;
                uC_ChiTietChuyenBay.Lbl_ThoiGianBay.Text = thongTinChuyenBays[i].ThoiGianDi;
                uC_ChiTietChuyenBay.Lbl_KhoiHanh.Text = i == 1 ? "Trở về" : "Khởi hành";
                uC_ChiTietChuyenBay.Location = new Point(2, 230 * i + 3);
                Pnl_ChiTietChuyenBay.Controls.Add(uC_ChiTietChuyenBay);

            }
        }

        private void Btn_TiepTuc_Click(object sender, EventArgs e)
        {
            // Lay thong tin khach hang
            List<KhachHangNguoiLon> khachHangNguoiLons = new List<KhachHangNguoiLon>();
            List<KhachHangTreEm> khachHangTreEms = new List<KhachHangTreEm>();

            if (DanhSachNguoiLon(ref khachHangNguoiLons) && DanhSachTreEm(ref khachHangTreEms))
            {
                // Thuc hien thanh cong lay thong tin khach hang
            }
            else
            {
                MessageBox.Show("Thông tin khách hàng không phù hợp!");
            }
        }
    }
}
