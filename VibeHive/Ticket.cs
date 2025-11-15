namespace VibeHive.Models
{
    /// <summary>
    /// Represents a booked ticket for an event.
    /// (matches the assignment: EventID, UserID, Status).
    /// </summary>
    public class Ticket
    {
        public int Id { get; set; }          // PK (we'll assign in memory)
        public int EventId { get; set; }     // which event this ticket is for
        public int UserId { get; set; }      // which user booked it
                                             // "Booked" or "Cancelled" (we'll keep it as string to stay simple)
        public string Status { get; set; } = "Booked";
    }
}