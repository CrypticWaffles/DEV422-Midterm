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
        // Store users in-memory for simplicity
        private static readonly List<Guid> Users = new List<Guid>();

        /// <summary>
        /// Create a new playlist
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreatePlaylist(PlaylistCreationDto dto)
        {
            // Simulate user creation
            Guid userId = Guid.NewGuid();

            // Add user to in-memory list
            Users.Add(userId);

            // Create new playlist with the desired properties
            var playlist = new Playlist(dto.Name, userId)
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
        public IActionResult GetPlaylists()
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
        public IActionResult AddSongToPlaylist(Guid id, [FromBody] SongCreationDto songDto)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id);
            // If not found, return 404
            if (playlist == null)
            {
                return NotFound("Playlist not found");
            }

            // Create new song and add to the playlist
            var newSong = new Song(songDto.Title, songDto.Artist, songDto.Genre, songDto.Duration);
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
        public IActionResult InviteCollaborator(Guid id, Guid userId)
        {
            // Find the playlist
            var playlist = Playlists.FirstOrDefault(p => p.Id == id);
            // If not found, return 404
            if (playlist == null)
            {
                return NotFound("Playlist not found");
            }
            // Check if user exists
            if (!Users.Contains(userId))
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
        public IActionResult VoteSongInPlaylist(Guid id, Guid songId)
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
            return Ok(new { message = $"Song {song.Title} upvoted in {playlist.Name}", song = song });
        }

        /// <summary>
        /// Get ranked songs in a playlist
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/rankings")]
        public IActionResult GetSongRankings(Guid id)
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
