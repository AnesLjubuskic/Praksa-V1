using eVjezba1.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.DBAccess
{
    public partial class ApplicationDB:DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options):base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);//kako bi se ovo overwritalo da nije parital klasa
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            TimeStamp();
            return base.SaveChanges();
        }

        private void TimeStamp()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity
            && (e.State == EntityState.Added || e.State == EntityState.Modified));
            foreach(var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).Created_At = DateTime.UtcNow;
                }
                else if (entityEntry.State == EntityState.Modified)
                {
                    ((BaseEntity)entityEntry.Entity).Updated_At = DateTime.UtcNow;
                }
            }
        }
    }
    public partial class ApplicationDB
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                UserName = "anes@fit.ba",
                Password = "test",
                Hash = "rrrr2",
                FirstName = "anes",
                LastName = "ljuba"
            },new User()
            {
                Id = 2,
                UserName = "dena@fit.ba",
                Password = "test",
                Hash = "rrrr2",
                FirstName = "dena",
                LastName = "dena"
            }
            ) ;
            
        }
    }
}
