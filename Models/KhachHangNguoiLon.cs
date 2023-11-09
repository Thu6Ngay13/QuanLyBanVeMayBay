namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangNguoiLon
    {
        private int makhachhangnguoilon;
        private string hoten;
        private string gioitinh;
        private string ngaysinh;
        private string sodienthoai;
        private string email;
        private string diachi;
        private int magoihanhlychieudi;
        private int magoihanhlychieuve;
        private int mavechieudi;
        private int mavechieuve;

        public KhachHangNguoiLon() {}
        public KhachHangNguoiLon(
            string hoten, 
            string gioitinh, 
            string ngaysinh, 
            string sodienthoai, 
            string email, 
            string diachi)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.email = email;
            this.diachi = diachi;
        }

        public int MaKhachHangNguoiLon { get => makhachhangnguoilon; set => makhachhangnguoilon = value; }  
        public string HoTen { get => hoten; set => hoten = value; }
        public string GioiTinh {  get => gioitinh; set => gioitinh = value;}
        public string NgaySinh { get => ngaysinh; set => ngaysinh = value;}
        public string SoDienThoai { get => sodienthoai; set => sodienthoai = value;}
        public string Email {  get => email; set => email = value;} 
        public string DiaChi { get => diachi; set => diachi = value;}
        public int Mavechieudi { get => mavechieudi; set => mavechieudi = value; }
        public int Mavechieuve { get => mavechieuve; set => mavechieuve = value; }
        public int Magoihanhlychieudi { get => magoihanhlychieudi; set => magoihanhlychieudi = value; }
        public int Magoihanhlychieuve { get => magoihanhlychieuve; set => magoihanhlychieuve = value; }
    }
}

