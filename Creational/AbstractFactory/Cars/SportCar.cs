using AbstractFactory.Cars.Engines;
using AbstractFactory.Cars.Transmissions;

namespace AbstractFactory.Cars
{
    public class SportCar : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new TurboEngine();
        }

        public override Transmission CreateTransmission()
        {
            return new ManualTransmission();
        }
    }
}
