using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternetShop.Models;
using InternetShop.Data;

namespace InternetShop.Controllers
{
    public class ProductsController : Controller
    {

        public ProductsController(IProductService context)
        {
            productService = context;
        }

        // GET: Products
        public IActionResult Index()
        {
            return View(productService.AllProducts());
        }

        public IActionResult AvailableByQuantity() {
            return View(productService.AvailableProductsByQuantity());
        }

        public IActionResult AvailableByPrice() {
            return View(productService.AvailableProductsByPrice());
        }

        public IActionResult Sale() {
            return View(productService.ProductsOnSale());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await productService.Db.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new SelectList(productService.Db.Categories, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Name,Description,Price,OnSale,SalePrice,Quantity")] Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Db.Add(product);
                await productService.Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await productService.Db.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["Categories"] = new SelectList(productService.Db.Categories, "Id", "Name");

            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Name,Description,Price,OnSale,SalePrice,Quantity")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productService.Db.Products.Update(product);
                    await productService.Db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await productService.Db.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await productService.Db.Products.FindAsync(id);
            productService.Db.Products.Remove(product);
            await productService.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return productService.Db.Products.Any(e => e.Id == id);
        }

        private readonly IProductService productService;
    }
}
