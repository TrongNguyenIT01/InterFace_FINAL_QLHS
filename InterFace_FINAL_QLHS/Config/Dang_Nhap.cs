using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace InterFace_FINAL_QLHS.Config
{
    public class Dang_Nhap
    {
        public static bool checkDN(string username, string password, int role) 
        {
            string sql = "SELECT * FROM Users WHERE (UserName = @username Or Email=@username) AND Pass_word = @password AND Quyen =@role";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@role", role)
            };
            DataTable dt = DataProvider.SelectData(sql, CommandType.Text, parameters);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}
