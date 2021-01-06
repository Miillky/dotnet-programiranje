using Microsoft.EntityFrameworkCore;

namespace Todoer.Models {

    public class TodoerDbContext : DbContext {

        public TodoerDbContext(DbContextOptions<TodoerDbContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}