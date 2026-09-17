namespace TouristSite.Models
{
  public interface ITownEventRepository
  {
    IQueryable<TownEvent> TownEvents { get; }

    TownEvent? GetEventDetail(int id);

    IQueryable<Category> Categories { get; }
  }
}