using QuanLyBanVeMayBay.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeMayBay.BLLs
{
    public class BLL_DoanhThu
    {
        DBConnectionSQlServer db = null;
        SqlParameter[] parameters = null;
        string err = "";

        public BLL_DoanhThu()
        {
            db = new DBConnectionSQlServer();
        }
        public DataSet lay_Nam()
        {
            return db.executeQuery("SELECT DISTINCT YEAR(ThoiGianThanhToan) as Nam FROM view_ThongTinHoaDon", CommandType.Text, parameters, ref err);
        }

        public DataSet lay_DoanhThuTheoThang(int nam)
        {
            string sql = "SELECT MONTH(ThoiGianThanhToan) as Thang, sum(TongTien - TongTien * Thue) as DoanhThu\r\n" +
                         "FROM view_ThongTinHoaDon\r\n" +
                         "WHERE YEAR(ThoiGianThanhToan) = @nam\r\n" +
                         "GROUP BY MONTH(ThoiGianThanhToan)";

            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter()
            {
                ParameterName = "@nam",
                Value = nam
            };
            return db.executeQuery(sql, CommandType.Text, parameters, ref err);
        }
    }
}
