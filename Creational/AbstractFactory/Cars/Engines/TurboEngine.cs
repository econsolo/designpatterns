namespace AbstractFactory.Cars.Engines
{
    public class TurboEngine : Engine
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Turbo Engine!");
        }
    }
}
