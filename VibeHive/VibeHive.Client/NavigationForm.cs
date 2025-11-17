using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace VibeHive.Client
{
    public partial class NavigationForm : Form
    {
        private readonly HttpClient _http;

        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public NavigationForm()
        {
            InitializeComponent();

            // URL/port Events API
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7113")
            };
        }

        // ============ Navigation Methods ===============

        /*
         * Open Ticket Booking form ( MainForm.cs ):
         * Opens the MainForm / Ticket Booking page when "Book Tickets" is clicked
         * The navigation form is hidden afterwards.
         */
        private async void Mod3BookTicketBtn_Click(object sender, EventArgs e)
        {
            // Generate an instance of the MainForm / TicketForm: 
            MainForm ticketForm = new MainForm();
            ticketForm.Show();

            // Hide the Navigation form:
            this.Hide();
        }

        /*
         * Open User Registration form ( RegisterForm.cs ):
         * Opens the registration and login page when "Register Account / Login" is clicked
         * The navigation form is hidden afterwards.
         */
        private void Mod3RegUserBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            // Hide the Navigation form:
            this.Hide();
        }

        /*
         * Open Event Adding form ( EventForm.cs ):
         * Opends the event-adding form.
         */
        private void Mod3AddEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Show();

            // Hide navigation form:
            this.Hide();
        }
    }
}
