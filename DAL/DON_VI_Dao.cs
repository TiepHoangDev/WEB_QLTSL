
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class DON_VI_Dao
    {
        
public List<DON_VI_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_DON_VI_GetAll();
    List<DON_VI_Object> lst = new List<DON_VI_Object>();
    foreach (var item in list)
    {
        var obj = new DON_VI_Object();
        
obj.ID_DONVI = item.ID_DONVI  ;
obj.TEN_DONVI = item.TEN_DONVI  ;
        lst.Add(obj);
    }
    return lst;
}

        
public DON_VI_Object GetByID_DONVI(System.Int32 ID_DONVI)
{
    var list =  new dbQLTSLEntities().SP_DON_VI_GetByID_DONVI(ID_DONVI);
    foreach (var item in list)
    {
        var obj = new DON_VI_Object();
        
obj.ID_DONVI = item.ID_DONVI  ;
obj.TEN_DONVI = item.TEN_DONVI  ;
        return obj;
    }
    return null;
}

        
public bool Insert(DON_VI_Object ob)
{
    return new dbQLTSLEntities().SP_DON_VI_Insert( ob.TEN_DONVI )>0;
}

        
public bool Delete( System.Int32 ID_DONVI)
{
    return new dbQLTSLEntities().SP_DON_VI_Delete( ID_DONVI)>0;
}

        
public bool Update(DON_VI_Object ob)
{
    return new dbQLTSLEntities().SP_DON_VI_Update( ob.ID_DONVI , ob.TEN_DONVI )>0;
}

    }
}
