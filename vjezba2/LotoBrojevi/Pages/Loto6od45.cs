using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LotoBrojevi.Pages {
    public class Loto6od45Model : PageModel{
        private readonly ILogger<Loto6od45Model> _logger;

        public Loto6od45Model(ILogger<Loto6od45Model> logger){
            _logger = logger;
        }

        public void OnGet(){
            Numbers = Loto.GenerateNumbers(6, 45);
        }

        public SortedSet<int> Numbers;
    }
}
