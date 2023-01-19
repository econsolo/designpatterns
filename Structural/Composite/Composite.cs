namespace Composite
{
    public class Composite : Component
    {
        private List<Component> components = new();

        public Composite(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Show(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");

            foreach (var component in components)
            {
                component.Show(depth + 2);
            }
        }
    }
}
