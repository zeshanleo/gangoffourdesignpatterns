using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater[] creaters = new Creater[2];

            creaters[0] = new CreaterA();
            creaters[1] = new CreaterB();

            foreach (var provider in creaters)
            {
                AbstractProduct product = provider.CreateProduct();
                Console.WriteLine("Product is: " + product.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}
