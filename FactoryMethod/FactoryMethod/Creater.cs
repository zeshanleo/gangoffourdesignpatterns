using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creater
    {
        public abstract AbstractProduct CreateProduct();
    }

    public class CreaterA : Creater
    {
        public override AbstractProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class CreaterB : Creater
    {
        public override AbstractProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
