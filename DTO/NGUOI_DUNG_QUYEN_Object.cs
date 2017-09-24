
using System;
using System.Collections.Generic;

namespace DTO
{
    public class NGUOI_DUNG_QUYEN_Object
    {

        public System.Int32 ID { get; set; }
        public System.Int32? ID_NGUOIDUNG { get; set; }
        public System.Int32? ID_QUYEN { get; set; }
        public NGUOI_DUNG_Object NGUOI_DUNG_ObjectJoin { get; set; }
        public QUYEN_Object QUYEN_ObjectJoin { get; set; }
    }
}
