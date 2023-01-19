namespace Decorator
{
    public class Book : LibraryItem
    {
        public Book(string author, string title, int copyNumber)
        {
            Title = title;
            Author = author;
            CopyNumber = copyNumber;
        }

        public string Title { get; set; }
        public string Author { get; set; }

        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"--- Book");
            Console.WriteLine($"\tTitle: {Title}");
            Console.WriteLine($"\tAuthor: {Author}");
            Console.WriteLine($"\t# Copies: {CopyNumber}");
        }
    }
}
