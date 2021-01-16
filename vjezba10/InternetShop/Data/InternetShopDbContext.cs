using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternetShop.Models;

namespace InternetShop.Data {
    public class InternetShopDbContext : DbContext
    {
        public InternetShopDbContext (DbContextOptions<InternetShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<InternetShop.Models.Product> Products { get; set; }

        public DbSet<InternetShop.Models.Category> Categories { get; set; }
    }
}
