using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FanBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace FanBook.Controllers
{
  public class BandsController : Controller
  {
    private readonly FanBookContext _db;

    public BandsController(FanBookContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Bands.ToList());
    }
  }
}  