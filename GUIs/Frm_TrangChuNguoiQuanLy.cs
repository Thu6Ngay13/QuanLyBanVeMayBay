using QuanLyBanVeMayBay.BLL;
using System;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_TrangChuNguoiQuanLy : Form
    {
        BLL_ChuyenBay themChuyenBay = null;
        string error = null;
        string MaMaybay = null;
        string LoaiChuyenBay = null;
        string DiemDi = null;
        string DiemDen = null;
        string NgayDi = null;
        string ThoiGianDi = null;
        string ThoiGianDuKienDen = null;
        string ChiPhi = null;
        string GiaVePhoThong = null;
        string GiaVeThuongGia = null;
        string KhoiLuongHanhLy = null;

        public Frm_TrangChuNguoiQuanLy()
        {
            InitializeComponent();
        }
        private void Init()
        {
            themChuyenBay = new BLL_ChuyenBay();
        }

        private void LayThongTinChuyenBay()
        {
            MaMaybay = Txt_MaMayBay.Text.Trim();
            LoaiChuyenBay = Cmb_LoaiChuyenBay.Text.Trim();
            DiemDi = Txt_DiemDi.Text.Trim();
            DiemDen = Txt_DiemDen.Text.Trim();
            NgayDi = Mtb_NgayDi.Text.Trim();
            ThoiGianDi = Mtb_ThoiGianDi.Text.Trim();
            ThoiGianDuKienDen = Mtb_ThoiGianDuKienDen.Text.Trim();
            ChiPhi = Txt_ChiPhi.Text.Trim();
            GiaVePhoThong = Txt_GiaVePhoThong.Text.Trim();
            GiaVeThuongGia = Txt_GiaVeThuongGia.Text.Trim();
            KhoiLuongHanhLy = Txt_KhoiLuongHanhLy.Text.Trim();
        }

        private bool KiemTraThongTin()
        {
            LayThongTinChuyenBay();
            return string.IsNullOrEmpty(MaMaybay)
                || string.IsNullOrEmpty(LoaiChuyenBay)
                || string.IsNullOrEmpty(DiemDi)
                || string.IsNullOrEmpty(DiemDen)
                || string.IsNullOrEmpty(NgayDi)
                || string.IsNullOrEmpty(ThoiGianDi)
                || string.IsNullOrEmpty(ThoiGianDuKienDen)
                || string.IsNullOrEmpty(ChiPhi)
                || string.IsNullOrEmpty(GiaVePhoThong)
                || !int.TryParse(GiaVePhoThong, out _)
                || !int.TryParse(ChiPhi, out _)
                || !int.TryParse(GiaVeThuongGia, out _)
                || !int.TryParse(KhoiLuongHanhLy, out _)
                || string.IsNullOrEmpty(GiaVeThuongGia)
                || string.IsNullOrEmpty(KhoiLuongHanhLy) ? false : true;
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            Init();
            LayThongTinChuyenBay();
            if (KiemTraThongTin())
            {
                themChuyenBay.ThemChuyenBay(MaMaybay,
                                            LoaiChuyenBay,
                                            DiemDi,
                                            DiemDen,
                                            string.Concat(FormatDate(NgayDi), " ", ThoiGianDi),
                                            string.Concat(FormatDate(NgayDi), " ", ThoiGianDuKienDen),
                                            ChiPhi,
                                            GiaVePhoThong,
                                            GiaVeThuongGia,
                                            KhoiLuongHanhLy,
                                            ref error);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chuyến bay!");
            }
            
        }
        private string FormatDate(string date)
        {
            DateTime ParsedDate = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            string FormattedDate = ParsedDate.ToString("yyyy/MM/dd");
            return FormattedDate;
        }
    }
}
