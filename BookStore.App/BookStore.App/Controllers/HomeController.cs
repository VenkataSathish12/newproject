using Microsoft.AspNetCore.Mvc;

namespace BookStore.App.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "BookStore Application";
        }
    }
}
