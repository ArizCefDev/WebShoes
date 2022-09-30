using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Categories
{
    public class StyleCategoryList : ViewComponent
    {
        private readonly IMarkaStyleService _markaStyleService;

        public StyleCategoryList(IMarkaStyleService markaStyleService)
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
