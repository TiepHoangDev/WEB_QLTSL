
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class KHACHHANG_THIETBI_Dao
    {
        
public List<KHACHHANG_THIETBI_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_KHACHHANG_THIETBI_GetAll();
    List<KHACHHANG_THIETBI_Object> lst = new List<KHACHHANG_THIETBI_Object>();
    foreach (var item in list)
    {
        var obj = new KHACHHANG_THIETBI_Object();
        
obj.CONG = item.CONG  ;
obj.ID = item.ID  ;
obj.ID_KHACHHANG = item.ID_KHACHHANG  ;
obj.ID_THIETBI = item.ID_THIETBI  ;
obj.TOCDO = item.TOCDO  ;
obj.KHACH_HANG_ObjectJoin = new KHACH_HANG_Object()
{
    
        CVLAN = item.CVLAN_KHACH_HANGJoin  ,
        ID_KHACHHANG = (System.Int32)item.ID_KHACHHANG  ,
        ID_LOAIDICHVU = item.ID_LOAIDICHVU_KHACH_HANGJoin  ,
        ID_NHOMKHACHHANG = item.ID_NHOMKHACHHANG_KHACH_HANGJoin  ,
        ID_TRANGTHAI = item.ID_TRANGTHAI_KHACH_HANGJoin  ,
        ID_VUNGKETNOI = item.ID_VUNGKETNOI_KHACH_HANGJoin  ,
        IPGATEWAY = item.IPGATEWAY_KHACH_HANGJoin  ,
        IPLAN = item.IPLAN_KHACH_HANGJoin  ,
        IPWAN = item.IPWAN_KHACH_HANGJoin  ,
        SVLAN = item.SVLAN_KHACH_HANGJoin  ,
        TEN_KHACHHANG = item.TEN_KHACHHANG_KHACH_HANGJoin  ,
        THOIGIAN_CUNGCAP = item.THOIGIAN_CUNGCAP_KHACH_HANGJoin  
};

obj.THIET_BI_ObjectJoin = new THIET_BI_Object()
{
    
        ID_THIETBI = (System.Int32)item.ID_THIETBI  ,
        TEN_THIETBI = item.TEN_THIETBI_THIET_BIJoin  
};

        lst.Add(obj);
    }
    return lst;
}

        
public KHACHHANG_THIETBI_Object GetByID(System.Int32 ID)
{
    var list =  new dbQLTSLEntities().SP_KHACHHANG_THIETBI_GetByID(ID);
    foreach (var item in list)
    {
        var obj = new KHACHHANG_THIETBI_Object();
        
obj.CONG = item.CONG  ;
obj.ID = item.ID  ;
obj.ID_KHACHHANG = item.ID_KHACHHANG  ;
obj.ID_THIETBI = item.ID_THIETBI  ;
obj.TOCDO = item.TOCDO  ;
obj.KHACH_HANG_ObjectJoin = new KHACH_HANG_Object()
{
    
        CVLAN =  item.CVLAN_KHACH_HANGJoin  ,
        ID_KHACHHANG = (System.Int32) item.ID_KHACHHANG  ,
        ID_LOAIDICHVU =  item.ID_LOAIDICHVU_KHACH_HANGJoin  ,
        ID_NHOMKHACHHANG =  item.ID_NHOMKHACHHANG_KHACH_HANGJoin  ,
        ID_TRANGTHAI =  item.ID_TRANGTHAI_KHACH_HANGJoin  ,
        ID_VUNGKETNOI =  item.ID_VUNGKETNOI_KHACH_HANGJoin  ,
        IPGATEWAY =  item.IPGATEWAY_KHACH_HANGJoin  ,
        IPLAN =  item.IPLAN_KHACH_HANGJoin  ,
        IPWAN =  item.IPWAN_KHACH_HANGJoin  ,
        SVLAN =  item.SVLAN_KHACH_HANGJoin  ,
        TEN_KHACHHANG =  item.TEN_KHACHHANG_KHACH_HANGJoin  ,
        THOIGIAN_CUNGCAP =  item.THOIGIAN_CUNGCAP_KHACH_HANGJoin  
};

obj.THIET_BI_ObjectJoin = new THIET_BI_Object()
{
    
        ID_THIETBI = (System.Int32) item.ID_THIETBI  ,
        TEN_THIETBI =  item.TEN_THIETBI_THIET_BIJoin  
};

        return obj;
    }
    return null;
}

        
public bool Insert(KHACHHANG_THIETBI_Object ob)
{
    return new dbQLTSLEntities().SP_KHACHHANG_THIETBI_Insert( ob.CONG , ob.ID_KHACHHANG , ob.ID_THIETBI , ob.TOCDO )>0;
}

        
public bool Delete( System.Int32 ID)
{
    return new dbQLTSLEntities().SP_KHACHHANG_THIETBI_Delete( ID)>0;
}

        
public bool Update(KHACHHANG_THIETBI_Object ob)
{
    return new dbQLTSLEntities().SP_KHACHHANG_THIETBI_Update( ob.CONG , ob.ID , ob.ID_KHACHHANG , ob.ID_THIETBI , ob.TOCDO )>0;
}

    }
}
