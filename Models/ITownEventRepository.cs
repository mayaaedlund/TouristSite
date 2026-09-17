namespace TouristSite.Models
{
  public interface ITownEventRepository
  {
    IQueryable<TownEvent> TownEvents { get; }

    TownEvent? GetEventDetail(int id);

    void SaveEvent(TownEvent townEvent);

    IQueryable<Category> Categories { get; }
  }
}