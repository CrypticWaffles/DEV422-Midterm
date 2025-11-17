using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistClient
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }


        public User(Guid id, string username)
        {
            Id = id;
            Username = username;
        }

        public override string ToString()
        {
            return $"Username: {Username}";
        }

        public class UserCreationDto
        {
            public Guid Id { get; set; }
            public string Username { get; set; }
        }
    }
}
