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

        private ThongTinChuyenBay thongtinchuyenbay;
        private string ho = null;
        private string ten = null;
        private string gioitinh = null;
        private string ngaysinh = null;
        private string sodienthoai = null;
        private string email = null;
        private string diachi = null;
        private string error = null;

        public Frm_ThongTinKhachHang()
        {
            InitializeComponent();
        }

        public Frm_ThongTinKhachHang(ThongTinChuyenBay thongtinchuyenbay)
        {
            InitializeComponent();
            this.thongtinchuyenbay = thongtinchuyenbay;
        }

        public void Init()
        {
            themThongTinKhachHang = new BLL_KhachHang();
        }

        private void Frm_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            // Test
            thongtinchuyenbay = new ThongTinChuyenBay(
                "Tp.Hồ Chí Minh (SGN)", 
                "Hà Nội (HAN)", 
                new DateTime(2023, 6, 1, 7, 47, 0), 
                new DateTime(2023, 6, 1, 7, 47, 0), 
                4, // so nguoi lon
                3, // so tre em
                1, // ma chieu di
                2, // ma chieu ve
                3, // ma may bay di
                4); // ma may bay ve

            // Load form dien thong tin khach hang 
            int X = 3;
            int Y = 0;
            for (int i = 0; i < thongtinchuyenbay.Sokhachnguoilon; i++)
            {
                UC_ThongTinNguoiLon nl = new UC_ThongTinNguoiLon();
                Y = 540 * i;
                nl.Lbl_NguoiLon.Text = string.Concat("NGƯỜI LỚN ", i + 1);
                nl.Location = new Point(X, Y);
                Pnl_ThongTinKhachHang.Controls.Add(nl);
            }

            for (int i = thongtinchuyenbay.Sokhachnguoilon; i < (thongtinchuyenbay.Sokhachnguoilon + thongtinchuyenbay.Sokhachtreem); i++)
            {
                UC_ThongTinTreEm te = new UC_ThongTinTreEm();
                Y = i == thongtinchuyenbay.Sokhachnguoilon ? 540 * i : Y + 350;
                te.Lbl_TreEm.Text = string.Concat("TRẺ EM ", i - thongtinchuyenbay.Sokhachnguoilon + 1);
                te.Location = new Point(X, Y); ;
                Pnl_ThongTinKhachHang.Controls.Add(te);
            }

            // Lay thong tin chuyen bay
            LayThongTinChuyenBay();
        }

        private bool KiemTraThongTinNguoiLon(UC_ThongTinNguoiLon thongTinNguoiLon)
        {
            ho = thongTinNguoiLon.Txt_Ho.Text.Trim();
            ten = thongTinNguoiLon.Txt_TenDemVaTen.Text.Trim();
            gioitinh = thongTinNguoiLon.Cmb_GioiTinh.Text.Trim();
            ngaysinh = thongTinNguoiLon.Mtb_NgaySinh.Text.Trim();
            sodienthoai = thongTinNguoiLon.Txt_SoDienThoai.Text.Trim();
            email = thongTinNguoiLon.Txt_Email.Text.Trim();
            diachi = thongTinNguoiLon.Txt_DiaChi.Text.Trim();

            return string.IsNullOrEmpty(ho)
                || string.IsNullOrEmpty(ten)
                || string.IsNullOrEmpty(gioitinh)
                || string.IsNullOrEmpty(sodienthoai)
                || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(diachi) ? false : true;
        }                               
        private bool KiemTraThongTinTreEm(UC_ThongTinTreEm thongTinTreEm)
        {
            ho = thongTinTreEm.Txt_Ho.Text.Trim();
            ten = thongTinTreEm.Txt_TenDemVaTen.Text.Trim();
            gioitinh = thongTinTreEm.Cmb_GioiTinh.Text.Trim();
            ngaysinh = thongTinTreEm.Mtb_NgaySinh.Text.Trim();

            return string.IsNullOrEmpty(ho)
                || string.IsNullOrEmpty(ten)
                || string.IsNullOrEmpty(gioitinh) ? false : true;
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
                    gioitinh = thongTinNguoiLon.Cmb_GioiTinh.Text.Trim();
                    ngaysinh = thongTinNguoiLon.Mtb_NgaySinh.Text.Trim();
                    sodienthoai = thongTinNguoiLon.Txt_SoDienThoai.Text.Trim();
                    email = thongTinNguoiLon.Txt_Email.Text.Trim();
                    diachi = thongTinNguoiLon.Txt_DiaChi.Text.Trim();

                    KhachHangNguoiLon khachHangNguoiLon =
                        new KhachHangNguoiLon(HoTen, gioitinh, ngaysinh, sodienthoai, email, diachi);

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
                    gioitinh = thongTinTreEm.Cmb_GioiTinh.Text.Trim();
                    ngaysinh = thongTinTreEm.Mtb_NgaySinh.Text.Trim();

                    KhachHangTreEm khachHangTreEm = new KhachHangTreEm(HoTen, gioitinh, ngaysinh);

                    if (!KiemTraThongTinTreEm(thongTinTreEm)) return false;

                    khachHangTreEms.Add(khachHangTreEm);
                }
            }
            return true;
        }

        private void LayThongTinChuyenBay()
        {
            // Thong tin chieu di
            UC_ThongTinChieuBay thongTinChieuBay = new UC_ThongTinChieuBay();
            thongTinChieuBay.Location = new Point(2, 3);
            thongTinChieuBay.Lbl_MaChuyenBay.Text = string.Concat("Mã chuyến bay: ", thongtinchuyenbay.Machieudi);
            thongTinChieuBay.Lbl_MaMayBay.Text = string.Concat("Mã máy bay: ", thongtinchuyenbay.Mamaybaydi);
            thongTinChieuBay.Lbl_DiemDi.Text = thongtinchuyenbay.Diemdi;
            thongTinChieuBay.Lbl_DiemDen.Text = thongtinchuyenbay.Diemden;
            thongTinChieuBay.Lbl_GioDi.Text = thongtinchuyenbay.Thoigiandi.ToString();
            Pnl_HanhTrinh.Controls.Add(thongTinChieuBay);

            // Thong tin ve chieu ve
            if (thongtinchuyenbay.Machieuve != 0)
            {
                thongTinChieuBay = new UC_ThongTinChieuBay();
                thongTinChieuBay.Location = new Point(2, 145);
                thongTinChieuBay.Lbl_MaChuyenBay.Text = string.Concat("Mã chuyến bay: ", thongtinchuyenbay.Machieuve);
                thongTinChieuBay.Lbl_MaMayBay.Text = string.Concat("Mã máy bay: ", thongtinchuyenbay.Mamaybayve);
                thongTinChieuBay.Lbl_DiemDi.Text = thongtinchuyenbay.Diemden;
                thongTinChieuBay.Lbl_DiemDen.Text = thongtinchuyenbay.Diemdi;
                thongTinChieuBay.Lbl_ChieuBay.Text = "Chiều về";
                thongTinChieuBay.Lbl_GioDi.Text = thongtinchuyenbay.Thoigianve.ToString();
                Pnl_HanhTrinh.Controls.Add(thongTinChieuBay);
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
                MessageBox.Show("Thông tin khách hàng không hợp lệ!");
            }
        }
    }
}
