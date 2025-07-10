using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.ProductServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIModalComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public UIModalComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string productId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            return View(product);
        }
    }
}
