
using System;
using System.Collections.Generic;

namespace DTO
{
    public class NGUOI_DUNG_Object
    {
        
public string HO_TEN { get; set; }
public System.Int32? ID_DONVI { get; set; }
public System.Int32 ID_NGUOIDUNG { get; set; }
public string PASSWORD { get; set; }
public System.Int32? SDT { get; set; }
public string USERNAME { get; set; }
public DON_VI_Object DON_VI_ObjectJoin { get; set; }
    }
}
