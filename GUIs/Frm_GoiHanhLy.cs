using HeQuanTriDemo01.Models;
using QuanLyBanVeMayBay.BLL;
using QuanLyBanVeMayBay.Models;
using QuanLyBanVeMayBay.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyBanVeMayBay.GUI
{
    public partial class Frm_GoiHanhLy : Form
    {
        BLL_GoiHanhLy GoiHanhLy = new BLL_GoiHanhLy();
        ThongTinChuyenBay thongTinChuyenBay = null;
        List<KhachHangNguoiLon> khachHangNguoiLons = new List<KhachHangNguoiLon>();
        List<KhachHangTreEm> khachHangTreEms = new List<KhachHangTreEm>();
        
        int thutunguoilon = 0;
        int thututreem = -1;
        bool khuhoi = false;
        int goihanhly_chieudi = 1;
        int goihanhly_chieuve = 0;

        public Frm_GoiHanhLy()
        {
            InitializeComponent();
        }

        public Frm_GoiHanhLy(
            List<KhachHangNguoiLon> khachHangNguoiLons, 
            List<KhachHangTreEm> khachHangTreEms, 
            ThongTinChuyenBay thongTinChuyenBay)
        {
            InitializeComponent();
            this.khachHangNguoiLons = khachHangNguoiLons;
            this.khachHangTreEms = khachHangTreEms;
            this.thongTinChuyenBay = thongTinChuyenBay;
            khuhoi = thongTinChuyenBay.Khuhoi;
        }

        private void Frm_GoiHanhLy_Load(object sender, System.EventArgs e)
        {
            LayGoiHanhLy(thutunguoilon);
        }
        private void LayGoiHanhLy(int thutu)
        {
            /*MessageBox.Show(thutu.ToString());*/
            if (thututreem == -1)
            {
                Lbl_TenKhachHang.Text = khachHangNguoiLons[thutu].Hoten;
            }
            else
            {
                Lbl_TenKhachHang.Text = khachHangTreEms[thutu].Hoten;
            }
            if (khuhoi)
            {
                Cmb_Chieu.Items.Clear();
                Cmb_Chieu.Items.Add("Chiều đi");
                Cmb_Chieu.Items.Add("Chiều về");
            }
            else
            {
                Cmb_Chieu.Items.Clear();
                Cmb_Chieu.Items.Add("Chiều đi");
            }
            Pnl_GoiHanhLy.Controls.Clear();
            DataSet ds = GoiHanhLy.LayGoiHanhLy();
            DataTable dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                UC_GoiHanhLy goihanhly = new UC_GoiHanhLy();
                goihanhly.Lbl_MaGoiHanhLy.Text = dt.Rows[i]["MaGoi"].ToString();
                goihanhly.Lbl_KhoiLuongMuaThem.Text = dt.Rows[i]["KhoiLuongMuaThem"].ToString();
                goihanhly.Lbl_Gia.Text = dt.Rows[i]["GiaTien"].ToString();

                goihanhly.Location = new System.Drawing.Point(10, 40 * i + 3);

                goihanhly.Btn_Chon.Click += Btn_Chon_Click;
                this.Pnl_GoiHanhLy.Controls.Add(goihanhly);
            }
        }
        private void Btn_Chon_Click(object sender, EventArgs e)
        {
            if (sender is Button Btn_Chon)
            {
                if (Btn_Chon.Parent is UC_GoiHanhLy goihanhly)
                {
                    BLL_GoiHanhLy GoiHanhLy = new BLL_GoiHanhLy();
                    DialogResult xacnhanmua = MessageBox.Show("Mỗi vé chỉ được mua 01 gói hành lý \n\nXác nhận mua/ thay đổi ?", "Mua gói hành lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    bool success = false;
                    if (xacnhanmua == DialogResult.Yes)
                    {
                        if (Cmb_Chieu.Text == "Chiều đi")
                        {
                            if (thututreem != -1)
                            {
                                foreach(KhachHangTreEm khachHangTreEm in khachHangTreEms)
                                {
                                    khachHangTreEm.Magoihanhlychieudi = Convert.ToInt32(goihanhly.Lbl_MaGoiHanhLy.Text);
                                }
                            }
                            else
                            {
                                foreach(KhachHangNguoiLon khachHangNguoiLon in khachHangNguoiLons)
                                {
                                    khachHangNguoiLon.Magoihanhlychieudi = Convert.ToInt32(goihanhly.Lbl_MaGoiHanhLy.Text);
                                }
                            }
                        }
                        else if (Cmb_Chieu.Text == "Chiều về")
                        {
                            if (thututreem != -1)
                            {
                                foreach (KhachHangTreEm khachHangTreEm in khachHangTreEms)
                                {
                                    khachHangTreEm.Magoihanhlychieudi = Convert.ToInt32(goihanhly.Lbl_MaGoiHanhLy.Text);
                                }
                            }
                            else
                            {
                                foreach (KhachHangNguoiLon khachHangNguoiLon in khachHangNguoiLons)
                                {
                                    khachHangNguoiLon.Magoihanhlychieudi = Convert.ToInt32(goihanhly.Lbl_MaGoiHanhLy.Text);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn hướng bay");
                        }
                    }
                    if (success)
                    {
                        MessageBox.Show("Mua thành công");
                    }
                }
            }
        }

        private void Btn_XoaGoiHanhLy_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult xacnhanmua = MessageBox.Show("Xác nhận xóa gói hành lý?", "Xóa gói hành lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (xacnhanmua == DialogResult.Yes)
                {
                    GoiHanhLy.them_GoiHanhLy("NULL", "6");
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi xóa gói hành lý");
            }
        }

        private void Btn_TiepTuc_GoiHanhLy_Click(object sender, EventArgs e)
        {
            if (thutunguoilon < khachHangNguoiLons.Count - 1)
            {
                thutunguoilon = thutunguoilon + 1;
                LayGoiHanhLy(thutunguoilon);
            }
            else
            {
                if (thututreem < khachHangTreEms.Count - 1)
                {
                    thututreem = thututreem + 1;
                    LayGoiHanhLy(thututreem);
                }
                else
                {
                    this.Close();   
                    Frm_ChonChoNgoi frm_ChonChoNgoi = new Frm_ChonChoNgoi(khachHangNguoiLons, khachHangTreEms, thongTinChuyenBay);
                    frm_ChonChoNgoi.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}
