using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;
using System.Reflection;

namespace MusicRentalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : Controller
    {
        // Create a list of music albums
        public static List<Music> AlbumList = new List<Music>();

        // Create random number 
        private static readonly Random rnd = new Random();

        // -----------------------------------------------------------------------------
        // Function: POST /api/music: Add a new music album 
        // -----------------------------------------------------------------------------
        [HttpPost]
        public ActionResult<Music> AddAlbum(Music music)
        {
            /// validate required fields
            if (string.IsNullOrWhiteSpace(music.Title))
                return BadRequest("Title is required.");

            if (string.IsNullOrWhiteSpace(music.Artist))
                return BadRequest("Artist is required.");

            if (string.IsNullOrWhiteSpace(music.Genre))
                return BadRequest("Genre is required.");

            if (music.Year < 1900 || music.Year > DateTime.Now.Year)
                return BadRequest("Year must be valid.");

            /// generation id
            music.Id = GenerateId();
            music.Available = true;

            /// add album
            AlbumList.Add(music);

            /// return created message
            return Created($"/api/music/{music.Id}", music);
        }

        // -----------------------------------------------------------------------------
        // Function: GET /api/music: List all available music albums
        // -----------------------------------------------------------------------------
        [HttpGet]
        public ActionResult<List<Music>> ListAvailableAlbums()
        {
            /// returns list of albums
            return Ok(AlbumList);
        }

        // -----------------------------------------------------------------------------
        // Function: DELETE /api/music/{id}: Delete a music album by its ID 
        // -----------------------------------------------------------------------------
        [HttpDelete("{id}")]
        public ActionResult DeleteAlbum(int id)
        {
            var album = AlbumList.FirstOrDefault(a => a.Id == id);

            /// checks if theres an album with given id
            if (album == null)
                return NotFound($"Album with ID {id} does not exist.");

            /// cannot delete album if currently rented
            if (!album.Available)
                return Conflict("Cannot delete an album that is currently rented.");

            /// remove album from album list
            AlbumList.Remove(album);

            /// return album deleted message
            return Ok($"Album {id} deleted.");
        }

        // -----------------------------------------------------------------------------
        // Method: Generate Random Id
        // -----------------------------------------------------------------------------
        private int GenerateId()
        {
            int id;

            /// Generates 100–999
            do { id = rnd.Next(100, 1000);}
            /// Check duplicates
            while (AlbumList.Any(a => a.Id == id)); 

            return id;
        }
    }
}