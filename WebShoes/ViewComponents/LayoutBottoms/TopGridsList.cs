using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.LayoutBottoms
{
    public class TopGridsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
