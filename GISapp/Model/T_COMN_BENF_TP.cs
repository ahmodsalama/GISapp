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
    
    public partial class T_COMN_BENF_TP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_COMN_BENF_TP()
        {
            this.T_COMN_BLACK_LIST = new HashSet<T_COMN_BLACK_LIST>();
            this.T_COMN_COMP_DATA = new HashSet<T_COMN_COMP_DATA>();
            this.T_COMN_GOV_DATA = new HashSet<T_COMN_GOV_DATA>();
        }
    
        public decimal ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_COMN_BLACK_LIST> T_COMN_BLACK_LIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_COMN_COMP_DATA> T_COMN_COMP_DATA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_COMN_GOV_DATA> T_COMN_GOV_DATA { get; set; }
        public virtual T_COMN_PERS_DATA T_COMN_PERS_DATA { get; set; }
    }
}
