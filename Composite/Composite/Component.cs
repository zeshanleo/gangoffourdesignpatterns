using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        protected string _name = String.Empty;

        public Component(string name)
        {
            this._name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int level);
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name ):base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int level)
        {
            Console.WriteLine(new string('-', level) + _name);

            foreach(var child in children)
            {
                child.Display(level+1);
            }
        }
    }

    public class Leaf : Component
    {

        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            Console.WriteLine("Can not add a component in the leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Can not remove from a leaf component");
        }

        public override void Display(int level)
        {
            Console.WriteLine(new string('-', level) + _name);
        }
    }
}
