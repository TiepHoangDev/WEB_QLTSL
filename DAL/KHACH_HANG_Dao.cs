
using System;
using System.Collections.Generic;
using DTO;
using DAL.Entities;

namespace DAL
{
    public class KHACH_HANG_Dao
    {
        
public List<KHACH_HANG_Object> GetAll()
{
    var list = new dbQLTSLEntities().SP_KHACH_HANG_GetAll();
    List<KHACH_HANG_Object> lst = new List<KHACH_HANG_Object>();
    foreach (var item in list)
    {
        var obj = new KHACH_HANG_Object();
        
obj.CVLAN = item.CVLAN  ;
obj.ID_KHACHHANG = item.ID_KHACHHANG  ;
obj.ID_LOAIDICHVU = item.ID_LOAIDICHVU  ;
obj.ID_NHOMKHACHHANG = item.ID_NHOMKHACHHANG  ;
obj.ID_TRANGTHAI = item.ID_TRANGTHAI  ;
obj.ID_VUNGKETNOI = item.ID_VUNGKETNOI  ;
obj.IPGATEWAY = item.IPGATEWAY  ;
obj.IPLAN = item.IPLAN  ;
obj.IPWAN = item.IPWAN  ;
obj.SVLAN = item.SVLAN  ;
obj.TEN_KHACHHANG = item.TEN_KHACHHANG  ;
obj.THOIGIAN_CUNGCAP = item.THOIGIAN_CUNGCAP  ;
obj.LOAI_DICHVU_ObjectJoin = new LOAI_DICHVU_Object()
{
    
        ID_LOAI_DICHVU = (System.Int32)item.ID_LOAIDICHVU  ,
        TEN_LOAI_DICHVU = item.TEN_LOAI_DICHVU_LOAI_DICHVUJoin  
};

obj.NHOM_KHACH_HANG_ObjectJoin = new NHOM_KHACH_HANG_Object()
{
    
        ID_NHOMKHACHHANG = (System.Int32)item.ID_NHOMKHACHHANG  ,
        TEN_NHOMKHACHHANG = item.TEN_NHOMKHACHHANG_NHOM_KHACH_HANGJoin  
};

obj.TRANG_THAI_ObjectJoin = new TRANG_THAI_Object()
{
    
        ID_TRANGTHAI = (System.Int32)item.ID_TRANGTHAI  ,
        TEN_TRANGTHAI = item.TEN_TRANGTHAI_TRANG_THAIJoin  
};

obj.VUNGKETNOI_ObjectJoin = new VUNGKETNOI_Object()
{
    
        ID_VUNGKETNOI = (System.Int32)item.ID_VUNGKETNOI  ,
        TEN_VUNGKETNOI = item.TEN_VUNGKETNOI_VUNGKETNOIJoin  
};

        lst.Add(obj);
    }
    return lst;
}

        
public KHACH_HANG_Object GetByID_KHACHHANG(System.Int32 ID_KHACHHANG)
{
    var list =  new dbQLTSLEntities().SP_KHACH_HANG_GetByID_KHACHHANG(ID_KHACHHANG);
    foreach (var item in list)
    {
        var obj = new KHACH_HANG_Object();
        
obj.CVLAN = item.CVLAN  ;
obj.ID_KHACHHANG = item.ID_KHACHHANG  ;
obj.ID_LOAIDICHVU = item.ID_LOAIDICHVU  ;
obj.ID_NHOMKHACHHANG = item.ID_NHOMKHACHHANG  ;
obj.ID_TRANGTHAI = item.ID_TRANGTHAI  ;
obj.ID_VUNGKETNOI = item.ID_VUNGKETNOI  ;
obj.IPGATEWAY = item.IPGATEWAY  ;
obj.IPLAN = item.IPLAN  ;
obj.IPWAN = item.IPWAN  ;
obj.SVLAN = item.SVLAN  ;
obj.TEN_KHACHHANG = item.TEN_KHACHHANG  ;
obj.THOIGIAN_CUNGCAP = item.THOIGIAN_CUNGCAP  ;
obj.LOAI_DICHVU_ObjectJoin = new LOAI_DICHVU_Object()
{
    
        ID_LOAI_DICHVU = (System.Int32) item.ID_LOAIDICHVU  ,
        TEN_LOAI_DICHVU =  item.TEN_LOAI_DICHVU_LOAI_DICHVUJoin  
};

obj.NHOM_KHACH_HANG_ObjectJoin = new NHOM_KHACH_HANG_Object()
{
    
        ID_NHOMKHACHHANG = (System.Int32) item.ID_NHOMKHACHHANG  ,
        TEN_NHOMKHACHHANG =  item.TEN_NHOMKHACHHANG_NHOM_KHACH_HANGJoin  
};

obj.TRANG_THAI_ObjectJoin = new TRANG_THAI_Object()
{
    
        ID_TRANGTHAI = (System.Int32) item.ID_TRANGTHAI  ,
        TEN_TRANGTHAI =  item.TEN_TRANGTHAI_TRANG_THAIJoin  
};

obj.VUNGKETNOI_ObjectJoin = new VUNGKETNOI_Object()
{
    
        ID_VUNGKETNOI = (System.Int32) item.ID_VUNGKETNOI  ,
        TEN_VUNGKETNOI =  item.TEN_VUNGKETNOI_VUNGKETNOIJoin  
};

        return obj;
    }
    return null;
}

        
public bool Insert(KHACH_HANG_Object ob)
{
    return new dbQLTSLEntities().SP_KHACH_HANG_Insert( ob.CVLAN , ob.ID_LOAIDICHVU , ob.ID_NHOMKHACHHANG , ob.ID_TRANGTHAI , ob.ID_VUNGKETNOI , ob.IPGATEWAY , ob.IPLAN , ob.IPWAN , ob.SVLAN , ob.TEN_KHACHHANG , ob.THOIGIAN_CUNGCAP )>0;
}

        
public bool Delete( System.Int32 ID_KHACHHANG)
{
    return new dbQLTSLEntities().SP_KHACH_HANG_Delete( ID_KHACHHANG)>0;
}

        
public bool Update(KHACH_HANG_Object ob)
{
    return new dbQLTSLEntities().SP_KHACH_HANG_Update( ob.CVLAN , ob.ID_KHACHHANG , ob.ID_LOAIDICHVU , ob.ID_NHOMKHACHHANG , ob.ID_TRANGTHAI , ob.ID_VUNGKETNOI , ob.IPGATEWAY , ob.IPLAN , ob.IPWAN , ob.SVLAN , ob.TEN_KHACHHANG , ob.THOIGIAN_CUNGCAP )>0;
}

    }
}
