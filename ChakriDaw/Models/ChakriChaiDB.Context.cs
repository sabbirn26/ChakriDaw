﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChakriDaw.ViewModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChakriChaiDBEntities : DbContext
    {
        public ChakriChaiDBEntities()
            : base("name=ChakriChaiDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Academic> Academics { get; set; }
        public virtual DbSet<Apply> Applies { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<Employeer> Employeers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<JobPost> JobPosts { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
