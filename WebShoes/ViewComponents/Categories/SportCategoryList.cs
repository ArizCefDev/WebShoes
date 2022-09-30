using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Categories
{
    public class SportCategoryList : ViewComponent
    {
        private readonly IMarkaSportService _markaSportService;

        public SportCategoryList(IMarkaSportService markaSportService)
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
