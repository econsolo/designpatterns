namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Composite("Book");
            book.Add(new Sheet("Summary"));
            book.Add(new Sheet("Intro"));

            var subject = new Composite("Chapter one");
            subject.Add(new Sheet("Start"));
            subject.Add(new Sheet("Middle"));
            subject.Add(new Sheet("End"));

            book.Add(subject);
            book.Add(new Sheet("Conclusion"));

            var sheet = new Sheet("Thanks");
            book.Add(sheet);
            book.Remove(sheet);

            book.Show(1);
        }
    }
}