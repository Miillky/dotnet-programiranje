using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Models {
    public class Category {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Kategorija")]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
