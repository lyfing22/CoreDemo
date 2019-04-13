using System;
using System.Collections.Generic;
using System.Text;
using CoreDemo.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Entity
{
    public class CoreDemoDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<AuditEntry> Roles { get; set; }

        public DbSet<Post> UserRoleRelation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.5.97,16411;database=SmallProgramAsset_db;user=test2016;password=test2016;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditEntry>();
            //base.OnModelCreating(modelBuilder);
        }

    }
}
