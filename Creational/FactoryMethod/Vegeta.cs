namespace FactoryMethod
{
    public class Vegeta : ICharacter
    {
        public void Chosen()
        {
            Console.WriteLine($"{nameof(Vegeta)} chosen!");
        }
    }
}
