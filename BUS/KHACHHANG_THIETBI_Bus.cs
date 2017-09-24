
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class KHACHHANG_THIETBI_Bus
    {
        
public List<KHACHHANG_THIETBI_Object> GetAll()
{
    return new KHACHHANG_THIETBI_Dao().GetAll();
}

        
public KHACHHANG_THIETBI_Object GetByID(System.Int32 ID)
{
    return new KHACHHANG_THIETBI_Dao().GetByID(ID);
}

        
public bool Insert(KHACHHANG_THIETBI_Object ob)
{
    return new KHACHHANG_THIETBI_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID)
{
    return new KHACHHANG_THIETBI_Dao().Delete(ID);
}

        
public bool Update(KHACHHANG_THIETBI_Object ob)
{
    return new KHACHHANG_THIETBI_Dao().Update(ob);
}

    }
}
