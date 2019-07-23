using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Client
    {
        private readonly AbstractProductA abstractProductA;
        private readonly AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            abstractProductA.Interacts(abstractProductB);
            abstractProductB.Interacts(abstractProductA);
        }
    }
}
