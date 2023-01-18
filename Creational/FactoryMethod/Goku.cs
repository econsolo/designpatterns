namespace FactoryMethod
{
    public class Goku : ICharacter
    {
        public void Chosen()
        {
            Console.WriteLine($"{nameof(Goku)} chosen!");
        }
    }
}
