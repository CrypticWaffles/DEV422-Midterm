using System;

namespace MusicRentalClient.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int AlbumID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
