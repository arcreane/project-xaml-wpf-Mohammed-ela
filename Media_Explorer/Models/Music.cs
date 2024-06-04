namespace Media_Explorer.Models
{
    public class Music : Media
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }

        public Music(string name, long size, DateTime createdDate, string artist, string album, string genre)
            : base(name, size, createdDate)
        {
            Artist = artist;
            Album = album;
            Genre = genre;
        }

        public override void Display()
        {
            // Code pour lire la musique
        }
    }
}
