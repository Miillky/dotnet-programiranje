using System.Collections.Generic;
using System.Linq;
using CorpBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace CorpBlog.Models {
    class PostService : IPostService {
        public PostService(CorpBlogDbContext db){
            dbContext = db;
        }

        public IEnumerable<Post> AllPosts(){
            return (from p in dbContext.Posts
            orderby p.CreatedAt descending
                select p).Include("Category");
        }

        public IEnumerable<Post> PublishedPosts(){
            return from p in dbContext.Posts
                where p.Published == true
                orderby p.CreatedAt descending
                select p;
        }

        public int PostsCount(){
            return (from p in dbContext.Posts
                orderby p.CreatedAt descending
                select p).Count();
        }

        public CorpBlogDbContext Db { get => dbContext; }
        private readonly CorpBlogDbContext dbContext;
    }
}