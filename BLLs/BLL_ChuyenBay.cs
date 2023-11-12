using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanVeMayBay.DAL;

namespace QuanLyBanVeMayBay.BLL
{
    public class BLL_ChuyenBay
    {
        public DBConnectionSQlServer db = null;

        public BLL_ChuyenBay() 
        {
            db = new DBConnectionSQlServer();
        }  

        public DataSet lay_DiemDi(ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM lay_DiemDi()";

            return db.executeQuery(sql, CommandType.Text, null, ref error);
        }

        public DataSet lay_DiemDen(ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM lay_DiemDen()";

            return db.executeQuery(sql, CommandType.Text, null, ref error);
        }

        public DataSet lay_TinhTrang(ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM lay_TinhTrang()";
            return db.executeQuery(sql, CommandType.Text, null, ref error);
        }

        public DataSet lay_DanhSachChoNgoi_PROC(int machuyenbay,ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM lay_DanhSachChoNgoi_PROC(@MaChuyenBay)";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter()
            {
                ParameterName = "@MaChuyenBay",
                Value = machuyenbay
            };
            return db.executeQuery(sql, CommandType.Text, sqlParameter, ref error);
        }

        public DataSet lay_DeXuatChuyenBay(
            int soluongdexuat, 
            string diemdi,
            string diemden,
            float ngansach,
            ref string error)
        {
            string sql = 
                "SELECT * " +
                "FROM lay_DeXuatChuyenBay_FUNC(" +
                    "@SoLuongDeXuat, " +
                    "@DiemDi, " +
                    "@DiemDen, " +
                    "@NganSach" +
                ")";

            SqlParameter[] sqlParameter = new SqlParameter[4];
            sqlParameter[0] = new SqlParameter() 
            { 
                ParameterName = "@SoLuongDeXuat",
                Value = soluongdexuat
            };

            sqlParameter[1] = new SqlParameter()
            {
                ParameterName = "@DiemDi",
                Value = ((diemdi == "-1") ? DBNull.Value : (object)diemdi)
            };

            sqlParameter[2] = new SqlParameter()
            {
                ParameterName = "@DiemDen",
                Value = ((diemden == "-1") ? DBNull.Value : (object)diemden)
            };

            sqlParameter[3] = new SqlParameter()
            {
                ParameterName = "@NganSach",
                Value = ((ngansach == -1) ? DBNull.Value : (object)ngansach)

            };

            return db.executeQuery(sql, CommandType.Text, sqlParameter, ref error);
        }

