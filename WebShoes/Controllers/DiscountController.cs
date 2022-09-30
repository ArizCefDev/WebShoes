using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IMarkaDiscountService _markaDiscountService;
        private readonly IShoeDiscountService _shoeDiscountService;

        public DiscountController(IMarkaDiscountService markaDiscountService, IShoeDiscountService shoeDiscountService)
        {
            _markaDiscountService = markaDiscountService;
            _shoeDiscountService = shoeDiscountService;
        }

        public IActionResult Index()
        {
            var values = _shoeDiscountService.GetAll();
            return View(values);
        }
    }
}
