﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_COMN_BENF_TP> T_COMN_BENF_TP { get; set; }
        public virtual DbSet<T_COMN_BLACK_LIST> T_COMN_BLACK_LIST { get; set; }
        public virtual DbSet<T_COMN_COMP_DATA> T_COMN_COMP_DATA { get; set; }
        public virtual DbSet<T_COMN_GOV_DATA> T_COMN_GOV_DATA { get; set; }
        public virtual DbSet<T_COMN_MAIN_ACTIVITY> T_COMN_MAIN_ACTIVITY { get; set; }
        public virtual DbSet<T_COMN_SUB_ACTIVITY> T_COMN_SUB_ACTIVITY { get; set; }
        public virtual DbSet<T_COMN_PERS_DATA> T_COMN_PERS_DATA { get; set; }
    }
}
