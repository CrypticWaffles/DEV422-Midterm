using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VibeHive.Client
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public MainForm()
        {
            InitializeComponent();
            // URL/port Events API
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7113")
            };
        }



        // LOAD EVENTS 
      
        private async void btnLoadEvents_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _http.GetAsync("api/events");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var events = JsonSerializer.Deserialize<List<EventDto>>(json, _jsonOptions)
                             ?? new List<EventDto>();
                dgvEvents.DataSource = events;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load events:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        // BOOK TICKET 
     
        private async void btnBookTicket_Click(object sender, EventArgs e)

        {
            if (!int.TryParse(txtEventId.Text, out var eventId))
            {
                MessageBox.Show("Please enter a valid Event Id (number).");
                return;
            }
            if (!int.TryParse(txtUserId.Text, out var userId))
            {
                MessageBox.Show("Please enter a valid User Id (number).");
                return;
            }
            try
            {
                var body = new
                {
                    EventId = eventId,
                    UserId = userId
                };
                var jsonBody = JsonSerializer.Serialize(body);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                var response = await _http.PostAsync("api/tickets", content);
                if (!response.IsSuccessStatusCode)
                {
                    var errorText = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        $"Ticket booking failed:\n{response.StatusCode}\n{errorText}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                // success message
                lblBookingStatus.Text = "Ticket booked successfully!";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to book ticket:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        
        // LOAD MY TICKETS 
    
        private async void btnLoadTickets_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMyUserId.Text, out var userId))
            {
                MessageBox.Show("Please enter a valid User Id (number).");
                return;
            }
            await LoadTicketsInternalAsync(userId);
        }
        private async Task LoadTicketsInternalAsync(int userId)
        {
            try
            {
                var response = await _http.GetAsync($"api/tickets/{userId}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var tickets = JsonSerializer.Deserialize<List<TicketDto>>(json, _jsonOptions)
                              ?? new List<TicketDto>();
                BeginInvoke(new Action(() => { dgvTickets.DataSource = tickets; }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load tickets:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EventId textbox gets Id from selected row in upcoming events grid 

        private void dgvEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEvents.CurrentRow == null)
                return;
           
            if (dgvEvents.CurrentRow.DataBoundItem is EventDto ev)
            {
                txtEventId.Text = ev.Id.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}