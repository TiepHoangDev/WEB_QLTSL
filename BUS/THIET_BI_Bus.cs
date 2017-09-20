
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class THIET_BI_Bus
    {
        
public List<THIET_BI_Object> GetAll()
{
    return new THIET_BI_Dao().GetAll();
}

        
public THIET_BI_Object GetByID_THIETBI(System.Int32 ID_THIETBI)
{
    return new THIET_BI_Dao().GetByID_THIETBI(ID_THIETBI);
}

        
public bool Insert(THIET_BI_Object ob)
{
    return new THIET_BI_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_THIETBI)
{
    return new THIET_BI_Dao().Delete(ID_THIETBI);
}

        
public bool Update(THIET_BI_Object ob)
{
    return new THIET_BI_Dao().Update(ob);
}

    }
}
