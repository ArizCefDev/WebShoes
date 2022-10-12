using Business.Abstract;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebShoes.Areas.Admin.ViewComponents.Messages
{
    public class MessageList : ViewComponent
    {
        private readonly IMessageService _messageService;
        private readonly AppDBContext _dBContext;

        public MessageList(IMessageService messageService, AppDBContext dBContext)
        {
            _messageService = messageService;
            _dBContext = dBContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.newmessage = _dBContext.Messages.Count();
            var values = _messageService.GetAll();
            return View(values);
        }
    }
}
