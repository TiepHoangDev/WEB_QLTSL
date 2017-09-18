
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class TRANG_THAI_Dao
    {
        
public List<TRANG_THAI_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_TRANG_THAI_GetAll();
    List<TRANG_THAI_Object> lst = new List<TRANG_THAI_Object>();
    foreach (var item in list)
    {
        var obj = new TRANG_THAI_Object();
        
obj.ID_TRANGTHAI = item.ID_TRANGTHAI  ;
obj.TEN_TRANGTHAI = item.TEN_TRANGTHAI  ;
        lst.Add(obj);
    }
    return lst;
}

        
public TRANG_THAI_Object GetByID_TRANGTHAI(System.Int32 ID_TRANGTHAI)
{
    var list =  new dbQLTSLEntities().SP_TRANG_THAI_GetByID_TRANGTHAI(ID_TRANGTHAI);
    foreach (var item in list)
    {
        var obj = new TRANG_THAI_Object();
        
obj.ID_TRANGTHAI = item.ID_TRANGTHAI  ;
obj.TEN_TRANGTHAI = item.TEN_TRANGTHAI  ;
        return obj;
    }
    return null;
}

        
public bool Insert(TRANG_THAI_Object ob)
{
    return new dbQLTSLEntities().SP_TRANG_THAI_Insert( ob.TEN_TRANGTHAI )>0;
}

        
public bool Delete( System.Int32 ID_TRANGTHAI)
{
    return new dbQLTSLEntities().SP_TRANG_THAI_Delete( ID_TRANGTHAI)>0;
}

        
public bool Update(TRANG_THAI_Object ob)
{
    return new dbQLTSLEntities().SP_TRANG_THAI_Update( ob.ID_TRANGTHAI , ob.TEN_TRANGTHAI )>0;
}

    }
}
