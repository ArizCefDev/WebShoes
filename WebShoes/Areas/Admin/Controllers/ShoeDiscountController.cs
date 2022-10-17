using Business.Abstract;
using Business.Concrete;
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
    public class ShoeDiscountController : Controller
    {
        private readonly IMarkaDiscountService _markaDiscountService;
        private readonly IShoeDiscountService _shoeDiscountService;
        private readonly IColorService _colorService;
        private readonly ISizeService _sizeService;
        private readonly ICurrencyService _currencyService;

        public ShoeDiscountController(IMarkaDiscountService markaDiscountService, IShoeDiscountService shoeDiscountService, IColorService colorService, ISizeService sizeService, ICurrencyService currencyService)
        {
            _markaDiscountService = markaDiscountService;
            _shoeDiscountService = shoeDiscountService;
            _colorService = colorService;
            _sizeService = sizeService;
            _currencyService = currencyService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult ShoeDiscountIndex()
        {
            var values = _shoeDiscountService.GetAll();
            return View(values.OrderByDescending(row=>row.ID));
        }

        [HttpGet]
        public IActionResult ShoeDiscountAdd()
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaDiscountService.GetAll()
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
        public IActionResult ShoeDiscountAdd(ShoeDiscountDTO p)
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaDiscountService.GetAll()
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
            _shoeDiscountService.Insert(p);
            return RedirectToAction("ShoeDiscountIndex", "ShoeDiscount");
        }

        [HttpGet]
        public IActionResult ShoeDiscountUpdate(int id)
        {
            var values = _shoeDiscountService.GetByID(id);
            IEnumerable<SelectListItem> markaValue = (from marka in _markaDiscountService.GetAll()
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
        public IActionResult ShoeDiscountUpdate(ShoeDiscountDTO p)
        {
            IEnumerable<SelectListItem> markaValue = (from marka in _markaDiscountService.GetAll()
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
            _shoeDiscountService.Update(p);
            return RedirectToAction("ShoeDiscountIndex", "ShoeDiscount");
        }

        public IActionResult ShoeDiscountDelete(int id)
        {
            _shoeDiscountService.Delete(id);
            return RedirectToAction("ShoeDiscountIndex", "ShoeDiscount");
        }
    }
}
