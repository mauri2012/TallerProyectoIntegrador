﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIntegradorTaller.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class classroom_managerEntities : DbContext
    {
        public classroom_managerEntities()
            : base("name=classroom_managerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aula> aula { get; set; }
        public virtual DbSet<equipamiento> equipamiento { get; set; }
        public virtual DbSet<horas> horas { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuario { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<dias_semana> dias_semana { get; set; }
        public virtual DbSet<materias> materias { get; set; }
    }
}
