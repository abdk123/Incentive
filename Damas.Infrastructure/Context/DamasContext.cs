using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Damas.Domain.Modules.Security.Entities;
using Incentive.Entity;
using Incentive.Entity.Modules.Incentive.RootEntities;
using Incentive.Mapping;
using Incentive.Mapping.Modules.Incentive.Entities;
using Incentive.Mapping.Modules.Incentive.RootEntities;

namespace Damas.Infrastructure.Context
{
    public class DamasContext:DbContext
    {
        public DamasContext()
            : base("DefaultConnection")
        {
            
        }

        //public DbSet<Directorate> Directorates { get; set; }
        //public DbSet<Role> Roles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var assemblyEntity = Assembly.GetAssembly(typeof(AssemblyEntity));
            foreach (var ass in assemblyEntity.GetTypes().Where(x=>x.IsClass==true && x.Name!="AssemblyEntity"))
            {
                this.Set(ass);
            }
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            var assembly = Assembly.GetAssembly(typeof(MapAssembly));
            modelBuilder.Configurations.AddFromAssembly(assembly);
           
            
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
