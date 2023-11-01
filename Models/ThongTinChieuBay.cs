using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeQuanTriDemo01.Models
{
    public class ThongTinChieuBay
    {
        private int machuyenbay;
        private int mamaybay;
        private string diemdi;
        private string diemden;
        private string thoigiandi;

        public ThongTinChieuBay() { }

        public ThongTinChieuBay(
            int machuyenbay, 
            int mamaybay, 
            string diemdi, 
            string diemden, 
            string thoigiandi)
        {
            this.MaChuyenBay = machuyenbay;
            this.MaMayBay = mamaybay;
            this.DiemDi = diemdi;
            this.DiemDen = diemden;
            this.ThoiGianDi = thoigiandi;
        }

        public string DiemDi { get => diemdi; set => diemdi = value; }
        public string DiemDen { get => diemden; set => diemden = value; }
        public string ThoiGianDi { get => thoigiandi; set => thoigiandi = value; }
        public int MaChuyenBay { get => machuyenbay; set => machuyenbay = value; }
        public int MaMayBay { get => mamaybay; set => mamaybay = value; }
    }
}
