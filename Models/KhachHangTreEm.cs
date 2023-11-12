using System;

namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangTreEm
    {
        private int makhachhangtreem;
        private string hoten;
        private string gioitinh;
        private DateTime ngaysinh;

        private int magoihanhlychieudi;
        private float giatiengoihanhlychieudi;

        private int magoihanhlychieuve;
        private float giatiengoihanhlychieuve;

        private int mavechieudi;
        private float giatienvechieudi;

        private int mavechieuve;
        private float giatienvechieuve;

        public KhachHangTreEm(string hoten, string gioitinh, DateTime ngaysinh)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }

        public int Makhachhangtreem { get => makhachhangtreem; set => makhachhangtreem = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Magoihanhlychieudi { get => magoihanhlychieudi; set => magoihanhlychieudi = value; }
        public float Giatiengoihanhlychieudi { get => giatiengoihanhlychieudi; set => giatiengoihanhlychieudi = value; }
        public int Magoihanhlychieuve { get => magoihanhlychieuve; set => magoihanhlychieuve = value; }
        public float Giatiengoihanhlychieuve { get => giatiengoihanhlychieuve; set => giatiengoihanhlychieuve = value; }
        public int Mavechieudi { get => mavechieudi; set => mavechieudi = value; }
        public float Giatienvechieudi { get => giatienvechieudi; set => giatienvechieudi = value; }
        public int Mavechieuve { get => mavechieuve; set => mavechieuve = value; }
        public float Giatienvechieuve { get => giatienvechieuve; set => giatienvechieuve = value; }
    }
}
