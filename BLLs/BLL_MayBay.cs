using QuanLyBanVeMayBay.DAL;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanVeMayBay.BLLs
{
    public class BLL_MayBay
    {
        DBConnectionSQlServer db = null;
        SqlParameter[] parameters = null;
        string err = "";
        public BLL_MayBay()
        {
            db = new DBConnectionSQlServer();
        }
        public DataSet DanhSachMayBay()
        {
            return db.executeQuery("select MaMaybay from view_ThongTinMayBay", CommandType.Text, parameters, ref err);
        }
    }
}
