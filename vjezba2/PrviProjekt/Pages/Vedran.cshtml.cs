using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PrviProjekt.Pages
{
    public class VedranModel : PageModel
    {
        private readonly ILogger<VedranModel> _logger;

        public VedranModel(ILogger<VedranModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Ime = "Vedran";
        }

        public string Ime { get; set; }
    }
}