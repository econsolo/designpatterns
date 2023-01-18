namespace FactoryMethod
{
    public class Trunks : ICharacter
    {
        public void Chosen()
        {
            Console.WriteLine($"{nameof(Trunks)} chosen!");
        }
    }
}
