namespace AbstractFactory.Cars.Transmissions
{
    public class AutomaticTransmission : Transmission
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Automatic Transmission!");
        }
    }
}
