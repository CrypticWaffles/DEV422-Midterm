namespace PlaylistAPI
{
    /// <summary>
    /// Playlist class representing a playlist entity
    /// </summary>
    public class Playlist
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public List<Song> Songs { get; private set; } = new List<Song>();
        public Guid CreatedByUserId { get; private set; }
        public bool IsCollaborative { get; set; }
        public List<Guid> CollaboratorUserIds { get; private set; } = new List<Guid>();

        /// <summary>
        /// Main constructor for Playlist class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="isCollaborative"></param>
        public Playlist(string name, Guid id, Guid createdByUserId)
        {
            Id = id;
            Name = name;
            CreatedByUserId = createdByUserId;
            IsCollaborative = false;
        }

        // Define a DTO for input data
        public class PlaylistCreationDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public bool IsCollaborative { get; set; } = false; // Optional
        }

        public override string ToString()
        {
            // This will be displayed in the ListBox
            return $"{Name} Songs: {Songs.Count}";
        }
    }
}
