namespace TouristSite.Models
{
  // Represents a picture connected to an event.
  public class Picture
  {
    public int PictureId { get; set; }

    public string PictureName { get; set; } = string.Empty;

    public string AltText { get; set; } = string.Empty;

    public int TownEventId { get; set; }
  }
}