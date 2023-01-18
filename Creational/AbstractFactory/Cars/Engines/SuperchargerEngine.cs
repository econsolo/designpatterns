namespace AbstractFactory.Cars.Engines
{
    public class SuperchargerEngine : Engine
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Supercharger Engine!");
        }
    }
}
