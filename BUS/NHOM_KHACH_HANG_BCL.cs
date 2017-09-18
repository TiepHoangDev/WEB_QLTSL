
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class NHOM_KHACH_HANG_BCL
    {
        
public List<NHOM_KHACH_HANG_Object> GetAll()
{
    return new NHOM_KHACH_HANG_Dao().GetAll();
}

        
public NHOM_KHACH_HANG_Object GetByID_NHOMKHACHHANG(System.Int32 ID_NHOMKHACHHANG)
{
    return new NHOM_KHACH_HANG_Dao().GetByID_NHOMKHACHHANG(ID_NHOMKHACHHANG);
}

        
public bool Insert(NHOM_KHACH_HANG_Object ob)
{
    return new NHOM_KHACH_HANG_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_NHOMKHACHHANG)
{
    return new NHOM_KHACH_HANG_Dao().Delete(ID_NHOMKHACHHANG);
}

        
public bool Update(NHOM_KHACH_HANG_Object ob)
{
    return new NHOM_KHACH_HANG_Dao().Update(ob);
}

    }
}
