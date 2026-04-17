using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DBClass
/// </summary>
public class DataProvider
{
    public static string ChuoiKetNoi
    {
        //Máy Nguyễn
        get { return @"Data Source=.;Initial Catalog=QLHS;Integrated Security=True;Encrypt=False"; }
        //Máy Kiên
        //get { return @"Data Source=.;Initial Catalog=QLHS;Integrated Security=True;Encrypt=False"; }
        //Máy Phú
        //get.....
    }

    public static bool TruyVan_XuLy(string sql)
    {
        SqlConnection con = new SqlConnection(ChuoiKetNoi);
        bool kq = false;
        try
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection.Open();
            int count = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            kq = count > 0;
        }
        catch
        {
            kq = false;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        return kq;
    }

    public static DataTable TruyVan_LayDuLieu(string sql)
    {
        SqlConnection con = new SqlConnection(ChuoiKetNoi);
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataTable kq = new DataTable();
        da.Fill(kq);
        return kq;
    }

    public static int ExcuteNonQuery(string sql, CommandType type, SqlParameter[] paras)
    {
        SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand();
        {
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            cmd.CommandType = type;
        }
        ;

        if (paras != null)//có tham số
            cmd.Parameters.AddRange(paras);

        int count = cmd.ExecuteNonQuery();

        cmd.Parameters.Clear(); // Xóa Parameters để giải phóng

        sqlcon.Close();
        return count;
    }

    public static DataTable SelectData(string sql, CommandType type, SqlParameter[] paras)
    {
        DataTable kq = new DataTable();
        SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
        sqlcon.Open();

        SqlCommand cmd = new SqlCommand
        {
            Connection = sqlcon,
            CommandText = sql,
            CommandType = type
        };

        if (paras != null)
            cmd.Parameters.AddRange(paras);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(kq);

        cmd.Parameters.Clear(); // Xóa Parameters để giải phóng

        sqlcon.Close();
        return kq;
    }

    public static DataSet SelectMultiData(string sql)
    {
        DataSet kq = new DataSet();
        SqlConnection sqlcon = new SqlConnection(ChuoiKetNoi);
        sqlcon.Open();

        SqlDataAdapter da = new SqlDataAdapter(sql, sqlcon);
        da.Fill(kq);

        sqlcon.Close();
        return kq;
    }
}