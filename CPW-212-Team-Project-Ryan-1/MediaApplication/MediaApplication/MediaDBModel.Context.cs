﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MediaDBEntities : DbContext
    {
        public MediaDBEntities()
            : base("name=MediaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Awards> Awards { get; set; }
        public virtual DbSet<CastList> CastList { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<TVShows> TVShows { get; set; }
    }
}