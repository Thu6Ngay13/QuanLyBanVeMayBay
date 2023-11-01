using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeQuanTriDemo01.Models
{
    public class ThongTinChuyenBay
    {
        string tenmaybay;
        string diemdi;
        string diemden;
        string thoigiandi;

        public ThongTinChuyenBay(string tenmaybay, string diemdi, string diemden, string thoigiandi)
        {
            this.TenMayBay = tenmaybay;
            this.DiemDi = diemdi;
            this.DiemDen = diemden;
            this.ThoiGianDi = thoigiandi;
        }

        public string TenMayBay { get => tenmaybay; set => tenmaybay = value; }
        public string DiemDi { get => diemdi; set => diemdi = value; }
        public string DiemDen { get => diemden; set => diemden = value; }
        public string ThoiGianDi { get => thoigiandi; set => thoigiandi = value; }
    }
}
