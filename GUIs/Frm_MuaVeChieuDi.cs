using System;
using System.Data;
using System.Windows.Forms;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.UC;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_MuaVeChieuDi : Form
    {
        public Frm_MuaVeChieuDi()
        {
            InitializeComponent();
        }

        private void Frm_MuaVeChieuDi_Load(object sender, EventArgs e)
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error = "";

            //DataSet dataset = bll.timkiem_VeMayBay("Hà Nội", "Tokyo", new DateTime(2023, 10, 15), 0, ref error);
            DataSet dataset = bll.timkiem_VeMayBay("-1", "-1", new DateTime(2010, 1, 1), -1, ref error);
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
                vemaybay.Lbl_MaMayBayChuyenBay.Text = "Số hiệu chuyến bay: "
                    + datatable.Rows[i]["MaMayBay"].ToString() 
                    + " - " + datatable.Rows[i]["MaChuyenBay"].ToString();
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
