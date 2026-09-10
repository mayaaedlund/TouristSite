using Microsoft.AspNetCore.Mvc;

namespace TouristSite.Controllers;

// Handles pages used by editors.
public class EditorController : Controller
{
  // Displays the editor start page.
  public IActionResult StartEditor()
  {
    return View();
  }

  // Displays the page for creating or booking an event.
  public IActionResult BookEvent()
  {
    return View();
  }
}