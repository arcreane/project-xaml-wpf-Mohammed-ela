namespace Media_Explorer.Models
{
    public class ImageMedia : Media
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ImageMedia(string name, long size, DateTime createdDate, int width, int height)
            : base(name, size, createdDate)
        {
            Width = width;
            Height = height;
        }

        public override void Display()
        {
            // Code pour afficher l'image
        }
    }
}
