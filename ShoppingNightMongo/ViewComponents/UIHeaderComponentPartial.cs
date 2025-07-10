using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
