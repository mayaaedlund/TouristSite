using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

// Handles pages related to user accounts.
public class AccountController : Controller
{
  // Displays the login page.
  public IActionResult Login()
  {
    return View();
  }
}