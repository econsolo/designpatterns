using AbstractFactory.Cars.Engines;
using AbstractFactory.Cars.Transmissions;

namespace AbstractFactory.Cars
{
    public class Car
    {
        public Transmission Transmission { get; set; }
        public Engine Engine { get; set; }

        public void ShowDetails()
        {
            Engine.ShowDetails();
            Transmission.ShowDetails();
        }
    }
}
