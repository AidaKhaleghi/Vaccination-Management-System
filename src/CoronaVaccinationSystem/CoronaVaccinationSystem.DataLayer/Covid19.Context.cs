﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoronaVaccinationSystem.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Covid19_DBEntities : DbContext
    {
        public Covid19_DBEntities()
            : base("name=Covid19_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Deputies> Deputies { get; set; }
        public virtual DbSet<Vaccines> Vaccines { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
    }
}