using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistClient
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a new playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_createPlaylist_Click(object sender, EventArgs e)
        {
            User currentUser = cbx_currentUser.SelectedItem as User;
            if (currentUser == null)
            {
                MessageBox.Show("Please select a user before creating a playlist.", "User Selection Required");
                return;
            }

            Guid newId = Guid.NewGuid();

            // Create new playlist object from input field
            var playlistName = txt_playlistTitle.Text;
            var newPlaylist = new Playlist.PlaylistCreationDto
            {
                Id = newId,
                CreatedByUserId = currentUser.Id,
                Name = playlistName,
                IsCollaborative = false
            };

            // Serialize to JSON
            var json = JsonConvert.SerializeObject(newPlaylist);

            // Create StringContent for HTTP request
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send POST request to create playlist
            HttpResponseMessage message = await httpClient.PostAsync("https://localhost:7023/api/Playlist", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show($"Playlist: {playlistName} created successfully.");
                btn_listPlaylists_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed to create playlist.");
            }
        }

        /// <summary>
        /// List all playlists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_listPlaylists_Click(object sender, EventArgs e)
        {
            // Clear list box
            lbx_playlists.Items.Clear();

            HttpResponseMessage message = await httpClient.GetAsync("https://localhost:7023/api/Playlist");

            if (message.IsSuccessStatusCode)
            {
                // Read JSON response
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize to list of Playlist objects
                var playlists = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);

                // Populate list box
                foreach (var playlist in playlists)
                {
                    lbx_playlists.Items.Add(playlist);
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve playlists.", "Error");
            }
        }

        /// <summary>
        /// Add a song to the selected playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_addSong_Click(object sender, EventArgs e)
        {
            // Get selected playlist ID directly
            Playlist selectedPlaylist = lbx_playlists.SelectedItem as Playlist;

            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist from the list.", "Selection Error");
                return;
            }

            Guid id = selectedPlaylist.Id;

            // Check if the GUID is valid before proceeding
            if (id == Guid.Empty)
            {
                MessageBox.Show("Selected playlist has an invalid ID.", "Error");
                return;
            }

            // Create new song object from input fields
            var newSong = new Song.SongCreationDto
            {
                Id = Guid.NewGuid(),
                Title = txt_songTitle.Text,
                Artist = txt_songArtist.Text,
                Genre = txt_songGenre.Text,
                Duration = TimeSpan.Parse(txt_songDuration.Text)
            };

            // Serialize to JSON
            var json = JsonConvert.SerializeObject(newSong);

            // Create StringContent for HTTP request
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send PUT request to add song
            HttpResponseMessage message = await httpClient.PutAsync($"https://localhost:7023/api/Playlist/{id}/add", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show($"Song: {newSong.Title} added successfully.");
                btn_listPlaylists_Click(sender, e); 
            }
            else
            {
                // 1. Get the HTTP Status Code (e.g., 404, 400)
                string statusCode = message.StatusCode.ToString();

                // 2. Read the error body/message from the server
                string errorContent = await message.Content.ReadAsStringAsync();

                // 3. Display detailed error information
                MessageBox.Show(
                    $"Failed to add song. Status Code: {statusCode}\n" +
                    $"Server Response: {errorContent}",
                    "Error Adding Song"
                );
            }
        }


        /// <summary>
        /// Method to get song rankings for the selected playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_getRankings_Click(object sender, EventArgs e)
        {
            // Get the Playlist ID (using your robust selection logic)
            Playlist selectedPlaylist = lbx_playlists.SelectedItem as Playlist;

            if (selectedPlaylist == null)
            {
                MessageBox.Show("You need to select a playlist to view its rankings.", "Selection Required");
                return;
            }
            Guid id = selectedPlaylist.Id;

            // Send GET request to the rankings endpoint
            HttpResponseMessage message = await httpClient.GetAsync($"https://localhost:7023/api/Playlist/{id}/rankings");

            if (message.IsSuccessStatusCode)
            {
                string jsonString = await message.Content.ReadAsStringAsync();
                var rankedSongs = JsonConvert.DeserializeObject<List<Song>>(jsonString);

                lbx_songRankings.Items.Clear();

                if (rankedSongs.Count == 0)
                {
                    lbx_songRankings.Items.Add("No songs in this playlist yet.");
                }
                else
                {
                    // Populate the ListBox with the actual Song objects
                    for (int i = 0; i < rankedSongs.Count; i++)
                    {
                        var song = rankedSongs[i];

                        // Store the full Song object
                        lbx_songRankings.Items.Add(song);
                    }
                }
            }
            else
            {
                // Handle error 
                string errorContent = await message.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to get rankings. Status: {message.StatusCode}. Response: {errorContent}", "Error");
            }
        }

        /// <summary>
        /// Vote for the selected song in the rankings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_voteSong_Click(object sender, EventArgs e)
        {
            // Get the selected Playlist ID
            Guid playlistId = (lbx_playlists.SelectedItem as Playlist)?.Id ?? Guid.Empty;

            Playlist selectedPlaylist = lbx_playlists.SelectedItem as Playlist;
            if (playlistId == Guid.Empty || selectedPlaylist == null) {
                MessageBox.Show("Please select a playlist from the list.", "Selection Error");
                return;
            }

            int playlistIndex = lbx_playlists.SelectedIndex;

            // Get the selected Song
            Song selectedSong = lbx_songRankings.SelectedItem as Song;

            if (selectedSong == null)
            {
                MessageBox.Show("Please select a song from the rankings list to vote.", "Selection Required");
                return;
            }

            // Extract the ID
            Guid songId = selectedSong.Id;

            // Construct URL with query parameter
            string url = $"https://localhost:7023/api/Playlist/{playlistId}/vote?songId={songId}";

            // Send POST request (with empty content, as the data is in the query string)
            HttpResponseMessage message = await httpClient.PostAsync(url, null);

            // Handle response
            if (message.IsSuccessStatusCode)
            {
                // Read the successful response body
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize into a dynamic/anonymous object to access the returned objects
                var result = JsonConvert.DeserializeObject<dynamic>(jsonString);

                // Deserialize the updated playlist object from the response
                string updatedPlaylistJson = result.playlist.ToString();
                var updatedPlaylist = JsonConvert.DeserializeObject<Playlist>(updatedPlaylistJson);

                // Update the ListBox with the new Playlist object
                if (playlistIndex != -1)
                {
                    lbx_playlists.Items[playlistIndex] = updatedPlaylist;
                }

                MessageBox.Show($"Successfully voted for song: {selectedSong.Title}");
        
                // 4. Refresh the song rankings list
                btn_getRankings_Click(sender, e);
            }
            else
            {
                string errorContent = await message.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to vote for song. Status: {message.StatusCode}. Response: {errorContent}", "Error");
            }
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_createUser_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            if (string.IsNullOrWhiteSpace(username)) return;

            // Generate the GUID
            Guid newId = Guid.NewGuid();

            var newUserDto = new User.UserCreationDto
            {
                Id = newId,
                Username = username
            };

            var json = JsonConvert.SerializeObject(newUserDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage message = await httpClient.PostAsync("https://localhost:7023/api/User", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show($"User: {username} created successfully.");
                // After creation, refresh the user selection list
                await LoadUsersToComboBox();
            }
            else
            {
                MessageBox.Show("Failed to create playlist.");
            }
        }

        // Helper method to load users into the ComboBox
        private async Task LoadUsersToComboBox()
        {
            cbx_currentUser.Items.Clear();

            HttpResponseMessage message = await httpClient.GetAsync("https://localhost:7023/api/User");

            if (message.IsSuccessStatusCode)
            {
                string jsonString = await message.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(jsonString);

                // Populate the ComboBox with User objects (using User.ToString() for display)
                foreach (var user in users)
                {
                    cbx_currentUser.Items.Add(user);
                }

                if (cbx_currentUser.Items.Count > 0)
                {
                    // Auto-select the first user or the newly created one
                    cbx_currentUser.SelectedIndex = 0;
                }
            }
        }

        private async void btn_invite_Click(object sender, EventArgs e)
        {
            User selectedUser = lbx_users.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to invite.", "Selection Required");
                return;
            }

            Playlist selectedPlaylist = lbx_playlists.SelectedItem as Playlist;
            if (selectedPlaylist == null)
            {
                MessageBox.Show("Please select a playlist to invite the user to.", "Selection Required");
                return;
            }

            Guid userId = selectedUser.Id;
            Guid playlistId = selectedPlaylist.Id;
            
            HttpResponseMessage message = await httpClient.PutAsync($"https://localhost:7023/api/Playlist/{playlistId}/invite?userId={userId}", null);

            // Handle response
            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show($"User: {selectedUser.Username} invited successfully to playlist: {selectedPlaylist.Name}.");
            }
            else
            {
                string errorContent = await message.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to invite user. Status: {message.StatusCode}. Response: {errorContent}", "Error");
            }
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_getUsers_Click(object sender, EventArgs e)
        {
            // Clear list box
            lbx_users.Items.Clear();

            HttpResponseMessage message = await httpClient.GetAsync("https://localhost:7023/api/User");

            if (message.IsSuccessStatusCode)
            {
                // Read JSON response
                string jsonString = await message.Content.ReadAsStringAsync();

                // Deserialize to list of Playlist objects
                var users = JsonConvert.DeserializeObject<List<User>>(jsonString);

                // Populate list box
                foreach (var user in users)
                {
                    lbx_users.Items.Add(user);
                }
            }
            else
            {
                MessageBox.Show("Failed to retrieve Users.", "Error");
            }
        }
    }
}
