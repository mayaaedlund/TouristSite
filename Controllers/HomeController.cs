using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

// Handles requests for the application's home page.
public class HomeController : Controller
{
  // Displays the application's start page.
  public IActionResult Index()
  {
    return View();
  }
}