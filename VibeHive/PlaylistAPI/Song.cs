namespace PlaylistAPI
{
    /// <summary>
    /// Song class representing a song entity
    /// </summary>
    public class Song
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public string Genre { get; private set; }
        public TimeSpan Duration { get; private set; }
        public int Votes { get; private set; } = 0;

        /// <summary>
        /// Main constructor for Song class
        /// </summary>
        /// <param name="title"></param>
        /// <param name="artist"></param>
        /// <param name="genre"></param>
        /// <param name="duration"></param>
        public Song(Guid id, string title, string artist, string genre, TimeSpan duration)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }

        /// <summary>
        ///  Method to upvote the song
        /// </summary>
        public void Upvote()
        {
            Votes++;
        }

        /// <summary>
        ///  ToString override to display song information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title} by {Artist} - {Genre} [{Duration}]";
        }

        // Define a DTO for input data
        public class SongCreationDto
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Genre { get; set; }
            public TimeSpan Duration { get; set; }
        }
    }
}
