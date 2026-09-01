using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}