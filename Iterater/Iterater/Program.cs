using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterater
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "Item A";
            aggregate[1] = "Item B";
            aggregate[2] = "Item C";
            aggregate[3] = "Item D";
            aggregate[4] = "Item E";

            Iterater i = aggregate.CreateIterater();

            Console.WriteLine("Iterating over the collection");

            object item = i.First();
            while(item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadLine();
        }
    }
}
