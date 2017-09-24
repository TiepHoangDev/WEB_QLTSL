
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class NGUOI_DUNG_QUYEN_Dao
    {

        public List<NGUOI_DUNG_QUYEN_Object> GetAll()
        {
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_GetAll();
            List<NGUOI_DUNG_QUYEN_Object> lst = new List<NGUOI_DUNG_QUYEN_Object>();
            foreach (var item in list)
            {
                var obj = new NGUOI_DUNG_QUYEN_Object();

                obj.ID = item.ID;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.ID_QUYEN = item.ID_QUYEN;
                obj.NGUOI_DUNG_ObjectJoin = new NGUOI_DUNG_Object()
                {

                    HO_TEN = item.HO_TEN_NGUOI_DUNGJoin,
                    ID_DONVI = item.ID_DONVI_NGUOI_DUNGJoin,
                    ID_NGUOIDUNG = (System.Int32)item.ID_NGUOIDUNG,
                    SDT = item.SDT_NGUOI_DUNGJoin,
                    USERNAME = item.USERNAME_NGUOI_DUNGJoin
                };

                obj.QUYEN_ObjectJoin = new QUYEN_Object()
                {

                    ID_QUYEN = (System.Int32)item.ID_QUYEN,
                    TEN_QUYEN = item.TEN_QUYEN_QUYENJoin
                };

                lst.Add(obj);
            }
            return lst;
        }

        public List<NGUOI_DUNG_QUYEN_Object> GetBy_IdNguoiDung(int iD_NGUOIDUNG)
        {
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG(iD_NGUOIDUNG);
            List<NGUOI_DUNG_QUYEN_Object> lst = new List<NGUOI_DUNG_QUYEN_Object>();
            foreach (var item in list)
            {
                var obj = new NGUOI_DUNG_QUYEN_Object();

                obj.ID = item.ID;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.ID_QUYEN = item.ID_QUYEN;

                obj.NGUOI_DUNG_ObjectJoin = new NGUOI_DUNG_Object()
                {
                    HO_TEN = item.HO_TEN_NGUOI_DUNGJoin,
                    ID_DONVI = item.ID_DONVI_NGUOI_DUNGJoin,
                    ID_NGUOIDUNG = (System.Int32)item.ID_NGUOIDUNG
                };

                obj.QUYEN_ObjectJoin = new QUYEN_Object()
                {
                    ID_QUYEN = (System.Int32)item.ID_QUYEN,
                    TEN_QUYEN = item.TEN_QUYEN_QUYENJoin
                };

                lst.Add(obj);
            }
            return lst;
        }

        public NGUOI_DUNG_QUYEN_Object GetByID(System.Int32 ID)
        {
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_GetByID(ID);
            foreach (var item in list)
            {
                var obj = new NGUOI_DUNG_QUYEN_Object();

                obj.ID = item.ID;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.ID_QUYEN = item.ID_QUYEN;
                obj.NGUOI_DUNG_ObjectJoin = new NGUOI_DUNG_Object()
                {

                    HO_TEN = item.HO_TEN_NGUOI_DUNGJoin,
                    ID_DONVI = item.ID_DONVI_NGUOI_DUNGJoin,
                    ID_NGUOIDUNG = (System.Int32)item.ID_NGUOIDUNG,
                    SDT = item.SDT_NGUOI_DUNGJoin,
                    USERNAME = item.USERNAME_NGUOI_DUNGJoin
                };

                obj.QUYEN_ObjectJoin = new QUYEN_Object()
                {

                    ID_QUYEN = (System.Int32)item.ID_QUYEN,
                    TEN_QUYEN = item.TEN_QUYEN_QUYENJoin
                };

                return obj;
            }
            return null;
        }


        public bool Insert(NGUOI_DUNG_QUYEN_Object ob)
        {
            return new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_Insert(ob.ID_NGUOIDUNG, ob.ID_QUYEN) > 0;
        }


        public bool Delete(System.Int32 ID)
        {
            return new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_Delete(ID) > 0;
        }


        public bool Update(NGUOI_DUNG_QUYEN_Object ob)
        {
            return new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_Update(ob.ID, ob.ID_NGUOIDUNG, ob.ID_QUYEN) > 0;
        }


        public List<NGUOI_DUNG_QUYEN_Object> GetByID_NGUOIDUNG(int id)
        {
            var list = new dbQLTSLEntities().SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG(id);
            List<NGUOI_DUNG_QUYEN_Object> lst = new List<NGUOI_DUNG_QUYEN_Object>();
            foreach (var item in list)
            {
                var obj = new NGUOI_DUNG_QUYEN_Object();

                obj.ID = item.ID;
                obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG;
                obj.ID_QUYEN = item.ID_QUYEN;

                obj.NGUOI_DUNG_ObjectJoin = new NGUOI_DUNG_Object()
                {
                    HO_TEN = item.HO_TEN_NGUOI_DUNGJoin,
                    ID_DONVI = item.ID_DONVI_NGUOI_DUNGJoin,
                    ID_NGUOIDUNG = (System.Int32)item.ID_NGUOIDUNG
                };

                obj.QUYEN_ObjectJoin = new QUYEN_Object()
                {
                    ID_QUYEN = (System.Int32)item.ID_QUYEN,
                    TEN_QUYEN = item.TEN_QUYEN_QUYENJoin
                };

                lst.Add(obj);
            }
            return lst;
        }
    }
}
