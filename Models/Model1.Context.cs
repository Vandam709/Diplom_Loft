﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom_Loft.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PanasenkoLoft2Entities : DbContext
    {
        public PanasenkoLoft2Entities()
            : base("name=PanasenkoLoft2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lоft> Lоft { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SubjectMattеr> SubjectMattеr { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}