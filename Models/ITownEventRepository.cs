namespace TouristSite.Models
{
  // Defines how event data should be accessed.
  public interface ITownEventRepository
  {
    IQueryable<TownEvent> TownEvents { get; }

    IQueryable<Category> Categories { get; }
  }
}