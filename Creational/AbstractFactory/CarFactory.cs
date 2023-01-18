using AbstractFactory.Cars.Engines;
using AbstractFactory.Cars.Transmissions;

namespace AbstractFactory
{
    public abstract class CarFactory
    {
        public abstract Engine CreateEngine();
        public abstract Transmission CreateTransmission();
    }
}
