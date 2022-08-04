using Microsoft.AspNetCore.Mvc;

namespace FanBook.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}