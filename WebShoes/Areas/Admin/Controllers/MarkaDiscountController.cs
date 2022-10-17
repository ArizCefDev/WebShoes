using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaDiscountController : Controller
    {
        private readonly IMarkaDiscountService _markaDiscountService;

        public MarkaDiscountController(IMarkaDiscountService markaDiscountService)
        {
            _markaDiscountService = markaDiscountService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult MarkaDiscountIndex()
        {
            var values = _markaDiscountService.GetAll();
            return View(values.OrderByDescending(row => row.ID));
        }

        [HttpGet]
        public IActionResult MarkaDiscountAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MarkaDiscountAdd(MarkaDiscountDTO p)
        {
            p.Status = true;
            _markaDiscountService.Insert(p);
            return RedirectToAction("MarkaDiscountIndex", "MarkaDiscount");
        }

        [HttpGet]
        public IActionResult MarkaDiscountUpdate(int id)
        {
            var values = _markaDiscountService.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult MarkaDiscountUpdate(MarkaDiscountDTO p)
        {
            p.Status = true;
            _markaDiscountService.Update(p);
            return RedirectToAction("MarkaDiscountIndex", "MarkaDiscount");
        }

        public IActionResult MarkaDiscountDelete(int id)
        {
            _markaDiscountService.Delete(id);
            return RedirectToAction("MarkaDiscountIndex", "MarkaDiscount");
        }
    }
}
