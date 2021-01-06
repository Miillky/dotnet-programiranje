using System.ComponentModel.DataAnnotations;

namespace Todoer.Models {

    public class Todo  {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string DueDate { get; set; }

        [Required]
        public bool IsDone { get; set; }
    }
}