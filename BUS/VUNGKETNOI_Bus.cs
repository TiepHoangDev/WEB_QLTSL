
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class VUNGKETNOI_Bus
    {
        
public List<VUNGKETNOI_Object> GetAll()
{
    return new VUNGKETNOI_Dao().GetAll();
}

        
public VUNGKETNOI_Object GetByID_VUNGKETNOI(System.Int32 ID_VUNGKETNOI)
{
    return new VUNGKETNOI_Dao().GetByID_VUNGKETNOI(ID_VUNGKETNOI);
}

        
public bool Insert(VUNGKETNOI_Object ob)
{
    return new VUNGKETNOI_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_VUNGKETNOI)
{
    return new VUNGKETNOI_Dao().Delete(ID_VUNGKETNOI);
}

        
public bool Update(VUNGKETNOI_Object ob)
{
    return new VUNGKETNOI_Dao().Update(ob);
}

    }
}
