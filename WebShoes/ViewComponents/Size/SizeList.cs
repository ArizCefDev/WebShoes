using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Size
{
    public class SizeList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
