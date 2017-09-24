
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class TRANG_THAI_Bus
    {
        
public List<TRANG_THAI_Object> GetAll()
{
    return new TRANG_THAI_Dao().GetAll();
}

        
public TRANG_THAI_Object GetByID_TRANGTHAI(System.Int32 ID_TRANGTHAI)
{
    return new TRANG_THAI_Dao().GetByID_TRANGTHAI(ID_TRANGTHAI);
}

        
public bool Insert(TRANG_THAI_Object ob)
{
    return new TRANG_THAI_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_TRANGTHAI)
{
    return new TRANG_THAI_Dao().Delete(ID_TRANGTHAI);
}

        
public bool Update(TRANG_THAI_Object ob)
{
    return new TRANG_THAI_Dao().Update(ob);
}

    }
}
