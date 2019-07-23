using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the root component
            Component component = new Composite("root");
            Component a = new Composite("A");
            Component b = new Composite("B");
            Component c = new Composite("C");

            // Add  into the root component
            component.Add(a);
            component.Add(b);
            component.Add(c);

            Component xa = new Composite("XA");
            Component xb = new Composite("XB");
            Component xc = new Composite("XC");

            a.Add(xa);
            b.Add(xb);
            c.Add(xc);

            Component leafxa = new Leaf("XA-Leaf");
            xa.Add(leafxa);

            component.Display(1);

            Console.ReadLine();

        }
    }
}
