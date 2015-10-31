namespace MusicSystem.Models
{
    //Songs (Title, Year, Genre, etc.)
    public class Song
    {
        public int Id
        {
            get; set;
        }

        public ushort Year
        {
            get; set;
        }

        public string Genre
        {
            get; set;
        }

        public int ArtistId
        {
            get; set;
        }

        public virtual Artist Artist
        {
            get; set;
        }
    }
}
