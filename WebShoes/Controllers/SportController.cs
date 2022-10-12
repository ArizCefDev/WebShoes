using Business.Abstract;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Controllers
{
    public class SportController : Controller
    {
        private readonly IMarkaSportService _markaSportService;
        private readonly IShoeSportService _shoeSportService;
        private readonly AppDBContext _dBContext;

        public SportController(IMarkaSportService markaSportService, IShoeSportService shoeSportService, AppDBContext dBContext)
        {
            _markaSportService = markaSportService;
            _shoeSportService = shoeSportService;
            _dBContext = dBContext;
        }

        public IActionResult Index(string s)
        {
            var values = from a in _shoeSportService.GetCurrencyInclude() select a;
            if (!string.IsNullOrEmpty(s))
            {
                values = _shoeSportService.SearchSportShoe(s);
            }
            ViewBag.sportshoes = _dBContext.ShoeSports.Count();
            return View(values.OrderByDescending(x=>x.ID));
        }

        public IActionResult GetMarkaSport(int id)
        {
            var values = _shoeSportService.GetMarkaShoe(id);
            return View(values);
        }

        public IActionResult GetSportCurrency(int id)
        {
            var values = _shoeSportService.GetCurrencyShoe(id);
            return View(values);
        }

        public IActionResult GetSportSize(int id)
        {
            var values = _shoeSportService.GetSizeShoe(id);
            return View(values);
        }

        public IActionResult GetSportColor(int id)
        {
            var values = _shoeSportService.GetColorShoe(id);
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _shoeSportService.GetSportShoeID(id);
            return View(values);
        }
    }
}
