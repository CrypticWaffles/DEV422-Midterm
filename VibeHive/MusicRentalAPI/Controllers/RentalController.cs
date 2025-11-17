using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;
using MusicRentalAPI.Controllers;

namespace MusicRentalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        // Create a list of album rentals
        private static List<Rental> RentalList = new List<Rental>();

        // Create random number 
        private static readonly Random rnd = new Random();

        // -----------------------------------------------------------------------------
        // Function: POST /api/rentals: Rent an album by providing user ID and album ID
        // -----------------------------------------------------------------------------
        [HttpPost]
        public ActionResult<Rental> RentAlbum(Rental request)
        {

            /// validate userid input is positive
            if (request.UserID <= 0)
                return BadRequest("UserID must be a positive number.");

            /// validate albumid input is positive
            if (request.AlbumID <= 0)
                return BadRequest("AlbumID must be a positive number.");

            /// checks for album with given id
            var album = MusicController.AlbumList
                .FirstOrDefault(a => a.Id == request.AlbumID);

            /// check if album id exists
            if (album == null)
                return NotFound($"Album with ID {request.AlbumID} does not exist.");

            /// checks if album is available
            if (!album.Available)
                return Conflict($"Album {album.Id} is already rented.");

            /// Create rental
            var rental = new Rental
            {
                Id = GenerateRentalId(),
                UserID = request.UserID,
                AlbumID = request.AlbumID,
                RentalDate = DateTime.Now,
                ReturnDate = null
            };

            /// mark  rented album as unavailable
            album.Available = false;

            /// add rental to rental list
            RentalList.Add(rental);

            /// return created message
            return Created($"/api/rental/{rental.Id}", rental);
        }

        // -----------------------------------------------------------------------------
        // Function: POST /api/rentals/{id}/return: Return a rented album
        // -----------------------------------------------------------------------------
        [HttpPost("{id}/return")]
        public ActionResult ReturnAlbum(int id)
        {
            var rental = RentalList.FirstOrDefault(r => r.Id == id);

            /// checks if theres an rental with given id
            if (rental == null)
                return NotFound($"Rental with ID {id} does not exist.");

            /// checks rental was already returned
            if (rental.ReturnDate != null)
                return Conflict("This rental has already been returned.");

            /// set return date
            rental.ReturnDate = DateTime.Now;

            /// marks album as avaliable
            var album = MusicController.AlbumList.FirstOrDefault(a => a.Id == rental.AlbumID);
            if (album != null)
                album.Available = true;

            /// return successful message
            return Ok($"Rental {id} returned successfully.");
        }

        // -----------------------------------------------------------------------------
        // Function: GET /api/rentals: List all active rentals
        // -----------------------------------------------------------------------------
        [HttpGet]
        public ActionResult<List<Rental>> GetActiveRentals()
        {
            var active = RentalList.Where(r => r.ReturnDate == null).ToList();

            /// returns list of active rentals
            return Ok(active);
        }

        // -----------------------------------------------------------------------------
        // Method: Generate Random Id
        // -----------------------------------------------------------------------------
        private int GenerateRentalId()
        {
            int id;

            /// Generates 100–999
            do { id = rnd.Next(1000, 9999);}
            while (RentalList.Any(r => r.Id == id));

            return id;
        }
    }
}
