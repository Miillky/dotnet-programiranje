using System.ComponentModel.DataAnnotations;

namespace VUBgram.Models {
  public class Post {
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string URL { get; set; }
    
    public string Description { get; set; }
    
    public int Likes { get; set; }
  }
}