namespace VibeHive.EventsApi.Models
{
    /// <summary>
    /// Represents an event in VibeHive
    /// </summary>
    public class Event
    {
        public int Id { get; set; }                // PK 
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }         // when the event happens
        public string Venue { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int AvailableTickets { get; set; }  // remaining tickets
    }
}