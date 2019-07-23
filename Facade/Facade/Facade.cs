using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private readonly SubSystemA subSystemA;
        private readonly SubSystemB subSystemB;
        private readonly SubSystemC subSystemC;
        private readonly SubSystemD subSystemD;


        public Facade()
        {
            subSystemA = new SubSystemA();
            subSystemB = new SubSystemB();
            subSystemC = new SubSystemC();
            subSystemD = new SubSystemD();
        }

        public void MethodA()
        {
            Console.WriteLine("Facade Method A");
            subSystemA.MethodA();
            subSystemB.MethodB();
        }

        public void MethodB()
        {
            Console.WriteLine("Facade Method B");
            subSystemB.MethodB();
            subSystemC.MethodC();
            subSystemD.MethodD();
        }
    }

    public class SubSystemA
    {
        public void MethodA()
        {
            Console.WriteLine("SubSystemA Method A");
        }
    }

    public class SubSystemB
    {
        public void MethodB()
        {
            Console.WriteLine("SubSystemB Method B");
        }
    }

    public class SubSystemC
    {
        public void MethodC()
        {
            Console.WriteLine("SubSystemC Method C");
        }
    }

    public class SubSystemD
    {
        public void MethodD()
        {
            Console.WriteLine("SubSystemD Method D");
        }
    }
}
