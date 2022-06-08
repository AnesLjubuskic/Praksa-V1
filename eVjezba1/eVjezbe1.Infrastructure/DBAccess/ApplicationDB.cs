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
            var User_A = (User)modelBuilder.Model;//Sta se u ovoj liniji desilo i zasto ovo radi
            Seed(User_A);//kako bi se ovo overwritalo da nije parital klasa
            base.OnModelCreating(modelBuilder);
        }
    }
    public partial class ApplicationDB
    {
        public void Seed(User user)
        {
            user.UserName = "Random1";
            user.Password = "Random11";
            user.FirstName = "Anes";
            user.LastName = "Part";
            user.Created_At = DateTime.Now;
            user.isDeleted = false;
            Users.Add(user);
        }
    }
}
