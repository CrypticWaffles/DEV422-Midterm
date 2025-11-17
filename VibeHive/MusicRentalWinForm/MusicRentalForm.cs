using MusicRentalClient.Models;
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

namespace MusicRentalClient
{
    public partial class MusicRentalForm : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        // -----------------------------------------------------------------------------
        // Method: Clear List Box
        // -----------------------------------------------------------------------------
        private void clearListBox()
        {
            listBox_MusicRental.Items.Clear();
            listBox_MusicRental.Font = new Font("Consolas", 10);
        }

        // -----------------------------------------------------------------------------
        // Function: Initialize Music Rental Form
        // -----------------------------------------------------------------------------
        public MusicRentalForm()
        {
            InitializeComponent();

            /// initially disable buttons
            button_AddAlbum.Enabled = false;
            button_RentAlbum.Enabled = false;
            button_ReturnAlbum.Enabled = false;

            /// text box validation listeners
            txtAdd_Title.TextChanged += ValidateAddInputs;
            txtAdd_Artist.TextChanged += ValidateAddInputs;
            txtAdd_Genre.TextChanged += ValidateAddInputs;
            txtAdd_Year.TextChanged += ValidateAddInputs;

            txtRent_UserID.TextChanged += ValidateRentInputs;
            txtRent_AlbumID.TextChanged += ValidateRentInputs;

            txtReturn_RentalID.TextChanged += ValidateReturnInputs;

            /// welcome text
            listBox_MusicRental.Font = new Font("Consolas", 10);
            listBox_MusicRental.Items.Add(new string('-', 85));
            listBox_MusicRental.Items.Add("WELCOME TO MUSIC RENTAL SYSTEM");
            listBox_MusicRental.Items.Add(new string('-', 85));
        }
        // -----------------------------------------------------------------------------
        // Method: Validate Add Inputs
        // -----------------------------------------------------------------------------
        private void ValidateAddInputs(object sender, EventArgs e)
        {
            /// checks if year is a valid number
            bool validYear = int.TryParse(txtAdd_Year.Text, out _);

            /// enable add button if all fields contain valid input
            button_AddAlbum.Enabled =
                !string.IsNullOrWhiteSpace(txtAdd_Title.Text) &&
                !string.IsNullOrWhiteSpace(txtAdd_Artist.Text) &&
                !string.IsNullOrWhiteSpace(txtAdd_Genre.Text) &&
                validYear;
        }

        // -----------------------------------------------------------------------------
        // Method: Validate Rent Inputs
        // -----------------------------------------------------------------------------
        private void ValidateRentInputs(object sender, EventArgs e)
        {
            /// checks if userId is a positive number
            bool validUser = int.TryParse(txtRent_UserID.Text, out _);

            /// checks if albumId is a positive number
            bool validAlbum = int.TryParse(txtRent_AlbumID.Text, out _);

            /// enable rent button if all fields are valid
            button_RentAlbum.Enabled = validUser && validAlbum;
        }

        // -----------------------------------------------------------------------------
        // Method: Validate Return Inputs
        // -----------------------------------------------------------------------------
        private void ValidateReturnInputs(object sender, EventArgs e)
        {
            /// checks if return id is valid before enabling button
            button_ReturnAlbum.Enabled = int.TryParse(txtReturn_RentalID.Text, out _);
        }

        // -----------------------------------------------------------------------------
        // Function: List Albums
        // -----------------------------------------------------------------------------
        private async void button_ListAlbums_Click(object sender, EventArgs e)
        {
            /// clear listbox
            clearListBox();

            /// send GET request to api
            HttpResponseMessage message = await _httpClient.GetAsync("https://localhost:7159/api/music");

            /// show api error message
            if (!message.IsSuccessStatusCode)
            {
                MessageBox.Show(await message.Content.ReadAsStringAsync(), "API Error");
                return;
            }

            /// convert to json
            string jsonData = await message.Content.ReadAsStringAsync();
            var albums = JsonConvert.DeserializeObject<List<Music>>(jsonData);

            /// table header
            listBox_MusicRental.Items.Add("ALBUM LIST");
            listBox_MusicRental.Items.Add(new string('-', 85));
            listBox_MusicRental.Items.Add(
                string.Format("{0,-5} {1,-25} {2,-25} {3,-15} {4,-10}",
                "ID", "Title", "Artist", "Genre", "Avaliable"));
            listBox_MusicRental.Items.Add(new string('-', 85));

            /// display each avaliable album in list
            foreach (var a in albums)
            {
                listBox_MusicRental.Items.Add(
                    string.Format("{0,-5} {1,-25} {2,-25} {3,-15} {4,-10}",
                    a.Id, a.Title, a.Artist, a.Genre, a.Available ? "Yes" : "No"));
            }
        }

