using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todoer.Models;
using System.Threading.Tasks;

namespace Todoer.Pages.Users {

    public class CreateModel : PageModel {

        private readonly TodoerDbContext dbContext;

        public CreateModel(TodoerDbContext db){
            dbContext = db;
        }

        public void OnGet(string search){

        }

        public async Task<IActionResult> OnPostAsync(){
            if(!ModelState.IsValid){
                return Page();
            }

            dbContext.Users.Add(User);
            await dbContext.SaveChangesAsync();

            return Redirect("/Users/Index");
        }

        [BindProperty]
        public User User { get; set; }
    }
}