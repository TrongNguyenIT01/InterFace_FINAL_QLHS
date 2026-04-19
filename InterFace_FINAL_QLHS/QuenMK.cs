using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_FINAL_QLHS
{
    internal class QuenMK
    {
        public static class QuenMK_Session
        {
            public static string EmailDangXuLy { get; set; }
            public static string MaOTP { get; set; }
            public static DateTime HanSuDung { get; set; }
        }
        public static class UserSession
        {
            public static string CurrentUsername { get; set; }
        }
    }
}
