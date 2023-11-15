using QuanLyBanVeMayBay.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanVeMayBay.BLL
{
    public class BLL_HoaDon
    {
        DBConnectionSQlServer db = null;
        public BLL_HoaDon()
        {
            db = new DBConnectionSQlServer();   
        }

        // Hàm nhận tham số mã hóa đơn và trả về danh sách chi tiết vé máy bay
        public DataSet ThongTinHoaDon(string MaHoaDon, ref string error)
        {
            string sql = "SELECT * FROM tracuu_HoaDon_FUNC(@MaHoaDon)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter()
            {
                ParameterName = "@MaHoaDon",
                Value = MaHoaDon
            };
            return db.executeQuery(sql, CommandType.Text, sqlParameters, ref error);
        }

        // Hàm nhận tham số mã vé máy bay và thực hiện hủy vé trong cơ sở dữ liệu
        public bool HuyVe(string MaVe, ref string error)
        {
            string sql = "EXEC huy_Ve_PROC @MaVe";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter()
            {
                ParameterName = "@MaVe",
                Value = MaVe
            };
            return db.executeNonQuery(sql, CommandType.Text, sqlParameters, ref error);
        }

        // Hàm khởi tạo hóa đơn mới và trả về mã hóa đơn vừa tạo
        public int khoitao_HoaDon(ref string error)
        {
            string sql = 
                "EXEC dbo.khoitao_HoaDon_PROC " +
                "@MaHoaDon OUTPUT";

            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter()
            {
                ParameterName = "@MaHoaDon",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            bool success = db.executeNonQuery(sql, CommandType.Text, sqlParameter, ref error);
            int mahoadon = (int)sqlParameter[0].Value;

            if (success) return mahoadon;
            return -1;
        }

        // Hàm nhận vào 2 tham số: mã người dùng, mã hóa đơn
        // Trả về thông tin lịch sử giao dịch của người dùng bao gồm: 
        // số điện thoại, mã hóa đơn, tổng tiền thanh toán, thời gian thanh toán
        public DataSet timkiem_LichSuGiaoDich(int manguoidung, int mahoadon, ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM timkiem_LichSuGiaoDich_FUNC(" +
                    "@MaNguoiDung, " +
                    "@MaHoaDon" +
                ")";

            SqlParameter[] sqlParameter = new SqlParameter[2];
            sqlParameter[0] = new SqlParameter()
            {
                ParameterName = "@MaNguoiDung",
                Value = manguoidung
            };

            sqlParameter[1] = new SqlParameter()
            {
                ParameterName = "@MaHoaDon",
                Value = ((mahoadon == -1) ? DBNull.Value : (object)mahoadon)
            };

            return db.executeQuery(sql, CommandType.Text, sqlParameter, ref error);
        }
    }
}