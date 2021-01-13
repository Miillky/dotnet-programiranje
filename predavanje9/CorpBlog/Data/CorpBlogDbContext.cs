using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CorpBlog.Models;

namespace CorpBlog.Data
{
        public class CorpBlogDbContext : DbContext
    {
        public CorpBlogDbContext (DbContextOptions<CorpBlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<CorpBlog.Models.Post> Posts { get; set; }
    }
}

