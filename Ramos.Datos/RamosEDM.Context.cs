﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ramos.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RamosEntities : DbContext
    {
        public RamosEntities()
            : base("name=RamosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alumno> alumno { get; set; }
        public virtual DbSet<carrera> carrera { get; set; }
        public virtual DbSet<inscripcion> inscripcion { get; set; }
        public virtual DbSet<jornada> jornada { get; set; }
        public virtual DbSet<profesor> profesor { get; set; }
        public virtual DbSet<ramo> ramo { get; set; }
        public virtual DbSet<seccion> seccion { get; set; }
        public virtual DbSet<sede> sede { get; set; }
    }
}