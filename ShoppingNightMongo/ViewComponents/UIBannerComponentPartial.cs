using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.CategoryServices;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIBannerComponentPartial:ViewComponent

    {
        private readonly ICategoryService _categoryService;

        public UIBannerComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var values = await _categoryService.GetCategoryAsync();
            var firstThree = values.Take(3).ToList(); 
            return View(firstThree);
        }
    }
}
