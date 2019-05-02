using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public StoreContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=tcp:awesomestoreserver.database.windows.net,1433;Initial Catalog=awesomestoredb;Persist Security Info=False;User ID=classbrothers;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
