﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickWorkshop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QWDBEntities : DbContext
    {
        public QWDBEntities()
            : base("name=QWDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<order> orders { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<orderpdetail> orderpdetails { get; set; }
        public DbSet<ordersdetail> ordersdetails { get; set; }
    }
}