
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class VUNGKETNOI_Dao
    {
        
public List<VUNGKETNOI_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_VUNGKETNOI_GetAll();
    List<VUNGKETNOI_Object> lst = new List<VUNGKETNOI_Object>();
    foreach (var item in list)
    {
        var obj = new VUNGKETNOI_Object();
        
obj.ID_VUNGKETNOI = item.ID_VUNGKETNOI  ;
obj.TEN_VUNGKETNOI = item.TEN_VUNGKETNOI  ;
        lst.Add(obj);
    }
    return lst;
}

        
public VUNGKETNOI_Object GetByID_VUNGKETNOI(System.Int32 ID_VUNGKETNOI)
{
    var list =  new dbQLTSLEntities().SP_VUNGKETNOI_GetByID_VUNGKETNOI(ID_VUNGKETNOI);
    foreach (var item in list)
    {
        var obj = new VUNGKETNOI_Object();
        
obj.ID_VUNGKETNOI = item.ID_VUNGKETNOI  ;
obj.TEN_VUNGKETNOI = item.TEN_VUNGKETNOI  ;
        return obj;
    }
    return null;
}

        
public bool Insert(VUNGKETNOI_Object ob)
{
    return new dbQLTSLEntities().SP_VUNGKETNOI_Insert( ob.TEN_VUNGKETNOI )>0;
}

        
public bool Delete( System.Int32 ID_VUNGKETNOI)
{
    return new dbQLTSLEntities().SP_VUNGKETNOI_Delete( ID_VUNGKETNOI)>0;
}

        
public bool Update(VUNGKETNOI_Object ob)
{
    return new dbQLTSLEntities().SP_VUNGKETNOI_Update( ob.ID_VUNGKETNOI , ob.TEN_VUNGKETNOI )>0;
}

    }
}
