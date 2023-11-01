using System;

namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangTreEm
    {
        private int makhachhangtreem;
        private string hoten;
        private string gioitinh;
        private string ngaysinh;

        private int magoihanhly;
        private int mavechieudi;
        private int mavechieuve;

        public KhachHangTreEm(string hoten, string gioitinh, string ngaysinh)
        {
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
        }

        public int Makhachhangtreem { get => makhachhangtreem; set => makhachhangtreem = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public int MaGoiHanhLy { get => magoihanhly; set => magoihanhly = value; }
        public int MaVeChieuDi { get => mavechieudi; set => mavechieudi = value; }
        public int MaVeChieuVe { get => mavechieuve; set => mavechieuve = value; }
    }
}
