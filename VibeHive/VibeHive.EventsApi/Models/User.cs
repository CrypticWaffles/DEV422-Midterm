namespace VibeHive.EventsApi.Models
{
    /*
     * Defines basic user profiles for API:
     */
    public class User
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
