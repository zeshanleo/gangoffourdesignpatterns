using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class AbstractProductA
    {
        public abstract void Interacts(AbstractProductB b);
    }

    public abstract class AbstractProductB
    {
        public abstract void Interacts(AbstractProductA a);
    }

    public class ProductA1 : AbstractProductA
    {
        public override void Interacts(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + b.GetType().Name);
        }
    }

    public class ProductA2 : AbstractProductA
    {
        public override void Interacts(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + b.GetType().Name);
        }
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interacts(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }


    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interacts(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
