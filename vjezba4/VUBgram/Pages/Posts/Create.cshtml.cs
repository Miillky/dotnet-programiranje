using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VUBgram.Models;
using System.Threading.Tasks;

namespace VUBgram.Pages.Posts {
    public class CreateModel : PageModel {
        private readonly VUBgramDbContext db;

        public CreateModel(VUBgramDbContext db) {
            this.db = db;
        }

        public void OnGet(string search) {
        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            db.Posts.Add(Post);
            await db.SaveChangesAsync();

            return RedirectToPage("/Posts/Index");
        } 

        [BindProperty]
        public Post Post { get; set; }
    }
}
