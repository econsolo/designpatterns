namespace Decorator
{
    public class Lent : Decorator
    {
        protected List<string> Lents = new();

        public Lent(LibraryItem libraryItem) : base(libraryItem)
        {

        }

        public void Lend(string name)
        {
            Lents.Add(name);
            LibraryItem.CopyNumber--;
        }

        public void Return(string name)
        {
            Console.WriteLine($"Item returned by {name}");
            Lents.Remove(name);
            LibraryItem.CopyNumber++;
        }

        public override void Show()
        {
            base.Show();
            foreach (var item in Lents)
            {
                Console.WriteLine($"-- Lent to: {item}");
            }
        }
    }
}
