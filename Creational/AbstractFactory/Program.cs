using AbstractFactory.Cars;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var luxuryCar = CreateCar("luxury");
            luxuryCar.ShowDetails();

            Console.WriteLine();

            var sportCar = CreateCar("sport");
            sportCar.ShowDetails();

            Console.WriteLine();

            var cheapCar = CreateCar("cheap");
            cheapCar.ShowDetails();
        }

        private static Car CreateCar(string kind)
        {
            Console.WriteLine($"Creating a {kind} car...");

            CarFactory carFactory = kind switch
            {
                "luxury" => new LuxuryCar(),
                "sport" => new SportCar(),
                _ => new CheapCar()
            };

            var car = new Car
            {
                Engine = carFactory.CreateEngine(),
                Transmission = carFactory.CreateTransmission()
            };

            Console.WriteLine($"Created a {kind} car.");

            return car;
        }
    }
}