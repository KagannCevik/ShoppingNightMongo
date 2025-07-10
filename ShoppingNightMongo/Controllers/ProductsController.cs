using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.ProductServices;

namespace ShoppingNightMongo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> ProductList()
        {
            var products = await _productService.GetAllProductsAsync();
            var categories = await _categoryService.GetCategoryAsync();

            var productList = products.Select(p => new ProductWithCategoryDto
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                ProductPrice = p.ProductPrice,
                //ImageUrl = p.ImageUrls,
                Status = p.Status,
                StockCount = p.StockCount,
                CategoryName = categories.FirstOrDefault(c => c.CategoryId == p.CategoryId)?.CategoryName ?? "Kategori Yok"
            }).ToList();

            return View(productList);
        }
        [HttpGet]

        public async Task<IActionResult> CreateProduct(string id)
        {
            var categories = await _categoryService.GetCategoryAsync();
            ViewBag.v=categories.Select(c=> new SelectListItem
            {
                Text=c.CategoryName,
                Value=c.CategoryId
            }).ToList();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            var categories = await _categoryService.GetCategoryAsync();

            ViewBag.v = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName,       // 👈 Kullanıcıya görünen
                Value = c.CategoryId,        // 👈 Formdan gelen (gönderilecek)
                Selected = c.CategoryId == product.CategoryId // 👈 Seçili olan kategori
            }).ToList();

            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            updateProductDto.Status = true;
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");

        }
    }
}
