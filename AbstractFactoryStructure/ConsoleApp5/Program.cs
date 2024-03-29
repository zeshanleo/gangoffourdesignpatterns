﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            AbstractFactory factory2 = new ConcreteFactory2();


            Client client1 = new Client(factory1);
            Client client2 = new Client(factory2);

            client1.Run();

            client2.Run();

            Console.ReadLine();
        }
    }
}
