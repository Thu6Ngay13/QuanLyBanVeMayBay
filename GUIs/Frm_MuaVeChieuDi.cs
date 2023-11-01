using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.UC;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_MuaVeChieuDi : Form
    {
        private string diemdi = "-1";
        private string diemden = "-1";
        private DateTime ngaydi= new DateTime(2010, 1, 1);
        private int sohanhkhach = -1;

        public Frm_MuaVeChieuDi()
        {
            InitializeComponent();
        }

        public Frm_MuaVeChieuDi(string diemdi, string diemden, DateTime ngaydi, int sohanhkhach)
        {
            InitializeComponent();
            this.diemdi = diemdi;
            this.diemden = diemden;
            this.ngaydi = ngaydi;
            this.sohanhkhach = sohanhkhach;
        }

        private void Frm_MuaVeChieuDi_Load(object sender, EventArgs e)
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error = "";

            DataSet dataset = bll.timkiem_VeMayBay(diemdi, diemden, ngaydi, sohanhkhach, ref error);
            DataTable datatable = new DataTable();
            datatable.Clear();
            datatable = dataset.Tables[0];

            this.SuspendLayout();
            this.Pnl_DanhSachVe.SuspendLayout();
            this.Lbl_SoLuongKetQua.Text = "Số lượng: " + datatable.Rows.Count.ToString();

            for (int i = 0; i < datatable.Rows.Count; ++i)
            {
                UC_ThongTinVeMua vemaybay = new UC_ThongTinVeMua();
                vemaybay.Lbl_GioDi.Text = "Giờ đi: "
                    + datatable.Rows[i]["ThoiGianDi"].ToString();
                vemaybay.Lbl_GioDen.Text = "Giờ đến: "
                    + datatable.Rows[i]["ThoiGianDuKienDen"].ToString();
                vemaybay.Lbl_ThoiGianDuKien.Text = "Thời gian dự kiến bay: " 
                    + ((DateTime)datatable.Rows[i]["ThoiGianDuKienDen"])
                    .Subtract((DateTime)datatable.Rows[i]["ThoiGianDi"]).ToString();
                vemaybay.Lbl_MaMayBay.Text = datatable.Rows[i]["MaMayBay"].ToString();
                vemaybay.Lbl_MaChuyenBay.Text = datatable.Rows[i]["MaChuyenBay"].ToString();
                vemaybay.Btn_GiaVePhoThong.Text = datatable.Rows[i]["GiaVePhoThong"].ToString();
                vemaybay.Btn_GiaVeThuongGia.Text = datatable.Rows[i]["GiaVeThuongGia"].ToString();
                vemaybay.Lbl_SoGheConLaiPhoThong.Text = "Số ghế còn lại: "
                    + datatable.Rows[i]["SoVeConLaiPhoThong"].ToString();
                vemaybay.Lbl_SoGheConLaiThuongGia.Text = "Số ghế còn lại: "
                    + datatable.Rows[i]["SoVeConLaiThuongGia"].ToString();
                vemaybay.Location = new System.Drawing.Point(5, 5 + 130 * i);

                this.Pnl_DanhSachVe.Controls.Add(vemaybay);
            }
            this.Pnl_DanhSachVe.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
