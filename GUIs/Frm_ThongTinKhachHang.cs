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

        public Frm_ThongTinKhachHang()
        {
            InitializeComponent();
        }

        public void Init()
        {
            themThongTinKhachHang = new BLL_KhachHang();
        }

        private void Frm_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            int X = 3;
            int Y = 0;
            // Test 
            for (int i = 0; i < 2; i++)
            {
                UC_ThongTinNguoiLon nl = new UC_ThongTinNguoiLon();
                Y = 540 * i;
                nl.Lbl_NguoiLon.Text = string.Concat("NGƯỜI LỚN ", i + 1);
                nl.Location = new Point(X, Y);
                Pnl_ThongTinKhachHang.Controls.Add(nl);
            }

            for (int i = 2; i < 3; i++)
            {
                UC_ThongTinTreEm te = new UC_ThongTinTreEm();
                Y = i == 2 ? 540 * i : Y + 350;
                te.Lbl_TreEm.Text = string.Concat("TRẺ EM ", i - 3);
                te.Location = new Point(X, Y); ;
                Pnl_ThongTinKhachHang.Controls.Add(te);
            }
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

        private void Btn_TiepTuc_Click(object sender, EventArgs e)
        {
            /*List<string> lstMaNguoiLon = new List<string>();
            List<string> lstMaTreEm = new List<string>();
            Init();
            foreach(Control control in Pnl_ThongTinKhachHang.Controls)
            {
                if(control is UC_ThongTinNguoiLon)
                {
                    DataSet ds = new DataSet();
                    UC_ThongTinNguoiLon thongTinNguoiLon = (UC_ThongTinNguoiLon)control;
                    ds = themThongTinKhachHang.ThemKhachHangNguoiLon(
                        string.Concat(thongTinNguoiLon.Txt_Ho.Text.Trim(), " ", thongTinNguoiLon.Txt_TenDemVaTen.Text.Trim()),
                        thongTinNguoiLon.Cmb_GioiTinh.Text.Trim(),
                        thongTinNguoiLon.Mtb_NgaySinh.Text.Trim(),
                        thongTinNguoiLon.Txt_SoDienThoai.Text.Trim(),
                        thongTinNguoiLon.Txt_Email.Text.Trim(),
                        thongTinNguoiLon.Txt_DiaChi.Text.Trim(),
                        "1",
                        ref error
                    );
                    lstMaNguoiLon.Add(ds.Tables[0].Rows[0][0].ToString());
                }
                if (control is UC_ThongTinTreEm)
                {
                    DataSet ds = new DataSet();
                    UC_ThongTinTreEm thongTinNguoiLon = (UC_ThongTinTreEm)control;
                    ds = themThongTinKhachHang.ThemKhachHangTreEm(
                        string.Concat(thongTinNguoiLon.Txt_Ho.Text.Trim(), " ", thongTinNguoiLon.Txt_TenDemVaTen.Text.Trim()),
                        thongTinNguoiLon.Cmb_GioiTinh.Text.Trim(),
                        thongTinNguoiLon.Mtb_NgaySinh.Text.Trim(),
                        "1",
                        ref error
                    );
                    lstMaTreEm.Add(ds.Tables[0].Rows[0][0].ToString());
                }
            }
            if(lstMaTreEm.Count > 0)
            {
                foreach(string MaNguoiLon in lstMaNguoiLon)
                {
                    foreach(string MaTreEm in lstMaTreEm)
                    {
                        themThongTinKhachHang.ThemKhachHangNguoiLonQuanLyTreEm(MaNguoiLon, MaTreEm, ref error);
                    }
                }
            }*/


            // Lay thong tin khach hang

            List<KhachHangNguoiLon> khachHangNguoiLons = new List<KhachHangNguoiLon>();
            List<KhachHangTreEm> khachHangTreEms = new List<KhachHangTreEm>();

            if (DanhSachNguoiLon(ref khachHangNguoiLons))
            {
                MessageBox.Show("Them nguoi lon thanh cong");
            }
            else
            {
                MessageBox.Show("loi them nguoi lon");
            }


            if (DanhSachTreEm(ref khachHangTreEms))
            {
                MessageBox.Show("Them tre thanh cong");
            }
            else
            {
                MessageBox.Show("loi them tre em");
            }

        }
    }
}
