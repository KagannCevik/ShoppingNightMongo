using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Services.SliderServices;
using System.Threading.Tasks;

namespace ShoppingNightMongo.ViewComponents
{
    public class _UISliderComponentPartial:ViewComponent
    {
        private ISliderService _sliderService;

        public _UISliderComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return View(values);
        }
    }
}
