using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1.Equals(s2))
            {
                Console.WriteLine("Object is singleton!");
            }

            Console.ReadLine();
        }
    }
}
