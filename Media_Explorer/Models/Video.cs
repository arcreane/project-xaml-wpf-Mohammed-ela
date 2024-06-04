namespace Media_Explorer.Models
{
    public class Video : Media
    {
        public TimeSpan Duration { get; set; }

        public Video(string name, long size, DateTime createdDate, TimeSpan duration)
            : base(name, size, createdDate)
        {
            Duration = duration;
        }

        public override void Display()
        {
            // Code pour afficher la vidéo
        }
    }
}
