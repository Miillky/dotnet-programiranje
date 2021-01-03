using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordGenerator.Pages {
  public class GenerateModel : PageModel {
    public void OnGet() {
      Passwords = GeneratePasswords();
    }

    private List<string> GeneratePasswords() {
      List<string> passwords = new List<string>();

      for (int i = 0; i < 10; i++) {
        passwords.Add(Guid.NewGuid().ToString().Substring(0,7));
      }

      return passwords;
    }

    public List<string> Passwords { get; set; }
  }
}
