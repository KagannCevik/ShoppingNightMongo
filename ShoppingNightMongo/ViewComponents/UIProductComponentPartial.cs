using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Services.CategoryServices;
using ShoppingNightMongo.Services.ProductServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIProductComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public UIProductComponentPartial(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new ProductViewModel
            {
                Products = await _productService.GetAllProductsAsync(),
                Categories = await _categoryService.GetCategoryAsync()
            };
            return View(model);
        }
    }
}
