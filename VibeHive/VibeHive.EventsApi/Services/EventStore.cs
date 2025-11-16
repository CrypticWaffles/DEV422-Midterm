using System.Collections.Generic;

using System.Linq;

using VibeHive.EventsApi.Models;

namespace VibeHive.EventsApi.Services

{

    /// <summary>

    /// In-memory storage for events and tickets.

    /// </summary>

    public class EventStore

    {

        private readonly List<Event> _events = new();

        private readonly List<Ticket> _tickets = new();

        private int _nextEventId = 1;

        private int _nextTicketId = 1;

        private readonly object _lock = new();

        public EventStore()

        {

            // shows something even before someone creates events

            AddEvent(new Event

            {

                Name = "Indie Night",

                Date = DateTime.UtcNow.AddDays(7),

                Venue = "Main Hall",

                Genre = "Indie",

                AvailableTickets = 100

            });

            AddEvent(new Event

            {

                Name = "Hip-Hop Fest",

                Date = DateTime.UtcNow.AddDays(14),

                Venue = "City Arena",

                Genre = "Hip-Hop",

                AvailableTickets = 150

            });

        }

        // Events

        public IEnumerable<Event> GetAllEvents()

        {

            lock (_lock)

            {

                return _events.ToList();

            }

        }

        public Event? GetEventById(int id)

        {

            lock (_lock)

            {

                return _events.FirstOrDefault(e => e.Id == id);

            }

        }

        public Event AddEvent(Event e)

        {

            lock (_lock)

            {

                e.Id = _nextEventId++;

                _events.Add(e);

                return e;

            }

        }

        // Tickets 

        /// <summary>

        /// Tries to book a ticket for an event.

        /// Returns true/false + the created ticket or an error message.

        /// </summary>

        public bool TryBookTicket(int eventId, int userId,

        out Ticket? ticket, out string? error)
        {
            lock (_lock)
            {
                ticket = null;
                error = null;

                // Find the event
                var ev = _events.FirstOrDefault(e => e.Id == eventId);
                if (ev == null)
                {
                    error = "Event not found.";
                    return false;
                }
                // Prevent duplicate booking for same user + event
                var alreadyBooked = _tickets.Any(t =>
                    t.EventId == eventId &&
                    t.UserId == userId &&
                    t.Status == "Booked");
                if (alreadyBooked)
                {
                    error = "You already booked this event.";
                    return false;
                }
                // Check remaining tickets
                if (ev.AvailableTickets <= 0)
                {
                    error = "No tickets left for this event.";
                    return false;
                }
                // Reserve one ticket if available
                ev.AvailableTickets--;
                ticket = new Ticket
                {
                    Id = _nextTicketId++,
                    EventId = eventId,
                    UserId = userId,
                    Status = "Booked"
                };
                _tickets.Add(ticket);
                return true;
            }

        }

        public IEnumerable<Ticket> GetTicketsForUser(int userId)

        {

            lock (_lock)

            {

                return _tickets

                    .Where(t => t.UserId == userId)

                    .ToList();

            }

        }

    }

}
