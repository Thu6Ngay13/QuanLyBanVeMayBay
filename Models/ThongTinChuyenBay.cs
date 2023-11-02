using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeQuanTriDemo01.Models
{
    public class ThongTinChuyenBay
    {
        private string diemdi;
        private string diemden;
        private DateTime thoigiandi;
        private DateTime thoigianve;

        private int sokhachnguoilon;
        private int sokhachtreem;

        private int machieudi;
        private int machieuve;

        public ThongTinChuyenBay() { }  
        public ThongTinChuyenBay(
            string diemdi,
            string diemden,
            DateTime thoigiandi,
            DateTime thoigianve,

            int sokhachnguoilon,
            int sokhachtreem,

            int machieudi,
            int machieuve)
        {
            Diemdi = diemdi;
            Diemden = diemden;
            Thoigiandi = thoigiandi;
            Thoigianve = thoigianve;

            Sokhachnguoilon = sokhachnguoilon;
            Sokhachtreem = sokhachtreem;

            Machieudi = machieudi;
            Machieuve = machieuve;
        }

        public string Diemdi { get => diemdi; set => diemdi = value; }
        public string Diemden { get => diemden; set => diemden = value; }
        public DateTime Thoigiandi { get => thoigiandi; set => thoigiandi = value; }
        public DateTime Thoigianve { get => thoigianve; set => thoigianve = value; }
        public int Sokhachnguoilon { get => sokhachnguoilon; set => sokhachnguoilon = value; }
        public int Sokhachtreem { get => sokhachtreem; set => sokhachtreem = value; }
        public int Machieudi { get => machieudi; set => machieudi = value; }
        public int Machieuve { get => machieuve; set => machieuve = value; }
    }
}
