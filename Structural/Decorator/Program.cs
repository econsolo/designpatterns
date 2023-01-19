namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book("John", "Adventures of mine", 50);
            book.Show();

            var video = new Video("Willian", "Funny moments of mine", 60, 3);
            video.Show();

            Console.WriteLine("\nBorrowing a video:");

            var lent = new Lent(video);
            lent.Lend("Paul");
            lent.Lend("Mary");

            lent.Show();

            lent.Return("Paul");

            lent.Show();
        }
    }
}