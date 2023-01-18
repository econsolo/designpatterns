using System.Text;

namespace Prototype
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder()
                .Append("- Name: ").Append(Name)
                .Append('\n')
                .Append("- Age: ").Append(Age)
                .Append('\n')
                .Append("- Type: ").Append(Type);

            return sb.ToString();
        }

        public IWorker Clone()
        {
            return (IWorker)MemberwiseClone();
        }
    }
}
