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
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Factory> Factories { get; set; }

        public DbSet<FactoryOrder> FactoryOrders { get; set; }

        public DbSet<FactoryProduct> FactoryProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Season> Seasons { get; set; }
    }
}
