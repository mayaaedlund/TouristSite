using Microsoft.AspNetCore.Mvc;
using TouristSite.Models;

namespace TouristSite.Controllers;

// Handles pages used by editors.
public class EditorController : Controller
{
  private readonly ITownEventRepository repository;
  private readonly IWebHostEnvironment environment;

  public EditorController(
      ITownEventRepository repository,
      IWebHostEnvironment environment)
  {
    this.repository = repository;
    this.environment = environment;
  }

  // Displays the editor start page.
  public IActionResult StartEditor()
  {
    return View();
  }

  // Displays the page for creating a new event.
  [HttpGet]
  public IActionResult BookEvent()
  {
    return View();
  }

  // Receives and saves the event submitted from the form.
  [HttpPost]
  public async Task<IActionResult> BookEvent(
      TownEvent townEvent,
      IFormFile? loadImage,
      string? altText)
  {
    // The image is required.
    if (loadImage == null || loadImage.Length == 0)
    {
      ModelState.AddModelError("loadImage", "Du måste välja en bild.");
    }

    if (!ModelState.IsValid)
    {
      return View(townEvent);
    }

    // Use a default alt text if none was entered.
    if (string.IsNullOrWhiteSpace(altText))
    {
      altText = "Bild för evenemanget";
    }

    // Save the uploaded image in wwwroot/pictures.
    string fileName = Path.GetFileName(loadImage!.FileName);
    string pictureFolder = Path.Combine(
        environment.WebRootPath,
        "pictures");

    string filePath = Path.Combine(pictureFolder, fileName);

    using (var stream = new FileStream(filePath, FileMode.Create))
    {
      await loadImage.CopyToAsync(stream);
    }

    // Connect the picture to the new event.
    townEvent.Pictures.Add(new Picture
    {
      PictureName = fileName,
      AltText = altText
    });

    // Save the event and its picture to the database.
    repository.SaveEvent(townEvent);

    TempData["SuccessMessage"] = "Evenemanget har sparats.";

    return RedirectToAction("StartEditor");
  }
}