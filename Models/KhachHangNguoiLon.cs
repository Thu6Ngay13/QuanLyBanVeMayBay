namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangNguoiLon
    {
        private string hoten;
        private string gioitinh;
        private string ngaysinh;
        private string sodienthoai;
        private string email;
        private string diachi;

        public KhachHangNguoiLon(string hoten, string gioitinh, string ngaysinh, string sodienthoai, string email, string diachi)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.email = email;
            this.diachi = diachi;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.email = email;
            this.diachi = diachi;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Email { get => email; set => email = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
