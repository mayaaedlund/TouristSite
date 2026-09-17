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

    // Returns one specific event based on its id, together with its pictures.
    public TownEvent? GetEventDetail(int id)
    {
      return context.TownEvents
          .Include(e => e.Pictures)
          .FirstOrDefault(e => e.TownEventId == id);
    }

    // Saves a new event to the database.
    public void SaveEvent(TownEvent townEvent)
    {
      context.TownEvents.Add(townEvent);
      context.SaveChanges();
    }

    // Returns all event categories.
    public IQueryable<Category> Categories =>
        context.Categories;
  }
}