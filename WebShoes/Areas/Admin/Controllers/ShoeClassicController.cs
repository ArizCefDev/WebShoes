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
    public class ShoeClassicController : Controller
    {
        private readonly IShoeClassicService _shoeClassicService;
        private readonly IMarkaClassicService _markaClassicService;
        private readonly IColorService _colorService;
        private readonly ISizeService _sizeService;
        private readonly ICurrencyService _currencyService;

        public ShoeClassicController(IShoeClassicService shoeClassicService, IMarkaClassicService markaClassicService, IColorService colorService, ISizeService sizeService, ICurrencyService currencyService)
        {
            _shoeClassicService = shoeClassicService;
            _markaClassicService = markaClassicService;
            _colorService = colorService;
            _sizeService = sizeService;
            _currencyService = currencyService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult ShoeClassicIndex()
        {
            var values = _shoeClassicService.GetAll();
            return View(values.OrderByDescending(row=>row.ID));
        }

        [HttpGet]
        public IActionResult ShoeClassicAdd()
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaClassicService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = marka.ShoeName,
                                                           Value = marka.ID.ToString()
                                                       }).ToList();
            ViewBag.m = markaValues;

            IEnumerable<SelectListItem> colorValues = (from color in _colorService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = color.ColorName,
                                                           Value = color.ID.ToString()
                                                       }).ToList();
            ViewBag.c = colorValues;

            IEnumerable<SelectListItem> sizeValues = (from size in _sizeService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = size.SizeNumber,
                                                          Value = size.ID.ToString()
                                                      }).ToList();
            ViewBag.s = sizeValues;

            IEnumerable<SelectListItem> currencyValues = (from currency in _currencyService.GetAll()
                                                          select new SelectListItem
                                                          {
                                                              Text = currency.CurrencyName,
                                                              Value = currency.ID.ToString()
                                                          }).ToList();
            ViewBag.cr = currencyValues;
            return View();
        }

        [HttpPost]
        public IActionResult ShoeClassicAdd(ShoeClassicDTO p)
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaClassicService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = marka.ShoeName,
                                                           Value = marka.ID.ToString()
                                                       }).ToList();
            ViewBag.m = markaValues;

            IEnumerable<SelectListItem> colorValues = (from color in _colorService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = color.ColorName,
                                                           Value = color.ID.ToString()
                                                       }).ToList();
            ViewBag.c = colorValues;

            IEnumerable<SelectListItem> sizeValues = (from size in _sizeService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = size.SizeNumber,
                                                          Value = size.ID.ToString()
                                                      }).ToList();
            ViewBag.s = sizeValues;

            IEnumerable<SelectListItem> currencyValues = (from currency in _currencyService.GetAll()
                                                          select new SelectListItem
                                                          {
                                                              Text = currency.CurrencyName,
                                                              Value = currency.ID.ToString()
                                                          }).ToList();
            ViewBag.cr = currencyValues;
            p.Status = true;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _shoeClassicService.Insert(p);
            return RedirectToAction("ShoeClassicIndex", "ShoeClassic");
        }

        [HttpGet]
        public IActionResult ShoeClassicUpdate(int id)
        {
            var values = _shoeClassicService.GetByID(id);

            IEnumerable<SelectListItem> markaValues = (from marka in _markaClassicService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = marka.ShoeName,
                                                           Value = marka.ID.ToString()
                                                       }).ToList();
            ViewBag.m = markaValues;

            IEnumerable<SelectListItem> colorValues = (from color in _colorService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = color.ColorName,
                                                           Value = color.ID.ToString()
                                                       }).ToList();
            ViewBag.c = colorValues;

            IEnumerable<SelectListItem> sizeValues = (from size in _sizeService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = size.SizeNumber,
                                                          Value = size.ID.ToString()
                                                      }).ToList();
            ViewBag.s = sizeValues;

            IEnumerable<SelectListItem> currencyValues = (from currency in _currencyService.GetAll()
                                                          select new SelectListItem
                                                          {
                                                              Text = currency.CurrencyName,
                                                              Value = currency.ID.ToString()
                                                          }).ToList();
            ViewBag.cr = currencyValues;

            return View(values);
        }

        [HttpPost]
        public IActionResult ShoeClassicUpdate(ShoeClassicDTO p)
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaClassicService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = marka.ShoeName,
                                                           Value = marka.ID.ToString()
                                                       }).ToList();
            ViewBag.m = markaValues;

            IEnumerable<SelectListItem> colorValues = (from color in _colorService.GetAll()
                                                       select new SelectListItem
                                                       {
                                                           Text = color.ColorName,
                                                           Value = color.ID.ToString()
                                                       }).ToList();
            ViewBag.c = colorValues;

            IEnumerable<SelectListItem> sizeValues = (from size in _sizeService.GetAll()
                                                      select new SelectListItem
                                                      {
                                                          Text = size.SizeNumber,
                                                          Value = size.ID.ToString()
                                                      }).ToList();
            ViewBag.s = sizeValues;

            IEnumerable<SelectListItem> currencyValues = (from currency in _currencyService.GetAll()
                                                          select new SelectListItem
                                                          {
                                                              Text = currency.CurrencyName,
                                                              Value = currency.ID.ToString()
                                                          }).ToList();
            ViewBag.cr = currencyValues;
            p.Status = true;
            _shoeClassicService.Update(p);
            return RedirectToAction("ShoeClassicIndex", "ShoeClassic");
        }

        public IActionResult ShoeClassicDelete(int id)
        {
            _shoeClassicService.Delete(id);
            return RedirectToAction("ShoeClassicIndex", "ShoeClassic");
        }
    }
}
