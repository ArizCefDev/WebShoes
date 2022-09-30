using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.LayoutBottoms
{
    public class BottomGridsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
