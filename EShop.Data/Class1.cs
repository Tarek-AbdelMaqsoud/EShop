using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Model;

namespace EShop.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext() : base("EShopConnectionString")
        {
            Database.SetInitializer<EShopDbContext>(new CreateDatabaseIfNotExists<EShopDbContext>());
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
