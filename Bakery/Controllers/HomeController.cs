using System.Security.Claims;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using Bakery.ViewModels;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    public HomeController(BakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var HomeModel = new UserViewModel {
        Flavors = _db.Flavors.ToList()
          .OrderByDescending(f => f.User.Id == userId)
          .ToList(),
        Treats = _db.Treats
          .OrderByDescending(t => t.User.Id == userId)
          .ToList(),
        UserId = userId
      };
      return View(HomeModel);
    }
  }
}