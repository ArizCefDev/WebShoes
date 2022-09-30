using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.NavBarMenu
{
    public class SportZoneList : ViewComponent
    {
        private readonly IMarkaSportService _markaSportService;

        public SportZoneList(IMarkaSportService markaSportService)
        {
            _markaSportService = markaSportService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _markaSportService.GetAll();
            return View(values);
        }
    }
}
