using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLife.DAL.Context
{
    public class GymContext : DbContext
    {
        public GymContext():base("name=dataConnection")
        {
            Database.SetInitializer(new GymInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> Details { get; set; }
        public DbSet<UserNatification> Notifications { get; set; }

    }
}
