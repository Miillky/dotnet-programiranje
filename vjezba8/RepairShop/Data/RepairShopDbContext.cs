using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepairShop.Models;

namespace RepairShop.Data {
    public class RepairShopDbContext : DbContext
    {
        public RepairShopDbContext (DbContextOptions<RepairShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<RepairShop.Models.Ticket> Tickets { get; set; }
    }
}
    