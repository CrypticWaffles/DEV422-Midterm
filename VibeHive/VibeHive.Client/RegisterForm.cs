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

namespace VibeHive.Client
{
    public partial class RegisterForm : Form
    {
        private readonly HttpClient _http;

        private readonly JsonSerializerOptions _jsonOptions =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public RegisterForm()
        {
            InitializeComponent();

            // URL/port Events API
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7113")
            };
        }

        /*
         * Return to the main navigation form
         */
        private void NavReturnBtn_Click(object sender, EventArgs e)
        {
            // Switch to navigation form:
            NavigationForm navForm = new NavigationForm();
            navForm.Show();

            // Hide the Navigation form:
            this.Hide();
        }

        /*
         * Register new user:
         * Parse register form for user name, email, password, and role
         * Add a new user to the system with this information
         */
        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            // 1.) Check for valid inputs:
            if (string.IsNullOrEmpty(RegNameInput.Text))
            {
                MessageBox.Show("Please enter a valid Username (string).");
                return;
            }
            if (string.IsNullOrEmpty(RegEmailInput.Text))
            {
                MessageBox.Show("Please enter a valid Email (string).");
                return;
            }
            if (string.IsNullOrEmpty(RegPasswordInput.Text))
            {
                MessageBox.Show("Please enter a valid Password (string).");
                return;
            }
            if (string.IsNullOrEmpty(RegRoleInput.Text))
            {
                MessageBox.Show("Please select a Role (string).");
                return;
            }

            // 2.) Register a new user from the registration form data:
            try
            {
                // Get text inputs / create user:
                var newUser = new
                {
                    Name = RegNameInput.Text,
                    Email = RegEmailInput.Text,
                    Password = RegPasswordInput.Text,
                    Role = RegRoleInput.Text
                };

                // Serialize user:
                var jsonUser = JsonSerializer.Serialize(newUser);
                // Encode serialized user:
                var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                // Send user data to API:
                var response = await _http.PostAsync("api/auth/register", content);

                if (!response.IsSuccessStatusCode)
                {
                    // Failed registration:
                    var failure = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        $"User registration failed:{response.StatusCode}\n{failure}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                // 3.) If user was registered successfully: Notify the user in the GUI:
                MessageBox.Show($"User Registered successfully:\n" +
                    $"User: {newUser.Name}\n" +
                    $"Email: {newUser.Email}\n" +
                    $"Role: {newUser.Role}", "Success");
                return;

            } // 4.) Catch registration failures:
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register user:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /*
         * Login existing User:
         * take the information entered in the login form and verify it,
         * then return a token to the session storage of the application
         * Session storage will probably just be a static variable?
         */
        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            // 1.) Check for valid inputs:
            if (string.IsNullOrEmpty(LoginNameInput.Text))
            {
                MessageBox.Show("Please enter a valid Username (string).");
                return;
            }
            if (string.IsNullOrEmpty(LoginPassInput.Text))
            {
                MessageBox.Show("Please enter a valid Password (string).");
                return;
            }

            // 2.) Register a new user from the registration form data:
            try
            {
                // Get text inputs / create user login:
                var loginUser = new
                {
                    Name = LoginNameInput.Text,
                    Password = LoginPassInput.Text
                };

                // Serialize user:
                var jsonUser = JsonSerializer.Serialize(loginUser);
                // Encode serialized user:
                var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
                // Send user data to API:
                var response = await _http.PostAsync("api/auth/login", content);

                if (!response.IsSuccessStatusCode)
                {
                    // Failed registration:
                    var failure = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        $"User login failed:{response.StatusCode}\n{failure}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                // 3.) If user was logged in successfully: Notify the user in the GUI:
                Program.userToken = await response.Content.ReadAsStringAsync(); // <------ Store this properly.

                MessageBox.Show($"User Logged in successfully:\n" +
                    $"User: {loginUser.Name}\n" +
                    $"Token: { Program.userToken }", "Success");
                return;

            } // 4.) Catch registration failures:
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to login user:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
