namespace TouristSite.Models
{
  // Provides fake event data for testing before the real database is connected.
  public class FakeRepository : ITownEventRepository
  {
    public IQueryable<TownEvent> TownEvents => new List<TownEvent>
    {
      new TownEvent
      {
        TownEventId = 1,
        EventName = "Lär dig odla",
        ShortDescription = "Odlingskurs för nybörjare. Vi tittar på rotfrukter och grönsaker",
        Category = "Övrigt",
        EventDate = new DateTime(2026, 09, 23, 17, 30, 00),
        Place = "Växthuset",
        LongDescription = "Odlingskurs för nybörjare. Vi tittar på olika rotfrukter och grönsaker du kan odla enkelt hemma. Inga förkunskaper krävs. Material tillhandahålls för inköp"
      },

      new TownEvent
      {
        TownEventId = 2,
        EventName = "Match korpenbollen",
        ShortDescription = "Fotbollsmatch där lagen inom korpen spelar",
        Category = "Sport",
        EventDate = new DateTime(2026, 10, 25, 13, 00, 00),
        Place = "Idrottsplatsen",
        LongDescription = "De fyra korpenlagen - Little Towners, Kontorsslavarna, Miljökämparna, Lag utan slag - möts i en alla-mot-alla match. Kom och njut av spelet, varm korven och hejaropen"
      },

      new TownEvent
      {
        TownEventId = 3,
        EventName = "Litteraturafton",
        ShortDescription = "Vår lokala författare Stina Jämtlund berättar om sin senaste bok",
        Category = "Litteratur",
        EventDate = new DateTime(2026, 11, 12, 15, 00, 00),
        Place = "Biblioteket",
        LongDescription = "Vår lokala författare Stina Jämtlund berättar om sin senaste bok. Efter samtalet som börjar kl. 15.00 får man chans att köpa boken signerad."
      }
    }.AsQueryable();

    // Returns one specific event based on its id.
    public TownEvent? GetEventDetail(int id)
    {
      return TownEvents.FirstOrDefault(e => e.TownEventId == id);
    }

    // Saves an event in the fake repository.
    // This repository is only used for testing, so no database save is performed.
    public void SaveEvent(TownEvent townEvent)
    {
    }

    public IQueryable<Category> Categories => new List<Category>
    {
      new Category { CategoryId = "C01", CategoryName = "Musik" },
      new Category { CategoryId = "C02", CategoryName = "Teater" },
      new Category { CategoryId = "C03", CategoryName = "Dans" },
      new Category { CategoryId = "C04", CategoryName = "Litteratur" },
      new Category { CategoryId = "C05", CategoryName = "Marknad" },
      new Category { CategoryId = "C06", CategoryName = "Barn" },
      new Category { CategoryId = "C07", CategoryName = "Sport" },
      new Category { CategoryId = "C08", CategoryName = "Övrigt" }
    }.AsQueryable();
  }
}