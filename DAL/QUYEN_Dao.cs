
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class QUYEN_Dao
    {
        
public List<QUYEN_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_QUYEN_GetAll();
    List<QUYEN_Object> lst = new List<QUYEN_Object>();
    foreach (var item in list)
    {
        var obj = new QUYEN_Object();
        
obj.ID_QUYEN = item.ID_QUYEN  ;
obj.TEN_QUYEN = item.TEN_QUYEN  ;
        lst.Add(obj);
    }
    return lst;
}

        
public QUYEN_Object GetByID_QUYEN(System.Int32 ID_QUYEN)
{
    var list =  new dbQLTSLEntities().SP_QUYEN_GetByID_QUYEN(ID_QUYEN);
    foreach (var item in list)
    {
        var obj = new QUYEN_Object();
        
obj.ID_QUYEN = item.ID_QUYEN  ;
obj.TEN_QUYEN = item.TEN_QUYEN  ;
        return obj;
    }
    return null;
}

        
public bool Insert(QUYEN_Object ob)
{
    return new dbQLTSLEntities().SP_QUYEN_Insert( ob.TEN_QUYEN )>0;
}

        
public bool Delete( System.Int32 ID_QUYEN)
{
    return new dbQLTSLEntities().SP_QUYEN_Delete( ID_QUYEN)>0;
}

        
public bool Update(QUYEN_Object ob)
{
    return new dbQLTSLEntities().SP_QUYEN_Update( ob.ID_QUYEN , ob.TEN_QUYEN )>0;
}

    }
}
