
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class QUYEN_BCL
    {
        
public List<QUYEN_Object> GetAll()
{
    return new QUYEN_Dao().GetAll();
}

        
public QUYEN_Object GetByID_QUYEN(System.Int32 ID_QUYEN)
{
    return new QUYEN_Dao().GetByID_QUYEN(ID_QUYEN);
}

        
public bool Insert(QUYEN_Object ob)
{
    return new QUYEN_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_QUYEN)
{
    return new QUYEN_Dao().Delete(ID_QUYEN);
}

        
public bool Update(QUYEN_Object ob)
{
    return new QUYEN_Dao().Update(ob);
}

    }
}
