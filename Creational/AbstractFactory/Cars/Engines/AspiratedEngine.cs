namespace AbstractFactory.Cars.Engines
{
    public class AspiratedEngine : Engine
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Aspirated Engine!");
        }
    }
}
