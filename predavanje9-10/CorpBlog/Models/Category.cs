using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CorpBlog.Models {
    public class Category {

        [Key]
        public int Id { get; set; }        

        [Required]
        [Display(Name="Naziv Kategorije")]
        public string CategoryName { get; set; }

        public List<Post> Posts { get; set; }
    }
}