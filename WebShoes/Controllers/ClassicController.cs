using Business.Abstract;
using Business.Concrete;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Controllers
{
    public class ClassicController : Controller
    {
        private readonly IMarkaClassicService _markaClassicService;
        private readonly IShoeClassicService _shoeClassicService;
        private readonly AppDBContext _dBContext;

        public ClassicController(IMarkaClassicService markaClassicService, IShoeClassicService shoeClassicService, AppDBContext dBContext)
        {
            _markaClassicService = markaClassicService;
            _shoeClassicService = shoeClassicService;
            _dBContext = dBContext;
        }

        public IActionResult Index(string s)
        {
            var values = from a in _shoeClassicService.GetCurrencyInclude() select a;
            if (!string.IsNullOrEmpty(s))
            {
                values = _shoeClassicService.SearchClassicShoe(s);
            }
            ViewBag.classicshoes = _dBContext.ShoeClassics.Count();
            return View(values.OrderByDescending(x=>x.ID));
        }

        public IActionResult GetMarkaClassic(int id)
        {
            var values = _shoeClassicService.GetMarkaShoe(id);
            return View(values);
        }

        public IActionResult GetClassicCurrency(int id)
        {
            var values = _shoeClassicService.GetCurrencyShoe(id);
            return View(values);
        }

        public IActionResult GetClassicSize(int id)
        {
            var values = _shoeClassicService.GetSizeShoe(id);
            return View(values);
        }

        public IActionResult GetClassicColor(int id)
        {
            var values = _shoeClassicService.GetColorShoe(id);
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _shoeClassicService.GetByID(id);
            return View(values);
        }
    }
}
