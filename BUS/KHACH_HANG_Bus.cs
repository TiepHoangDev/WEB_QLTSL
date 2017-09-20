
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class KHACH_HANG_Bus
    {
        
public List<KHACH_HANG_Object> GetAll()
{
    return new KHACH_HANG_Dao().GetAll();
}

        
public KHACH_HANG_Object GetByID_KHACHHANG(System.Int32 ID_KHACHHANG)
{
    return new KHACH_HANG_Dao().GetByID_KHACHHANG(ID_KHACHHANG);
}

        
public bool Insert(KHACH_HANG_Object ob)
{
    return new KHACH_HANG_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_KHACHHANG)
{
    return new KHACH_HANG_Dao().Delete(ID_KHACHHANG);
}

        
public bool Update(KHACH_HANG_Object ob)
{
    return new KHACH_HANG_Dao().Update(ob);
}

    }
}
