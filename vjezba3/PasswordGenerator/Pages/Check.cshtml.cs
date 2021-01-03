using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordGenerator.Pages {
    public class CheckModel : PageModel {
        public void OnGet(string password) {
            if (password != null) {
                if (CheckValidPassword(password)) {
                    ViewData["password"] = "Password is valid";
                } else {
                    ViewData["password"] = "Password is NOT valid";
                }
            }
        }

        private bool CheckValidPassword(string password) {
            if (password.Length < 8) {
                return false;
            }

            bool hasDigit = false;
            bool hasUpperCharacter = false;
            bool hasLowerCharacter = false;

            foreach (var character in password) {
                if (Char.IsDigit(character)) hasDigit = true;
                if (Char.IsUpper(character)) hasUpperCharacter = true;
                if (Char.IsLower(character)) hasLowerCharacter = true;
            }

            if (hasDigit && hasUpperCharacter && hasLowerCharacter) {
                return true;
            }
            
            return false;
        }
  }
}
