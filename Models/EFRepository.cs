using Microsoft.EntityFrameworkCore;

namespace TouristSite.Models
{
  // Provides access to event and category data stored in the database.
  public class EFRepository : ITownEventRepository
  {
    private readonly TouristContext context;

    // Receives the database context through dependency injection.
    public EFRepository(TouristContext context)
    {
      this.context = context;
    }

    // Returns events together with their related pictures.
    public IQueryable<TownEvent> TownEvents =>
        context.TownEvents.Include(e => e.Pictures);

    // Returns all event categories.
    public IQueryable<Category> Categories =>
        context.Categories;
  }
}