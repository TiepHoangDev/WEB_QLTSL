
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class NGUOI_DUNG_Dao
    {
        
public List<NGUOI_DUNG_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_NGUOI_DUNG_GetAll();
    List<NGUOI_DUNG_Object> lst = new List<NGUOI_DUNG_Object>();
    foreach (var item in list)
    {
        var obj = new NGUOI_DUNG_Object();
        
obj.HO_TEN = item.HO_TEN  ;
obj.ID_DONVI = item.ID_DONVI  ;
obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG  ;
obj.PASSWORD = item.PASSWORD  ;
obj.SDT = item.SDT  ;
obj.USERNAME = item.USERNAME  ;
obj.DON_VI_ObjectJoin = new DON_VI_Object()
{
    
        ID_DONVI = (System.Int32)item.ID_DONVI  ,
        TEN_DONVI = item.TEN_DONVI_DON_VIJoin  
};

        lst.Add(obj);
    }
    return lst;
}

        
public NGUOI_DUNG_Object GetByID_NGUOIDUNG(System.Int32 ID_NGUOIDUNG)
{
    var list =  new dbQLTSLEntities().SP_NGUOI_DUNG_GetByID_NGUOIDUNG(ID_NGUOIDUNG);
    foreach (var item in list)
    {
        var obj = new NGUOI_DUNG_Object();
        
obj.HO_TEN = item.HO_TEN  ;
obj.ID_DONVI = item.ID_DONVI  ;
obj.ID_NGUOIDUNG = item.ID_NGUOIDUNG  ;
obj.PASSWORD = item.PASSWORD  ;
obj.SDT = item.SDT  ;
obj.USERNAME = item.USERNAME  ;
obj.DON_VI_ObjectJoin = new DON_VI_Object()
{
    
        ID_DONVI = (System.Int32) item.ID_DONVI  ,
        TEN_DONVI =  item.TEN_DONVI_DON_VIJoin  
};

        return obj;
    }
    return null;
}

        
public bool Insert(NGUOI_DUNG_Object ob)
{
    return new dbQLTSLEntities().SP_NGUOI_DUNG_Insert( ob.HO_TEN , ob.ID_DONVI , ob.PASSWORD , ob.SDT , ob.USERNAME )>0;
}

        
public bool Delete( System.Int32 ID_NGUOIDUNG)
{
    return new dbQLTSLEntities().SP_NGUOI_DUNG_Delete( ID_NGUOIDUNG)>0;
}

        
public bool Update(NGUOI_DUNG_Object ob)
{
    return new dbQLTSLEntities().SP_NGUOI_DUNG_Update( ob.HO_TEN , ob.ID_DONVI , ob.ID_NGUOIDUNG , ob.PASSWORD , ob.SDT , ob.USERNAME )>0;
}

    }
}
