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
            Guid newId = Guid.NewGuid();

            // Create new playlist object from input field
            var playlistName = txt_playlistTitle.Text;
            var newPlaylist = new Playlist.PlaylistCreationDto
            {
                Id = newId,
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

            Guid id = selectedPlaylist.Id; // Reliable ID retrieval

            // Check if the GUID is valid before proceeding
            if (id == Guid.Empty)
            {
                MessageBox.Show("Selected playlist has an invalid ID.", "Error");
                return;
            }

            // Create new song object from input fields
            var newSong = new Song.SongCreationDto
            {
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
    }
}
