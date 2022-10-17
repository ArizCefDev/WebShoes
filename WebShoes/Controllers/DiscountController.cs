using Business.Abstract;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IMarkaDiscountService _markaDiscountService;
        private readonly IShoeDiscountService _shoeDiscountService;
        private readonly AppDBContext _dBContext;

        public DiscountController(IMarkaDiscountService markaDiscountService, IShoeDiscountService shoeDiscountService, AppDBContext dBContext)
        {
            _markaDiscountService = markaDiscountService;
            _shoeDiscountService = shoeDiscountService;
            _dBContext = dBContext;
        }

        public IActionResult Index(string s)
        {
            ViewBag.discountshoe = _dBContext.ShoeDiscounts.Count();
            var values = from a in _shoeDiscountService.GetCurrencyInclude() select a;
            if (!string.IsNullOrEmpty(s))
            {
                values = _shoeDiscountService.SearchDiscountShoe(s);
            }
            return View(values.OrderByDescending(x => x.ID));
        }

        public IActionResult Details(int id)
        {
            var values = _shoeDiscountService.GetDiscountShoeID(id);
            return View(values);
        }
    }
}
