namespace FactoryMethod
{
    public class Gohan : ICharacter
    {
        public void Chosen()
        {
            Console.WriteLine($"{nameof(Gohan)} chosen!");
        }
    }
}
