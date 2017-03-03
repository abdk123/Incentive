using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Damas.Domain.Modules.Security.Entities;
using Incentive.Entity;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Damas.Infrastructure.Context
{
    public class DamasContext:DbContext
    {
        public DamasContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Directorate> Directorates { get; set; }
        public DbSet<Role> Roles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Modified") != null || entry.Entity.GetType().GetProperty("Created") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = DateTime.Now;
                    entry.Property("Modified").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Modified").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
