namespace VibeHive.Models
{
    /// <summary>
    /// Represents a music event in VibeHive
    /// (matches the assignment: Name, Date, Venue, Genre, AvailableTickets).
    /// </summary>
    public class Event
    {
        public int Id { get; set; }                // PK (we'll assign in memory)
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }         // when the event happens
        public string Venue { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int AvailableTickets { get; set; }  // remaining tickets
    }
}