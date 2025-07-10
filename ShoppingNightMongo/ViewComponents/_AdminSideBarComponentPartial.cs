using Microsoft.AspNetCore.Mvc;

namespace ShoppingNightMongo.ViewComponents
{
    public class _AdminSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
