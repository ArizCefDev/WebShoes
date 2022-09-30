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

        public IActionResult Index()
        {
            ViewBag.styleshoes = _dBContext.ShoeStyles.Count();
            var values = _shoeStyleService.GetAll();
            return View(values);
        }

        public IActionResult GetMarkaStyle(int id)
        {
            var values = _shoeStyleService.GetMarkaShoe(id);
            return View(values.OrderByDescending(x => x.ID));
        }
    }
}
