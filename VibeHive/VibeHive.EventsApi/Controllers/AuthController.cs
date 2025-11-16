using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace VibeHive.EventsApi.Controllers
{
    /*
     * Controller endpoint used to register and authorize user accounts:
     */

    // Setup route template for this controller:
    [Route("api/[controller]")]

    // Indicate that this controller is an API controller:
    [ApiController]

    public class AuthController : ControllerBase
    {
        // Store the JWT key:
        private readonly string _secretKey;

        // Access local-storage database of users: ( Should probably be moved to a service )
        private static readonly List<User> _users = new List<User>();

        // Initialize the AuthController object with the secret key:
        public AuthController(IConfiguration configuration)
        {
            // Secret key is set to the key defined in the appsettings.json
            _secretKey = configuration["Jwt:SecretKey"];
        }

        // ========== Controller Methods / Interactions: ===========

        /*
         * Register new user:
         */
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // 1.) Check for valid username and password:
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password))
            {
                // If the username or password is missing return an error:
                return BadRequest("Username and password required for registration");
            }
            if (_users.Any(u => u.Name == user.Name))
            {
                // If any current existing username is the same as the newly rentered one, return error:
                return BadRequest("Entered username is already in use: Please choose new username");
            }

            // 2.) Encrypt user password for security:
            user.Password = HashUserPassword(user.Password);

            // 3.) Register new user with the database / local-storage:
            _users.Add(user);

            return Ok(new { Message = "Registered user successfully!" });
        }

        /*
         * Login current user:
         */

        // ----------- Helper functions -------------

        /*
         * Encrypt user password:
         */
        private string HashUserPassword(string password)
        {
            // Generate encryptor instance:
            using(var sha256 = SHA256.Create())
            {
                // Convert user password to bytes, then compute with encryptor:
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Convert hashed bytes to a base64 string:
                return Convert.ToBase64String(hashedBytes);
            }
        }

    }
}
