namespace QuanLyBanVeMayBay.Models
{
    public class KhachHangTreEm
    {
        private string hoten;
        private string gioitinh;
        private string ngaysinh;

        public KhachHangTreEm(string hoten, string gioitinh, string ngaysinh)
        {
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
