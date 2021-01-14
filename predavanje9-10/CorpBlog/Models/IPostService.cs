using System.Collections.Generic;
using CorpBlog.Data;

namespace CorpBlog.Models {
    public interface IPostService {
        IEnumerable<Post> AllPosts();
        IEnumerable<Post> PublishedPosts();
        int PostsCount();

        public CorpBlogDbContext Db { get; }
    }
}