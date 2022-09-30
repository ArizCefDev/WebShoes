using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.NavBarMenu
{
    public class ClassicZoneList : ViewComponent
    {
        private readonly IMarkaClassicService _markaClassicService;

        public ClassicZoneList(IMarkaClassicService markaClassicService)
        {
            _markaClassicService = markaClassicService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _markaClassicService.GetAll();
            return View(values);
        }
    }
}
