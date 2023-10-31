using QuanLyBanVeMayBay.DAL;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyBanVeMayBay.BLL
{
    public class BLL_GoiHanhLy
    {
        DBConnectionSQlServer db = null;
        SqlParameter[] parameters = null;
        string err = "";
        public BLL_GoiHanhLy()
        {
            db = new DBConnectionSQlServer();
        }
        public DataSet LayGoiHanhLy()
        {
            return db.executeQuery("select * from lay_GoiHanhLy", CommandType.Text, parameters, ref err);
        }
        public bool them_GoiHanhLy(string MaGoiHanhLy, string MaVe)
        {
            string sql = "EXEC them_GoiHanhLy_PROC @MaGoiHanhLy = " + MaGoiHanhLy + " , @MaVe = " + MaVe + ";";
            return db.executeNonQuery(sql, CommandType.Text, parameters, ref err);
        }
    }
}
