
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class NHOM_KHACH_HANG_Dao
    {
        
public List<NHOM_KHACH_HANG_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_NHOM_KHACH_HANG_GetAll();
    List<NHOM_KHACH_HANG_Object> lst = new List<NHOM_KHACH_HANG_Object>();
    foreach (var item in list)
    {
        var obj = new NHOM_KHACH_HANG_Object();
        
obj.ID_NHOMKHACHHANG = item.ID_NHOMKHACHHANG  ;
obj.TEN_NHOMKHACHHANG = item.TEN_NHOMKHACHHANG  ;
        lst.Add(obj);
    }
    return lst;
}

        
public NHOM_KHACH_HANG_Object GetByID_NHOMKHACHHANG(System.Int32 ID_NHOMKHACHHANG)
{
    var list =  new dbQLTSLEntities().SP_NHOM_KHACH_HANG_GetByID_NHOMKHACHHANG(ID_NHOMKHACHHANG);
    foreach (var item in list)
    {
        var obj = new NHOM_KHACH_HANG_Object();
        
obj.ID_NHOMKHACHHANG = item.ID_NHOMKHACHHANG  ;
obj.TEN_NHOMKHACHHANG = item.TEN_NHOMKHACHHANG  ;
        return obj;
    }
    return null;
}

        
public bool Insert(NHOM_KHACH_HANG_Object ob)
{
    return new dbQLTSLEntities().SP_NHOM_KHACH_HANG_Insert( ob.TEN_NHOMKHACHHANG )>0;
}

        
public bool Delete( System.Int32 ID_NHOMKHACHHANG)
{
    return new dbQLTSLEntities().SP_NHOM_KHACH_HANG_Delete( ID_NHOMKHACHHANG)>0;
}

        
public bool Update(NHOM_KHACH_HANG_Object ob)
{
    return new dbQLTSLEntities().SP_NHOM_KHACH_HANG_Update( ob.ID_NHOMKHACHHANG , ob.TEN_NHOMKHACHHANG )>0;
}

    }
}
