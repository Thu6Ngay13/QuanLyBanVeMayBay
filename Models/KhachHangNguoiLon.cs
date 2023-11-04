using System;

namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangNguoiLon
    {
        private int makhachhangnguoilon;
        private string hoten;

        private string gioitinh;
        private DateTime ngaysinh;
        private string sodienthoai;
        private string email;
        private string diachi;
        
        private int magoihanhly;
        private int mavechieudi;
        private int mavechieuve;

        public KhachHangNguoiLon() {}
        public KhachHangNguoiLon(
            string hoten, 
            string gioitinh,
            DateTime ngaysinh, 
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

        public int Makhachhangnguoilon { get => makhachhangnguoilon; set => makhachhangnguoilon = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Email { get => email; set => email = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Magoihanhly { get => magoihanhly; set => magoihanhly = value; }
        public int Mavechieudi { get => mavechieudi; set => mavechieudi = value; }
        public int Mavechieuve { get => mavechieuve; set => mavechieuve = value; }
    }
}

