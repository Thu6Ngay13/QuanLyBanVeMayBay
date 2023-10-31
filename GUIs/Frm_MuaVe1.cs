using QuanLyBanVeMayBay.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanVeMayBay.GUI.Form_HanhKhach;

namespace DoAn
{
    public partial class Frm_MuaVe1 : Form
    {
        public Frm_MuaVe1()
        {
            InitializeComponent();
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

        private void Btn_HanhKhach_Click(object sender, EventArgs e)
        {
            Frm_HanhKhach form = new Frm_HanhKhach();
            form.ShowDialog();  

        }
    }
}
