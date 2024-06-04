namespace Media_Explorer.Models
{
    public abstract class Media
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime CreatedDate { get; set; }

        protected Media(string name, long size, DateTime createdDate)
        {
            Name = name;
            Size = size;
            CreatedDate = createdDate;
        }

        public abstract void Display();
    }
}
