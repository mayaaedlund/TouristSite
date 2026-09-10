using Microsoft.AspNetCore.Mvc;
using TouristSite.Models;

namespace TouristSite.Controllers;

public class CitizenController : Controller
{
  private readonly ITownEventRepository repository;

  // Constructor that receives the repository through dependency injection.
  public CitizenController(ITownEventRepository repository)
  {
    this.repository = repository;
  }

  public IActionResult About()
  {
    return View();
  }

  public IActionResult Contact()
  {
    return View();
  }

  // Shows details for one specific event.
  public IActionResult EventDetail(int id)
  {
    var townEvent = repository.TownEvents
        .FirstOrDefault(e => e.TownEventId == id);

    if (townEvent == null)
    {
      return NotFound();
    }

    return View(townEvent);
  }

  // Shows all events sorted by date.
  public IActionResult EventList()
  {
    var events = repository.TownEvents
        .OrderBy(e => e.EventDate);

    return View(events);
  }
}