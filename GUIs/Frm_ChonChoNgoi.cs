using HeQuanTriDemo01.Models;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.Models;
using QuanLyBanVeMayBay.UC;
using QuanLyBanVeMayBay.UCs;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_ChonChoNgoi : Form
    {
        ThongTinChuyenBay thongTinChuyenBay = null;
        List<KhachHangNguoiLon> khachHangNguoiLons = new List<KhachHangNguoiLon>();
        List<KhachHangTreEm> khachHangTreEms = new List<KhachHangTreEm>();

        private int sokhachlon = -1;
        private int sokhachnho = -1;    
        private int sohanhkhach = -1;
        
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

        public void LayDanhSachKhachHang()
        {
            //Frm_HanhKhach hk = new Frm_HanhKhach();
            //sokhachlon = (int)hk.Nud_NguoiLon.Value;
            //sokhachnho = (int)hk.Nud_TreEm.Value;

            sohanhkhach = sokhachlon + sokhachnho;
            if (thongTinChuyenBay.Sokhachnguoilon != -1)
            {
                UC_HanhKhachChonChoNgoi hanhKhachChonChoNgoi = new UC_HanhKhachChonChoNgoi();
                Pnl_DanhSachHanhKhach.Controls.Add(hanhKhachChonChoNgoi);
            }
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
                        UC_ButtonChonViTriChuaMua btn_ChuaMua = new UC_ButtonChonViTriChuaMua();
                        btn_ChuaMua.Left = x - 5 + (col * (btn_ChuaMua.Width + khoangCach)) + (col / 2) * khoangCachGiua;
                        btn_ChuaMua.Top = 10 + (row * (btn_ChuaMua.Height + khoangCach));
                        btn_ChuaMua.Btn_MaGhe.Text = datatable.Rows[numCols * row + col]["ChoNgoi"].ToString();
                        Pnl_ChonViTri.Controls.Add(btn_ChuaMua);
                    }
                    else
                    {
                        UC_ButtonChonViTriDaMua btn_DaMua = new UC_ButtonChonViTriDaMua();
                        btn_DaMua.Left = x - 5 + (col * (btn_DaMua.Width + khoangCach)) + (col / 2) * khoangCachGiua;
                        btn_DaMua.Top = 10 + (row * (btn_DaMua.Height + khoangCach));
                        btn_DaMua.Btn_MaGhe.Text = datatable.Rows[numCols * row + col]["ChoNgoi"].ToString();
                        Pnl_ChonViTri.Controls.Add(btn_DaMua);
                    }
                }
            }
            this.Pnl_ChonViTri.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        /*private void LayThongTinChuyenBay()
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
        }*/

        private void Frm_ChonChoNgoi_Load(object sender, System.EventArgs e)
        {
            // LayThongTinChuyenBay();
            LayThongTinChoNgoi();
        }
    }
}
