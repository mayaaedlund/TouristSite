using Microsoft.AspNetCore.Mvc;
using TouristSite.Models;

namespace TouristSite.ViewComponents
{
  public class CategoryListViewComponent : ViewComponent
  {
    private readonly ITownEventRepository repository;

    public CategoryListViewComponent(ITownEventRepository repository)
    {
      this.repository = repository;
    }

    public IViewComponentResult Invoke()
    {
      var categories = repository.Categories
          .OrderBy(c => c.CategoryName);

      return View(categories);
    }
  }
}