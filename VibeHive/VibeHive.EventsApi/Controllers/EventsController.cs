using Microsoft.AspNetCore.Authorization; // Needed for JWT authorization
using Microsoft.AspNetCore.Mvc;
﻿using Microsoft.AspNetCore.Mvc;

using VibeHive.EventsApi.Models;

using VibeHive.EventsApi.Services;

namespace VibeHive.EventsApi.Controllers

{

    // api/events

    [ApiController]

    [Route("api/[controller]")]

    public class EventsController : ControllerBase

    {

        private readonly EventStore _store;

        public EventsController(EventStore store)

        {

            _store = store;

        }

        /*
         * POST /api/events:
         * Add a new music event
         * endpoint access for Admins / Event Managers ONLY
         */
        [Authorize] // <--- Update to specific roles later.
        [HttpPost]
        public ActionResult AddEvent(Event @event)
        {
            // 1.) Check event submission for invalid / missing inputs:
            if (string.IsNullOrEmpty(@event.Name)
                || string.IsNullOrEmpty(@event.Venue)
                || string.IsNullOrEmpty(@event.Genre))
            {
                return BadRequest("Event missing valid Name, Venue, or Genre");
            }
            if (@event.AvailableTickets < 0 )
            {
                return BadRequest("Event was set with negative tickets available");
            }

            // 2.) Add the new appointment to the database / local-storage:
            _store.AddEvent( @event );

            // 3.) Return confirmation to client / Windows form:
            return Ok(new
            {
                message = $"Event: {@event.Id} | {@event.Name} ({@event.Genre}) booked at {@event.Venue}" +
                $" for {@event.Date} with {@event.AvailableTickets} Tickets Available."
            });
        }


        // GET /api/events

        // returns all upcoming events

        [HttpGet]

        public ActionResult<IEnumerable<Event>> GetAllEvents()

        {

            var events = _store.GetAllEvents();

            return Ok(events);

        }

    }

}
