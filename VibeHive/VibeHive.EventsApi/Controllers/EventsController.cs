using Microsoft.AspNetCore.Mvc;

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
