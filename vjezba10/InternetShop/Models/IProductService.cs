using System;
using System.Collections.Generic;
using System.Linq;
using InternetShop.Data;

namespace InternetShop.Models {
  public interface IProductService {
    IEnumerable<Product> AllProducts();
    IEnumerable<Product> AvailableProductsByPrice();
    IEnumerable<Product> AvailableProductsByQuantity();
    IEnumerable<Product> ProductsOnSale();

    InternetShopDbContext Db { get; }
  }
}
