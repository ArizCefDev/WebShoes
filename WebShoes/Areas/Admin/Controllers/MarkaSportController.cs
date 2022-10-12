using Business.Abstract;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaSportController : Controller
    {
        private readonly IMarkaSportService _markaSportService;

        public MarkaSportController(IMarkaSportService markaSportService)
        {
            _markaSportService = markaSportService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult MarkaSportIndex()
        {
            var values = _markaSportService.GetAll();
            return View(values.OrderByDescending(row=>row.ID));
        }

        [HttpGet]
        public IActionResult MarkaSportAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MarkaSportAdd(MarkaSportDTO p)
        {
            p.Status = true;
            _markaSportService.Insert(p);
            return RedirectToAction("MarkaSportIndex", "MarkaSport");
        }

        [HttpGet]
        public IActionResult MarkaSportUpdate(int id)
        {
            var values = _markaSportService.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult MarkaSportUpdate(MarkaSportDTO p)
        {
            p.Status = true;
            _markaSportService.Update(p);
            return RedirectToAction("MarkaSportIndex", "MarkaSport");
        }

        public IActionResult MarkaSportDelete(int id)
        {
            _markaSportService.Delete(id);
            return RedirectToAction("MarkaSportIndex", "MarkaSport");
        }
    }
}
