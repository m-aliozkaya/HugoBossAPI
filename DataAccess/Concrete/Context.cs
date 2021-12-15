using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        private const string CONN_STR = @"server=(localdb)\MSSQLLocalDB; database=HugoBoss; integrated security=true;MultipleActiveResultSets=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conStr = _configuration.GetConnectionString("TarTarimDb2");
            optionsBuilder.UseSqlServer(CONN_STR);
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Factory> Factories { get; set; }

        public DbSet<FactoryOrder> FactoryOrders { get; set; }

        public DbSet<FactoryProduct> FactoryProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Season> Seasons { get; set; }
    }
}
