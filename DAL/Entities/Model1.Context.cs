﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbQLTSLEntities : DbContext
    {
        public dbQLTSLEntities()
            : base("name=dbQLTSLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG_Result> NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG(Nullable<int> iD_NGUOIDUNG)
        {
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG_Result>("NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG", iD_NGUOIDUNGParameter);
        }
    
        public virtual ObjectResult<SP_CheckLogin_Result> SP_CheckLogin(string uSERNAME, string pASSWORD)
        {
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CheckLogin_Result>("SP_CheckLogin", uSERNAMEParameter, pASSWORDParameter);
        }
    
        public virtual int SP_DON_VI_Delete(Nullable<int> iD_DONVI)
        {
            var iD_DONVIParameter = iD_DONVI.HasValue ?
                new ObjectParameter("ID_DONVI", iD_DONVI) :
                new ObjectParameter("ID_DONVI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DON_VI_Delete", iD_DONVIParameter);
        }
    
        public virtual ObjectResult<SP_DON_VI_GetAll_Result> SP_DON_VI_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DON_VI_GetAll_Result>("SP_DON_VI_GetAll");
        }
    
        public virtual ObjectResult<SP_DON_VI_GetByID_DONVI_Result> SP_DON_VI_GetByID_DONVI(Nullable<int> iD_DONVI)
        {
            var iD_DONVIParameter = iD_DONVI.HasValue ?
                new ObjectParameter("ID_DONVI", iD_DONVI) :
                new ObjectParameter("ID_DONVI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DON_VI_GetByID_DONVI_Result>("SP_DON_VI_GetByID_DONVI", iD_DONVIParameter);
        }
    
        public virtual int SP_DON_VI_Insert(string tEN_DONVI)
        {
            var tEN_DONVIParameter = tEN_DONVI != null ?
                new ObjectParameter("TEN_DONVI", tEN_DONVI) :
                new ObjectParameter("TEN_DONVI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DON_VI_Insert", tEN_DONVIParameter);
        }
    
        public virtual int SP_DON_VI_Update(Nullable<int> iD_DONVI, string tEN_DONVI)
        {
            var iD_DONVIParameter = iD_DONVI.HasValue ?
                new ObjectParameter("ID_DONVI", iD_DONVI) :
                new ObjectParameter("ID_DONVI", typeof(int));
    
            var tEN_DONVIParameter = tEN_DONVI != null ?
                new ObjectParameter("TEN_DONVI", tEN_DONVI) :
                new ObjectParameter("TEN_DONVI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DON_VI_Update", iD_DONVIParameter, tEN_DONVIParameter);
        }
    
        public virtual int SP_KHACH_HANG_Delete(Nullable<int> iD_KHACHHANG)
        {
            var iD_KHACHHANGParameter = iD_KHACHHANG.HasValue ?
                new ObjectParameter("ID_KHACHHANG", iD_KHACHHANG) :
                new ObjectParameter("ID_KHACHHANG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACH_HANG_Delete", iD_KHACHHANGParameter);
        }
    
        public virtual ObjectResult<SP_KHACH_HANG_GetAll_Result> SP_KHACH_HANG_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_KHACH_HANG_GetAll_Result>("SP_KHACH_HANG_GetAll");
        }
    
        public virtual ObjectResult<SP_KHACH_HANG_GetByID_KHACHHANG_Result> SP_KHACH_HANG_GetByID_KHACHHANG(Nullable<int> iD_KHACHHANG)
        {
            var iD_KHACHHANGParameter = iD_KHACHHANG.HasValue ?
                new ObjectParameter("ID_KHACHHANG", iD_KHACHHANG) :
                new ObjectParameter("ID_KHACHHANG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_KHACH_HANG_GetByID_KHACHHANG_Result>("SP_KHACH_HANG_GetByID_KHACHHANG", iD_KHACHHANGParameter);
        }
    
        public virtual int SP_KHACH_HANG_Insert(Nullable<int> cVLAN, Nullable<int> iD_LOAIDICHVU, Nullable<int> iD_NHOMKHACHHANG, Nullable<int> iD_TRANGTHAI, Nullable<int> iD_VUNGKETNOI, string iPGATEWAY, string iPLAN, string iPWAN, Nullable<int> sVLAN, string tEN_KHACHHANG, Nullable<System.DateTime> tHOIGIAN_CUNGCAP)
        {
            var cVLANParameter = cVLAN.HasValue ?
                new ObjectParameter("CVLAN", cVLAN) :
                new ObjectParameter("CVLAN", typeof(int));
    
            var iD_LOAIDICHVUParameter = iD_LOAIDICHVU.HasValue ?
                new ObjectParameter("ID_LOAIDICHVU", iD_LOAIDICHVU) :
                new ObjectParameter("ID_LOAIDICHVU", typeof(int));
    
            var iD_NHOMKHACHHANGParameter = iD_NHOMKHACHHANG.HasValue ?
                new ObjectParameter("ID_NHOMKHACHHANG", iD_NHOMKHACHHANG) :
                new ObjectParameter("ID_NHOMKHACHHANG", typeof(int));
    
            var iD_TRANGTHAIParameter = iD_TRANGTHAI.HasValue ?
                new ObjectParameter("ID_TRANGTHAI", iD_TRANGTHAI) :
                new ObjectParameter("ID_TRANGTHAI", typeof(int));
    
            var iD_VUNGKETNOIParameter = iD_VUNGKETNOI.HasValue ?
                new ObjectParameter("ID_VUNGKETNOI", iD_VUNGKETNOI) :
                new ObjectParameter("ID_VUNGKETNOI", typeof(int));
    
            var iPGATEWAYParameter = iPGATEWAY != null ?
                new ObjectParameter("IPGATEWAY", iPGATEWAY) :
                new ObjectParameter("IPGATEWAY", typeof(string));
    
            var iPLANParameter = iPLAN != null ?
                new ObjectParameter("IPLAN", iPLAN) :
                new ObjectParameter("IPLAN", typeof(string));
    
            var iPWANParameter = iPWAN != null ?
                new ObjectParameter("IPWAN", iPWAN) :
                new ObjectParameter("IPWAN", typeof(string));
    
            var sVLANParameter = sVLAN.HasValue ?
                new ObjectParameter("SVLAN", sVLAN) :
                new ObjectParameter("SVLAN", typeof(int));
    
            var tEN_KHACHHANGParameter = tEN_KHACHHANG != null ?
                new ObjectParameter("TEN_KHACHHANG", tEN_KHACHHANG) :
                new ObjectParameter("TEN_KHACHHANG", typeof(string));
    
            var tHOIGIAN_CUNGCAPParameter = tHOIGIAN_CUNGCAP.HasValue ?
                new ObjectParameter("THOIGIAN_CUNGCAP", tHOIGIAN_CUNGCAP) :
                new ObjectParameter("THOIGIAN_CUNGCAP", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACH_HANG_Insert", cVLANParameter, iD_LOAIDICHVUParameter, iD_NHOMKHACHHANGParameter, iD_TRANGTHAIParameter, iD_VUNGKETNOIParameter, iPGATEWAYParameter, iPLANParameter, iPWANParameter, sVLANParameter, tEN_KHACHHANGParameter, tHOIGIAN_CUNGCAPParameter);
        }
    
        public virtual int SP_KHACH_HANG_Update(Nullable<int> cVLAN, Nullable<int> iD_KHACHHANG, Nullable<int> iD_LOAIDICHVU, Nullable<int> iD_NHOMKHACHHANG, Nullable<int> iD_TRANGTHAI, Nullable<int> iD_VUNGKETNOI, string iPGATEWAY, string iPLAN, string iPWAN, Nullable<int> sVLAN, string tEN_KHACHHANG, Nullable<System.DateTime> tHOIGIAN_CUNGCAP)
        {
            var cVLANParameter = cVLAN.HasValue ?
                new ObjectParameter("CVLAN", cVLAN) :
                new ObjectParameter("CVLAN", typeof(int));
    
            var iD_KHACHHANGParameter = iD_KHACHHANG.HasValue ?
                new ObjectParameter("ID_KHACHHANG", iD_KHACHHANG) :
                new ObjectParameter("ID_KHACHHANG", typeof(int));
    
            var iD_LOAIDICHVUParameter = iD_LOAIDICHVU.HasValue ?
                new ObjectParameter("ID_LOAIDICHVU", iD_LOAIDICHVU) :
                new ObjectParameter("ID_LOAIDICHVU", typeof(int));
    
            var iD_NHOMKHACHHANGParameter = iD_NHOMKHACHHANG.HasValue ?
                new ObjectParameter("ID_NHOMKHACHHANG", iD_NHOMKHACHHANG) :
                new ObjectParameter("ID_NHOMKHACHHANG", typeof(int));
    
            var iD_TRANGTHAIParameter = iD_TRANGTHAI.HasValue ?
                new ObjectParameter("ID_TRANGTHAI", iD_TRANGTHAI) :
                new ObjectParameter("ID_TRANGTHAI", typeof(int));
    
            var iD_VUNGKETNOIParameter = iD_VUNGKETNOI.HasValue ?
                new ObjectParameter("ID_VUNGKETNOI", iD_VUNGKETNOI) :
                new ObjectParameter("ID_VUNGKETNOI", typeof(int));
    
            var iPGATEWAYParameter = iPGATEWAY != null ?
                new ObjectParameter("IPGATEWAY", iPGATEWAY) :
                new ObjectParameter("IPGATEWAY", typeof(string));
    
            var iPLANParameter = iPLAN != null ?
                new ObjectParameter("IPLAN", iPLAN) :
                new ObjectParameter("IPLAN", typeof(string));
    
            var iPWANParameter = iPWAN != null ?
                new ObjectParameter("IPWAN", iPWAN) :
                new ObjectParameter("IPWAN", typeof(string));
    
            var sVLANParameter = sVLAN.HasValue ?
                new ObjectParameter("SVLAN", sVLAN) :
                new ObjectParameter("SVLAN", typeof(int));
    
            var tEN_KHACHHANGParameter = tEN_KHACHHANG != null ?
                new ObjectParameter("TEN_KHACHHANG", tEN_KHACHHANG) :
                new ObjectParameter("TEN_KHACHHANG", typeof(string));
    
            var tHOIGIAN_CUNGCAPParameter = tHOIGIAN_CUNGCAP.HasValue ?
                new ObjectParameter("THOIGIAN_CUNGCAP", tHOIGIAN_CUNGCAP) :
                new ObjectParameter("THOIGIAN_CUNGCAP", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACH_HANG_Update", cVLANParameter, iD_KHACHHANGParameter, iD_LOAIDICHVUParameter, iD_NHOMKHACHHANGParameter, iD_TRANGTHAIParameter, iD_VUNGKETNOIParameter, iPGATEWAYParameter, iPLANParameter, iPWANParameter, sVLANParameter, tEN_KHACHHANGParameter, tHOIGIAN_CUNGCAPParameter);
        }
    
        public virtual int SP_KHACHHANG_THIETBI_Delete(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACHHANG_THIETBI_Delete", iDParameter);
        }
    
        public virtual ObjectResult<SP_KHACHHANG_THIETBI_GetAll_Result> SP_KHACHHANG_THIETBI_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_KHACHHANG_THIETBI_GetAll_Result>("SP_KHACHHANG_THIETBI_GetAll");
        }
    
        public virtual ObjectResult<SP_KHACHHANG_THIETBI_GetByID_Result> SP_KHACHHANG_THIETBI_GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_KHACHHANG_THIETBI_GetByID_Result>("SP_KHACHHANG_THIETBI_GetByID", iDParameter);
        }
    
        public virtual int SP_KHACHHANG_THIETBI_Insert(string cONG, Nullable<int> iD_KHACHHANG, Nullable<int> iD_THIETBI, string tOCDO)
        {
            var cONGParameter = cONG != null ?
                new ObjectParameter("CONG", cONG) :
                new ObjectParameter("CONG", typeof(string));
    
            var iD_KHACHHANGParameter = iD_KHACHHANG.HasValue ?
                new ObjectParameter("ID_KHACHHANG", iD_KHACHHANG) :
                new ObjectParameter("ID_KHACHHANG", typeof(int));
    
            var iD_THIETBIParameter = iD_THIETBI.HasValue ?
                new ObjectParameter("ID_THIETBI", iD_THIETBI) :
                new ObjectParameter("ID_THIETBI", typeof(int));
    
            var tOCDOParameter = tOCDO != null ?
                new ObjectParameter("TOCDO", tOCDO) :
                new ObjectParameter("TOCDO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACHHANG_THIETBI_Insert", cONGParameter, iD_KHACHHANGParameter, iD_THIETBIParameter, tOCDOParameter);
        }
    
        public virtual int SP_KHACHHANG_THIETBI_Update(string cONG, Nullable<int> iD, Nullable<int> iD_KHACHHANG, Nullable<int> iD_THIETBI, string tOCDO)
        {
            var cONGParameter = cONG != null ?
                new ObjectParameter("CONG", cONG) :
                new ObjectParameter("CONG", typeof(string));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var iD_KHACHHANGParameter = iD_KHACHHANG.HasValue ?
                new ObjectParameter("ID_KHACHHANG", iD_KHACHHANG) :
                new ObjectParameter("ID_KHACHHANG", typeof(int));
    
            var iD_THIETBIParameter = iD_THIETBI.HasValue ?
                new ObjectParameter("ID_THIETBI", iD_THIETBI) :
                new ObjectParameter("ID_THIETBI", typeof(int));
    
            var tOCDOParameter = tOCDO != null ?
                new ObjectParameter("TOCDO", tOCDO) :
                new ObjectParameter("TOCDO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_KHACHHANG_THIETBI_Update", cONGParameter, iDParameter, iD_KHACHHANGParameter, iD_THIETBIParameter, tOCDOParameter);
        }
    
        public virtual int SP_LOAI_DICHVU_Delete(Nullable<int> iD_LOAI_DICHVU)
        {
            var iD_LOAI_DICHVUParameter = iD_LOAI_DICHVU.HasValue ?
                new ObjectParameter("ID_LOAI_DICHVU", iD_LOAI_DICHVU) :
                new ObjectParameter("ID_LOAI_DICHVU", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LOAI_DICHVU_Delete", iD_LOAI_DICHVUParameter);
        }
    
        public virtual ObjectResult<SP_LOAI_DICHVU_GetAll_Result> SP_LOAI_DICHVU_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LOAI_DICHVU_GetAll_Result>("SP_LOAI_DICHVU_GetAll");
        }
    
        public virtual ObjectResult<SP_LOAI_DICHVU_GetByID_LOAI_DICHVU_Result> SP_LOAI_DICHVU_GetByID_LOAI_DICHVU(Nullable<int> iD_LOAI_DICHVU)
        {
            var iD_LOAI_DICHVUParameter = iD_LOAI_DICHVU.HasValue ?
                new ObjectParameter("ID_LOAI_DICHVU", iD_LOAI_DICHVU) :
                new ObjectParameter("ID_LOAI_DICHVU", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_LOAI_DICHVU_GetByID_LOAI_DICHVU_Result>("SP_LOAI_DICHVU_GetByID_LOAI_DICHVU", iD_LOAI_DICHVUParameter);
        }
    
        public virtual int SP_LOAI_DICHVU_Insert(string tEN_LOAI_DICHVU)
        {
            var tEN_LOAI_DICHVUParameter = tEN_LOAI_DICHVU != null ?
                new ObjectParameter("TEN_LOAI_DICHVU", tEN_LOAI_DICHVU) :
                new ObjectParameter("TEN_LOAI_DICHVU", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LOAI_DICHVU_Insert", tEN_LOAI_DICHVUParameter);
        }
    
        public virtual int SP_LOAI_DICHVU_Update(Nullable<int> iD_LOAI_DICHVU, string tEN_LOAI_DICHVU)
        {
            var iD_LOAI_DICHVUParameter = iD_LOAI_DICHVU.HasValue ?
                new ObjectParameter("ID_LOAI_DICHVU", iD_LOAI_DICHVU) :
                new ObjectParameter("ID_LOAI_DICHVU", typeof(int));
    
            var tEN_LOAI_DICHVUParameter = tEN_LOAI_DICHVU != null ?
                new ObjectParameter("TEN_LOAI_DICHVU", tEN_LOAI_DICHVU) :
                new ObjectParameter("TEN_LOAI_DICHVU", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_LOAI_DICHVU_Update", iD_LOAI_DICHVUParameter, tEN_LOAI_DICHVUParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_Delete(Nullable<int> iD_NGUOIDUNG)
        {
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_Delete", iD_NGUOIDUNGParameter);
        }
    
        public virtual ObjectResult<SP_NGUOI_DUNG_GetAll_Result> SP_NGUOI_DUNG_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NGUOI_DUNG_GetAll_Result>("SP_NGUOI_DUNG_GetAll");
        }
    
        public virtual ObjectResult<SP_NGUOI_DUNG_GetByID_NGUOIDUNG_Result> SP_NGUOI_DUNG_GetByID_NGUOIDUNG(Nullable<int> iD_NGUOIDUNG)
        {
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NGUOI_DUNG_GetByID_NGUOIDUNG_Result>("SP_NGUOI_DUNG_GetByID_NGUOIDUNG", iD_NGUOIDUNGParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_Insert(string hO_TEN, Nullable<int> iD_DONVI, string pASSWORD, Nullable<int> sDT, string uSERNAME)
        {
            var hO_TENParameter = hO_TEN != null ?
                new ObjectParameter("HO_TEN", hO_TEN) :
                new ObjectParameter("HO_TEN", typeof(string));
    
            var iD_DONVIParameter = iD_DONVI.HasValue ?
                new ObjectParameter("ID_DONVI", iD_DONVI) :
                new ObjectParameter("ID_DONVI", typeof(int));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var sDTParameter = sDT.HasValue ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(int));
    
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_Insert", hO_TENParameter, iD_DONVIParameter, pASSWORDParameter, sDTParameter, uSERNAMEParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_QUYEN_Delete(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_QUYEN_Delete", iDParameter);
        }
    
        public virtual ObjectResult<SP_NGUOI_DUNG_QUYEN_GetAll_Result> SP_NGUOI_DUNG_QUYEN_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NGUOI_DUNG_QUYEN_GetAll_Result>("SP_NGUOI_DUNG_QUYEN_GetAll");
        }
    
        public virtual ObjectResult<SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG_Result> SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG(Nullable<int> iD_NGUOIDUNG)
        {
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG_Result>("SP_NGUOI_DUNG_QUYEN_GetBy_ID_NGUOIDUNG", iD_NGUOIDUNGParameter);
        }
    
        public virtual ObjectResult<SP_NGUOI_DUNG_QUYEN_GetByID_Result> SP_NGUOI_DUNG_QUYEN_GetByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NGUOI_DUNG_QUYEN_GetByID_Result>("SP_NGUOI_DUNG_QUYEN_GetByID", iDParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_QUYEN_Insert(Nullable<int> iD_NGUOIDUNG, Nullable<int> iD_QUYEN)
        {
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            var iD_QUYENParameter = iD_QUYEN.HasValue ?
                new ObjectParameter("ID_QUYEN", iD_QUYEN) :
                new ObjectParameter("ID_QUYEN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_QUYEN_Insert", iD_NGUOIDUNGParameter, iD_QUYENParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_QUYEN_Update(Nullable<int> iD, Nullable<int> iD_NGUOIDUNG, Nullable<int> iD_QUYEN)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            var iD_QUYENParameter = iD_QUYEN.HasValue ?
                new ObjectParameter("ID_QUYEN", iD_QUYEN) :
                new ObjectParameter("ID_QUYEN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_QUYEN_Update", iDParameter, iD_NGUOIDUNGParameter, iD_QUYENParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_Update(string hO_TEN, Nullable<int> iD_DONVI, Nullable<int> iD_NGUOIDUNG, string pASSWORD, Nullable<int> sDT, string uSERNAME)
        {
            var hO_TENParameter = hO_TEN != null ?
                new ObjectParameter("HO_TEN", hO_TEN) :
                new ObjectParameter("HO_TEN", typeof(string));
    
            var iD_DONVIParameter = iD_DONVI.HasValue ?
                new ObjectParameter("ID_DONVI", iD_DONVI) :
                new ObjectParameter("ID_DONVI", typeof(int));
    
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            var pASSWORDParameter = pASSWORD != null ?
                new ObjectParameter("PASSWORD", pASSWORD) :
                new ObjectParameter("PASSWORD", typeof(string));
    
            var sDTParameter = sDT.HasValue ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(int));
    
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_Update", hO_TENParameter, iD_DONVIParameter, iD_NGUOIDUNGParameter, pASSWORDParameter, sDTParameter, uSERNAMEParameter);
        }
    
        public virtual int SP_NHOM_KHACH_HANG_Delete(Nullable<int> iD_NHOMKHACHHANG)
        {
            var iD_NHOMKHACHHANGParameter = iD_NHOMKHACHHANG.HasValue ?
                new ObjectParameter("ID_NHOMKHACHHANG", iD_NHOMKHACHHANG) :
                new ObjectParameter("ID_NHOMKHACHHANG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NHOM_KHACH_HANG_Delete", iD_NHOMKHACHHANGParameter);
        }
    
        public virtual ObjectResult<SP_NHOM_KHACH_HANG_GetAll_Result> SP_NHOM_KHACH_HANG_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NHOM_KHACH_HANG_GetAll_Result>("SP_NHOM_KHACH_HANG_GetAll");
        }
    
        public virtual ObjectResult<SP_NHOM_KHACH_HANG_GetByID_NHOMKHACHHANG_Result> SP_NHOM_KHACH_HANG_GetByID_NHOMKHACHHANG(Nullable<int> iD_NHOMKHACHHANG)
        {
            var iD_NHOMKHACHHANGParameter = iD_NHOMKHACHHANG.HasValue ?
                new ObjectParameter("ID_NHOMKHACHHANG", iD_NHOMKHACHHANG) :
                new ObjectParameter("ID_NHOMKHACHHANG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NHOM_KHACH_HANG_GetByID_NHOMKHACHHANG_Result>("SP_NHOM_KHACH_HANG_GetByID_NHOMKHACHHANG", iD_NHOMKHACHHANGParameter);
        }
    
        public virtual int SP_NHOM_KHACH_HANG_Insert(string tEN_NHOMKHACHHANG)
        {
            var tEN_NHOMKHACHHANGParameter = tEN_NHOMKHACHHANG != null ?
                new ObjectParameter("TEN_NHOMKHACHHANG", tEN_NHOMKHACHHANG) :
                new ObjectParameter("TEN_NHOMKHACHHANG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NHOM_KHACH_HANG_Insert", tEN_NHOMKHACHHANGParameter);
        }
    
        public virtual int SP_NHOM_KHACH_HANG_Update(Nullable<int> iD_NHOMKHACHHANG, string tEN_NHOMKHACHHANG)
        {
            var iD_NHOMKHACHHANGParameter = iD_NHOMKHACHHANG.HasValue ?
                new ObjectParameter("ID_NHOMKHACHHANG", iD_NHOMKHACHHANG) :
                new ObjectParameter("ID_NHOMKHACHHANG", typeof(int));
    
            var tEN_NHOMKHACHHANGParameter = tEN_NHOMKHACHHANG != null ?
                new ObjectParameter("TEN_NHOMKHACHHANG", tEN_NHOMKHACHHANG) :
                new ObjectParameter("TEN_NHOMKHACHHANG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NHOM_KHACH_HANG_Update", iD_NHOMKHACHHANGParameter, tEN_NHOMKHACHHANGParameter);
        }
    
        public virtual int SP_QUYEN_Delete(Nullable<int> iD_QUYEN)
        {
            var iD_QUYENParameter = iD_QUYEN.HasValue ?
                new ObjectParameter("ID_QUYEN", iD_QUYEN) :
                new ObjectParameter("ID_QUYEN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_QUYEN_Delete", iD_QUYENParameter);
        }
    
        public virtual ObjectResult<SP_QUYEN_GetAll_Result> SP_QUYEN_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_QUYEN_GetAll_Result>("SP_QUYEN_GetAll");
        }
    
        public virtual ObjectResult<SP_QUYEN_GetByID_QUYEN_Result> SP_QUYEN_GetByID_QUYEN(Nullable<int> iD_QUYEN)
        {
            var iD_QUYENParameter = iD_QUYEN.HasValue ?
                new ObjectParameter("ID_QUYEN", iD_QUYEN) :
                new ObjectParameter("ID_QUYEN", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_QUYEN_GetByID_QUYEN_Result>("SP_QUYEN_GetByID_QUYEN", iD_QUYENParameter);
        }
    
        public virtual int SP_QUYEN_Insert(string tEN_QUYEN)
        {
            var tEN_QUYENParameter = tEN_QUYEN != null ?
                new ObjectParameter("TEN_QUYEN", tEN_QUYEN) :
                new ObjectParameter("TEN_QUYEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_QUYEN_Insert", tEN_QUYENParameter);
        }
    
        public virtual int SP_QUYEN_Update(Nullable<int> iD_QUYEN, string tEN_QUYEN)
        {
            var iD_QUYENParameter = iD_QUYEN.HasValue ?
                new ObjectParameter("ID_QUYEN", iD_QUYEN) :
                new ObjectParameter("ID_QUYEN", typeof(int));
    
            var tEN_QUYENParameter = tEN_QUYEN != null ?
                new ObjectParameter("TEN_QUYEN", tEN_QUYEN) :
                new ObjectParameter("TEN_QUYEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_QUYEN_Update", iD_QUYENParameter, tEN_QUYENParameter);
        }
    
        public virtual int SP_THIET_BI_Delete(Nullable<int> iD_THIETBI)
        {
            var iD_THIETBIParameter = iD_THIETBI.HasValue ?
                new ObjectParameter("ID_THIETBI", iD_THIETBI) :
                new ObjectParameter("ID_THIETBI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_THIET_BI_Delete", iD_THIETBIParameter);
        }
    
        public virtual ObjectResult<SP_THIET_BI_GetAll_Result> SP_THIET_BI_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_THIET_BI_GetAll_Result>("SP_THIET_BI_GetAll");
        }
    
        public virtual ObjectResult<SP_THIET_BI_GetByID_THIETBI_Result> SP_THIET_BI_GetByID_THIETBI(Nullable<int> iD_THIETBI)
        {
            var iD_THIETBIParameter = iD_THIETBI.HasValue ?
                new ObjectParameter("ID_THIETBI", iD_THIETBI) :
                new ObjectParameter("ID_THIETBI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_THIET_BI_GetByID_THIETBI_Result>("SP_THIET_BI_GetByID_THIETBI", iD_THIETBIParameter);
        }
    
        public virtual int SP_THIET_BI_Insert(string tEN_THIETBI)
        {
            var tEN_THIETBIParameter = tEN_THIETBI != null ?
                new ObjectParameter("TEN_THIETBI", tEN_THIETBI) :
                new ObjectParameter("TEN_THIETBI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_THIET_BI_Insert", tEN_THIETBIParameter);
        }
    
        public virtual int SP_THIET_BI_Update(Nullable<int> iD_THIETBI, string tEN_THIETBI)
        {
            var iD_THIETBIParameter = iD_THIETBI.HasValue ?
                new ObjectParameter("ID_THIETBI", iD_THIETBI) :
                new ObjectParameter("ID_THIETBI", typeof(int));
    
            var tEN_THIETBIParameter = tEN_THIETBI != null ?
                new ObjectParameter("TEN_THIETBI", tEN_THIETBI) :
                new ObjectParameter("TEN_THIETBI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_THIET_BI_Update", iD_THIETBIParameter, tEN_THIETBIParameter);
        }
    
        public virtual int SP_TRANG_THAI_Delete(Nullable<int> iD_TRANGTHAI)
        {
            var iD_TRANGTHAIParameter = iD_TRANGTHAI.HasValue ?
                new ObjectParameter("ID_TRANGTHAI", iD_TRANGTHAI) :
                new ObjectParameter("ID_TRANGTHAI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_TRANG_THAI_Delete", iD_TRANGTHAIParameter);
        }
    
        public virtual ObjectResult<SP_TRANG_THAI_GetAll_Result> SP_TRANG_THAI_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TRANG_THAI_GetAll_Result>("SP_TRANG_THAI_GetAll");
        }
    
        public virtual ObjectResult<SP_TRANG_THAI_GetByID_TRANGTHAI_Result> SP_TRANG_THAI_GetByID_TRANGTHAI(Nullable<int> iD_TRANGTHAI)
        {
            var iD_TRANGTHAIParameter = iD_TRANGTHAI.HasValue ?
                new ObjectParameter("ID_TRANGTHAI", iD_TRANGTHAI) :
                new ObjectParameter("ID_TRANGTHAI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TRANG_THAI_GetByID_TRANGTHAI_Result>("SP_TRANG_THAI_GetByID_TRANGTHAI", iD_TRANGTHAIParameter);
        }
    
        public virtual int SP_TRANG_THAI_Insert(string tEN_TRANGTHAI)
        {
            var tEN_TRANGTHAIParameter = tEN_TRANGTHAI != null ?
                new ObjectParameter("TEN_TRANGTHAI", tEN_TRANGTHAI) :
                new ObjectParameter("TEN_TRANGTHAI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_TRANG_THAI_Insert", tEN_TRANGTHAIParameter);
        }
    
        public virtual int SP_TRANG_THAI_Update(Nullable<int> iD_TRANGTHAI, string tEN_TRANGTHAI)
        {
            var iD_TRANGTHAIParameter = iD_TRANGTHAI.HasValue ?
                new ObjectParameter("ID_TRANGTHAI", iD_TRANGTHAI) :
                new ObjectParameter("ID_TRANGTHAI", typeof(int));
    
            var tEN_TRANGTHAIParameter = tEN_TRANGTHAI != null ?
                new ObjectParameter("TEN_TRANGTHAI", tEN_TRANGTHAI) :
                new ObjectParameter("TEN_TRANGTHAI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_TRANG_THAI_Update", iD_TRANGTHAIParameter, tEN_TRANGTHAIParameter);
        }
    
        public virtual int SP_VUNGKETNOI_Delete(Nullable<int> iD_VUNGKETNOI)
        {
            var iD_VUNGKETNOIParameter = iD_VUNGKETNOI.HasValue ?
                new ObjectParameter("ID_VUNGKETNOI", iD_VUNGKETNOI) :
                new ObjectParameter("ID_VUNGKETNOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VUNGKETNOI_Delete", iD_VUNGKETNOIParameter);
        }
    
        public virtual ObjectResult<SP_VUNGKETNOI_GetAll_Result> SP_VUNGKETNOI_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VUNGKETNOI_GetAll_Result>("SP_VUNGKETNOI_GetAll");
        }
    
        public virtual ObjectResult<SP_VUNGKETNOI_GetByID_VUNGKETNOI_Result> SP_VUNGKETNOI_GetByID_VUNGKETNOI(Nullable<int> iD_VUNGKETNOI)
        {
            var iD_VUNGKETNOIParameter = iD_VUNGKETNOI.HasValue ?
                new ObjectParameter("ID_VUNGKETNOI", iD_VUNGKETNOI) :
                new ObjectParameter("ID_VUNGKETNOI", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VUNGKETNOI_GetByID_VUNGKETNOI_Result>("SP_VUNGKETNOI_GetByID_VUNGKETNOI", iD_VUNGKETNOIParameter);
        }
    
        public virtual int SP_VUNGKETNOI_Insert(string tEN_VUNGKETNOI)
        {
            var tEN_VUNGKETNOIParameter = tEN_VUNGKETNOI != null ?
                new ObjectParameter("TEN_VUNGKETNOI", tEN_VUNGKETNOI) :
                new ObjectParameter("TEN_VUNGKETNOI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VUNGKETNOI_Insert", tEN_VUNGKETNOIParameter);
        }
    
        public virtual int SP_VUNGKETNOI_Update(Nullable<int> iD_VUNGKETNOI, string tEN_VUNGKETNOI)
        {
            var iD_VUNGKETNOIParameter = iD_VUNGKETNOI.HasValue ?
                new ObjectParameter("ID_VUNGKETNOI", iD_VUNGKETNOI) :
                new ObjectParameter("ID_VUNGKETNOI", typeof(int));
    
            var tEN_VUNGKETNOIParameter = tEN_VUNGKETNOI != null ?
                new ObjectParameter("TEN_VUNGKETNOI", tEN_VUNGKETNOI) :
                new ObjectParameter("TEN_VUNGKETNOI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_VUNGKETNOI_Update", iD_VUNGKETNOIParameter, tEN_VUNGKETNOIParameter);
        }
    
        public virtual int SP_NGUOI_DUNG_ResetPassword(Nullable<int> iD_Admin, string rePassword, Nullable<int> iD_NGUOIDUNG)
        {
            var iD_AdminParameter = iD_Admin.HasValue ?
                new ObjectParameter("ID_Admin", iD_Admin) :
                new ObjectParameter("ID_Admin", typeof(int));
    
            var rePasswordParameter = rePassword != null ?
                new ObjectParameter("RePassword", rePassword) :
                new ObjectParameter("RePassword", typeof(string));
    
            var iD_NGUOIDUNGParameter = iD_NGUOIDUNG.HasValue ?
                new ObjectParameter("ID_NGUOIDUNG", iD_NGUOIDUNG) :
                new ObjectParameter("ID_NGUOIDUNG", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_NGUOI_DUNG_ResetPassword", iD_AdminParameter, rePasswordParameter, iD_NGUOIDUNGParameter);
        }
    }
}
