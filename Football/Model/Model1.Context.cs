﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Football_DB : DbContext
    {
        public Football_DB()
            : base("name=Football_DB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Hesabat> tbl_Hesabat { get; set; }
        public virtual DbSet<tbl_Meydan> tbl_Meydan { get; set; }
        public virtual DbSet<tbl_Musteri> tbl_Musteri { get; set; }
        public virtual DbSet<tbl_Otag> tbl_Otag { get; set; }
        public virtual DbSet<tbl_Rezerv> tbl_Rezerv { get; set; }
    }
}