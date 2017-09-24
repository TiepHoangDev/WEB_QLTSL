
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class DON_VI_Bus
    {

        public List<DON_VI_Object> GetAll()
        {
            return new DON_VI_Dao().GetAll();
        }


        public DON_VI_Object GetByID_DONVI(System.Int32 ID_DONVI)
        {
            return new DON_VI_Dao().GetByID_DONVI(ID_DONVI);
        }


        public bool Insert(DON_VI_Object ob)
        {
            return new DON_VI_Dao().Insert(ob);
        }


        public bool Delete(System.Int32 ID_DONVI)
        {
            return new DON_VI_Dao().Delete(ID_DONVI);
        }


        public bool Update(DON_VI_Object ob)
        {
            return new DON_VI_Dao().Update(ob);
        }

    }
}
