namespace VibeHive.EventsApi.Models
{
    /// <summary>
    /// Represents a booked ticket for an event
    /// </summary>
    public class Ticket
    {
        public int Id { get; set; }          // PK
        public int EventId { get; set; }     // which event this ticket is for
        public int UserId { get; set; }      // which user booked it
                                             // "Booked" or "Cancelled"
        public string Status { get; set; } = "Booked";
    }
}