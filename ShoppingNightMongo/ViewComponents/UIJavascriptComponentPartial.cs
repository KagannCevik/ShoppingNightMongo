using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIJavascriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
