using AbstractFactory.Cars.Engines;
using AbstractFactory.Cars.Transmissions;

namespace AbstractFactory.Cars
{
    public class CheapCar : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new AspiratedEngine();
        }

        public override Transmission CreateTransmission()
        {
            return new ManualTransmission();
        }
    }
}
