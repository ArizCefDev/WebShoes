using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Color
{
    public class ColorList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
