using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LotoBrojevi.Pages {
    public class Loto7od39Model : PageModel {
        private readonly ILogger<Loto7od39Model> _logger;

        public Loto7od39Model(ILogger<Loto7od39Model> logger) {
            _logger = logger;
        }

         public void OnGet(){
            Numbers = Loto.GenerateNumbers(7, 39);
        }

        public SortedSet<int> Numbers;
    }
}
