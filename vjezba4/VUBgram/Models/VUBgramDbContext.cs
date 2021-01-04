using Microsoft.EntityFrameworkCore;

namespace VUBgram.Models {
  public class VUBgramDbContext : DbContext {
    public VUBgramDbContext(DbContextOptions<VUBgramDbContext> options) : base(options) { }

    public DbSet<Post> Posts { get; set; }
  }
} 