using Microsoft.AspNetCore.Mvc;

using VibeHive.EventsApi.Models;

using VibeHive.EventsApi.Services;

namespace VibeHive.EventsApi.Controllers

{

    // api/tickets

    [ApiController]

    [Route("api/[controller]")]

    public class TicketsController : ControllerBase

    {

        private readonly EventStore _store;

        public TicketsController(EventStore store)

        {

            _store = store;

        }

        // DTO for booking a ticket

        public class BookTicketRequest

        {

            public int EventId { get; set; }

            public int UserId { get; set; }

        }

        // POST /api/tickets

        // books a ticket for an event + user

        [HttpPost]

        public ActionResult<Ticket> BookTicket([FromBody] BookTicketRequest request)

        {

            if (!ModelState.IsValid)

            {

                return BadRequest(ModelState);

            }

            var ok = _store.TryBookTicket(

                request.EventId,

                request.UserId,

                out var ticket,

                out var error);

            if (!ok || ticket == null)

            {

                // event missing or no tickets left

                return BadRequest(new { message = error ?? "Unable to book ticket." });

            }

            // 201 Created with the ticket data

            return CreatedAtAction(

                nameof(GetTicketsForUser),

                new { userId = ticket.UserId },

                ticket);

        }

        // GET /api/tickets/{userId}

        // returns all tickets for a specific user

        [HttpGet("{userId:int}")]

        public ActionResult<IEnumerable<Ticket>> GetTicketsForUser(int userId)

        {

            var tickets = _store.GetTicketsForUser(userId);

            return Ok(tickets);

        }

    }

}
