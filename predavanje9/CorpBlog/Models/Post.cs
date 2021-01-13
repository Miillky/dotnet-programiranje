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

        public DateTime CreatedAt { get; set; }

        public bool Published { get; set; }
    }
}