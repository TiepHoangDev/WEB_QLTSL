
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class LOAI_DICHVU_Dao
    {
        
public List<LOAI_DICHVU_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_LOAI_DICHVU_GetAll();
    List<LOAI_DICHVU_Object> lst = new List<LOAI_DICHVU_Object>();
    foreach (var item in list)
    {
        var obj = new LOAI_DICHVU_Object();
        
obj.ID_LOAI_DICHVU = item.ID_LOAI_DICHVU  ;
obj.TEN_LOAI_DICHVU = item.TEN_LOAI_DICHVU  ;
        lst.Add(obj);
    }
    return lst;
}

        
public LOAI_DICHVU_Object GetByID_LOAI_DICHVU(System.Int32 ID_LOAI_DICHVU)
{
    var list =  new dbQLTSLEntities().SP_LOAI_DICHVU_GetByID_LOAI_DICHVU(ID_LOAI_DICHVU);
    foreach (var item in list)
    {
        var obj = new LOAI_DICHVU_Object();
        
obj.ID_LOAI_DICHVU = item.ID_LOAI_DICHVU  ;
obj.TEN_LOAI_DICHVU = item.TEN_LOAI_DICHVU  ;
        return obj;
    }
    return null;
}

        
public bool Insert(LOAI_DICHVU_Object ob)
{
    return new dbQLTSLEntities().SP_LOAI_DICHVU_Insert( ob.TEN_LOAI_DICHVU )>0;
}

        
public bool Delete( System.Int32 ID_LOAI_DICHVU)
{
    return new dbQLTSLEntities().SP_LOAI_DICHVU_Delete( ID_LOAI_DICHVU)>0;
}

        
public bool Update(LOAI_DICHVU_Object ob)
{
    return new dbQLTSLEntities().SP_LOAI_DICHVU_Update( ob.ID_LOAI_DICHVU , ob.TEN_LOAI_DICHVU )>0;
}

    }
}
