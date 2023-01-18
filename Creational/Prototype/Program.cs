namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // basically this clone an object without reference

            var worker = new Worker
            {
                Name = "John",
                Age = 30,
                Type = "Human Resources"
            };

            Console.WriteLine($"Worker: \n{worker}\n");

            var clonedWorker = (Worker)worker.Clone();
            clonedWorker.Name = "Willian";
            clonedWorker.Age = 28;

            Console.WriteLine($"Worker: \n{worker}\n");

            Console.WriteLine($"Cloned Worker: \n{clonedWorker}");
        }
    }
}