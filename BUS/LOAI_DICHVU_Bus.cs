
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class LOAI_DICHVU_Bus
    {
        
public List<LOAI_DICHVU_Object> GetAll()
{
    return new LOAI_DICHVU_Dao().GetAll();
}

        
public LOAI_DICHVU_Object GetByID_LOAI_DICHVU(System.Int32 ID_LOAI_DICHVU)
{
    return new LOAI_DICHVU_Dao().GetByID_LOAI_DICHVU(ID_LOAI_DICHVU);
}

        
public bool Insert(LOAI_DICHVU_Object ob)
{
    return new LOAI_DICHVU_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_LOAI_DICHVU)
{
    return new LOAI_DICHVU_Dao().Delete(ID_LOAI_DICHVU);
}

        
public bool Update(LOAI_DICHVU_Object ob)
{
    return new LOAI_DICHVU_Dao().Update(ob);
}

    }
}
