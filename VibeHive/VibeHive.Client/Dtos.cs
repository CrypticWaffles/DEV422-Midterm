using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Client
{
        public class EventDto
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public DateTime Date { get; set; }
            public string Venue { get; set; } = string.Empty;
            public string Genre { get; set; } = string.Empty;
            public int AvailableTickets { get; set; }
        }
        public class TicketDto
        {
            public int Id { get; set; }
            public int EventId { get; set; }
            public int UserId { get; set; }
            public string Status { get; set; } = string.Empty;
        }
    }

