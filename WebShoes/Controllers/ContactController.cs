using Business.Abstract;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Mvc;

namespace WebShoes.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageAdd(MessageDTO p)
        {
            p.Status = true;
            _messageService.Insert(p);
            return RedirectToAction("MessageShow", "Contact");
        }

        public IActionResult MessageShow()
        {
            return View();
        }
    }
}
