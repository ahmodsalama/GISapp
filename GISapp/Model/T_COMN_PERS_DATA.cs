//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_COMN_PERS_DATA
    {
        public decimal ID { get; set; }
        public Nullable<decimal> FK_BENF_ID { get; set; }
        public string PERSNAME { get; set; }
        public string PERSNID { get; set; }
        public Nullable<System.DateTime> PERSBIRTHDATE { get; set; }
        public string PERSADDRESS { get; set; }
    
        public virtual T_COMN_BENF_TP T_COMN_BENF_TP { get; set; }
    }
}
