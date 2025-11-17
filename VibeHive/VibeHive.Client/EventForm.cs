using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VibeHive.Client
{
    public partial class EventForm : Form
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public EventForm()
        {
            InitializeComponent();
            // URL/port Events API
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7113")
            };
        }

        /*
         * Add new music event:
         * Takes information entered into EventForm and adds new event to API:
         */
        private async void AddEventBtn_Click(object sender, EventArgs e)
        {
            // 1.) Check for valid inputs:
            if (string.IsNullOrEmpty(EventName.Text))
            {
                MessageBox.Show("Please enter a valid event name (string).");
                return;
            }
            if (string.IsNullOrEmpty(EventGenre.Text))
            {
                MessageBox.Show("Please enter a valid event genre(s) (string).");
                return;
            }
            if (string.IsNullOrEmpty(EventVenue.Text))
            {
                MessageBox.Show("Please enter a valid event venue (string).");
                return;
            }
            if (EventTicketsNum.Value < 0)
            {
                MessageBox.Show("Please enter a valid ticket availability (number).");
                return;
            }
            if (EventDate.Value <= DateTime.UtcNow)
            {
                MessageBox.Show("Please enter a valid future date (dateTime).");
                return;
            }

            // 2.) Add new event from the event form data:
            try
            {
                // Get text inputs / create event:
                var newEvent = new
                {
                    Name = EventName.Text,
                    Date = EventDate.Value,
                    Venue = EventVenue.Text,
                    Genre = EventGenre.Text,
                    AvailableTickets = EventTicketsNum.Value
                };

                // Serialize event:
                var jsonEvent = JsonSerializer.Serialize(newEvent);
                // Encode serialized event:
                var content = new StringContent(jsonEvent, Encoding.UTF8, "application/json");

                // 2.5) BEFORE you send a http request, add the token for authorization:
                // Define new client header to add bearer token in:
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Program.userToken);

                // Send event data to API:
                var response = await _http.PostAsync("api/events", content);

                if (!response.IsSuccessStatusCode)
                {
                    // Failed addition:
                    var failure = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        $"Event addition failed:{response.StatusCode}\n{failure}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                // 3.) If the event was added successfully: Notify the user in the GUI:
                MessageBox.Show($"Event added successfully:\n" +
                    $"Name: {newEvent.Name}\n" +
                    $"Genre: {newEvent.Genre}\n" +
                    $"Date: {newEvent.Date}\n" +
                    $"Venue: {newEvent.Venue}\n" +
                    $"Available Tickets: {newEvent.AvailableTickets}", "Success");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add event:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /*
         * Return to navigationForm:
         */
        private void NavReturnBtn_Click(object sender, EventArgs e)
        {
            // Switch to navigation form:
            NavigationForm navForm = new NavigationForm();
            navForm.Show();

            // Hide the Navigation form:
            this.Hide();
        }
    }
}
