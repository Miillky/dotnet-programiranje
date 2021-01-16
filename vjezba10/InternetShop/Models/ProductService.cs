using System;
using System.Collections.Generic;
using System.Linq;
using InternetShop.Data;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.Models {
  public class ProductService : IProductService {
    public ProductService(InternetShopDbContext db) {
      this.db = db;
    }

    public IEnumerable<Product> AllProducts() {
      return (from p in db.Products
              select p).Include("Category");
    }

    public IEnumerable<Product> AvailableProductsByQuantity() {
      return (from p in db.Products
        where p.Quantity > 0
        orderby p.Quantity descending
        select p).Include("Category");
    }

    public IEnumerable<Product> AvailableProductsByPrice() {
      return (from p in db.Products
        orderby p.Price
        select p).Include("Category");
    }

    public IEnumerable<Product> ProductsOnSale() {
      return (from p in db.Products
        where p.OnSale == true
        orderby p.Price
        select p).Include("Category");
    }

    public InternetShopDbContext Db { get => db; }

    private readonly InternetShopDbContext db;
  }
}
