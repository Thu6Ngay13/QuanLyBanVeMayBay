using QuanLyBanVeMayBay.BLLs;
using QuanLyBanVeMayBay.UCs;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUIs
{
    public partial class Frm_CapNhat : Form
    {
        public Frm_CapNhat()
        {
            InitializeComponent();
        }
        private void Frm_CapNhat_Load(object sender, EventArgs e)
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error1 = "";
            string error2 = "";
            string error3 = "";

            DataSet dataset1 = bll.lay_DiemDi(ref error1);
            DataTable datatable1 = new DataTable();
            datatable1.Clear();
            datatable1 = dataset1.Tables[0];
            foreach (DataRow row in datatable1.Rows)
                Cbb_DiemDi.Items.Add(row["DiemDi"]);

            DataSet dataset2 = bll.lay_DiemDen(ref error2);
            DataTable datatable2 = new DataTable();
            datatable2.Clear();
            datatable2 = dataset2.Tables[0];
            foreach (DataRow row in datatable2.Rows)
                Cbb_DiemDen.Items.Add(row["DiemDen"]);

            DataSet dataset3 = bll.lay_TinhTrang(ref error3);
            DataTable datatable3 = new DataTable();
            datatable3.Clear();
            datatable3 = dataset3.Tables[0];
            foreach (DataRow row in datatable3.Rows)
                Cbb_TinhTrang.Items.Add(row["TinhTrangChuyenBay"]);

            timkiem_ChuyenBay("-1", "-1", new DateTime(2010, 1, 1), "-1");
        }

        public void timkiem_ChuyenBay(string diemdi, string diemden, DateTime ngaydi, string tinhtrangchuyenbay)
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error = "";

            DataSet dataset = bll.timkiem_ChuyenBay(diemdi, diemden, ngaydi, tinhtrangchuyenbay, ref error);
            DataTable datatable = new DataTable();
            datatable.Clear();
            datatable = dataset.Tables[0];

            this.SuspendLayout();
            this.Pnl_ThongTinChuyenBay.SuspendLayout();
            this.Pnl_ThongTinChuyenBay.Controls.Clear();

            for (int i = 0; i < datatable.Rows.Count; ++i)
            {
                UC_ThongTinChuyenBay ttcb = new UC_ThongTinChuyenBay();

                ttcb.Lbl_GioDi.Text = datatable.Rows[i]["ThoiGianDi"].ToString();
                ttcb.Lbl_GioDen.Text = datatable.Rows[i]["ThoiGianDuKienDen"].ToString();
                ttcb.Lbl_DiemDi.Text = datatable.Rows[i]["DiemDi"].ToString();
                ttcb.Lbl_DiemDen.Text = datatable.Rows[i]["DiemDen"].ToString();
                TimeSpan ThoiGianBayDuKien = ((DateTime)datatable.Rows[i]["ThoiGianDuKienDen"])
                    .Subtract((DateTime)datatable.Rows[i]["ThoiGianDi"]);
                ttcb.Lbl_ThoiGianDuKienBay.Text = ThoiGianBayDuKien.ToString("h' giờ 'mm");
                ttcb.Lbl_GiaVePhoThong.Text = "Giá vé phổ thông: " + datatable.Rows[i]["GiaVePhoThong"].ToString();
                ttcb.Lbl_GiaVeThuongGia.Text = "Giá vé thương gia: " + datatable.Rows[i]["GiaVeThuongGia"].ToString();
                ttcb.Location = new System.Drawing.Point(0, i * 145);
                ttcb.Dock = DockStyle.Top;

                this.Pnl_ThongTinChuyenBay.Controls.Add(ttcb);
            }

            this.Pnl_ThongTinChuyenBay.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void change_Value(object sender, EventArgs e)
        {
            
            string diemdi = (Cbb_DiemDi.Text.Trim().Equals("") ? "-1" : Cbb_DiemDi.Text.Trim());
            string diemden = (Cbb_DiemDen.Text.Trim().Equals("") ? "-1" : Cbb_DiemDen.Text.Trim());
            DateTime ngaydi = (Dtp_NgayDi.Checked ? Dtp_NgayDi.Value : new DateTime(2010, 1, 1));
            string tinhtrang = (Cbb_TinhTrang.Text.Trim().Equals("") ? "-1" : Cbb_TinhTrang.Text.Trim());
            //MessageBox.Show(ngaydi.ToString());
            timkiem_ChuyenBay(diemdi, diemden, ngaydi, tinhtrang);
        }
    }
}
