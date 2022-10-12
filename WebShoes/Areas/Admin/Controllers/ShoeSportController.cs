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
    public class ShoeSportController : Controller
    {
        private readonly IShoeSportService _shoeSportService;
        private readonly IMarkaSportService _markaSportService;
        private readonly IColorService _colorService;
        private readonly ISizeService _sizeService;
        private readonly ICurrencyService _currencyService;

        public ShoeSportController(IShoeSportService shoeSportService, IMarkaSportService markaSportService, IColorService colorService, ISizeService sizeService, ICurrencyService currencyService)
        {
            _shoeSportService = shoeSportService;
            _markaSportService = markaSportService;
            _colorService = colorService;
            _sizeService = sizeService;
            _currencyService = currencyService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult ShoeSportIndex()
        {
            var values = _shoeSportService.GetAll();
            return View(values.OrderByDescending(row => row.ID));
        }

        [HttpGet]
        public IActionResult ShoeSportAdd()
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaSportService.GetAll()
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
        public IActionResult ShoeSportAdd(ShoeSportDTO p)
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaSportService.GetAll()
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
            p.Details = "Details";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            _shoeSportService.Insert(p);
            return RedirectToAction("ShoeSportIndex", "ShoeSport");
        }

        [HttpGet]
        public IActionResult ShoeSportUpdate(int id)
        {
            var values = _shoeSportService.GetByID(id);
            IEnumerable<SelectListItem> markaValues = (from marka in _markaSportService.GetAll()
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
        public IActionResult ShoeSportUpdate(ShoeSportDTO p)
        {
            IEnumerable<SelectListItem> markaValues = (from marka in _markaSportService.GetAll()
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
            p.Details = "Details";
            p.Status = true;
            _shoeSportService.Update(p);
            return RedirectToAction("ShoeSportIndex", "ShoeSport");
        }

        public IActionResult ShoeSportDelete(int id)
        {
            _shoeSportService.Delete(id);
            return RedirectToAction("ShoeSportIndex", "ShoeSport");
        }
    }
}
