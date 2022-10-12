using Business.Abstract;
using DataAccess.Entity;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebShoes.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShoeStyleController : Controller
    {
        private readonly IShoeStyleService _shoeStyleService;
        private readonly IMarkaStyleService _markaStyleService;
        private readonly IColorService _colorService;
        private readonly ICurrencyService _currencyService;
        private readonly ISizeService _sizeService;

        public ShoeStyleController(IShoeStyleService shoeStyleService, IMarkaStyleService markaStyleService, IColorService colorService, ICurrencyService currencyService, ISizeService sizeService)
        {
            _shoeStyleService = shoeStyleService;
            _markaStyleService = markaStyleService;
            _colorService = colorService;
            _currencyService = currencyService;
            _sizeService = sizeService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult ShoeStyleIndex()
        {
            var values = _shoeStyleService.GetAll();
            return View(values.OrderByDescending(row => row.ID));
        }

        [HttpGet]
        public IActionResult ShoeStyleAdd()
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaStyleService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = marka.ShoeName,
                                                          Value = marka.ID.ToString()
                                                      }).ToList();
            ViewBag.m = markaValue;

            IEnumerable<SelectListItem> colorValue = (from color in _colorService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = color.ColorName,
                                                          Value = color.ID.ToString()
                                                      }).ToList();
            ViewBag.c = colorValue;

            IEnumerable<SelectListItem> currencyValue = (from currency in _currencyService.GetAll()
                                                         select new SelectListItem
                                                         {
                                                             Text = currency.CurrencyName,
                                                             Value = currency.ID.ToString()
                                                         }).ToList();
            ViewBag.cr = currencyValue;

            IEnumerable<SelectListItem> sizeValue = (from size in _sizeService.GetAll()
                                                     select new SelectListItem
                                                     {
                                                         Text = size.SizeNumber,
                                                         Value = size.ID.ToString()
                                                     }).ToList();
            ViewBag.s = sizeValue;
            return View();
        }

        [HttpPost]
        public IActionResult ShoeStyleAdd(ShoeStyleDTO p)
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaStyleService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = marka.ShoeName,
                                                          Value = marka.ID.ToString()
                                                      }).ToList();
            ViewBag.m = markaValue;

            IEnumerable<SelectListItem> colorValue = (from color in _colorService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = color.ColorName,
                                                          Value = color.ID.ToString()
                                                      }).ToList();
            ViewBag.c = colorValue;

            IEnumerable<SelectListItem> currencyValue = (from currency in _currencyService.GetAll()
                                                         select new SelectListItem
                                                         {
                                                             Text = currency.CurrencyName,
                                                             Value = currency.ID.ToString()
                                                         }).ToList();
            ViewBag.cr = currencyValue;

            IEnumerable<SelectListItem> sizeValue = (from size in _sizeService.GetAll()
                                                     select new SelectListItem
                                                     {
                                                         Text = size.SizeNumber,
                                                         Value = size.ID.ToString()
                                                     }).ToList();
            ViewBag.s = sizeValue;
            p.Status = true;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _shoeStyleService.Insert(p);
            return RedirectToAction("ShoeStyleIndex", "ShoeStyle");
        }

        [HttpGet]
        public IActionResult ShoeStyleUpdate(int id)
        {
            var values = _shoeStyleService.GetByID(id);
            IEnumerable<SelectListItem> markaValue = (from marka in _markaStyleService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = marka.ShoeName,
                                                          Value = marka.ID.ToString()
                                                      }).ToList();
            ViewBag.m = markaValue;

            IEnumerable<SelectListItem> colorValue = (from color in _colorService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = color.ColorName,
                                                          Value = color.ID.ToString()
                                                      }).ToList();
            ViewBag.c = colorValue;

            IEnumerable<SelectListItem> currencyValue = (from currency in _currencyService.GetAll()
                                                         select new SelectListItem
                                                         {
                                                             Text = currency.CurrencyName,
                                                             Value = currency.ID.ToString()
                                                         }).ToList();
            ViewBag.cr = currencyValue;

            IEnumerable<SelectListItem> sizeValue = (from size in _sizeService.GetAll()
                                                     select new SelectListItem
                                                     {
                                                         Text = size.SizeNumber,
                                                         Value = size.ID.ToString()
                                                     }).ToList();
            ViewBag.s = sizeValue;
            return View(values);
        }

        [HttpPost]
        public IActionResult ShoeStyleUpdate(ShoeStyleDTO p)
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaStyleService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = marka.ShoeName,
                                                          Value = marka.ID.ToString()
                                                      }).ToList();
            ViewBag.m = markaValue;

            IEnumerable<SelectListItem> colorValue = (from color in _colorService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = color.ColorName,
                                                          Value = color.ID.ToString()
                                                      }).ToList();
            ViewBag.c = colorValue;

            IEnumerable<SelectListItem> currencyValue = (from currency in _currencyService.GetAll()
                                                         select new SelectListItem
                                                         {
                                                             Text = currency.CurrencyName,
                                                             Value = currency.ID.ToString()
                                                         }).ToList();
            ViewBag.cr = currencyValue;

            IEnumerable<SelectListItem> sizeValue = (from size in _sizeService.GetAll()
                                                     select new SelectListItem
                                                     {
                                                         Text = size.SizeNumber,
                                                         Value = size.ID.ToString()
                                                     }).ToList();
            ViewBag.s = sizeValue;
            p.Status = true;
            _shoeStyleService.Update(p);
            return RedirectToAction("ShoeStyleIndex", "ShoeStyle");
        }

        public IActionResult ShoeStyleDelete(int id)
        {
            _shoeStyleService.Delete(id);
            return RedirectToAction("ShoeStyleIndex", "ShoeStyle");
        }
    }
}
