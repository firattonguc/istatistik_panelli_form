﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrunStokUygulama
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbEntıtyUrunEntities : DbContext
    {
        public DbEntıtyUrunEntities()
            : base("name=DbEntıtyUrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_kategori> tbl_kategori { get; set; }
        public virtual DbSet<tbl_musterı> tbl_musterı { get; set; }
        public virtual DbSet<tbl_satıs> tbl_satıs { get; set; }
        public virtual DbSet<tbl_urun> tbl_urun { get; set; }
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
    
        public virtual ObjectResult<string> markagetır()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("markagetır");
        }
    }
}
