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
      var model = new UserViewModel {
        Flavors = _db.Flavors.ToList(),
        Treats = _db.Treats.ToList()
      };
      return View(model);
    }
  }
}