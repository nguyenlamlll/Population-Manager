using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataLayer.Model;

namespace DataLayer.DatabaseContext
{
    public class SQLDatabaseContext : DbContext
    {
        public SQLDatabaseContext(DbContextOptions<SQLDatabaseContext> options)
            : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Name configuration: Changes auto-generated plural table names to singular names.
            modelBuilder.Entity<Resident>().ToTable("Resident");

        }

        public DbSet<Resident> Residents { get; set; }
    }
}
