using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using VUBgram.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace VUBgram.Pages.Posts {
    public class EditModel : PageModel {
        private readonly VUBgramDbContext db;

        public EditModel(VUBgramDbContext db) {
            this.db = db;
        }

        public async Task<IActionResult> OnGetAsync(int id) {
            Post = await db.Posts.FindAsync(id);

            if (Post == null) {
                return RedirectToPage("/Posts/Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            db.Attach(Post).State = EntityState.Modified;

            try {
                await db.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException) {
            }

            return RedirectToPage("/Posts/Index");
        }

        [BindProperty]
        public Post Post { get; set; }
    }
}