        public DataSet timkiem_VeMayBay(
            string diemdi,
            string diemden,
            DateTime ngaydi,
            int sohanhkhach,
            ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM timkiem_VeMayBay_FUNC(" +
                    "@DiemDi, " +
                    "@DiemDen, " +
                    "@NgayDi, " +
                    "@SoHanhKhach" +
                ")";

            SqlParameter[] sqlParameter = new SqlParameter[4];
            sqlParameter[0] = new SqlParameter()
            {
                ParameterName = "@DiemDi",
                Value = ((diemdi == "-1") ? DBNull.Value : (object)diemdi)
            };

            sqlParameter[1] = new SqlParameter()
            {
                ParameterName = "@DiemDen",
                Value = ((diemden == "-1") ? DBNull.Value : (object)diemden)
            };

            sqlParameter[2] = new SqlParameter()
            {
                ParameterName = "@NgayDi",
                Value = (ngaydi.Equals(new DateTime(2010, 1, 1)) ? DBNull.Value : (object) ngaydi)
            };

            sqlParameter[3] = new SqlParameter()
            {
                ParameterName = "@SoHanhKhach",
                Value = ((sohanhkhach == -1) ? DBNull.Value : (object)sohanhkhach)

            };

            return db.executeQuery(sql, CommandType.Text, sqlParameter, ref error);
        }

        public DataSet timkiem_ChuyenBay(
            string DiemDi, 
            string DiemDen,
            DateTime NgayDi,
            string TinhTrangChuyenBay,
            ref string error)
        {
            string sql =
                "SELECT * " +
                "FROM timkiem_ChuyenBay_FUNC(" +
                    "@DiemDi, " +
                    "@DiemDen, " +
                    "@NgayDi, " +
                    "@TinhTrangChuyenBay" +
                ")";

            SqlParameter[] sqlParameter = new SqlParameter[4];
            sqlParameter[0] = new SqlParameter()
            {
                ParameterName = "@DiemDi",
                Value = ((DiemDi == "-1") ? DBNull.Value : (object)DiemDi)
            };

            sqlParameter[1] = new SqlParameter()
            {
                ParameterName = "@DiemDen",
                Value = ((DiemDen == "-1") ? DBNull.Value : (object)DiemDen)
            };

            sqlParameter[2] = new SqlParameter()
            {
                ParameterName = "@NgayDi",
                Value = (NgayDi.Equals(new DateTime(2010, 1, 1)) ? DBNull.Value : (object)NgayDi)
            };

            sqlParameter[3] = new SqlParameter()
            {
                ParameterName = "@TinhTrangChuyenBay",
                Value = ((TinhTrangChuyenBay == "-1") ? DBNull.Value : (object)TinhTrangChuyenBay)
            };

            return db.executeQuery(sql, CommandType.Text, sqlParameter, ref error);
        }
        public void ThemChuyenBay(
            int MaMayMay,
            string LoaiChuyenBay,
            string DiemDi,
            string DiemDen,
            DateTime ThoiGiandi,
            DateTime ThoiGianDuKienDen,
            string ChiPhi,
            string GiaVePhoThong,
            string GiaVeThuongGia,
            string KhoiLuongHanhLy,
            ref string error)
        {
            string sql = "DECLARE @MaChuyenBay INT\r\n" +
                         "EXEC them_ChuyenBay_PROC " +
                         "@MaChuyenBay OUTPUT, " +
                         "@LoaiChuyenBay, " +
                         "@DiemDi, " +
                         "@DiemDen, " +
                         "@ThoiGiandi, " +
                         "@ThoiGianDuKienDen, " +
                         "N'Chưa cất cánh', " +
                         "@ChiPhi\r\n" +
                         "SELECT @MaChuyenBay";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LoaiChuyenBay", LoaiChuyenBay),
                new SqlParameter("@DiemDi", DiemDi),
                new SqlParameter("@DiemDen", DiemDen),
                new SqlParameter("@ThoiGiandi", ThoiGiandi),
                new SqlParameter("@ThoiGianDuKienDen", ThoiGianDuKienDen),
                new SqlParameter("@ChiPhi", ChiPhi)
            
            };

            DataSet ds = new DataSet();
            ds = db.executeQuery(sql, CommandType.Text, sqlParameters, ref error);
            string MaChuyenBay = ds.Tables[0].Rows[0][0].ToString();

            ThemMayBayKhoiTaoChuyenBay(MaMayMay, MaChuyenBay, ref error);
            ThemChuyenBayPhatHanhVeMayBay(GiaVeThuongGia, GiaVePhoThong, KhoiLuongHanhLy, MaChuyenBay, ref error);
        }

        private bool ThemMayBayKhoiTaoChuyenBay(int MaMayBay, string MaChuyenBay, ref string error)
        {
            string sql = "EXEC khoitao_ChuyenBay_PROC " +
                         "@MaMayBay, " +
                         "@MaChuyenBay";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaMayBay", MaMayBay),
                new SqlParameter("@MaChuyenBay", MaChuyenBay),
            };
            return db.executeNonQuery(sql, CommandType.Text, sqlParameters, ref error);
        }

        private bool ThemChuyenBayPhatHanhVeMayBay(string GiaVeThuongGia, string GiaVePhoThong, string KhoiLuongHanhLy, string MaChuyenMay, ref string error)
        {
            string sql = "EXEC phathanh_VeMayBay_PROC " +
                         "@GiaVeThuongGia, " +
                         "@GiaVePhoThong, " +
                         "@KhoiLuongHanhLy, " +
                         "@MaChuyenBay";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@GiaVeThuongGia", GiaVeThuongGia),
                new SqlParameter("@GiaVePhoThong", GiaVePhoThong),
                new SqlParameter("@KhoiLuongHanhLy", KhoiLuongHanhLy),
                new SqlParameter("@MaChuyenBay", MaChuyenMay)
            };
            return db.executeNonQuery(sql, CommandType.Text, sqlParameters, ref error);
        }
    }
}