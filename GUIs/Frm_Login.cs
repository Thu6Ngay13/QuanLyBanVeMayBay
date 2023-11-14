using QuanLyBanVeMayBay.BLLs;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.GUIs
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            BLL_Login bll = new BLL_Login();
            string error = "";

            string sodienthoai = Txt_Username_DNhap.Text.Trim();
            string matkhau = Txt_Password_DNhap.Text.Trim();

            DataSet dataset = bll.kiemtra_DangNhap(sodienthoai, matkhau, ref error);
            DataTable datatable = new DataTable();
            datatable.Clear();
            datatable = dataset.Tables[0];

            string stringconnection = datatable.Rows[0]["stringConnection"].ToString();
            string numofrole = datatable.Rows[0]["NumOfRole"].ToString();

            if (error != "") MessageBox.Show("Hệ thống gặp sự cố vui lòng quay lại sau");
            else if (stringconnection == "0") MessageBox.Show("Tài khoản mật khẩu không chính xác");
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                ConstantDATA.stringConnection = stringconnection;
                this.Hide();
                if (numofrole == "5")
                {
                    Frm_TrangChuNguoiQuanLy form = new Frm_TrangChuNguoiQuanLy();
                    form.ShowDialog();

                    this.Show();
                }
                else if(numofrole == "1")
                {
                    Frm_TrangChuNguoiDung form = new Frm_TrangChuNguoiDung();
                    form.ShowDialog();

                    this.Show();
                }
            }
        }

        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            BLL_Login bll = new BLL_Login();
            string error = "";

            string hoten = "";
            string sodienthoai = "";
            string email = "";
            string matkhau = "";

            bool dangkythanhcong = bll.dangky_TaiKhoan(hoten, sodienthoai, email, matkhau, ref error);

            if (error != "" || dangkythanhcong == false) MessageBox.Show("Số điện thoại hoặc email đã được sử dụng");
            else MessageBox.Show("Đăng ký thành công");
        }
    }
}
