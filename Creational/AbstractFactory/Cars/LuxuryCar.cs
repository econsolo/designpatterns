using AbstractFactory.Cars.Engines;
using AbstractFactory.Cars.Transmissions;

namespace AbstractFactory.Cars
{
    public class LuxuryCar : CarFactory
    {
        public override Engine CreateEngine()
        {
            return new SuperchargerEngine();
        }

        public override Transmission CreateTransmission()
        {
            return new AutomaticTransmission();
        }
    }
}
