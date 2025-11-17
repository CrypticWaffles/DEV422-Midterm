using Microsoft.AspNetCore.Mvc;
using static PlaylistAPI.Playlist;
using static PlaylistAPI.Song;

namespace PlaylistAPI.Controllers
{
    /// <summary>
    /// PlaylistController to manage playlist-related operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController : ControllerBase
    {
        // Store playlists in-memory for simplicity
        private static readonly List<Playlist> Playlists = new List<Playlist>();
        // Store songs in-memory for simplicity
        private static readonly List<Song> Songs = new List<Song>();

        /// <summary>
        /// Create a new playlist
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreatePlaylist(PlaylistCreationDto dto)
        {
            if (UserController.Users.All(u => u.Id != dto.CreatedByUserId))
            {
                return NotFound("User not found");
            };

            // Create new playlist with the desired properties
            var playlist = new Playlist(dto.Name, dto.Id, dto.CreatedByUserId)
            {
                IsCollaborative = dto.IsCollaborative
            };

            // Add the playlist to the in-memory list
            Playlists.Add(playlist);

            // Return success response
            return Ok( new { message = $"Playlist {playlist.Name} Created", playlist = playlist });
        }

        /// <summary>
        /// List all playlists
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetPlaylists()
        {
            return Ok(Playlists);
        }

        /// <summary>
        /// Add a song to a playlist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="playlist"></param>
        /// <returns></returns>
        [HttpPut("{id}/add")]
        public ActionResult AddSongToPlaylist(Guid id, [FromBody] SongCreationDto songDto)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id);
            // If not found, return 404
            if (playlist == null)
            {
                return NotFound("Playlist not found");
            }

            // Create new song and add to the playlist
            var newSong = new Song(songDto.Id, songDto.Title, songDto.Artist, songDto.Genre, songDto.Duration);
            // Also add to global song list
            Songs.Add(newSong);

            // Add song to the playlist
            playlist.Songs.Add(newSong);

            // Return success response
            return Ok(new { message = $"Song {newSong.Title} added to {playlist.Name}", playlist = playlist });
        }

        /// <summary>
        /// Add a collaborator to a collaborative playlist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPut("{id}/invite")]
        public ActionResult InviteCollaborator(Guid id, [FromQuery] Guid userId)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id); 
            
            // If not found, return 404
            if (playlist == null)
            {
                 return NotFound("Playlist not found"); 
            
            }
            // Check if user exists
            if (UserController.Users.All(u => u.Id != userId))
            {
                 return NotFound("User not found"); 
            }

            // Add collaborator
            playlist.CollaboratorUserIds.Add(userId); 

            // Set playlist to collaborative
            playlist.IsCollaborative = true; 
            
            // Return success response
            return Ok(new { message = $"User {userId} invited to collaborate on {playlist.Name}", playlist = playlist });
        }

        /// <summary>
        /// Vote for a song in a playlist
        /// </summary>
        /// <param name="id"></param>
        /// <param name="songId"></param>
        /// <returns></returns>
        [HttpPost("{id}/vote")]
        public ActionResult VoteSongInPlaylist(Guid id, [FromQuery] Guid songId)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id);
            // If not found, return 404
            if (playlist == null)
            {
                return NotFound("Playlist not found");
            }
            // Find the song in the playlist
            var song = playlist.Songs.FirstOrDefault(s => s.Id == songId);
            // If not found, return 404
            if (song == null)
            {
                return NotFound("Song not found in the playlist");
            }
            // Upvote the song
            song.Upvote();
            // Return success response
            return Ok(new
            {
                message = $"Song {song.Title} upvoted in {playlist.Name}",
                song = song,
                playlist = playlist
            });
        }

        /// <summary>
        /// Get ranked songs in a playlist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/rankings")]
        public ActionResult GetSongRankings(Guid id)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id);

            // If not found, return 404
            if (playlist == null)
            {
                return NotFound("Playlist not found");
            }

            // Rank songs by votes
            var rankedSongs = playlist.Songs.OrderByDescending(s => s.Votes).ToList();

            // Return ranked songs
            return Ok(rankedSongs);
        }
    }
}
