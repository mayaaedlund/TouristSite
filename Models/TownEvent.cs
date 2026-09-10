using System.ComponentModel.DataAnnotations;

namespace TouristSite.Models
{
  // Represents an event in the municipality.
  public class TownEvent
  {
    public int TownEventId { get; set; }

    [Required]
    public string EventName { get; set; } = string.Empty;

    [Required]
    public string ShortDescription { get; set; } = string.Empty;

    [Required]
    public DateTime EventDate { get; set; }

    [Required]
    public string Place { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [Required]
    public string LongDescription { get; set; } = string.Empty;

    [Required]
    public string Organizer { get; set; } = string.Empty;

    public ICollection<Picture> Pictures { get; set; } = new List<Picture>();
  }
}