using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Process request via Target");
        }
    }

    public class Adapter : Target
    {
        private readonly Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SomeotherRequest();
        }
    }

    public class Adaptee
    {
        public void SomeotherRequest()
        {
            Console.WriteLine("Process request via Adaptee");
        }
    }

}
