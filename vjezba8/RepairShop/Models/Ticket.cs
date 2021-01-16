using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RepairShop.Models {
  public class Ticket {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Subject { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    public string Note { get; set; }

    public bool Completed { get; set; }
  }
}
