using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

public class EditorController : Controller
{
  public IActionResult StartEditor()
  {
    return View();
  }

  public IActionResult BookEvent()
  {
    return View();
  }
}