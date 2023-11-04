﻿using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_ThanhToan : Form
    {
        public static int thanhtoanthanhcong = 0;
        private int ThoiGianConLai = 600;
        private List<KhachHangNguoiLon> khachHangNguoiLons = null;
        private List<KhachHangTreEm> khachHangTreEms = null;

        public Frm_ThanhToan()
        {
            InitializeComponent();
        }

        public Frm_ThanhToan(List<KhachHangNguoiLon> khachHangNguoiLons, List<KhachHangTreEm> khachHangTreEms)
        {
            InitializeComponent();
            this.khachHangNguoiLons = khachHangNguoiLons;
            this.khachHangTreEms = khachHangTreEms;
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
                    khachHangNguoiLons[i].Magoihanhly,
                    khachHangNguoiLons[i].Mavechieudi,
                    mahoadon);

                success1 = them_ThongTinNguoiDungMuaVe(1, khachHangNguoiLons[i].Mavechieudi) && success1;
                khachHangNguoiLons[i].Makhachhangnguoilon = manguoilon;
            }

            // Chieu di
            for (int i = 0; i < khachHangTreEms.Count; ++i)
            {
                int matreem = them_KhachHangTreEm(
                    khachHangTreEms[i].Hoten,
                    khachHangTreEms[i].Gioitinh,
                    khachHangTreEms[i].Ngaysinh,
                    khachHangTreEms[i].Magoihanhly,
                    khachHangTreEms[i].Mavechieudi,
                    mahoadon);

                success1 = them_ThongTinNguoiDungMuaVe(1, khachHangTreEms[i].Mavechieudi) && success1;
                khachHangTreEms[i].Makhachhangtreem = matreem;
            }

            // Chieu di
            for (int i = 0; i < khachHangNguoiLons.Count; ++i)
            {
                for(int j = 0; j < khachHangTreEms.Count; ++j)
                {
                    success2 = them_NguoiLonQuanLyTreEm(khachHangNguoiLons[i].Makhachhangnguoilon, khachHangTreEms[j].Makhachhangtreem) && success2;
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
    }
}
