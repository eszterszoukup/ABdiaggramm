using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    public class D : B
    {
        public void S7()
        {
            Console.WriteLine("D :: S7");
            S8();
        }

        public void S8()
        {
            Console.WriteLine("D :: S8");
            V2();
        }

       protected virtual void V2()
        {
            Console.WriteLine("D :: V2");
            S7();
        }
    }
}