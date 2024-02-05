using Microsoft.AspNetCore.Mvc;

namespace App.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "WebApplication";
        }
    }
}
