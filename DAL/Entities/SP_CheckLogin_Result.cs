//------------------------------------------------------------------------------
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
    
    public partial class SP_CheckLogin_Result
    {
        public int ID_NGUOIDUNG { get; set; }
        public Nullable<int> ID_DONVI { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string HO_TEN { get; set; }
        public Nullable<int> SDT { get; set; }
    }
}