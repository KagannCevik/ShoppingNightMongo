using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.ProductServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIProductDetailComponent:ViewComponent
    {
       private readonly IProductService _productService;

        public UIProductDetailComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return View(product);
        }
    }
}
