namespace AbstractFactory.Cars.Transmissions
{
    public class ManualTransmission : Transmission
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Manual Transmission!");
        }
    }
}
