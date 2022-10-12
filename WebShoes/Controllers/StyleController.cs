using Business.Abstract;
using Business.Concrete;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Controllers
{
    public class StyleController : Controller
    {
        private readonly IMarkaStyleService _markaStyleService;
        private readonly IShoeStyleService _shoeStyleService;
        private readonly AppDBContext _dBContext;

        public StyleController(IMarkaStyleService markaStyleService, IShoeStyleService shoeStyleService, AppDBContext dBContext)
        {
            _markaStyleService = markaStyleService;
            _shoeStyleService = shoeStyleService;
            _dBContext = dBContext;
        }

        public IActionResult Index(string s)
        {

            var values = from a in _shoeStyleService.GetCurrencyInclude() select a;
            if (!string.IsNullOrEmpty(s))
            {
                values = _shoeStyleService.SearchSportShoe(s);
            }
            ViewBag.styleshoes = _dBContext.ShoeStyles.Count();
            return View(values.OrderByDescending(x => x.ID));
        }

        public IActionResult GetMarkaStyle(int id)
        {
            var values = _shoeStyleService.GetMarkaShoe(id);
            return View(values);
        }

        public IActionResult GetStyleCurrency(int id)
        {
            var values = _shoeStyleService.GetCurrencyShoe(id);
            return View(values);
        }

        public IActionResult GetStyleSize(int id)
        {
            var values = _shoeStyleService.GetSizeShoe(id);
            return View(values);
        }

        public IActionResult GetStyleColor(int id)
        {
            var values = _shoeStyleService.GetColorShoe(id);
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _shoeStyleService.GetStyleShoeID(id);
            return View(values);
        }
    }
}
