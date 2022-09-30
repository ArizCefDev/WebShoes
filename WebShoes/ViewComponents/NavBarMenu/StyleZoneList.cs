using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.NavBarMenu
{
    public class StyleZoneList : ViewComponent
    {
        private readonly IMarkaStyleService _markaStyleService;

        public StyleZoneList(IMarkaStyleService markaStyleService)
        {
            _markaStyleService = markaStyleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _markaStyleService.GetAll();
            return View(values);
        }
    }
}
