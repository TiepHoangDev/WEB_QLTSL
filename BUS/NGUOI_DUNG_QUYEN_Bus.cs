
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class NGUOI_DUNG_QUYEN_Bus
    {

        public List<NGUOI_DUNG_QUYEN_Object> GetAll()
        {
            return new NGUOI_DUNG_QUYEN_Dao().GetAll();
        }


        public NGUOI_DUNG_QUYEN_Object GetByID(System.Int32 ID)
        {
            return new NGUOI_DUNG_QUYEN_Dao().GetByID(ID);
        }


        public bool Insert(NGUOI_DUNG_QUYEN_Object ob)
        {
            return new NGUOI_DUNG_QUYEN_Dao().Insert(ob);
        }


        public bool Delete(System.Int32 ID)
        {
            return new NGUOI_DUNG_QUYEN_Dao().Delete(ID);
        }

        public List<NGUOI_DUNG_QUYEN_Object> GetBy_IdNguoiDung(int iD_NGUOIDUNG)
        {
            return new NGUOI_DUNG_QUYEN_Dao().GetBy_IdNguoiDung(iD_NGUOIDUNG);
        }

        public bool Update(NGUOI_DUNG_QUYEN_Object ob)
        {
            return new NGUOI_DUNG_QUYEN_Dao().Update(ob);
        }


        public List<NGUOI_DUNG_QUYEN_Object> GetByID_NGUOIDUNG(int id)
        {
            return new NGUOI_DUNG_QUYEN_Dao().GetByID_NGUOIDUNG(id);
        }
    }
}
