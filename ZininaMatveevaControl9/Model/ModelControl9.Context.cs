﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZininaMatveevaControl9.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LagerZininaMatveevaEntities1 : DbContext
    {
        public LagerZininaMatveevaEntities1()
            : base("name=LagerZininaMatveevaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounting> Accounting { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<TypeCompetition> TypeCompetition { get; set; }
    }
}
