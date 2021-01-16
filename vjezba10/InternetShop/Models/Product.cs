using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InternetShop.Models {
    public class Product {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool OnSale { get; set; }

        public decimal SalePrice { get; set; }

        public string SalePercentage {
            get {
                return (@Math.Round(((Price - SalePrice) / Price) * 100, 0)).ToString();
            }
        }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
