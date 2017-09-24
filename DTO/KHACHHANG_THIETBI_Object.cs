
using System;
using System.Collections.Generic;

namespace DTO
{
    public class KHACHHANG_THIETBI_Object
    {
        public string CONG { get; set; }
        public System.Int32 ID { get; set; }
        public System.Int32? ID_KHACHHANG { get; set; }
        public System.Int32? ID_THIETBI { get; set; }
        public string TOCDO { get; set; }
        public KHACH_HANG_Object KHACH_HANG_ObjectJoin { get; set; }
        public THIET_BI_Object THIET_BI_ObjectJoin { get; set; }
    }
}
