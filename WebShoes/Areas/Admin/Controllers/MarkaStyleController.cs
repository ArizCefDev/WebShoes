using Business.Abstract;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaStyleController : Controller
    {
        private readonly IMarkaStyleService _markaStyleService;

        public MarkaStyleController(IMarkaStyleService markaStyleService)
        {
            _markaStyleService = markaStyleService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult MarkaStyleIndex()
        {
            var values = _markaStyleService.GetAll();
            return View(values.OrderByDescending(row => row.ID));
        }

        [HttpGet]
        public IActionResult MarkaStyleAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MarkaStyleAdd(MarkaStyleDTO p)
        {
            p.Status = true;
            _markaStyleService.Insert(p);
            return RedirectToAction("MarkaStyleIndex", "MarkaStyle");
        }

        [HttpGet]
        public IActionResult MarkaStyleUpdate(int id)
        {
            var values = _markaStyleService.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult MarkaStyleUpdate(MarkaStyleDTO p)
        {
            p.Status = true;
            _markaStyleService.Update(p);
            return RedirectToAction("MarkaStyleIndex", "MarkaStyle");
        }

        public IActionResult MarkaStyleDelete(int id)
        {
            _markaStyleService.Delete(id);
            return RedirectToAction("MarkaStyleIndex", "MarkaStyle");
        }
    }
}
