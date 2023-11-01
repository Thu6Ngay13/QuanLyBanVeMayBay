using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.UC;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_TimKiemChuyenBay : Form
    {
        private bool chuyenbayduocdexuat = false;
        private string diemdi = "-1";
        private string diemden = "-1";
        private DateTime ngaydi = new DateTime(2010, 1, 1);
        private int soluonghanhkhach = -1;

        public Frm_TimKiemChuyenBay()
        {
            InitializeComponent();
            Rdb_MotChieu.Checked = true;
        }

        public Frm_TimKiemChuyenBay(string diemdi, string diemden, DateTime ngaydi)
        {
            InitializeComponent();
            Rdb_MotChieu.Checked = true;    
            chuyenbayduocdexuat = true;
            this.diemdi = diemdi;
            this.diemden = diemden;
            this.ngaydi = ngaydi;   
        }

        private void Frm_MuaVe1_Load(object sender, EventArgs e)
        {
            BLL_ChuyenBay bll = new BLL_ChuyenBay();
            string error1 = "";
            string error2 = "";

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

            if (chuyenbayduocdexuat) 
                nhan_ThongTinChuyenBayDeXuat();
        }

        private void Rdb_MotChieu_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_MotChieu.Checked)
            {
                Rdb_KhuHoi.Checked = false;
                Pnl_NgayVe.Hide();
            }
        }

        private void Rdb_KhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_KhuHoi.Checked)
            {
                Rdb_MotChieu.Checked = false;
                Pnl_NgayVe.Show();
            }
        }

        public void nhap_HanhKhach()
        {
            Frm_HanhKhach form = new Frm_HanhKhach();
            form.ShowDialog();

            int SoKhachNguoiLon = (int)form.Nud_NguoiLon.Value;
            int SoKhachTreEm = (int)form.Nud_TreEm.Value;
            string skn = "- " + SoKhachTreEm.ToString() + " trẻ em";
            if (SoKhachTreEm == 0)
            {
                skn = "";
            }
            soluonghanhkhach = SoKhachNguoiLon + SoKhachTreEm;

            this.Txt_HanhKhach.Text = " " + SoKhachNguoiLon.ToString() + " người lớn " + skn;
        }

        private void Btn_HanhKhach_Click(object sender, EventArgs e)
        {
            nhap_HanhKhach();
        }

        private void nhan_ThongTinChuyenBayDeXuat()
        {
            Cbb_DiemDi.Text = diemdi;
            Cbb_DiemDen.Text = diemden;
            Dtp_NgayDi.Value = ngaydi;
        }

        private void Btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (soluonghanhkhach == -1)
            {
                DialogResult temp = MessageBox.Show("Bạn chưa nhập số lượng hành khách!", "Warning", MessageBoxButtons.OK);
                if (temp == DialogResult.OK)
                {
                    nhap_HanhKhach();
                }
            }
            else if (soluonghanhkhach != -1)
            {
                Frm_MuaVeChieuDi muavechieudi = new Frm_MuaVeChieuDi(diemdi, diemden, ngaydi, soluonghanhkhach);
                muavechieudi.ShowDialog();
            }
        }
    }
}

