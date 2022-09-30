using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.LayoutBottoms
{
    public class SlidersList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
