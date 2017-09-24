
using System;
using System.Collections.Generic;

namespace DTO
{
    public class KHACH_HANG_Object
    {
        public System.Int32? CVLAN { get; set; }
        public System.Int32 ID_KHACHHANG { get; set; }
        public System.Int32? ID_LOAIDICHVU { get; set; }
        public System.Int32? ID_NHOMKHACHHANG { get; set; }
        public System.Int32? ID_TRANGTHAI { get; set; }
        public System.Int32? ID_VUNGKETNOI { get; set; }
        public string IPGATEWAY { get; set; }
        public string IPLAN { get; set; }
        public string IPWAN { get; set; }
        public System.Int32? SVLAN { get; set; }
        public string TEN_KHACHHANG { get; set; }
        public System.DateTime? THOIGIAN_CUNGCAP { get; set; }
        public LOAI_DICHVU_Object LOAI_DICHVU_ObjectJoin { get; set; }
        public NHOM_KHACH_HANG_Object NHOM_KHACH_HANG_ObjectJoin { get; set; }
        public TRANG_THAI_Object TRANG_THAI_ObjectJoin { get; set; }
        public VUNGKETNOI_Object VUNGKETNOI_ObjectJoin { get; set; }
    }
}
