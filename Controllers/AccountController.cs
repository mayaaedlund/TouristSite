using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

public class AccountController : Controller
{
  public IActionResult Login()
  {
    return View();
  }
}