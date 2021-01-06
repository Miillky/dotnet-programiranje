using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Todoer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todoer.Pages.Users {
    
    public class IndexModel : PageModel {
        private readonly TodoerDbContext dbContext;

        public IndexModel(TodoerDbContext db){
            dbContext = db;
        }

        public void OnGet(){
            Users = dbContext.Users;
        }

        public IEnumerable<User> Users { get; set; }
    }
}
