﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STmanager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class smarttime_storeEntities : DbContext
    {
        public smarttime_storeEntities()
            : base("name=smarttime_storeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<branch> branches { get; set; }
        public virtual DbSet<branchinventory> branchinventories { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<good> goods { get; set; }
        public virtual DbSet<model> models { get; set; }
        public virtual DbSet<sale> sales { get; set; }
        public virtual DbSet<saledetail> saledetails { get; set; }
        public virtual DbSet<shipping> shippings { get; set; }
        public virtual DbSet<shippingdetail> shippingdetails { get; set; }
    }
}