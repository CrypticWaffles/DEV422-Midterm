using VibeHive.Models;

namespace VibeHive.Services

{

    /// <summary>

    /// Very simple in-memory storage for events and tickets.

    /// This is shared by all controllers while the app is running.

    /// </summary>

    public class EventStore

    {

        private readonly List<Event> _events = new();

        private readonly List<Ticket> _tickets = new();

        private int _nextEventId = 1;

        private int _nextTicketId = 1;

        public EventStore()

        {

            // Optional: some sample events to test with

            _events.Add(new Event

            {

                Id = _nextEventId++,

                Name = "Lo-Fi Night",

                Date = DateTime.UtcNow.AddDays(3),

                Venue = "Main Hall",

                Genre = "Lo-Fi",

                AvailableTickets = 50

            });

            _events.Add(new Event

            {

                Id = _nextEventId++,

                Name = "Afrobeat Jam",

                Date = DateTime.UtcNow.AddDays(7),

                Venue = "Stage B",

                Genre = "Afrobeat",

                AvailableTickets = 100

            });

        }

        // ---- Events ----

        public IReadOnlyList<Event> GetAllEvents() => _events;

        public Event? GetEventById(int id) =>

            _events.FirstOrDefault(e => e.Id == id);

        public Event AddEvent(Event e)

        {

            e.Id = _nextEventId++;

            _events.Add(e);

            return e;

        }

        // ---- Tickets ----

        public Ticket? GetTicketById(int id) =>

            _tickets.FirstOrDefault(t => t.Id == id);

        public IEnumerable<Ticket> GetTicketsForUser(int userId) =>

            _tickets.Where(t => t.UserId == userId);

        /// <summary>

        /// Books a ticket if the event exists and has available seats.

        /// Returns null if booking is not possible.

        /// </summary>

        public Ticket? BookTicket(int eventId, int userId)

        {

            var ev = GetEventById(eventId);

            if (ev == null || ev.AvailableTickets <= 0)

            {

                return null;

            }

            ev.AvailableTickets--;

            var ticket = new Ticket

            {

                Id = _nextTicketId++,

                EventId = eventId,

                UserId = userId,

                Status = "Booked"

            };

            _tickets.Add(ticket);

            return ticket;

        }

    }

}
