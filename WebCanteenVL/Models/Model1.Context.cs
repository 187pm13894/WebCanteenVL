﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebCanteenVL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYCANTEENEntities : DbContext
    {
        public QUANLYCANTEENEntities()
            : base("name=QUANLYCANTEENEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public DbSet<CATEGORY> CATEGORies { get; set; }
        public DbSet<CONTACT> CONTACTs { get; set; }
        public DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public DbSet<FACULTY> FACULTies { get; set; }
        public DbSet<FOOD> FOODs { get; set; }
        public DbSet<INTRODUCTION> INTRODUCTIONs { get; set; }
        public DbSet<MENU> MENUs { get; set; }
        public DbSet<NOTIFICATION> NOTIFICATIONs { get; set; }
        public DbSet<ORDER> ORDERs { get; set; }
        public DbSet<ORDER_DETAIL> ORDER_DETAIL { get; set; }
        public DbSet<SLIDER> SLIDERs { get; set; }
    }
}