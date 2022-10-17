using Business.Abstract;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MarkaClassicController : Controller
    {
        private readonly IMarkaClassicService _markaClassicService;

        public MarkaClassicController(IMarkaClassicService markaClassicService)
        {
            _markaClassicService = markaClassicService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult MarkaClassicIndex()
        {
            var values = _markaClassicService.GetAll();
            return View(values.OrderByDescending(row => row.ID));
        }

        [HttpGet]
        public IActionResult MarkaClassicAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MarkaClassicAdd(MarkaClassicDTO p)
        {
            p.Status = true;
            _markaClassicService.Insert(p);
            return RedirectToAction("MarkaClassicIndex", "MarkaClassic");
        }

        [HttpGet]
        public IActionResult MarkaClassicUpdate(int id)
        {
            var values = _markaClassicService.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult MarkaClassicUpdate(MarkaClassicDTO p)
        {
            p.Status = true;
            _markaClassicService.Update(p);
            return RedirectToAction("MarkaClassicIndex", "MarkaClassic");
        }

        public IActionResult MarkaClassicDelete(int id)
        {
            _markaClassicService.Delete(id);
            return RedirectToAction("MarkaClassicIndex", "MarkaClassic");
        }
    }
}
