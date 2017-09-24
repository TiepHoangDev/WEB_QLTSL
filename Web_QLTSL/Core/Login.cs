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
        const string QUYEN = "QUYEN";

        public bool CheckLogin(string Username, string Passord)
        {
            var ob = new NGUOI_DUNG_Bus().CheckLogin(Username, Passord);
            if (ob != null)
            {
                HttpContext.Current.Session[LOGIN] = ob;
                HttpContext.Current.Session[QUYEN] = new NGUOI_DUNG_QUYEN_Bus().GetBy_IdNguoiDung(ob.ID_NGUOIDUNG);
            }
            return ob != null;
        }

        public NGUOI_DUNG_Object GetNguoiDung()
        {
            return HttpContext.Current.Session[LOGIN] as NGUOI_DUNG_Object;
        }

        public List<NGUOI_DUNG_QUYEN_Object> GetAllQuyen()
        {
            return HttpContext.Current.Session[QUYEN] as List<NGUOI_DUNG_QUYEN_Object>;
        }

        public void Logout()
        {
            HttpContext.Current.Session[LOGIN] = null;
        }

    }
}