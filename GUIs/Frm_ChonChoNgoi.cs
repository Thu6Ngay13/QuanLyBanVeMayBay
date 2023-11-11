using HeQuanTriDemo01.Models;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.Models;
using QuanLyBanVeMayBay.UC;
using QuanLyBanVeMayBay.UCs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_ChonChoNgoi : Form
    {
        private ThongTinChuyenBay thongTinChuyenBay;
        private List<KhachHangNguoiLon> khachHangNguoiLons = new List<KhachHangNguoiLon>();
        private List<KhachHangTreEm> khachHangTreEms = new List<KhachHangTreEm>();
        private int i = 0;
        private int j = 0;
        private int X = 10;
        private int Y = 10;
        private int mave = -1;
        private int idx = -1;

        private List<UC_HanhKhachChonChoNgoi> uckhs = new List<UC_HanhKhachChonChoNgoi>();
        private List<Button> buttons = new List<Button>();
        private List<int> mavedachons = new List<int>();
        private List<int> maves = new List<int>();

        public Frm_ChonChoNgoi()
        {
            InitializeComponent();
        }

        public Frm_ChonChoNgoi(
            List<KhachHangNguoiLon> khachHangNguoiLons,
            List<KhachHangTreEm> khachHangTreEms,
            ThongTinChuyenBay thongTinChuyenBay)
        {
            InitializeComponent();
            this.khachHangNguoiLons = khachHangNguoiLons;
            this.khachHangTreEms = khachHangTreEms;
            this.thongTinChuyenBay = thongTinChuyenBay;
        }

        private void Frm_ChonChoNgoi_Load(object sender, System.EventArgs e)
        {
            //Pnl_ChonViTri.Hide();
            LayThongTinChuyenBay();
            LayThongTinChoNgoi();
            LayDanhSachKhachHang();
        }

        public void LayDanhSachKhachHang()
        {
            UC_HanhKhachChonChoNgoi hanhKhachChonChoNgoi = new UC_HanhKhachChonChoNgoi();

            if (i < thongTinChuyenBay.Sokhachnguoilon)
            {
                hanhKhachChonChoNgoi.Lbl_TenKhach.Text = khachHangNguoiLons[i].Hoten;
            }
            else if (j < thongTinChuyenBay.Sokhachtreem)
            {
                hanhKhachChonChoNgoi.Lbl_TenKhach.Text = khachHangTreEms[j].Hoten;
            }
            else
            {
                return;
            }

            hanhKhachChonChoNgoi.Location = new Point(X, Y);
            Pnl_DanhSachHanhKhach.Controls.Add(hanhKhachChonChoNgoi);
            uckhs.Add(hanhKhachChonChoNgoi);
            Y = Y + 90;
        }
        
        public void LayThongTinChoNgoi()
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error = "";

            DataSet dataset = bll.lay_DanhSachChoNgoi_PROC(1, ref error);
            DataTable datatable = new DataTable();
            datatable.Clear();
            datatable = dataset.Tables[0];

            //Lbl_TenMayBay.Text = "";

            this.SuspendLayout();
            this.Pnl_ChonViTri.SuspendLayout();

            int khoangCach = 5;
            int khoangCachGiua = 20;
            int numCols = 4;
            int numRows = 40;
            this.Controls.Add(Pnl_ChonViTri);

            int totalButtonWidth = numCols * (80 + khoangCach) - khoangCach + khoangCachGiua;
            int x = (Pnl_ChonViTri.Width - totalButtonWidth) / 2;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (datatable.Rows[numCols * row + col]["TinhTrangVe"].Equals("chưa bán"))
                    {
                        Button btn_ChuaMua = new Button();
                        btn_ChuaMua.Width = 80;
                        btn_ChuaMua.Height = 40;
                        btn_ChuaMua.BackColor = Color.SkyBlue;
                        btn_ChuaMua.Left = x - 5 + (col * (btn_ChuaMua.Width + khoangCach)) + (col / 2) * khoangCachGiua;
                        btn_ChuaMua.Top = 10 + (row * (btn_ChuaMua.Height + khoangCach));
                        btn_ChuaMua.Text = datatable.Rows[numCols * row + col]["ChoNgoi"].ToString();
                        btn_ChuaMua.Click += chonGhe;
                        buttons.Add(btn_ChuaMua);
                        maves.Add(Convert.ToInt32(datatable.Rows[numCols * row + col]["MaVe"].ToString()));
                        Pnl_ChonViTri.Controls.Add(btn_ChuaMua);

                    }
                    else
                    {
                        Button btn_DaMua = new Button();
                        btn_DaMua.Width = 80;
                        btn_DaMua.Height = 40;
                        btn_DaMua.BackColor = Color.Silver;
                        btn_DaMua.Left = x - 5 + (col * (btn_DaMua.Width + khoangCach)) + (col / 2) * khoangCachGiua;
                        btn_DaMua.Top = 10 + (row * (btn_DaMua.Height + khoangCach));
                        btn_DaMua.Enabled = false;
                        Pnl_ChonViTri.Controls.Add(btn_DaMua);
                    }
                }
            }
            this.Pnl_ChonViTri.ResumeLayout(false);
            this.ResumeLayout(false);
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


        private void chonGhe(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            idx = buttons.IndexOf(temp);
            mave = maves[idx];
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (mavedachons.IndexOf(mave) != -1 || idx == -1) return;
            if (i < thongTinChuyenBay.Sokhachnguoilon)
            {
                khachHangNguoiLons[i].Mavechieudi = mave;
                mavedachons.Add(mave);
                i = i + 1;
            }
            else if (j < thongTinChuyenBay.Sokhachtreem)
            {
                khachHangTreEms[j].Mavechieudi = mave;
                mavedachons.Add(mave);
                j = j + 1;
            }
            else
            {
                return;
            }

            uckhs[idx].Lbl_MaGhe.Text = buttons[idx].Text;
            uckhs[idx].Lbl_MaVe.Text = mave.ToString();

            buttons[idx].Text = "";
            buttons[idx].Click -= chonGhe;
            buttons[idx].Enabled = false;   
            LayDanhSachKhachHang();
        }

        private void Btn_TiepTuc_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_ThanhToan thanhToan = new Frm_ThanhToan(khachHangNguoiLons, khachHangTreEms);
            thanhToan.ShowDialog();

            if (Frm_ThanhToan.thanhtoanthanhcong == 999) this.Close();
            this.Show();

        }
    }
}
