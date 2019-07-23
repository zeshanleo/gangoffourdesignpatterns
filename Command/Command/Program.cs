using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver rec = new Receiver();
            Command cmd = new ConcreteCommand(rec);
            Invoke invoke = new Invoke();
            invoke.SetCommand(cmd);

            invoke.Execute();

            Console.ReadLine();
        }
    }
}
