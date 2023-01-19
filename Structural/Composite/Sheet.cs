using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Sheet : Component
    {
        public Sheet(string name) : base(name)
        {

        }

        public override void Add(Component component)
        {
            Console.WriteLine("Can't add the sheet!");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Can't remove the sheet!");
        }

        public override void Show(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {Name}");
        }
    }
}
