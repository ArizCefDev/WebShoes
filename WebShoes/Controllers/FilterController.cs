using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.Controllers
{
    public class FilterController : Controller
    {
        private readonly IColorService _colorService;
        private readonly ICurrencyService _currencyService;
        private readonly ISizeService _sizeService;

        public FilterController(IColorService colorService, ICurrencyService currencyService, ISizeService sizeService)
        {
            _colorService = colorService;
            _currencyService = currencyService;
            _sizeService = sizeService;
        }

        public IActionResult ColorList()
        {
            var values = _colorService.GetAll();
            return View(values);
        }

        public IActionResult ColorList2()
        {
            var values = _colorService.GetAll();
            return View(values);
        }

        public IActionResult ColorList3()
        {
            var values = _colorService.GetAll();
            return View(values);
        }

        public IActionResult SizeList()
        {
            var values = _sizeService.GetAll();
            return View(values);
        }

        public IActionResult SizeList2()
        {
            var values = _sizeService.GetAll();
            return View(values);
        }

        public IActionResult SizeList3()
        {
            var values = _sizeService.GetAll();
            return View(values);
        }

        public IActionResult CurrencyList()
        {
            var values = _currencyService.GetAll();
            return View(values);
        }

        public IActionResult CurrencyList2()
        {
            var values = _currencyService.GetAll();
            return View(values);
        }

        public IActionResult CurrencyList3()
        {
            var values = _currencyService.GetAll();
            return View(values);
        }
    }
}
