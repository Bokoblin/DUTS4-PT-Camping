﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PT_Camping.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<A_vendu> A_vendu { get; set; }
        public virtual DbSet<App> App { get; set; }
        public virtual DbSet<Caracteristique_Emplacement> Caracteristique_Emplacement { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Droit> Droit { get; set; }
        public virtual DbSet<Emplacement> Emplacement { get; set; }
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<Incident> Incident { get; set; }
        public virtual DbSet<Loge> Loge { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type_Emplacement> Type_Emplacement { get; set; }
        public virtual DbSet<Type_Incident> Type_Incident { get; set; }
    }
}
