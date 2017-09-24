
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class NGUOI_DUNG_Bus
    {

        public List<NGUOI_DUNG_Object> GetAll()
        {
            return new NGUOI_DUNG_Dao().GetAll();
        }


        public NGUOI_DUNG_Object GetByID_NGUOIDUNG(System.Int32 ID_NGUOIDUNG)
        {
            return new NGUOI_DUNG_Dao().GetByID_NGUOIDUNG(ID_NGUOIDUNG);
        }


        public bool Insert(NGUOI_DUNG_Object ob)
        {
            return new NGUOI_DUNG_Dao().Insert(ob);
        }


        public bool Delete(System.Int32 ID_NGUOIDUNG)
        {
            return new NGUOI_DUNG_Dao().Delete(ID_NGUOIDUNG);
        }


        public bool Update(NGUOI_DUNG_Object ob)
        {
            return new NGUOI_DUNG_Dao().Update(ob);
        }

        public NGUOI_DUNG_Object CheckLogin(string Username, string Password)
        {
            return new NGUOI_DUNG_Dao().CheckLogin(Username, Password);
        }

        public bool ResetPassword(int ID_admin, string repass, int id_user)
        {
            return new NGUOI_DUNG_Dao().ResetPassword(ID_admin, repass, id_user);
        }
    }
}
