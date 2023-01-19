namespace Decorator
{
    public class Video : LibraryItem
    {
        public Video(string author, string title, int duration, int copyNumber)
        {
            Title = title;
            Author = author;
            Duration = duration;
            CopyNumber = copyNumber;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }

        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"--- Book");
            Console.WriteLine($"\tTitle: {Title}");
            Console.WriteLine($"\tAuthor: {Author}");
            Console.WriteLine($"\tDuration: {Duration}");
            Console.WriteLine($"\t# Copies: {CopyNumber}");
        }
    }
}