        // -----------------------------------------------------------------------------
        // Function: Add Album
        // -----------------------------------------------------------------------------
        private async void button_AddAlbum_Click(object sender, EventArgs e)
        {
            /// create album object
            var album = new
            {
                Title = txtAdd_Title.Text,
                Artist = txtAdd_Artist.Text,
                Genre = txtAdd_Genre.Text,
                Year = int.Parse(txtAdd_Year.Text),
                Available = true
            };

            /// convert to json 
            string json = JsonConvert.SerializeObject(album);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /// send POST request to api
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7159/api/music", content);

            /// show api error message
            if (!message.IsSuccessStatusCode)
            {
                string error = await message.Content.ReadAsStringAsync();
                MessageBox.Show(error, "API Error");
                return;
            }

            /// success feedback
            MessageBox.Show("Album added!");

            /// clear input fields
            txtAdd_Title.Clear();
            txtAdd_Artist.Clear();
            txtAdd_Genre.Clear();
            txtAdd_Year.Clear();

            /// refresh album list
            button_ListAlbums_Click(sender, e);
        }

        // -----------------------------------------------------------------------------
        // Function: List Active Rentals
        // -----------------------------------------------------------------------------
        private async void button_ListRentals_Click(object sender, EventArgs e)
        {
            /// clear listbox
            clearListBox();

            /// send GET request to api
            HttpResponseMessage rentalMessage = await _httpClient.GetAsync("https://localhost:7159/api/rental");

            /// show api error message
            if (!rentalMessage.IsSuccessStatusCode)
            {
                MessageBox.Show(await rentalMessage.Content.ReadAsStringAsync(), "API Error");
                return;
            }

            /// deserialize rental results
            var rentals = JsonConvert.DeserializeObject<List<Rental>>(await rentalMessage.Content.ReadAsStringAsync());

            /// send GET request to api
            HttpResponseMessage albumMessage = await _httpClient.GetAsync("https://localhost:7159/api/music");

            /// show api error message
            if (!albumMessage.IsSuccessStatusCode)
            {
                MessageBox.Show(await albumMessage.Content.ReadAsStringAsync(), "API Error");
                return;
            }

            /// convert to json
            var albums = JsonConvert.DeserializeObject<List<Music>>(
                await albumMessage.Content.ReadAsStringAsync());

            /// table header
            listBox_MusicRental.Items.Add("ACTIVE RENTALS");
            listBox_MusicRental.Items.Add(new string('-', 100));
            listBox_MusicRental.Items.Add(
                string.Format("{0,-6} {1,-8} {2,-22} {3,-15} {4,-20}",
                "ID", "UserID", "Album Title", "Genre", "Rented"));
            listBox_MusicRental.Items.Add(new string('-', 100));

            /// display each rental with album details
            foreach (var r in rentals)
            {
                var album = albums.FirstOrDefault(a => a.Id == r.AlbumID);

                string title = album?.Title ?? "Unknown";
                string genre = album?.Genre ?? "Unknown";

                listBox_MusicRental.Items.Add(
                    string.Format("{0,-6} {1,-8} {2,-22} {3,-15} {4,-20}",
                    r.Id, r.UserID, title, genre,
                    r.RentalDate.ToString("MM/dd/yyyy HH:mm")));
            }
        }

        // -----------------------------------------------------------------------------
        // Function: Rent Album
        // -----------------------------------------------------------------------------
        private async void button_RentAlbum_Click(object sender, EventArgs e)
        {

            /// create rental request object
            var rentRequest = new
            {
                UserID = int.Parse(txtRent_UserID.Text),
                AlbumID = int.Parse(txtRent_AlbumID.Text)
            };

            /// convert to json
            string json = JsonConvert.SerializeObject(rentRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /// send POST request to api
            HttpResponseMessage message = await _httpClient.PostAsync("https://localhost:7159/api/rental", content);

            /// show error if album id not found
            if (!message.IsSuccessStatusCode)
            {
                string error = await message.Content.ReadAsStringAsync();
                MessageBox.Show(error, "API Error");
                return;
            }

            /// success feedback
            MessageBox.Show("Album rented!");

            /// clear inputs
            txtRent_UserID.Clear();
            txtRent_AlbumID.Clear();

            /// refresh active rentals list
            button_ListRentals_Click(sender, e);
        }

        // -----------------------------------------------------------------------------
        // Function: Return Album
        // -----------------------------------------------------------------------------
        private async void button_ReturnAlbum_Click(object sender, EventArgs e)
        {
            /// parse the rentalId
            int rentalID = int.Parse(txtReturn_RentalID.Text);

            /// send POST request to api
            HttpResponseMessage message = await _httpClient.PostAsync($"https://localhost:7159/api/rental/{rentalID}/return", null);

            /// show error if rental id not found
            if (!message.IsSuccessStatusCode)
            {
                string error = await message.Content.ReadAsStringAsync();
                MessageBox.Show(error, "API Error");
                return;
            }

            /// success feedback
            MessageBox.Show("Album returned!");

            /// clear input field
            txtReturn_RentalID.Clear();

            /// refresh active rentals list
            button_ListRentals_Click(sender, e);
        }
       
    }
}
