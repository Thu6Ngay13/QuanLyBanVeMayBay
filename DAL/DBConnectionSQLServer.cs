﻿using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace QuanLyBanVeMayBay.DAL
{
    public class DBConnectionSQlServer
    {
        private readonly string stringconnection = "Data Source = localhost;"
            + "Initial Catalog = QuanLyBanVeMayBay;"
            + "Integrated Security=True;";

        private readonly SqlConnection conn = null;
        private readonly SqlCommand cmd = null;

        public DBConnectionSQlServer() 
        {
            conn = new SqlConnection(stringconnection);
            cmd = conn.CreateCommand();
        }

        //Hàm này nhận vào
        //câu lệnh sql,
        //loại commandtype,
        //các tham số,
        //biến lấy về giá trị lỗi
        //thực hiện việc truy vấn có dữ liệu trả về
        public DataSet executeQuery(string sql, CommandType ct, SqlParameter[] sqlParameter, ref string error)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                cmd.CommandText = sql;
                if (sqlParameter != null) cmd.Parameters.AddRange(sqlParameter);
                cmd.CommandType = ct;

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
            return null;
        }

        //Hàm này nhận vào
        //câu lệnh sql,
        //loại commandtype,
        //các tham số,
        //biến lấy về giá trị lỗi
        //thực hiện việc truy vấn có không có dữ liệu trả về
        public bool executeNonQuery(string sql, CommandType ct, SqlParameter[] sqlParameter, ref string error)
        {
            bool flag = false;
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                cmd.CommandText = sql;
                if (sqlParameter != null) cmd.Parameters.AddRange(sqlParameter);
                cmd.CommandType = ct;

                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
            return flag;
        }
    }
}
