using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
         * Creates a token that the user will use to unlock endpoint access when returned.
         */
        [HttpPost]
        public IActionResult Login(UserLogin userLogin)
        {
            // 1.) Locate the user in the database / local-storage:
            var user = _users.FirstOrDefault(u => u.Name == userLogin.Name);

            // 2.) Check if the user exists in the db and their password matches:
            if (user == null || !VerifyPassword(userLogin.Password, user.Password))
            {
                // No user found / passwords do not match:
                return Unauthorized("No existing user found / invalid password");
            }

            // 3.) Generate a new JWT token handler to make tokens in:
            var tokenHandler = new JwtSecurityTokenHandler();

            // 4.) Convert our _secretKey, initialized from the app settings, to bytes:
            var key = Encoding.ASCII.GetBytes(_secretKey);

            // 5.) Configure new token generated to store user information:
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    // Add standard claims:
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role),
                }),
                // Set expiration time for 1 hour from generation:
                Expires = DateTime.UtcNow.AddHours(1),
                // Set signing credentials:
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
            };

            // 6.) Create configured token:
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // 7.) Convert token to string:
            var tokenString = tokenHandler.WriteToken(token);

            // 8.) Return token to the user: ( Will need to be changed to handle session management? ) 
            return Ok(new { message = tokenString });
        }

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

        /*
         * Verify user password:
         */
        private bool VerifyPassword(string password, string hashedPassword)
        {
            // Hash the user-inputed password:
            var hashedInput = HashUserPassword(password);

            // Compare now-hashed user input to hashed password stored in user account:
            return hashedInput == hashedPassword;
        }

    }
}
