namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new FactoryMethod();

            Console.WriteLine("Available characters:");

            Console.WriteLine("- Goku");
            Console.WriteLine("- Vegeta");
            Console.WriteLine("- Gohan");
            Console.WriteLine("- Trunks");

            Console.WriteLine();
            Console.WriteLine("Choose your character:");

            var choice = Console.ReadLine();

            var character = factory.ChooseCharacter(choice);
            
            Console.WriteLine();

            character.Chosen();
        }
    }
}