using Microsoft.AspNetCore.Mvc;

namespace WebShoes.ViewComponents.Currency
{
    public class CurrencyList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
