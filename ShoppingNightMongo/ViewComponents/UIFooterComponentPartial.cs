using Microsoft.AspNetCore.Mvc;
using ShoppingNightMongo.Models;

namespace ShoppingNightMongo.ViewComponents
{
    public class UIFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var value = new AdminMailViewModel();
            return View(value);
        }
    }
   
}
