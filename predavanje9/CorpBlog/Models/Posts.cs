using System.Collections.Generic;
using System.Linq;
using CorpBlog.Data;

namespace CorpBlog.Models {
    class Posts {
        public Posts(CorpBlogDbContext db){
            this.dbContext = db;
        }

        public IEnumerable<Post> AllPosts(){
            return from p in dbContext.Posts
            orderby p.CreatedAt descending
                select p;
        }

        public IEnumerable<Post> PublishedPosts(){
            return from p in dbContext.Posts
                where p.Published == true
                select p;
        }

        private readonly CorpBlogDbContext dbContext;
    }
}