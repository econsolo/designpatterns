namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var concreteAggregate = new ConcreteAggregate();
            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item C";
            concreteAggregate[3] = "Item D";
            concreteAggregate[4] = "Item E";

            var iterator = concreteAggregate.CreateIterator();

            Console.WriteLine("Iterating collection:");

            var first = iterator.First();

            var x = 0;

            while (first != null)
            {
                Console.WriteLine(first);

                if (x == 2)
                    first = iterator.CurrentItem();

                first = iterator.Next();
                x++;
            }
        }
    }
}