using System;
using System.ComponentModel.DataAnnotations;

namespace CorpBlog.Models {
    public class Post {

        [Key]
        public int Id { get; set; }        

        [Required]
        [Display(Name="Naslov")]
        public string Title { get; set; }

        [Display(Name="Sadržaj")]
        public string Content { get; set; }

        [Display(Name="Autor")]
        public string Author { get; set; }

        [Display(Name="Kreirano")]
        public DateTime CreatedAt { get; set; }

        [Display(Name="Objavljeno")]
        public bool Published { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}