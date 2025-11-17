using Microsoft.AspNetCore.Mvc;

namespace PlaylistAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Store users in-memory for simplicity
        public static readonly List<User> Users = new List<User>();

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateUser(User.UserCreationDto dto)
        {
            // Create new user
            var user = new User(dto.Id, dto.Username);
            // Add user to in-memory list
            Users.Add(user);
            // Return success response
            return Ok(new { message = $"User {user.Username} Created", user = user });
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok(Users);
        }
    }
}
