
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class THIET_BI_Dao
    {
        
public List<THIET_BI_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_THIET_BI_GetAll();
    List<THIET_BI_Object> lst = new List<THIET_BI_Object>();
    foreach (var item in list)
    {
        var obj = new THIET_BI_Object();
        
obj.ID_THIETBI = item.ID_THIETBI  ;
obj.TEN_THIETBI = item.TEN_THIETBI  ;
        lst.Add(obj);
    }
    return lst;
}

        
public THIET_BI_Object GetByID_THIETBI(System.Int32 ID_THIETBI)
{
    var list =  new dbQLTSLEntities().SP_THIET_BI_GetByID_THIETBI(ID_THIETBI);
    foreach (var item in list)
    {
        var obj = new THIET_BI_Object();
        
obj.ID_THIETBI = item.ID_THIETBI  ;
obj.TEN_THIETBI = item.TEN_THIETBI  ;
        return obj;
    }
    return null;
}

        
public bool Insert(THIET_BI_Object ob)
{
    return new dbQLTSLEntities().SP_THIET_BI_Insert( ob.TEN_THIETBI )>0;
}

        
public bool Delete( System.Int32 ID_THIETBI)
{
    return new dbQLTSLEntities().SP_THIET_BI_Delete( ID_THIETBI)>0;
}

        
public bool Update(THIET_BI_Object ob)
{
    return new dbQLTSLEntities().SP_THIET_BI_Update( ob.ID_THIETBI , ob.TEN_THIETBI )>0;
}

    }
}
