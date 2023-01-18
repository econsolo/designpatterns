using System.Text;

namespace Builder
{
    public class SmartPhone
    {
        public SmartPhone(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Screen { get; set; }
        public string Battery { get; set; }
        public string System { get; set; }
        public string Camera { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder()
                .Append("- Name: ").Append(Name)
                .Append('\n')
                .Append("- Screen: ").Append(Screen)
                .Append('\n')
                .Append("- Battery: ").Append(Battery)
                .Append('\n')
                .Append("- System: ").Append(System)
                .Append('\n')
                .Append("- Camera: ").Append(Camera);

            return sb.ToString();
        }
    }
}
