namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manufacturer = new Manufacturer();

            // Create Android phone
            var androidBuilder = new AndroidBuilder();
            manufacturer.CreateSmartPhone(androidBuilder);
            Console.WriteLine("New SmartPhone built:");
            Console.WriteLine(androidBuilder.SmartPhone);

            Console.WriteLine();

            // Create iPhone phone
            var iphoneBuilder = new IphoneBuilder();
            manufacturer.CreateSmartPhone(iphoneBuilder);
            Console.WriteLine("New SmartPhone built:");
            Console.WriteLine(iphoneBuilder.SmartPhone);
        }
    }
}