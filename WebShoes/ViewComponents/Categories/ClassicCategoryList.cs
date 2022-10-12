using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Categories
{
    public class ClassicCategoryList : ViewComponent
    {
        private readonly IMarkaClassicService _markaClassicService;

        public ClassicCategoryList(IMarkaClassicService markaClassicService)
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
