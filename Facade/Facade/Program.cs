using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade main = new Facade();

            main.MethodA();
            main.MethodB();

            Console.ReadLine();
        }
    }
}
