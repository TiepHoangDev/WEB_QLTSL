using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BUS;
using DTO;

namespace Web_QLTSL.Core
{
    public class Login
    {
        const string LOGIN = "LOGIN";

        public bool CheckLogin(string Username, string Passord)
        {
            var ob = new NGUOI_DUNG_Bus().CheckLogin(Username, Passord);
            if (ob != null)
            {
                HttpContext.Current.Session[LOGIN] = ob;
            }
            return ob != null;
        }

        public NGUOI_DUNG_Object GetNguoiDung()
        {
            return HttpContext.Current.Session[LOGIN] as NGUOI_DUNG_Object;
        }

        public void Logout()
        {
            HttpContext.Current.Session[LOGIN] = null;
        }

    }
}