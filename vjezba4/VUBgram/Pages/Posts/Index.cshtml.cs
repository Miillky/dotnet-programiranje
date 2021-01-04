using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VUBgram.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VUBgram.Pages.Posts {
    public class IndexModel : PageModel {
        private readonly VUBgramDbContext db;

        public IndexModel(VUBgramDbContext db) {
            this.db = db;
        }

        public void OnGet(string search) {
            if (search != null) {
                Posts =
                from p in db.Posts
                where p.Description.Contains(search)
                select p;
            } else {
                Posts = db.Posts;
            }
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id) {
            var post = await db.Posts.FindAsync(id);
            if (post == null) {
                return NotFound();
            }
            db.Posts.Remove(post);
            await db.SaveChangesAsync();

            return RedirectToPage("/Posts/Index");
        }

        public IEnumerable<Post> Posts { get; set; }
    }
}
